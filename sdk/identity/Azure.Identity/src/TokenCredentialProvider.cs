﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Identity
{
    public class TokenCredentialProvider : TokenCredential
    {
        private TokenCredential[] _sources;

        public TokenCredentialProvider(params TokenCredential[] sources)
        {
            if (sources == null) throw new ArgumentNullException(nameof(sources));

            if (sources.Length == 0) throw new ArgumentException("sources must not be empty", nameof(sources));

            if (sources.Any(tc => tc == null)) throw new ArgumentException("sources must not contain null", nameof(sources));

            _sources = sources;
        }

        public override string GetToken(string[] scopes, CancellationToken cancellationToken)
        {
            string token = null;

            for (int i = 0; i < _sources.Length && token == null; i++)
            {
                token = _sources[i].GetToken(scopes, cancellationToken);
            }

            if (token == null)
            {
                throw new InvalidOperationException("No valid credentials were found, please check the supplied credential sources and your configuration.");
            }

            return token;
        }

        public override async ValueTask<string> GetTokenAsync(string[] scopes, CancellationToken cancellationToken = default)
        {
            string token = null;

            for(int i = 0; i < _sources.Length && token == null; i++)
            {
                token = await _sources[i].GetTokenAsync(scopes, cancellationToken);
            }

            if (token == null)
            {
                throw new InvalidOperationException("No valid credentials were found, please check the supplied credential sources and your configuration.");
            }

            return token;
        }

    }
}
