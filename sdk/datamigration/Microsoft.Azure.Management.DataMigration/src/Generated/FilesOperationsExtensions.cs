// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FilesOperations.
    /// </summary>
    public static partial class FilesOperationsExtensions
    {
            /// <summary>
            /// Get files in a project
            /// </summary>
            /// <remarks>
            /// The project resource is a nested resource representing a stored migration
            /// project. This method returns a list of files owned by a project resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='projectName'>
            /// Name of the project
            /// </param>
            public static IPage<ProjectFile> List(this IFilesOperations operations, string groupName, string serviceName, string projectName)
            {
                return operations.ListAsync(groupName, serviceName, projectName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get files in a project
            /// </summary>
            /// <remarks>
            /// The project resource is a nested resource representing a stored migration
            /// project. This method returns a list of files owned by a project resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='projectName'>
            /// Name of the project
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProjectFile>> ListAsync(this IFilesOperations operations, string groupName, string serviceName, string projectName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(groupName, serviceName, projectName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get file information
            /// </summary>
            /// <remarks>
            /// The files resource is a nested, proxy-only resource representing a file
            /// stored under the project resource. This method retrieves information about
            /// a file.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='projectName'>
            /// Name of the project
            /// </param>
            /// <param name='fileName'>
            /// Name of the File
            /// </param>
            public static ProjectFile Get(this IFilesOperations operations, string groupName, string serviceName, string projectName, string fileName)
            {
                return operations.GetAsync(groupName, serviceName, projectName, fileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get file information
            /// </summary>
            /// <remarks>
            /// The files resource is a nested, proxy-only resource representing a file
            /// stored under the project resource. This method retrieves information about
            /// a file.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='projectName'>
            /// Name of the project
            /// </param>
            /// <param name='fileName'>
            /// Name of the File
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProjectFile> GetAsync(this IFilesOperations operations, string groupName, string serviceName, string projectName, string fileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(groupName, serviceName, projectName, fileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a file resource
            /// </summary>
            /// <remarks>
            /// The PUT method creates a new file or updates an existing one.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Information about the file
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='projectName'>
            /// Name of the project
            /// </param>
            /// <param name='fileName'>
            /// Name of the File
            /// </param>
            public static ProjectFile CreateOrUpdate(this IFilesOperations operations, ProjectFile parameters, string groupName, string serviceName, string projectName, string fileName)
            {
                return operations.CreateOrUpdateAsync(parameters, groupName, serviceName, projectName, fileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a file resource
            /// </summary>
            /// <remarks>
            /// The PUT method creates a new file or updates an existing one.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Information about the file
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='projectName'>
            /// Name of the project
            /// </param>
            /// <param name='fileName'>
            /// Name of the File
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProjectFile> CreateOrUpdateAsync(this IFilesOperations operations, ProjectFile parameters, string groupName, string serviceName, string projectName, string fileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(parameters, groupName, serviceName, projectName, fileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete file
            /// </summary>
            /// <remarks>
            /// This method deletes a file.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='projectName'>
            /// Name of the project
            /// </param>
            /// <param name='fileName'>
            /// Name of the File
            /// </param>
            public static void Delete(this IFilesOperations operations, string groupName, string serviceName, string projectName, string fileName)
            {
                operations.DeleteAsync(groupName, serviceName, projectName, fileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete file
            /// </summary>
            /// <remarks>
            /// This method deletes a file.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='projectName'>
            /// Name of the project
            /// </param>
            /// <param name='fileName'>
            /// Name of the File
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IFilesOperations operations, string groupName, string serviceName, string projectName, string fileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(groupName, serviceName, projectName, fileName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update a file
            /// </summary>
            /// <remarks>
            /// This method updates an existing file.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Information about the file
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='projectName'>
            /// Name of the project
            /// </param>
            /// <param name='fileName'>
            /// Name of the File
            /// </param>
            public static ProjectFile Update(this IFilesOperations operations, ProjectFile parameters, string groupName, string serviceName, string projectName, string fileName)
            {
                return operations.UpdateAsync(parameters, groupName, serviceName, projectName, fileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a file
            /// </summary>
            /// <remarks>
            /// This method updates an existing file.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Information about the file
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='projectName'>
            /// Name of the project
            /// </param>
            /// <param name='fileName'>
            /// Name of the File
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProjectFile> UpdateAsync(this IFilesOperations operations, ProjectFile parameters, string groupName, string serviceName, string projectName, string fileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(parameters, groupName, serviceName, projectName, fileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Request storage information for downloading the file content
            /// </summary>
            /// <remarks>
            /// This method is used for requesting storage information using which contents
            /// of the file can be downloaded.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='projectName'>
            /// Name of the project
            /// </param>
            /// <param name='fileName'>
            /// Name of the File
            /// </param>
            public static FileStorageInfo Read(this IFilesOperations operations, string groupName, string serviceName, string projectName, string fileName)
            {
                return operations.ReadAsync(groupName, serviceName, projectName, fileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Request storage information for downloading the file content
            /// </summary>
            /// <remarks>
            /// This method is used for requesting storage information using which contents
            /// of the file can be downloaded.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='projectName'>
            /// Name of the project
            /// </param>
            /// <param name='fileName'>
            /// Name of the File
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FileStorageInfo> ReadAsync(this IFilesOperations operations, string groupName, string serviceName, string projectName, string fileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ReadWithHttpMessagesAsync(groupName, serviceName, projectName, fileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Request information for reading and writing file content.
            /// </summary>
            /// <remarks>
            /// This method is used for requesting information for reading and writing the
            /// file content.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='projectName'>
            /// Name of the project
            /// </param>
            /// <param name='fileName'>
            /// Name of the File
            /// </param>
            public static FileStorageInfo ReadWrite(this IFilesOperations operations, string groupName, string serviceName, string projectName, string fileName)
            {
                return operations.ReadWriteAsync(groupName, serviceName, projectName, fileName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Request information for reading and writing file content.
            /// </summary>
            /// <remarks>
            /// This method is used for requesting information for reading and writing the
            /// file content.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='serviceName'>
            /// Name of the service
            /// </param>
            /// <param name='projectName'>
            /// Name of the project
            /// </param>
            /// <param name='fileName'>
            /// Name of the File
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FileStorageInfo> ReadWriteAsync(this IFilesOperations operations, string groupName, string serviceName, string projectName, string fileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ReadWriteWithHttpMessagesAsync(groupName, serviceName, projectName, fileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get files in a project
            /// </summary>
            /// <remarks>
            /// The project resource is a nested resource representing a stored migration
            /// project. This method returns a list of files owned by a project resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ProjectFile> ListNext(this IFilesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get files in a project
            /// </summary>
            /// <remarks>
            /// The project resource is a nested resource representing a stored migration
            /// project. This method returns a list of files owned by a project resource.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ProjectFile>> ListNextAsync(this IFilesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
