// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    internal partial class DatabaseColumnsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DatabaseColumnsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DatabaseColumnsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-11-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByDatabaseRequest(string subscriptionId, string resourceGroupName, string serverName, string databaseName, IEnumerable<string> schema, IEnumerable<string> table, IEnumerable<string> column, IEnumerable<string> orderBy, string skiptoken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/columns", false);
            if (schema != null && Optional.IsCollectionDefined(schema))
            {
                foreach (var param in schema)
                {
                    uri.AppendQuery("schema", param, true);
                }
            }
            if (table != null && Optional.IsCollectionDefined(table))
            {
                foreach (var param in table)
                {
                    uri.AppendQuery("table", param, true);
                }
            }
            if (column != null && Optional.IsCollectionDefined(column))
            {
                foreach (var param in column)
                {
                    uri.AppendQuery("column", param, true);
                }
            }
            if (orderBy != null && Optional.IsCollectionDefined(orderBy))
            {
                foreach (var param in orderBy)
                {
                    uri.AppendQuery("orderBy", param, true);
                }
            }
            if (skiptoken != null)
            {
                uri.AppendQuery("$skiptoken", skiptoken, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List database columns. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schema"> The IEnumerable{string} to use. </param>
        /// <param name="table"> The IEnumerable{string} to use. </param>
        /// <param name="column"> The IEnumerable{string} to use. </param>
        /// <param name="orderBy"> The IEnumerable{string} to use. </param>
        /// <param name="skiptoken"> An opaque token that identifies a starting point in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="databaseName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DatabaseColumnListResult>> ListByDatabaseAsync(string subscriptionId, string resourceGroupName, string serverName, string databaseName, IEnumerable<string> schema = null, IEnumerable<string> table = null, IEnumerable<string> column = null, IEnumerable<string> orderBy = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var message = CreateListByDatabaseRequest(subscriptionId, resourceGroupName, serverName, databaseName, schema, table, column, orderBy, skiptoken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseColumnListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseColumnListResult.DeserializeDatabaseColumnListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List database columns. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schema"> The IEnumerable{string} to use. </param>
        /// <param name="table"> The IEnumerable{string} to use. </param>
        /// <param name="column"> The IEnumerable{string} to use. </param>
        /// <param name="orderBy"> The IEnumerable{string} to use. </param>
        /// <param name="skiptoken"> An opaque token that identifies a starting point in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="databaseName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DatabaseColumnListResult> ListByDatabase(string subscriptionId, string resourceGroupName, string serverName, string databaseName, IEnumerable<string> schema = null, IEnumerable<string> table = null, IEnumerable<string> column = null, IEnumerable<string> orderBy = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var message = CreateListByDatabaseRequest(subscriptionId, resourceGroupName, serverName, databaseName, schema, table, column, orderBy, skiptoken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseColumnListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseColumnListResult.DeserializeDatabaseColumnListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByTableRequest(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/schemas/", false);
            uri.AppendPath(schemaName, true);
            uri.AppendPath("/tables/", false);
            uri.AppendPath(tableName, true);
            uri.AppendPath("/columns", false);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List database columns. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DatabaseColumnListResult>> ListByTableAsync(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var message = CreateListByTableRequest(subscriptionId, resourceGroupName, serverName, databaseName, schemaName, tableName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseColumnListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseColumnListResult.DeserializeDatabaseColumnListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List database columns. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DatabaseColumnListResult> ListByTable(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var message = CreateListByTableRequest(subscriptionId, resourceGroupName, serverName, databaseName, schemaName, tableName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseColumnListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseColumnListResult.DeserializeDatabaseColumnListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/schemas/", false);
            uri.AppendPath(schemaName, true);
            uri.AppendPath("/tables/", false);
            uri.AppendPath(tableName, true);
            uri.AppendPath("/columns/", false);
            uri.AppendPath(columnName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get database column. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/>, <paramref name="tableName"/> or <paramref name="columnName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/>, <paramref name="tableName"/> or <paramref name="columnName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DatabaseColumnData>> GetAsync(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));
            Argument.AssertNotNullOrEmpty(columnName, nameof(columnName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, serverName, databaseName, schemaName, tableName, columnName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseColumnData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseColumnData.DeserializeDatabaseColumnData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DatabaseColumnData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get database column. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/>, <paramref name="tableName"/> or <paramref name="columnName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/>, <paramref name="tableName"/> or <paramref name="columnName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DatabaseColumnData> Get(string subscriptionId, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string columnName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));
            Argument.AssertNotNullOrEmpty(columnName, nameof(columnName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, serverName, databaseName, schemaName, tableName, columnName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseColumnData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseColumnData.DeserializeDatabaseColumnData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((DatabaseColumnData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByDatabaseNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string serverName, string databaseName, IEnumerable<string> schema, IEnumerable<string> table, IEnumerable<string> column, IEnumerable<string> orderBy, string skiptoken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List database columns. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schema"> The IEnumerable{string} to use. </param>
        /// <param name="table"> The IEnumerable{string} to use. </param>
        /// <param name="column"> The IEnumerable{string} to use. </param>
        /// <param name="orderBy"> The IEnumerable{string} to use. </param>
        /// <param name="skiptoken"> An opaque token that identifies a starting point in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="databaseName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DatabaseColumnListResult>> ListByDatabaseNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string serverName, string databaseName, IEnumerable<string> schema = null, IEnumerable<string> table = null, IEnumerable<string> column = null, IEnumerable<string> orderBy = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var message = CreateListByDatabaseNextPageRequest(nextLink, subscriptionId, resourceGroupName, serverName, databaseName, schema, table, column, orderBy, skiptoken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseColumnListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseColumnListResult.DeserializeDatabaseColumnListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List database columns. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schema"> The IEnumerable{string} to use. </param>
        /// <param name="table"> The IEnumerable{string} to use. </param>
        /// <param name="column"> The IEnumerable{string} to use. </param>
        /// <param name="orderBy"> The IEnumerable{string} to use. </param>
        /// <param name="skiptoken"> An opaque token that identifies a starting point in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="databaseName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DatabaseColumnListResult> ListByDatabaseNextPage(string nextLink, string subscriptionId, string resourceGroupName, string serverName, string databaseName, IEnumerable<string> schema = null, IEnumerable<string> table = null, IEnumerable<string> column = null, IEnumerable<string> orderBy = null, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var message = CreateListByDatabaseNextPageRequest(nextLink, subscriptionId, resourceGroupName, serverName, databaseName, schema, table, column, orderBy, skiptoken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseColumnListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseColumnListResult.DeserializeDatabaseColumnListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByTableNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List database columns. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DatabaseColumnListResult>> ListByTableNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var message = CreateListByTableNextPageRequest(nextLink, subscriptionId, resourceGroupName, serverName, databaseName, schemaName, tableName, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseColumnListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DatabaseColumnListResult.DeserializeDatabaseColumnListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List database columns. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="schemaName"> The name of the schema. </param>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="filter"> An OData filter expression that filters elements in the collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, <paramref name="schemaName"/> or <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DatabaseColumnListResult> ListByTableNextPage(string nextLink, string subscriptionId, string resourceGroupName, string serverName, string databaseName, string schemaName, string tableName, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(schemaName, nameof(schemaName));
            Argument.AssertNotNullOrEmpty(tableName, nameof(tableName));

            using var message = CreateListByTableNextPageRequest(nextLink, subscriptionId, resourceGroupName, serverName, databaseName, schemaName, tableName, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DatabaseColumnListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DatabaseColumnListResult.DeserializeDatabaseColumnListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
