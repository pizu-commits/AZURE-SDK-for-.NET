﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Azure.Identity
{
    /// <summary>
    /// Enables authentication to Azure Active Directory using Azure CLI to generated an access token.
    /// </summary>
    public class AzureCliCredential : TokenCredential
    {
        private readonly CredentialPipeline _pipeline;
        private readonly AzureCliCredentialClient _client;

        /// <summary>
        /// Create an instance of CliCredential class.
        /// </summary>
        public AzureCliCredential()
            : this(CredentialPipeline.GetInstance(null), new AzureCliCredentialClient())
        { }

        internal AzureCliCredential(CredentialPipeline pipeline)
            : this(pipeline, new AzureCliCredentialClient())
        { }

        internal AzureCliCredential(CredentialPipeline pipeline, AzureCliCredentialClient client)
        {
            _pipeline = pipeline;

            _client = client;
        }

        /// <summary>
        /// Obtains a access token from Azure CLI credential, using this access token to authenticate. This method called by Azure SDK clients.
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override AccessToken GetToken(TokenRequestContext requestContext, CancellationToken cancellationToken = default)
        {
            return GetTokenImplAsync(false, requestContext, cancellationToken).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtains a access token from Azure CLI service, using the access token to authenticate. This method id called by Azure SDK clients.
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override async ValueTask<AccessToken> GetTokenAsync(TokenRequestContext requestContext, CancellationToken cancellationToken = default)
        {
            return await GetTokenImplAsync(true, requestContext, cancellationToken).ConfigureAwait(false);
        }

        private async ValueTask<AccessToken> GetTokenImplAsync(bool isAsync, TokenRequestContext requestContext, CancellationToken cancellationToken)
        {
            using CredentialDiagnosticScope scope = _pipeline.StartGetTokenScope("Azure.Identity.AzureCliCredential.GetToken", requestContext);

            try
            {
                AccessToken token = isAsync ? await _client.RequestCliAccessTokenAsync(requestContext.Scopes, cancellationToken).ConfigureAwait(false) : _client.RequestCliAccessToken(requestContext.Scopes, cancellationToken);

                return scope.Succeeded(token);
            }
            catch (OperationCanceledException e)
            {
                scope.Failed(e);

                throw;
            }
            catch (Exception e)
            {
                throw scope.Failed(e);
            }
        }
    }
}
