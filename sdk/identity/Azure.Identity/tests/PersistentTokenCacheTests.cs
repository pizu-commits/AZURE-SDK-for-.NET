// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Microsoft.Identity.Client;
using Microsoft.Identity.Client.Extensions.Msal;
using Moq;
using NUnit.Framework;

namespace Azure.Identity.Tests
{
    public class PersistentTokenCacheTests : ClientTestBase
    {
        public PersistentTokenCacheTests(bool isAsync) : base(isAsync)
        { }

        public PersistentTokenCache cache;
        public Mock<ITokenCacheSerializer> mockSerializer1;
        public Mock<ITokenCacheSerializer> mockSerializer2;
        public Mock<ITokenCache> mockMSALCache;
        internal Mock<MsalCacheHelperWrapper> mockWrapper;

        [SetUp]
        public void Setup()
        {
            cache = new PersistentTokenCache();
            mockSerializer1 = new Mock<ITokenCacheSerializer>();
            mockSerializer2 = new Mock<ITokenCacheSerializer>();
            mockMSALCache = new Mock<ITokenCache>();
            mockWrapper = new Mock<MsalCacheHelperWrapper>();
            mockWrapper.Setup(m => m.InitializeAsync(It.IsAny<StorageCreationProperties>(), null))
                .Returns(Task.CompletedTask);
        }

