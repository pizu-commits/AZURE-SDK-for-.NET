// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.Cryptography;
using Azure.Core.TestFramework;
using Azure.Security.KeyVault.Keys.Cryptography;
using Azure.Storage.Blobs.Tests;
using Azure.Storage.Cryptography.Models;
using Azure.Storage.Queues.Models;
using Azure.Storage.Queues.Specialized.Models;
using Azure.Storage.Queues.Tests;
using Moq;
using NUnit.Framework;
using static Moq.It;

namespace Azure.Storage.Queues.Test
{
    public class ClientSideEncryptionTests : QueueTestBase
    {

        private const string s_algorithmName = "some algorithm name";
        private static readonly CancellationToken s_cancellationToken = new CancellationTokenSource().Token;

        private readonly string SampleUTF8String = Encoding.UTF8.GetString(
            new byte[] { 0xe1, 0x9a, 0xa0, 0xe1, 0x9b, 0x87, 0xe1, 0x9a, 0xbb, 0x0a }); // valid UTF-8 bytes

        public ClientSideEncryptionTests(bool async)
            : base(async, null /* RecordedTestMode.Record /* to re-record */)
        {
        }

        #region Utility

        private string LocalManualEncryption(string message, byte[] key, byte[] iv)
        {
            using (var aesProvider = new AesCryptoServiceProvider() { Key = key, IV = iv })
            using (var encryptor = aesProvider.CreateEncryptor())
            using (var memStream = new MemoryStream())
            using (var cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
            {
                var messageBytes = Encoding.UTF8.GetBytes(message);
                cryptoStream.Write(messageBytes, 0, messageBytes.Length);
                cryptoStream.FlushFinalBlock();
                return Convert.ToBase64String(memStream.ToArray());
            }
        }

        private async Task<IKeyEncryptionKey> GetKeyvaultIKeyEncryptionKey()
        {
            var keyClient = GetKeyClient_TargetKeyClient();
            Security.KeyVault.Keys.KeyVaultKey key = await keyClient.CreateRsaKeyAsync(
                new Security.KeyVault.Keys.CreateRsaKeyOptions($"CloudRsaKey-{Guid.NewGuid()}", false));
            return new CryptographyClient(key.Id, GetTokenCredential_TargetKeyClient());
        }

        /// <summary>
        /// Creates an encrypted queue client from a normal queue client. Note that this method does not copy over any
        /// client options from the container client. You must pass in your own options. These options will be mutated.
        /// </summary>
        public async Task<DisposingQueue> GetTestEncryptedQueueAsync(
            ClientSideEncryptionOptions encryptionOptions,
            string queueName = default,
            IDictionary<string, string> metadata = default)
        {
            // normally set through property on subclass; this is easier to hook up in current test infra with internals access
            var options = GetOptions();
            options._clientSideEncryptionOptions = encryptionOptions;

            var service = GetServiceClient_SharedKey(options);

            metadata ??= new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            QueueClient queue = InstrumentClient(service.GetQueueClient(GetNewQueueName()));
            return await DisposingQueue.CreateAsync(queue, metadata);
        }

        /// <summary>
        /// Generates a random string of the given size.
        /// For implementation simplicity, this generates an ASCII string.
        /// </summary>
        /// <param name="size">Size of the string IN BYTES, not chars.</param>
        /// <returns></returns>
        public string GetRandomMessage(int size)
        {
            var buf = new byte[size];
            var random = new Random();
            for (int i = 0; i < size; i++)
            {
                buf[i] = (byte)random.Next(32, 127); // printable ASCII has values [32, 127)
            }

            return Encoding.ASCII.GetString(buf);
        }

        private Mock<IKeyEncryptionKey> GetIKeyEncryptionKey(byte[] userKeyBytes = default, string keyId = default)
        {
            if (userKeyBytes == default)
            {
                const int keySizeBits = 256;
                var bytes = new byte[keySizeBits >> 3];
                new RNGCryptoServiceProvider().GetBytes(bytes);
                userKeyBytes = bytes;
            }
            keyId ??= Guid.NewGuid().ToString();

            var keyMock = new Mock<IKeyEncryptionKey>(MockBehavior.Strict);
            keyMock.SetupGet(k => k.KeyId).Returns(keyId);
            if (IsAsync)
            {
                keyMock.Setup(k => k.WrapKeyAsync(s_algorithmName, IsNotNull<ReadOnlyMemory<byte>>(), s_cancellationToken))
                    .Returns<string, ReadOnlyMemory<byte>, CancellationToken>((algorithm, key, cancellationToken) => Task.FromResult(Xor(userKeyBytes, key.ToArray())));
                keyMock.Setup(k => k.UnwrapKeyAsync(s_algorithmName, IsNotNull<ReadOnlyMemory<byte>>(), s_cancellationToken))
                    .Returns<string, ReadOnlyMemory<byte>, CancellationToken>((algorithm, wrappedKey, cancellationToken) => Task.FromResult(Xor(userKeyBytes, wrappedKey.ToArray())));
            }
            else
            {
                keyMock.Setup(k => k.WrapKey(s_algorithmName, IsNotNull<ReadOnlyMemory<byte>>(), s_cancellationToken))
                    .Returns<string, ReadOnlyMemory<byte>, CancellationToken>((algorithm, key, cancellationToken) => Xor(userKeyBytes, key.ToArray()));
                keyMock.Setup(k => k.UnwrapKey(s_algorithmName, IsNotNull<ReadOnlyMemory<byte>>(), s_cancellationToken))
                    .Returns<string, ReadOnlyMemory<byte>, CancellationToken>((algorithm, wrappedKey, cancellationToken) => Xor(userKeyBytes, wrappedKey.ToArray()));
            }

            return keyMock;
        }

        private Mock<IKeyEncryptionKeyResolver> GetIKeyEncryptionKeyResolver(IKeyEncryptionKey iKey)
        {
            var resolverMock = new Mock<IKeyEncryptionKeyResolver>(MockBehavior.Strict);
            if (IsAsync)
            {
                resolverMock.Setup(r => r.ResolveAsync(IsNotNull<string>(), s_cancellationToken))
                    .Returns<string, CancellationToken>((keyId, cancellationToken) => iKey?.KeyId == keyId ? Task.FromResult(iKey) : throw new Exception("Mock resolver couldn't resolve key id."));
            }
            else
            {
                resolverMock.Setup(r => r.Resolve(IsNotNull<string>(), s_cancellationToken))
                    .Returns<string, CancellationToken>((keyId, cancellationToken) => iKey?.KeyId == keyId ? iKey : throw new Exception("Mock resolver couldn't resolve key id."));
            }

            return resolverMock;
        }

        private Mock<Microsoft.Azure.KeyVault.Core.IKey> GetTrackOneIKey(byte[] userKeyBytes = default, string keyId = default)
        {
            if (userKeyBytes == default)
            {
                const int keySizeBits = 256;
                var bytes = new byte[keySizeBits >> 3];
                new RNGCryptoServiceProvider().GetBytes(bytes);
                userKeyBytes = bytes;
            }
            keyId ??= Guid.NewGuid().ToString();

            var keyMock = new Mock<Microsoft.Azure.KeyVault.Core.IKey>(MockBehavior.Strict);
            keyMock.SetupGet(k => k.Kid).Returns(keyId);
            keyMock.SetupGet(k => k.DefaultKeyWrapAlgorithm).Returns(s_algorithmName);
            // track one had async-only key wrapping
            keyMock.Setup(k => k.WrapKeyAsync(IsNotNull<byte[]>(), IsAny<string>(), IsNotNull<CancellationToken>())) // track 1 doesn't pass in the same cancellation token?
                // track 1 doesn't pass in the algorithm name, it lets the implementation return the default algorithm it chose
                .Returns<byte[], string, CancellationToken>((key, algorithm, cancellationToken) => Task.FromResult(Tuple.Create(Xor(userKeyBytes, key), s_algorithmName)));
            keyMock.Setup(k => k.UnwrapKeyAsync(IsNotNull<byte[]>(), s_algorithmName, IsNotNull<CancellationToken>())) // track 1 doesn't pass in the same cancellation token?
                .Returns<byte[], string, CancellationToken>((wrappedKey, algorithm, cancellationToken) => Task.FromResult(Xor(userKeyBytes, wrappedKey)));

            return keyMock;
        }

        private Mock<Microsoft.Azure.KeyVault.Core.IKeyResolver> GetTrackOneIKeyResolver(Microsoft.Azure.KeyVault.Core.IKey iKey)
        {
            var resolverMock = new Mock<Microsoft.Azure.KeyVault.Core.IKeyResolver>(MockBehavior.Strict);
            resolverMock.Setup(r => r.ResolveKeyAsync(IsNotNull<string>(), IsNotNull<CancellationToken>())) // track 1 doesn't pass in the same cancellation token?
                .Returns<string, CancellationToken>((keyId, cancellationToken) => iKey?.Kid == keyId ? Task.FromResult(iKey) : throw new Exception("Mock resolver couldn't resolve key id."));

            return resolverMock;
        }

        private static byte[] Xor(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
            {
                throw new ArgumentException("Keys must be the same length for this mock implementation.");
            }

            var aBits = new System.Collections.BitArray(a);
            var bBits = new System.Collections.BitArray(b);

            var result = new byte[a.Length];
            aBits.Xor(bBits).CopyTo(result, 0);

            return result;
        }
        #endregion

        [TestCase(16, false)] // a single cipher block
        [TestCase(14, false)] // a single unalligned cipher block
        [TestCase(Constants.KB, false)] // multiple blocks
        [TestCase(Constants.KB - 4, false)] // multiple unalligned blocks
        [TestCase(0, true)] // utf8 support testing
        [LiveOnly] // cannot seed content encryption key
        public async Task UploadAsync(int messageSize, bool usePrebuiltMessage)
        {
            var message = usePrebuiltMessage
                ? GetRandomMessage(messageSize)
                : SampleUTF8String;
            var mockKey = GetIKeyEncryptionKey().Object;
            await using (var disposable = await GetTestEncryptedQueueAsync(new ClientSideEncryptionOptions(ClientSideEncryptionVersion.V1_0)
            {
                KeyEncryptionKey = mockKey,
                KeyWrapAlgorithm = s_algorithmName
            }))
            {
                var queue = disposable.Queue;

                // upload with encryption
                await queue.SendMessageAsync(message, cancellationToken: s_cancellationToken);

                // download without decrypting
                var receivedMessages = (await InstrumentClient(new QueueClient(queue.Uri, GetNewSharedKeyCredentials())).ReceiveMessagesAsync(cancellationToken: s_cancellationToken)).Value;
                Assert.AreEqual(1, receivedMessages.Length);
                var encryptedMessage = receivedMessages[0].MessageText; // json of message and metadata
                var parsedEncryptedMessage = EncryptedMessageSerializer.Deserialize(encryptedMessage);

                // encrypt original data manually for comparison
                EncryptionData encryptionMetadata = parsedEncryptedMessage.EncryptionData;
                Assert.NotNull(encryptionMetadata, "Never encrypted data.");
                var explicitlyUnwrappedKey = IsAsync
                    ? await mockKey.UnwrapKeyAsync(s_algorithmName, encryptionMetadata.WrappedContentKey.EncryptedKey, s_cancellationToken).ConfigureAwait(false)
                    : mockKey.UnwrapKey(s_algorithmName, encryptionMetadata.WrappedContentKey.EncryptedKey, s_cancellationToken);
                string expectedEncryptedMessage = LocalManualEncryption(
                    message,
                    explicitlyUnwrappedKey,
                    encryptionMetadata.ContentEncryptionIV);

                // compare data
                Assert.AreEqual(expectedEncryptedMessage, parsedEncryptedMessage.EncryptedMessageContents);
            }
        }

        [TestCase(16, false)] // a single cipher block
        [TestCase(14, false)] // a single unalligned cipher block
        [TestCase(Constants.KB, false)] // multiple blocks
        [TestCase(Constants.KB - 4, false)] // multiple unalligned blocks
        [TestCase(0, true)] // utf8 support testing
        [LiveOnly] // cannot seed content encryption key
        public async Task RoundtripAsync(int messageSize, bool usePrebuiltMessage)
        {
            var message = usePrebuiltMessage
                ? GetRandomMessage(messageSize)
                : SampleUTF8String;
            var mockKey = GetIKeyEncryptionKey().Object;
            var mockKeyResolver = GetIKeyEncryptionKeyResolver(mockKey).Object;
            await using (var disposable = await GetTestEncryptedQueueAsync(new ClientSideEncryptionOptions(ClientSideEncryptionVersion.V1_0)
            {
                KeyEncryptionKey = mockKey,
                KeyResolver = mockKeyResolver,
                KeyWrapAlgorithm = s_algorithmName
            }))
            {
                var queue = disposable.Queue;

                // upload with encryption
                await queue.SendMessageAsync(message, cancellationToken: s_cancellationToken);

                // download with decryption
                var receivedMessages = (await queue.ReceiveMessagesAsync(cancellationToken: s_cancellationToken)).Value;
                Assert.AreEqual(1, receivedMessages.Length);
                var downloadedMessage = receivedMessages[0].MessageText;

                // compare data
                Assert.AreEqual(message, downloadedMessage);
            }
        }

        [TestCase(Constants.KB, false)] // multiple blocks
        [TestCase(Constants.KB - 4, false)] // multiple unalligned blocks
        [TestCase(0, true)] // utf8 support testing
        [LiveOnly] // cannot seed content encryption key
        public async Task Track2DownloadTrack1Blob(int messageSize, bool usePrebuiltMessage)
        {
            var message = usePrebuiltMessage
                ? GetRandomMessage(messageSize)
                : SampleUTF8String;

            const int keySizeBits = 256;
            var keyEncryptionKeyBytes = new byte[keySizeBits >> 3];
            new RNGCryptoServiceProvider().GetBytes(keyEncryptionKeyBytes);
            var keyId = Guid.NewGuid().ToString();

            var mockKey = GetTrackOneIKey(keyEncryptionKeyBytes, keyId).Object;
            var mockKeyResolver = GetIKeyEncryptionKeyResolver(GetIKeyEncryptionKey(keyEncryptionKeyBytes, keyId).Object).Object;
            await using (var disposable = await GetTestEncryptedQueueAsync(new ClientSideEncryptionOptions(ClientSideEncryptionVersion.V1_0)
            {
                KeyResolver = mockKeyResolver,
                KeyWrapAlgorithm = s_algorithmName
            }))
            {
                var track2Queue = disposable.Queue;

                // upload with track 1
                var creds = GetNewSharedKeyCredentials();
                var track1Queue = new Microsoft.Azure.Storage.Queue.CloudQueue(
                    track2Queue.Uri,
                    new Microsoft.Azure.Storage.Auth.StorageCredentials(creds.AccountName, creds.GetAccountKey()));
                var track1RequestOptions = new Microsoft.Azure.Storage.Queue.QueueRequestOptions()
                {
                    EncryptionPolicy = new Microsoft.Azure.Storage.Queue.QueueEncryptionPolicy(mockKey, default)
                };
                if (IsAsync)
                {
                    await track1Queue.AddMessageAsync(new Microsoft.Azure.Storage.Queue.CloudQueueMessage(message), null, null, track1RequestOptions, null, s_cancellationToken);
                }
                else
                {
                    track1Queue.AddMessage(new Microsoft.Azure.Storage.Queue.CloudQueueMessage(message), null, null, track1RequestOptions, null);
                }

                // download with track 2
                var receivedMessages = (await track2Queue.ReceiveMessagesAsync(cancellationToken: s_cancellationToken)).Value;
                Assert.AreEqual(1, receivedMessages.Length);
                var downloadedMessage = receivedMessages[0].MessageText;

                // compare original data to downloaded data
                Assert.AreEqual(message, downloadedMessage);
            }
        }

        [TestCase(Constants.KB, false)] // multiple blocks
        [TestCase(Constants.KB - 4, false)] // multiple unalligned blocks
        [TestCase(0, true)] // utf8 support testing
        [LiveOnly] // cannot seed content encryption key
        public async Task Track1DownloadTrack2Blob(int messageSize, bool usePrebuiltMessage)
        {
            var message = usePrebuiltMessage
                ? GetRandomMessage(messageSize)
                : SampleUTF8String;

            const int keySizeBits = 256;
            var keyEncryptionKeyBytes = new byte[keySizeBits >> 3];
            new RNGCryptoServiceProvider().GetBytes(keyEncryptionKeyBytes);
            var keyId = Guid.NewGuid().ToString();

            var mockKey = GetIKeyEncryptionKey(keyEncryptionKeyBytes, keyId).Object;
            var mockKeyResolver = GetTrackOneIKeyResolver(GetTrackOneIKey(keyEncryptionKeyBytes, keyId).Object).Object;
            await using (var disposable = await GetTestEncryptedQueueAsync(new ClientSideEncryptionOptions(ClientSideEncryptionVersion.V1_0)
            {
                KeyEncryptionKey = mockKey,
                KeyWrapAlgorithm = s_algorithmName
            }))
            {
                var track2Queue = disposable.Queue;

                // upload with track 2
                await track2Queue.SendMessageAsync(message, cancellationToken: s_cancellationToken);

                // download with track 1
                var creds = GetNewSharedKeyCredentials();
                var track1Queue = new Microsoft.Azure.Storage.Queue.CloudQueue(
                    track2Queue.Uri,
                    new Microsoft.Azure.Storage.Auth.StorageCredentials(creds.AccountName, creds.GetAccountKey()));
                var response = await track1Queue.GetMessageAsync(
                    null,
                    new Microsoft.Azure.Storage.Queue.QueueRequestOptions()
                    {
                        EncryptionPolicy = new Microsoft.Azure.Storage.Queue.QueueEncryptionPolicy(default, mockKeyResolver)
                    },
                    null);

                // compare original data to downloaded data
                Assert.AreEqual(message, response.AsString);
            }
        }

        [Test]
        [LiveOnly] // need access to keyvault service && cannot seed content encryption key
        public async Task RoundtripWithKeyvaultProvider()
        {
            var message = GetRandomMessage(Constants.KB);
            IKeyEncryptionKey key = await GetKeyvaultIKeyEncryptionKey();
            await using (var disposable = await GetTestEncryptedQueueAsync(new ClientSideEncryptionOptions(ClientSideEncryptionVersion.V1_0)
            {
                KeyEncryptionKey = key,
                KeyWrapAlgorithm = "RSA-OAEP-256"
            }))
            {
                var queue = disposable.Queue;

                await queue.SendMessageAsync(message, cancellationToken: s_cancellationToken);

                var receivedMessages = (await queue.ReceiveMessagesAsync(cancellationToken: s_cancellationToken)).Value;
                Assert.AreEqual(1, receivedMessages.Length);
                var downloadedMessage = receivedMessages[0].MessageText;

                Assert.AreEqual(message, downloadedMessage);
            }
        }

        [Test]
        [LiveOnly] // cannot seed content encryption key
        public async Task ReadPlaintextMessage()
        {
            var message = "any old message";
            var mockKey = GetIKeyEncryptionKey().Object;
            var mockKeyResolver = GetIKeyEncryptionKeyResolver(mockKey).Object;
            await using (var disposable = await GetTestEncryptedQueueAsync(new ClientSideEncryptionOptions(ClientSideEncryptionVersion.V1_0)
            {
                KeyEncryptionKey = mockKey,
                KeyResolver = mockKeyResolver,
                KeyWrapAlgorithm = s_algorithmName
            }))
            {
                var encryptedQueueClient = disposable.Queue;
                var plainQueueClient = new QueueClient(encryptedQueueClient.Uri, GetNewSharedKeyCredentials());

                // upload with encryption
                await plainQueueClient.SendMessageAsync(message, cancellationToken: s_cancellationToken);

                // download with decryption
                var receivedMessages = (await encryptedQueueClient.ReceiveMessagesAsync(cancellationToken: s_cancellationToken)).Value;
                Assert.AreEqual(1, receivedMessages.Length);
                var downloadedMessage = receivedMessages[0].MessageText;

                // compare data
                Assert.AreEqual(message, downloadedMessage);
            }
        }

        [Test]
        [LiveOnly] // cannot seed content encryption key
        public async Task OnlyOneKeyWrapCall()
        {
            var message = "any old message";
            var mockKey = GetIKeyEncryptionKey();
            var mockKeyResolver = GetIKeyEncryptionKeyResolver(mockKey.Object);
            await using (var disposable = await GetTestEncryptedQueueAsync(new ClientSideEncryptionOptions(ClientSideEncryptionVersion.V1_0)
            {
                KeyEncryptionKey = mockKey.Object,
                KeyResolver = mockKeyResolver.Object,
                KeyWrapAlgorithm = s_algorithmName
            }))
            {
                var queue = disposable.Queue;

                await queue.SendMessageAsync(message, cancellationToken: s_cancellationToken).ConfigureAwait(false);

                var wrapSyncMethod = typeof(IKeyEncryptionKey).GetMethod("WrapKey");
                var wrapAsyncMethod = typeof(IKeyEncryptionKey).GetMethod("WrapKeyAsync");

                Assert.AreEqual(1, IsAsync
                    ? mockKey.Invocations.Count(invocation => invocation.Method == wrapAsyncMethod)
                    : mockKey.Invocations.Count(invocation => invocation.Method == wrapSyncMethod));
                Assert.AreEqual(0, IsAsync
                    ? mockKey.Invocations.Count(invocation => invocation.Method == wrapSyncMethod)
                    : mockKey.Invocations.Count(invocation => invocation.Method == wrapAsyncMethod));
            }
        }

        [Test]
        [LiveOnly] // cannot seed content encryption key
        public async Task OnlyOneKeyResolveAndUnwrapCall()
        {
            var message = "any old message";
            var mockKey = GetIKeyEncryptionKey();
            var mockKeyResolver = GetIKeyEncryptionKeyResolver(mockKey.Object);
            await using (var disposable = await GetTestEncryptedQueueAsync(new ClientSideEncryptionOptions(ClientSideEncryptionVersion.V1_0)
            {
                KeyEncryptionKey = mockKey.Object,
                KeyResolver = mockKeyResolver.Object,
                KeyWrapAlgorithm = s_algorithmName
            }))
            {
                var queue = disposable.Queue;
                await queue.SendMessageAsync(message, cancellationToken: s_cancellationToken).ConfigureAwait(false);

                // replace with client that has only key resolver
                var options = GetOptions();
                options._clientSideEncryptionOptions = new ClientSideEncryptionOptions(ClientSideEncryptionVersion.V1_0)
                {
                    KeyEncryptionKey = default, // we want the key resolver to trigger; no cached key
                    KeyResolver = mockKeyResolver.Object
                };
                queue = InstrumentClient(new QueueClient(
                    queue.Uri,
                    GetNewSharedKeyCredentials(),
                    options));

                await queue.ReceiveMessagesAsync(cancellationToken: s_cancellationToken);

                var resolveSyncMethod = typeof(IKeyEncryptionKeyResolver).GetMethod("Resolve");
                var resolveAsyncMethod = typeof(IKeyEncryptionKeyResolver).GetMethod("ResolveAsync");
                var unwrapSyncMethod = typeof(IKeyEncryptionKey).GetMethod("UnwrapKey");
                var unwrapAsyncMethod = typeof(IKeyEncryptionKey).GetMethod("UnwrapKeyAsync");

                Assert.AreEqual(1, IsAsync
                    ? mockKeyResolver.Invocations.Count(invocation => invocation.Method == resolveAsyncMethod)
                    : mockKeyResolver.Invocations.Count(invocation => invocation.Method == resolveSyncMethod));
                Assert.AreEqual(0, IsAsync
                    ? mockKeyResolver.Invocations.Count(invocation => invocation.Method == resolveSyncMethod)
                    : mockKeyResolver.Invocations.Count(invocation => invocation.Method == resolveAsyncMethod));

                Assert.AreEqual(1, IsAsync
                    ? mockKey.Invocations.Count(invocation => invocation.Method == unwrapAsyncMethod)
                    : mockKey.Invocations.Count(invocation => invocation.Method == unwrapSyncMethod));
                Assert.AreEqual(0, IsAsync
                    ? mockKey.Invocations.Count(invocation => invocation.Method == unwrapSyncMethod)
                    : mockKey.Invocations.Count(invocation => invocation.Method == unwrapAsyncMethod));
            }
        }

        [TestCase(true, false)]
        [TestCase(false, false)]
        [TestCase(true, true)]
        [TestCase(false, true)]
        [LiveOnly]
        public async Task CannotFindKeyAsync(bool useListener, bool resolverThrows)
        {
            MockMissingClientSideEncryptionKeyListener listener = null;
            if (useListener)
            {
                listener = new MockMissingClientSideEncryptionKeyListener();
            }

            const int numMessages = 5;
            var message = "any old message";
            var mockKey = GetIKeyEncryptionKey().Object;
            var mockKeyResolver = GetIKeyEncryptionKeyResolver(mockKey).Object;
            await using (var disposable = await GetTestEncryptedQueueAsync(
                new ClientSideEncryptionOptions(ClientSideEncryptionVersion.V1_0)
                {
                    KeyEncryptionKey = mockKey,
                    KeyResolver = mockKeyResolver,
                    KeyWrapAlgorithm = s_algorithmName
                }))
            {
                var queue = disposable.Queue;
                foreach (var _ in Enumerable.Range(0, numMessages))
                {
                    await queue.SendMessageAsync(message, cancellationToken: s_cancellationToken).ConfigureAwait(false);
                }

                bool threw = false;
                QueueMessage[] result = default;
                try
                {
                    // download but can't find key
                    var options = GetOptions();
                    options._clientSideEncryptionOptions = new ClientSideEncryptionOptions(ClientSideEncryptionVersion.V1_0)
                    {
                        // note decryption will throw whether the resolver throws or just returns null
                        KeyResolver = new AlwaysFailsKeyEncryptionKeyResolver() { ShouldThrow = resolverThrows },
                        KeyWrapAlgorithm = "test"
                    };
                    options._onClientSideDecryptionFailure = listener;
                    result = await InstrumentClient(new QueueClient(queue.Uri, GetNewSharedKeyCredentials(), options)).ReceiveMessagesAsync(numMessages, cancellationToken: s_cancellationToken);
                }
                catch (Exception)
                {
                    threw = true;
                }
                finally
                {
                    Assert.AreNotEqual(useListener, threw);

                    if (useListener)
                    {
                        Assert.AreEqual(numMessages, listener.TimesInvoked);
                        Assert.AreEqual(0, result.Length); // all messages should have been filtered out
                    }
                }
            }
        }
    }
}
