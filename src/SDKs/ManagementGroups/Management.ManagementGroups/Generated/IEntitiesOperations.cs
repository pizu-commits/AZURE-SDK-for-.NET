// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagementGroups
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// EntitiesOperations operations.
    /// </summary>
    public partial interface IEntitiesOperations
    {
        /// <summary>
        /// List all entities (Management Groups, Subscriptions, etc.) for the
        /// authenticated user.
        /// </summary>
        /// <param name='skiptoken'>
        /// Page continuation token is only used if a previous operation
        /// returned a partial result. If a previous response contains a
        /// nextLink element, the value of the nextLink element will include a
        /// token parameter that specifies a starting point to use for
        /// subsequent calls.
        /// </param>
        /// <param name='skip'>
        /// Number of entities to skip over when retrieving results. Passing
        /// this in will override $skipToken.
        /// </param>
        /// <param name='top'>
        /// Number of elements to return when retrieving results. Passing this
        /// in will override $skipToken.
        /// </param>
        /// <param name='select'>
        /// This parameter specifies the fields to include in the response. Can
        /// include any combination of
        /// Name,DisplayName,Type,ParentDisplayNameChain,ParentChain, e.g.
        /// '$select=Name,DisplayName,Type,ParentDisplayNameChain,ParentNameChain'.
        /// When specified the $select parameter can override select in
        /// $skipToken.
        /// </param>
        /// <param name='search'>
        /// The $search parameter is used in conjunction with the $filter
        /// parameter to return three different outputs depending on the
        /// parameter passed in. With $search=AllowedParents the API will
        /// return the entity info of all groups that the requested entity will
        /// be able to reparent to as determined by the user's permissions.
        /// With $search=AllowedChildren the API will return the entity info of
        /// all entities that can be added as children of the requested entity.
        /// With $search=ParentAndFirstLevelChildren the API will return the
        /// parent and  first level of children that the user has either direct
        /// access to or indirect access via one of their descendants. Possible
        /// values include: 'AllowedParents', 'AllowedChildren',
        /// 'ParentAndFirstLevelChildren', 'ParentOnly', 'ChildrenOnly'
        /// </param>
        /// <param name='filter'>
        /// The filter parameter allows you to filter on the name or display
        /// name fields. You can check for equality on the name field (e.g.
        /// name eq '{entityName}')  and you can check for substrings on either
        /// the name or display name fields(e.g. contains(name,
        /// '{substringToSearch}'), contains(displayName,
        /// '{substringToSearch')). Note that the '{entityName}' and
        /// '{substringToSearch}' fields are checked case insensitively.
        /// </param>
        /// <param name='view'>
        /// The view parameter allows clients to filter the type of data that
        /// is returned by the getEntities call. Possible values include:
        /// 'FullHierarchy', 'GroupsOnly', 'SubscriptionsOnly', 'Audit'
        /// </param>
        /// <param name='groupName'>
        /// A filter which allows the get entities call to focus on a
        /// particular group (i.e. "$filter=name eq 'groupName'")
        /// </param>
        /// <param name='cacheControl'>
        /// Indicates that the request shouldn't utilize any caches.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<EntityInfo>>> ListWithHttpMessagesAsync(string skiptoken = default(string), int? skip = default(int?), int? top = default(int?), string select = default(string), string search = default(string), string filter = default(string), string view = default(string), string groupName = default(string), string cacheControl = "no-cache", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List all entities (Management Groups, Subscriptions, etc.) for the
        /// authenticated user.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cacheControl'>
        /// Indicates that the request shouldn't utilize any caches.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<EntityInfo>>> ListNextWithHttpMessagesAsync(string nextPageLink, string cacheControl = "no-cache", Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