        [TearDown]
        public void Cleanup()
        {
            PersistentTokenCache.ResetWrapperCache();
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void DefaultConstructorInitializesAllowUnencryptedStorage(bool allowUnencryptedStorage)
        {
            cache = new PersistentTokenCache(new PersistentTokenCacheOptions { AllowUnencryptedStorage = allowUnencryptedStorage });
            Assert.That(cache._allowUnencryptedStorage, Is.EqualTo(allowUnencryptedStorage));
        }

        public static IEnumerable<object[]> PersistentCacheOptions()
        {
            yield return new object[] { new PersistentTokenCacheOptions { AllowUnencryptedStorage = true, Name = "foo" }, true, "foo" };
            yield return new object[] { new PersistentTokenCacheOptions { AllowUnencryptedStorage = false, Name = "bar" }, false, "bar" };
            yield return new object[] { new PersistentTokenCacheOptions { AllowUnencryptedStorage = false }, false, Constants.DefaultMsalTokenCacheName };
            yield return new object[] { new PersistentTokenCacheOptions { Name = "fizz" }, false, "fizz" };
            yield return new object[] { new PersistentTokenCacheOptions(), false, Constants.DefaultMsalTokenCacheName };
        }

        [Test]
        [TestCaseSource(nameof(PersistentCacheOptions))]
        public void DefaultConstructorInitializesAllowUnencryptedStorage(PersistentTokenCacheOptions options, bool expectedAllowUnencryptedStorage, string expectedName)
        {
            cache = new PersistentTokenCache(options);
            Assert.That(cache._allowUnencryptedStorage, Is.EqualTo(expectedAllowUnencryptedStorage));
            Assert.That(cache._name, Is.EqualTo(expectedName));
        }

        [Test]
        public async Task RegisterCacheInitializesEvents()
        {
            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);

            mockMSALCache.Verify(m => m.SetBeforeAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()), Times.Once);
            mockMSALCache.Verify(m => m.SetAfterAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()), Times.Once);
        }

        [Test]
        public async Task RegisterCacheInitializesEventsOnlyOnce()
        {
            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);
            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);

            mockMSALCache.Verify(m => m.SetBeforeAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()), Times.Once);
            mockMSALCache.Verify(m => m.SetAfterAccessAsync(It.IsAny<Func<TokenCacheNotificationArgs, Task>>()), Times.Once);
        }

        [Test]
        [NonParallelizable]
        public async Task RegisterCacheInitializesCacheWithName()
        {
            string cacheName = Guid.NewGuid().ToString();
            cache = new PersistentTokenCache(new PersistentTokenCacheOptions() { Name = cacheName }, mockWrapper.Object);

            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);

            mockWrapper.Verify(m => m.InitializeAsync(
                It.Is<StorageCreationProperties>(p =>
                    p.ClientId == PersistentTokenCache.s_msalCacheClientId &&
                    p.CacheFileName == cacheName &&
                    p.MacKeyChainServiceName == Constants.DefaultMsalTokenCacheKeychainService &&
                    p.KeyringCollection == Constants.DefaultMsalTokenCacheKeyringCollection),
                null));
        }

        [Test]
        [NonParallelizable]
        public async Task RegisterCacheInitializesCache()
        {
            cache = new PersistentTokenCache(new PersistentTokenCacheOptions(), mockWrapper.Object);

            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);

            mockWrapper.Verify(m => m.InitializeAsync(
                It.Is<StorageCreationProperties>(p =>
                    p.ClientId == PersistentTokenCache.s_msalCacheClientId &&
                    p.CacheFileName == Constants.DefaultMsalTokenCacheName &&
                    p.MacKeyChainServiceName == Constants.DefaultMsalTokenCacheKeychainService &&
                    p.KeyringCollection == Constants.DefaultMsalTokenCacheKeyringCollection),
                null));
        }

        [Test]
        [NonParallelizable]
        public async Task RegisterCacheInitializesCacheOnlyOnce()
        {
            cache = new PersistentTokenCache(new PersistentTokenCacheOptions(), mockWrapper.Object);

            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);
            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);

            mockWrapper.Verify(m => m.InitializeAsync(
                It.Is<StorageCreationProperties>(p =>
                    p.ClientId == PersistentTokenCache.s_msalCacheClientId &&
                    p.CacheFileName == Constants.DefaultMsalTokenCacheName &&
                    p.MacKeyChainServiceName == Constants.DefaultMsalTokenCacheKeychainService &&
                    p.KeyringCollection == Constants.DefaultMsalTokenCacheKeyringCollection),
                null), Times.Once);
        }

        [Test]
        [NonParallelizable]
        public void RegisterCacheInitializesCacheAndIsThreadSafe()
        {
            ManualResetEventSlim resetEvent2 = new ManualResetEventSlim();
            ManualResetEventSlim resetEvent1 = new ManualResetEventSlim();

            //The fist call to InitializeAsync will block. The second one will complete immediately.
            mockWrapper.SetupSequence(m => m.InitializeAsync(It.IsAny<StorageCreationProperties>(), null))
                .Returns(() =>
                {
                    resetEvent1.Wait(1);
                    resetEvent1.Set();
                    resetEvent2.Wait();
                    return Task.CompletedTask;
                })
                .Returns(Task.CompletedTask);
            cache = new PersistentTokenCache(new PersistentTokenCacheOptions(), mockWrapper.Object);
            var cache2 = new PersistentTokenCache(new PersistentTokenCacheOptions(), mockWrapper.Object);

            var task1 = Task.Run(() => cache.RegisterCache(IsAsync, mockMSALCache.Object, default));
            var task2 = Task.Run(() => cache2.RegisterCache(IsAsync, mockMSALCache.Object, default));

            //Ensure the two tasks are running before we release the first call to InitializeAsync.
            resetEvent1.Wait();
            resetEvent2.Set();

            Task.WaitAll(task1, task2);

            mockWrapper.Verify(m => m.InitializeAsync(
                It.Is<StorageCreationProperties>(p =>
                    p.ClientId == PersistentTokenCache.s_msalCacheClientId &&
                    p.CacheFileName == Constants.DefaultMsalTokenCacheName &&
                    p.MacKeyChainServiceName == Constants.DefaultMsalTokenCacheKeychainService &&
                    p.KeyringCollection == Constants.DefaultMsalTokenCacheKeyringCollection),
                null));
        }

        [Test]
        [NonParallelizable]
        public void RegisterCacheThrowsIfEncryptionIsUnavailableAndAllowUnencryptedStorageIsFalse()
        {
            mockWrapper.Setup(m => m.VerifyPersistence()).Throws<MsalCachePersistenceException>();
            cache = new PersistentTokenCache(new PersistentTokenCacheOptions(), mockWrapper.Object);

            Assert.ThrowsAsync<MsalCachePersistenceException>(() => cache.RegisterCache(IsAsync, mockMSALCache.Object, default));
        }

        [Test]
        [NonParallelizable]
        public async Task RegisterCacheInitializesCacheIfEncryptionIsUnavailableAndAllowUnencryptedStorageIsTrue()
        {
            mockWrapper.SetupSequence(m => m.VerifyPersistence())
            .Throws<MsalCachePersistenceException>()
            .Pass();
            cache = new PersistentTokenCache(new PersistentTokenCacheOptions { AllowUnencryptedStorage = true }, mockWrapper.Object);

            await cache.RegisterCache(IsAsync, mockMSALCache.Object, default);

            mockWrapper.Verify(m => m.InitializeAsync(
                It.Is<StorageCreationProperties>(p =>
                    p.ClientId == PersistentTokenCache.s_msalCacheClientId &&
                    p.CacheFileName == Constants.DefaultMsalTokenCacheName &&
                    p.MacKeyChainServiceName == Constants.DefaultMsalTokenCacheKeychainService &&
                    p.UseLinuxUnencryptedFallback),
                null));
        }
    }
}
