﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Linq;
using System.Threading;
using Azure.Core;

namespace Azure.Messaging.ServiceBus.Primitives
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Net;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The SharedAccessSignatureTokenProvider generates tokens using a shared access key or existing signature.
    /// </summary>
    class SharedAccessSignatureTokenProvider: TokenCredential
    {
        const TokenScope DefaultTokenScope = TokenScope.Entity;

        internal static readonly TimeSpan DefaultTokenTTL = TimeSpan.FromMinutes(60);

        readonly byte[] encodedSharedAccessKey;
        readonly string keyName;
        readonly TimeSpan tokenTimeToLive;
        readonly TokenScope tokenScope;
        readonly string sharedAccessSignature;
        internal static readonly Func<string, byte[]> MessagingTokenProviderKeyEncoder = Encoding.UTF8.GetBytes;

        internal SharedAccessSignatureTokenProvider(string sharedAccessSignature)
        {
            SharedAccessSignatureToken.Validate(sharedAccessSignature);
            this.sharedAccessSignature = sharedAccessSignature;
        }

        internal SharedAccessSignatureTokenProvider(string keyName, string sharedAccessKey, TokenScope tokenScope = TokenScope.Entity)
            : this(keyName, sharedAccessKey, MessagingTokenProviderKeyEncoder, DefaultTokenTTL, tokenScope)
        {
        }

        internal SharedAccessSignatureTokenProvider(string keyName, string sharedAccessKey, TimeSpan tokenTimeToLive, TokenScope tokenScope = TokenScope.Entity)
            : this(keyName, sharedAccessKey, MessagingTokenProviderKeyEncoder, tokenTimeToLive, tokenScope)
        {
        }

        /// <summary></summary>
        /// <param name="keyName"></param>
        /// <param name="sharedAccessKey"></param>
        /// <param name="customKeyEncoder"></param>
        /// <param name="tokenTimeToLive"></param>
        /// <param name="tokenScope"></param>
        protected SharedAccessSignatureTokenProvider(string keyName, string sharedAccessKey, Func<string, byte[]> customKeyEncoder, TimeSpan tokenTimeToLive, TokenScope tokenScope)
        {
            if (string.IsNullOrEmpty(keyName))
            {
                throw new ArgumentNullException(nameof(keyName));
            }

            if (keyName.Length > SharedAccessSignatureToken.MaxKeyNameLength)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(keyName),
                    Resources.ArgumentStringTooBig.FormatForUser(nameof(keyName), SharedAccessSignatureToken.MaxKeyNameLength));
            }

            if (string.IsNullOrEmpty(sharedAccessKey))
            {
                throw new ArgumentNullException(nameof(sharedAccessKey));
            }

            if (sharedAccessKey.Length > SharedAccessSignatureToken.MaxKeyLength)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(sharedAccessKey),
                    Resources.ArgumentStringTooBig.FormatForUser(nameof(sharedAccessKey), SharedAccessSignatureToken.MaxKeyLength));
            }

            this.keyName = keyName;
            this.tokenTimeToLive = tokenTimeToLive;
            this.encodedSharedAccessKey = customKeyEncoder != null ?
                customKeyEncoder(sharedAccessKey) :
                MessagingTokenProviderKeyEncoder(sharedAccessKey);
            this.tokenScope = tokenScope;
        }

        /// <summary></summary>
        /// <param name="targetUri"></param>
        /// <returns></returns>
        protected virtual string BuildSignature(string targetUri)
        {
            return string.IsNullOrWhiteSpace(this.sharedAccessSignature)
                ? SharedAccessSignatureBuilder.BuildSignature(
                    this.keyName,
                    this.encodedSharedAccessKey,
                    targetUri,
                    this.tokenTimeToLive)
                : this.sharedAccessSignature;
        }

        string NormalizeAppliesTo(string[] appliesTo)
        {
            return ServiceBusUriHelper.NormalizeUri(appliesTo.Single(), "https", true, stripPath: this.tokenScope == TokenScope.Namespace, ensureTrailingSlash: true);
        }

        static class SharedAccessSignatureBuilder
        {
            [SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Justification = "Uris are normalized to lowercase")]
            public static string BuildSignature(
                string keyName,
                byte[] encodedSharedAccessKey,
                string targetUri,
                TimeSpan timeToLive)
            {
                // Note that target URI is not normalized because in IoT scenario it
                // is case sensitive.
                string expiresOn = BuildExpiresOn(timeToLive);
                string audienceUri = WebUtility.UrlEncode(targetUri);
                List<string> fields = new List<string> { audienceUri, expiresOn };

                // Example string to be signed:
                // http://mynamespace.servicebus.windows.net/a/b/c?myvalue1=a
                // <Value for ExpiresOn>
                string signature = Sign(string.Join("\n", fields), encodedSharedAccessKey);

                // Example returned string:
                // SharedAccessKeySignature
                // sr=ENCODED(http://mynamespace.servicebus.windows.net/a/b/c?myvalue1=a)&sig=<Signature>&se=<ExpiresOnValue>&skn=<KeyName>

                return string.Format(CultureInfo.InvariantCulture, "{0} {1}={2}&{3}={4}&{5}={6}&{7}={8}",
                    SharedAccessSignatureToken.SharedAccessSignature,
                    SharedAccessSignatureToken.SignedResource, audienceUri,
                    SharedAccessSignatureToken.Signature, WebUtility.UrlEncode(signature),
                    SharedAccessSignatureToken.SignedExpiry, WebUtility.UrlEncode(expiresOn),
                    SharedAccessSignatureToken.SignedKeyName, WebUtility.UrlEncode(keyName));
            }

            static string BuildExpiresOn(TimeSpan timeToLive)
            {
                DateTime expiresOn = DateTime.UtcNow.Add(timeToLive);
                TimeSpan secondsFromBaseTime = expiresOn.Subtract(Constants.EpochTime);
                long seconds = Convert.ToInt64(secondsFromBaseTime.TotalSeconds, CultureInfo.InvariantCulture);
                return Convert.ToString(seconds, CultureInfo.InvariantCulture);
            }

            static string Sign(string requestString, byte[] encodedSharedAccessKey)
            {
                using (var hmac = new HMACSHA256(encodedSharedAccessKey))
                {
                    return Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(requestString)));
                }
            }
        }

        public override Task<AccessToken> GetTokenAsync(string[] scopes, CancellationToken cancellationToken)
        {
            var appliesTo = NormalizeAppliesTo(scopes);
            string tokenString = this.BuildSignature(appliesTo);
            var securityToken = new AccessToken(tokenString, DateTimeOffset.MaxValue);
            return Task.FromResult<AccessToken>(securityToken);
        }

        public override AccessToken GetToken(string[] scopes, CancellationToken cancellationToken)
        {
            var appliesTo = NormalizeAppliesTo(scopes);
            string tokenString = this.BuildSignature(appliesTo);
            var securityToken = new AccessToken(tokenString, DateTimeOffset.MaxValue);
            return securityToken;
        }
    }
}
