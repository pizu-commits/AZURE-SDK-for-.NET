// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Security.KeyVault.Administration.Models;

namespace Azure.Security.KeyVault.Administration
{
    internal partial class RoleDefinitionsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of RoleDefinitionsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public RoleDefinitionsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string apiVersion = "7.4")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateDeleteRequest(string vaultBaseUrl, string scope, string roleDefinitionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleDefinitions/", false);
            uri.AppendPath(roleDefinitionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a custom role definition. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role definition to delete. Managed HSM only supports '/'. </param>
        /// <param name="roleDefinitionName"> The name (GUID) of the role definition to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/>, <paramref name="scope"/> or <paramref name="roleDefinitionName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string vaultBaseUrl, string scope, string roleDefinitionName, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionName));
            }

            using var message = CreateDeleteRequest(vaultBaseUrl, scope, roleDefinitionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 404:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes a custom role definition. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role definition to delete. Managed HSM only supports '/'. </param>
        /// <param name="roleDefinitionName"> The name (GUID) of the role definition to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/>, <paramref name="scope"/> or <paramref name="roleDefinitionName"/> is null. </exception>
        public Response Delete(string vaultBaseUrl, string scope, string roleDefinitionName, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionName));
            }

            using var message = CreateDeleteRequest(vaultBaseUrl, scope, roleDefinitionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 404:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string vaultBaseUrl, string scope, string roleDefinitionName, RoleDefinitionCreateParameters parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleDefinitions/", false);
            uri.AppendPath(roleDefinitionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = parameters;
            return message;
        }

        /// <summary> Creates or updates a custom role definition. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role definition to create or update. Managed HSM only supports '/'. </param>
        /// <param name="roleDefinitionName"> The name of the role definition to create or update. It can be any valid GUID. </param>
        /// <param name="parameters"> Parameters for the role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/>, <paramref name="scope"/>, <paramref name="roleDefinitionName"/> or <paramref name="parameters"/> is null. </exception>
        public async Task<Response<KeyVaultRoleDefinition>> CreateOrUpdateAsync(string vaultBaseUrl, string scope, string roleDefinitionName, RoleDefinitionCreateParameters parameters, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(vaultBaseUrl, scope, roleDefinitionName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        KeyVaultRoleDefinition value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = KeyVaultRoleDefinition.DeserializeKeyVaultRoleDefinition(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates a custom role definition. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role definition to create or update. Managed HSM only supports '/'. </param>
        /// <param name="roleDefinitionName"> The name of the role definition to create or update. It can be any valid GUID. </param>
        /// <param name="parameters"> Parameters for the role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/>, <paramref name="scope"/>, <paramref name="roleDefinitionName"/> or <paramref name="parameters"/> is null. </exception>
        public Response<KeyVaultRoleDefinition> CreateOrUpdate(string vaultBaseUrl, string scope, string roleDefinitionName, RoleDefinitionCreateParameters parameters, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(vaultBaseUrl, scope, roleDefinitionName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        KeyVaultRoleDefinition value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = KeyVaultRoleDefinition.DeserializeKeyVaultRoleDefinition(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string vaultBaseUrl, string scope, string roleDefinitionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleDefinitions/", false);
            uri.AppendPath(roleDefinitionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get the specified role definition. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role definition to get. Managed HSM only supports '/'. </param>
        /// <param name="roleDefinitionName"> The name of the role definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/>, <paramref name="scope"/> or <paramref name="roleDefinitionName"/> is null. </exception>
        public async Task<Response<KeyVaultRoleDefinition>> GetAsync(string vaultBaseUrl, string scope, string roleDefinitionName, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionName));
            }

            using var message = CreateGetRequest(vaultBaseUrl, scope, roleDefinitionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        KeyVaultRoleDefinition value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = KeyVaultRoleDefinition.DeserializeKeyVaultRoleDefinition(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the specified role definition. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role definition to get. Managed HSM only supports '/'. </param>
        /// <param name="roleDefinitionName"> The name of the role definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/>, <paramref name="scope"/> or <paramref name="roleDefinitionName"/> is null. </exception>
        public Response<KeyVaultRoleDefinition> Get(string vaultBaseUrl, string scope, string roleDefinitionName, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (roleDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionName));
            }

            using var message = CreateGetRequest(vaultBaseUrl, scope, roleDefinitionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        KeyVaultRoleDefinition value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = KeyVaultRoleDefinition.DeserializeKeyVaultRoleDefinition(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string vaultBaseUrl, string scope, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.Authorization/roleDefinitions", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get all role definitions that are applicable at scope and above. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role definition. </param>
        /// <param name="filter"> The filter to apply on the operation. Use atScopeAndBelow filter to search below the given scope as well. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> or <paramref name="scope"/> is null. </exception>
        public async Task<Response<RoleDefinitionListResult>> ListAsync(string vaultBaseUrl, string scope, string filter = null, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            using var message = CreateListRequest(vaultBaseUrl, scope, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleDefinitionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleDefinitionListResult.DeserializeRoleDefinitionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get all role definitions that are applicable at scope and above. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role definition. </param>
        /// <param name="filter"> The filter to apply on the operation. Use atScopeAndBelow filter to search below the given scope as well. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> or <paramref name="scope"/> is null. </exception>
        public Response<RoleDefinitionListResult> List(string vaultBaseUrl, string scope, string filter = null, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            using var message = CreateListRequest(vaultBaseUrl, scope, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleDefinitionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleDefinitionListResult.DeserializeRoleDefinitionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string vaultBaseUrl, string scope, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get all role definitions that are applicable at scope and above. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role definition. </param>
        /// <param name="filter"> The filter to apply on the operation. Use atScopeAndBelow filter to search below the given scope as well. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="vaultBaseUrl"/> or <paramref name="scope"/> is null. </exception>
        public async Task<Response<RoleDefinitionListResult>> ListNextPageAsync(string nextLink, string vaultBaseUrl, string scope, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            using var message = CreateListNextPageRequest(nextLink, vaultBaseUrl, scope, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleDefinitionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoleDefinitionListResult.DeserializeRoleDefinitionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get all role definitions that are applicable at scope and above. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="scope"> The scope of the role definition. </param>
        /// <param name="filter"> The filter to apply on the operation. Use atScopeAndBelow filter to search below the given scope as well. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="vaultBaseUrl"/> or <paramref name="scope"/> is null. </exception>
        public Response<RoleDefinitionListResult> ListNextPage(string nextLink, string vaultBaseUrl, string scope, string filter = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            using var message = CreateListNextPageRequest(nextLink, vaultBaseUrl, scope, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoleDefinitionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoleDefinitionListResult.DeserializeRoleDefinitionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
