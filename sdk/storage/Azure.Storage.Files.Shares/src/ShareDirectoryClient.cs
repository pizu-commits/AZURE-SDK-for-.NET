﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Storage.Files.Shares.Models;
using Metadata = System.Collections.Generic.IDictionary<string, string>;

namespace Azure.Storage.Files.Shares
{
    /// <summary>
    /// A DirectoryClient represents a URI to the Azure Storage File service allowing you to manipulate a directory.
    /// </summary>
    public class ShareDirectoryClient
    {
        /// <summary>
        /// The directory's primary <see cref="Uri"/> endpoint.
        /// </summary>
        private readonly Uri _uri;

        /// <summary>
        /// Gets the directory's primary <see cref="Uri"/> endpoint.
        /// </summary>
        public virtual Uri Uri => _uri;

        /// <summary>
        /// The <see cref="HttpPipeline"/> transport pipeline used to send
        /// every request.
        /// </summary>
        private readonly HttpPipeline _pipeline;

        /// <summary>
        /// Gets the <see cref="HttpPipeline"/> transport pipeline used to send
        /// every request.
        /// </summary>
        internal virtual HttpPipeline Pipeline => _pipeline;

        /// <summary>
        /// The <see cref="ClientDiagnostics"/> instance used to create diagnostic scopes
        /// every request.
        /// </summary>
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary>
        /// The <see cref="ClientDiagnostics"/> instance used to create diagnostic scopes
        /// every request.
        /// </summary>
        internal virtual ClientDiagnostics ClientDiagnostics => _clientDiagnostics;

        /// <summary>
        /// The Storage account name corresponding to the directory client.
        /// </summary>
        private string _accountName;

        /// <summary>
        /// Gets the Storage account name corresponding to the directory client.
        /// </summary>
        public virtual string AccountName
        {
            get
            {
                SetNameFieldsIfNull();
                return _accountName;
            }
        }

        /// <summary>
        /// The share name corresponding to the directory client.
        /// </summary>
        private string _shareName;

        /// <summary>
        /// Gets the share name corresponding to the directory client.
        /// </summary>
        public virtual string ShareName
        {
            get
            {
                SetNameFieldsIfNull();
                return _shareName;
            }
        }

        /// <summary>
        /// The name of the directory.
        /// </summary>
        private string _name;

        /// <summary>
        /// Gets the name of the directory.
        /// </summary>
        public virtual string Name
        {
            get
            {
                SetNameFieldsIfNull();
                return _name;
            }
        }

        /// <summary>
        /// The path of the directory.
        /// </summary>
        private string _path;

        /// <summary>
        /// Gets the path of the directory.
        /// </summary>
        public virtual string Path
        {
            get
            {
                SetNameFieldsIfNull();
                return _path;
            }
        }

        #region ctors
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareDirectoryClient"/>
        /// class for mocking.
        /// </summary>
        protected ShareDirectoryClient()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareDirectoryClient"/> class.
        /// </summary>
        /// <param name="connectionString">
        /// A connection string includes the authentication information
        /// required for your application to access data in an Azure Storage
        /// account at runtime.
        ///
        /// For more information, <see href="https://docs.microsoft.com/en-us/azure/storage/common/storage-configure-connection-string"/>.
        /// </param>
        /// <param name="shareName">
        /// The name of the share in the storage account to reference.
        /// </param>
        /// <param name="directoryPath">
        /// The path of the directory in the storage account to reference.
        /// </param>
        public ShareDirectoryClient(string connectionString, string shareName, string directoryPath)
            : this(connectionString, shareName, directoryPath, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareDirectoryClient"/> class.
        /// </summary>
        /// <param name="connectionString">
        /// A connection string includes the authentication information
        /// required for your application to access data in an Azure Storage
        /// account at runtime.
        ///
        /// For more information, <see href="https://docs.microsoft.com/en-us/azure/storage/common/storage-configure-connection-string"/>.
        /// </param>
        /// <param name="shareName">
        /// The name of the share in the storage account to reference.
        /// </param>
        /// <param name="directoryPath">
        /// The path of the directory in the storage account to reference.
        /// </param>
        /// <param name="options">
        /// Optional <see cref="ShareClientOptions"/> that define the transport
        /// pipeline policies for authentication, retries, etc., that are
        /// applied to every request.
        /// </param>
        public ShareDirectoryClient(string connectionString, string shareName, string directoryPath, ShareClientOptions options)
        {
            options ??= new ShareClientOptions();
            var conn = StorageConnectionString.Parse(connectionString);
            var builder =
                new ShareUriBuilder(conn.FileEndpoint)
                {
                    ShareName = shareName,
                    DirectoryOrFilePath = directoryPath
                };
            _uri = builder.ToUri();
            _pipeline = options.Build(conn.Credentials);
            _clientDiagnostics = new ClientDiagnostics(options);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareDirectoryClient"/>
        /// class.
        /// </summary>
        /// <param name="directoryUri">
        /// A <see cref="Uri"/> referencing the directory that includes the
        /// name of the account, the name of the share, and the path of the
        /// directory.
        /// </param>
        /// <param name="options">
        /// Optional <see cref="ShareClientOptions"/> that define the transport
        /// pipeline policies for authentication, retries, etc., that are
        /// applied to every request.
        /// </param>
        public ShareDirectoryClient(Uri directoryUri, ShareClientOptions options = default)
            : this(directoryUri, (HttpPipelinePolicy)null, options)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareDirectoryClient"/>
        /// class.
        /// </summary>
        /// <param name="directoryUri">
        /// A <see cref="Uri"/> referencing the directory that includes the
        /// name of the account, the name of the share, and the path of the
        /// directory.
        /// </param>
        /// <param name="credential">
        /// The shared key credential used to sign requests.
        /// </param>
        /// <param name="options">
        /// Optional client options that define the transport pipeline
        /// policies for authentication, retries, etc., that are applied to
        /// every request.
        /// </param>
        public ShareDirectoryClient(Uri directoryUri, StorageSharedKeyCredential credential, ShareClientOptions options = default)
            : this(directoryUri, credential.AsPolicy(), options)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareDirectoryClient"/>
        /// class.
        /// </summary>
        /// <param name="directoryUri">
        /// A <see cref="Uri"/> referencing the directory that includes the
        /// name of the account, the name of the share, and the path of the
        /// directory.
        /// </param>
        /// <param name="authentication">
        /// An optional authentication policy used to sign requests.
        /// </param>
        /// <param name="options">
        /// Optional client options that define the transport pipeline
        /// policies for authentication, retries, etc., that are applied to
        /// every request.
        /// </param>
        internal ShareDirectoryClient(Uri directoryUri, HttpPipelinePolicy authentication, ShareClientOptions options)
        {
            options ??= new ShareClientOptions();
            _uri = directoryUri;
            _pipeline = options.Build(authentication);
            _clientDiagnostics = new ClientDiagnostics(options);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareDirectoryClient"/>
        /// class.
        /// </summary>
        /// <param name="directoryUri">
        /// A <see cref="Uri"/> referencing the directory that includes the
        /// name of the account, the name of the share, and the path of the
        /// directory.
        /// </param>
        /// <param name="pipeline">
        /// The transport pipeline used to send every request.
        /// </param>
        /// <param name="clientDiagnostics"></param>
        internal ShareDirectoryClient(Uri directoryUri, HttpPipeline pipeline, ClientDiagnostics clientDiagnostics)
        {
            _uri = directoryUri;
            _pipeline = pipeline;
            _clientDiagnostics = clientDiagnostics;
        }
        #endregion ctors

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareDirectoryClient"/>
        /// class with an identical <see cref="Uri"/> source but the specified
        /// <paramref name="snapshot"/> timestamp.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/snapshot-share"/>.
        /// </summary>
        /// <remarks>
        /// Pass null or empty string to remove the snapshot returning a URL to the base directory.
        /// </remarks>
        /// <param name="snapshot">
        /// The snapshot identifier.
        /// </param>
        /// <returns>
        /// A new <see cref="ShareDirectoryClient"/> instance.
        /// </returns>
        public virtual ShareDirectoryClient WithSnapshot(string snapshot)
        {
            var p = new ShareUriBuilder(Uri) { Snapshot = snapshot };
            return new ShareDirectoryClient(p.ToUri(), Pipeline, ClientDiagnostics);
        }

        /// <summary>
        /// Creates a new <see cref="ShareFileClient"/> object by appending
        /// <paramref name="fileName"/> to the end of <see cref="Uri"/>.  The
        /// new <see cref="ShareFileClient"/> uses the same request policy
        /// pipeline as the <see cref="ShareDirectoryClient"/>.
        /// </summary>
        /// <param name="fileName">The name of the file.</param>
        /// <returns>A new <see cref="ShareFileClient"/> instance.</returns>
        public virtual ShareFileClient GetFileClient(string fileName)
            => new ShareFileClient(Uri.AppendToPath(fileName), Pipeline, ClientDiagnostics);

        /// <summary>
        /// Creates a new <see cref="ShareDirectoryClient"/> object by appending
        /// <paramref name="subdirectoryName"/> to the end of <see cref="Uri"/>.
        /// The new <see cref="ShareDirectoryClient"/> uses the same request policy
        /// pipeline as the <see cref="ShareDirectoryClient"/>.
        /// </summary>
        /// <param name="subdirectoryName">The name of the subdirectory.</param>
        /// <returns>A new <see cref="ShareDirectoryClient"/> instance.</returns>
        public virtual ShareDirectoryClient GetSubdirectoryClient(string subdirectoryName)
            => new ShareDirectoryClient(Uri.AppendToPath(subdirectoryName), Pipeline, ClientDiagnostics);

        /// <summary>
        /// Sets the various name fields if they are currently null.
        /// </summary>
        private void SetNameFieldsIfNull()
        {
            if (_name == null || _shareName == null || _accountName == null || _path == null)
            {
                var builder = new ShareUriBuilder(Uri);
                _name = builder.LastDirectoryOrFileName;
                _shareName = builder.ShareName;
                _accountName = builder.AccountName;
                _path = builder.DirectoryOrFilePath;
            }
        }

        #region Create
        /// <summary>
        /// The <see cref="Create"/> operation creates a new directory
        /// at the specified <see cref="Uri"/>.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/create-directory"/>.
        /// </summary>
        /// <param name="metadata">
        /// Optional custom metadata to set for this directory.
        /// </param>
        /// <param name="smbProperties">
        /// Optional SMB properties to set for the directory.
        /// </param>
        /// <param name="filePermission">
        /// Optional file permission to set on the directory.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{StorageDirectoryInfo}"/> describing the newly
        /// created directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual Response<ShareDirectoryInfo> Create(
            Metadata metadata = default,
            FileSmbProperties smbProperties = default,
            string filePermission = default,
            CancellationToken cancellationToken = default) =>
            CreateInternal(
                metadata,
                smbProperties,
                filePermission,
                false, // async
                cancellationToken)
                .EnsureCompleted();

        /// <summary>
        /// The <see cref="CreateAsync"/> operation creates a new directory
        /// at the specified <see cref="Uri"/>.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/create-directory"/>.
        /// </summary>
        /// <param name="metadata">
        /// Optional custom metadata to set for this directory.
        /// </param>
        /// <param name="smbProperties">
        /// Optional SMB properties to set for the directory.
        /// </param>
        /// <param name="filePermission">
        /// Optional file permission to set on the directory.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{StorageDirectoryInfo}"/> describing the newly
        /// created directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual async Task<Response<ShareDirectoryInfo>> CreateAsync(
            Metadata metadata = default,
            FileSmbProperties smbProperties = default,
            string filePermission = default,
            CancellationToken cancellationToken = default) =>
            await CreateInternal(
                metadata,
                smbProperties,
                filePermission,
                true, // async
                cancellationToken)
                .ConfigureAwait(false);

        /// <summary>
        /// The <see cref="CreateInternal"/> operation creates a new directory
        /// at the specified <see cref="Uri"/>.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/create-directory"/>.
        /// </summary>
        /// <param name="metadata">
        /// Optional custom metadata to set for this directory.
        /// </param>
        /// <param name="smbProperties">
        /// Optional SMB properties to set for the directory.
        /// </param>
        /// <param name="filePermission">
        /// Optional file permission to set on the directory.
        /// </param>
        /// <param name="async">
        /// Whether to invoke the operation asynchronously.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{StorageDirectoryInfo}"/> describing the newly
        /// created directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        private async Task<Response<ShareDirectoryInfo>> CreateInternal(
            Metadata metadata,
            FileSmbProperties smbProperties,
            string filePermission,
            bool async,
            CancellationToken cancellationToken)
        {
            using (Pipeline.BeginLoggingScope(nameof(ShareDirectoryClient)))
            {
                Pipeline.LogMethodEnter(
                    nameof(ShareDirectoryClient),
                    message: $"{nameof(Uri)}: {Uri}");
                try
                {
                    FileSmbProperties smbProps = smbProperties ?? new FileSmbProperties();

                    ShareExtensions.AssertValidFilePermissionAndKey(filePermission, smbProps.FilePermissionKey);
                    if (filePermission == null && smbProps.FilePermissionKey == null)
                    {
                        filePermission = Constants.File.FilePermissionInherit;
                    }

                    Response<RawStorageDirectoryInfo> response = await FileRestClient.Directory.CreateAsync(
                        ClientDiagnostics,
                        Pipeline,
                        Uri,
                        metadata: metadata,
                        fileAttributes: smbProps.FileAttributes?.ToAttributesString() ?? Constants.File.FileAttributesNone,
                        filePermission: filePermission,
                        fileCreationTime: smbProps.FileCreatedOn.ToFileDateTimeString() ?? Constants.File.FileTimeNow,
                        fileLastWriteTime: smbProps.FileLastWrittenOn.ToFileDateTimeString() ?? Constants.File.FileTimeNow,
                        filePermissionKey: smbProps.FilePermissionKey,
                        async: async,
                        operationName: Constants.File.Directory.CreateOperationName,
                        cancellationToken: cancellationToken)
                        .ConfigureAwait(false);

                    return Response.FromValue(new ShareDirectoryInfo(response.Value), response.GetRawResponse());
                }
                catch (Exception ex)
                {
                    Pipeline.LogException(ex);
                    throw;
                }
                finally
                {
                    Pipeline.LogMethodExit(nameof(ShareDirectoryClient));
                }
            }
        }
        #endregion Create

        #region Delete
        /// <summary>
        /// The <see cref="Delete"/> operation removes the specified empty directory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/delete-directory"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response"/> if successful.
        /// </returns>
        /// <remarks>
        /// Note that the directory must be empty before it can be deleted.
        /// </remarks>
        public virtual Response Delete(
            CancellationToken cancellationToken = default) =>
            DeleteInternal(
                false, // async
                cancellationToken)
                .EnsureCompleted();

        /// <summary>
        /// The <see cref="DeleteAsync"/> operation removes the specified empty directory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/delete-directory"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response"/> if successful.
        /// </returns>
        /// <remarks>
        /// Note that the directory must be empty before it can be deleted.
        /// </remarks>
        public virtual async Task<Response> DeleteAsync(
            CancellationToken cancellationToken = default) =>
            await DeleteInternal(
                true, // async
                cancellationToken)
                .ConfigureAwait(false);

        /// <summary>
        /// The <see cref="DeleteInternal"/> operation removes the specified
        /// empty directory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/delete-directory"/>.
        /// </summary>
        /// <param name="async">
        /// Whether to invoke the operation asynchronously.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response"/> if successful.
        /// </returns>
        /// <remarks>
        /// Note that the directory must be empty before it can be deleted.
        /// </remarks>
        private async Task<Response> DeleteInternal(
            bool async,
            CancellationToken cancellationToken)
        {
            using (Pipeline.BeginLoggingScope(nameof(ShareDirectoryClient)))
            {
                Pipeline.LogMethodEnter(
                    nameof(ShareDirectoryClient),
                    message: $"{nameof(Uri)}: {Uri}");
                try
                {
                    return await FileRestClient.Directory.DeleteAsync(
                        ClientDiagnostics,
                        Pipeline,
                        Uri,
                        async: async,
                        operationName: Constants.File.Directory.DeleteOperationName,
                        cancellationToken: cancellationToken)
                        .ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    Pipeline.LogException(ex);
                    throw;
                }
                finally
                {
                    Pipeline.LogMethodExit(nameof(ShareDirectoryClient));
                }
            }
        }
        #endregion Delete

        #region GetProperties
        /// <summary>
        /// The <see cref="GetProperties"/> operation returns all
        /// user-defined metadata and system properties for the specified
        /// directory. The data returned does not include the directory's
        /// list of subdirectories or files.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/get-directory-properties"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{StorageDirectoryProperties}"/> describing the
        /// directory and its properties.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual Response<ShareDirectoryProperties> GetProperties(
            CancellationToken cancellationToken = default) =>
            GetPropertiesInternal(
                false, // async
                cancellationToken)
                .EnsureCompleted();

        /// <summary>
        /// The <see cref="GetPropertiesAsync"/> operation returns all
        /// user-defined metadata and system properties for the specified
        /// directory. The data returned does not include the directory's
        /// list of subdirectories or files.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/get-directory-properties"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{StorageDirectoryProperties}"/> describing the
        /// directory and its properties.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual async Task<Response<ShareDirectoryProperties>> GetPropertiesAsync(
            CancellationToken cancellationToken = default) =>
            await GetPropertiesInternal(
                true, // async
                cancellationToken)
                .ConfigureAwait(false);

        /// <summary>
        /// The <see cref="GetPropertiesInternal"/> operation returns all
        /// user-defined metadata and system properties for the specified
        /// directory. The data returned does not include the directory's
        /// list of subdirectories or files.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/get-directory-properties"/>.
        /// </summary>
        /// <param name="async">
        /// Whether to invoke the operation asynchronously.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{StorageDirectoryProperties}"/> describing the
        /// directory and its properties.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        private async Task<Response<ShareDirectoryProperties>> GetPropertiesInternal(
            bool async,
            CancellationToken cancellationToken)
        {
            using (Pipeline.BeginLoggingScope(nameof(ShareDirectoryClient)))
            {
                Pipeline.LogMethodEnter(
                    nameof(ShareDirectoryClient),
                    message:
                    $"{nameof(Uri)}: {Uri}");
                try
                {
                    Response<RawStorageDirectoryProperties> response = await FileRestClient.Directory.GetPropertiesAsync(
                        ClientDiagnostics,
                        Pipeline,
                        Uri,
                        async: async,
                        operationName: Constants.File.Directory.GetPropertiesOperationName,
                        cancellationToken: cancellationToken)
                        .ConfigureAwait(false);

                    // Return an exploding Response on 304
                    return response.IsUnavailable() ?
                        response.GetRawResponse().AsNoBodyResponse<ShareDirectoryProperties>() :
                        Response.FromValue(new ShareDirectoryProperties(response.Value), response.GetRawResponse());
                }
                catch (Exception ex)
                {
                    Pipeline.LogException(ex);
                    throw;
                }
                finally
                {
                    Pipeline.LogMethodExit(nameof(ShareDirectoryClient));
                }
            }
        }
        #endregion GetProperties

        #region SetHttpHeaders
        /// <summary>
        /// The <see cref="SetHttpHeaders"/> operation sets system
        /// properties on the directory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/set-directory-properties"/>.
        /// </summary>
        /// <param name="smbProperties">
        /// Optional SMB properties to set for the directory.
        /// </param>
        /// <param name="filePermission">
        /// Optional file permission to set for the directory.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{StorageFileInfo}"/> describing the
        /// state of the file.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual Response<ShareDirectoryInfo> SetHttpHeaders(
            FileSmbProperties smbProperties = default,
            string filePermission = default,
            CancellationToken cancellationToken = default) =>
            SetHttpHeadersInternal(
                smbProperties,
                filePermission,
                false, // async
                cancellationToken)
                .EnsureCompleted();

        /// <summary>
        /// The <see cref="SetHttpHeadersAsync"/> operation sets system
        /// properties on the directory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/set-directory-properties"/>.
        /// </summary>
        /// <param name="smbProperties">
        /// Optional SMB properties to set for the directory.
        /// </param>
        /// <param name="filePermission">
        /// Optional file permission to set for the directory.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{StorageFileInfo}"/> describing the
        /// state of the file.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual async Task<Response<ShareDirectoryInfo>> SetHttpHeadersAsync(
            FileSmbProperties smbProperties = default,
            string filePermission = default,
            CancellationToken cancellationToken = default) =>
            await SetHttpHeadersInternal(
                smbProperties,
                filePermission,
                true, // async
                cancellationToken)
                .ConfigureAwait(false);

        /// <summary>
        /// The <see cref="SetHttpHeadersInternal"/> operation sets system
        /// properties on the directory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/set-directory-properties"/>.
        /// </summary>
        /// <param name="smbProperties">
        /// Optional SMB properties to set for the directory.
        /// </param>
        /// <param name="filePermission">
        /// Optional file permission to set ofr the directory.
        /// </param>
        /// <param name="async">
        /// Whether to invoke the operation asynchronously.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{StorageFileInfo}"/> describing the
        /// state of the file.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        private async Task<Response<ShareDirectoryInfo>> SetHttpHeadersInternal(
            FileSmbProperties smbProperties,
            string filePermission,
            bool async,
            CancellationToken cancellationToken)
        {
            using (Pipeline.BeginLoggingScope(nameof(ShareDirectoryClient)))
            {
                Pipeline.LogMethodEnter(
                    nameof(ShareDirectoryClient),
                    message:
                    $"{nameof(Uri)}: {Uri}\n");
                try
                {
                    FileSmbProperties smbProps = smbProperties ?? new FileSmbProperties();

                    ShareExtensions.AssertValidFilePermissionAndKey(filePermission, smbProps.FilePermissionKey);
                    if (filePermission == null && smbProps.FilePermissionKey == null)
                    {
                        filePermission = Constants.File.Preserve;
                    }

                    Response<RawStorageDirectoryInfo> response = await FileRestClient.Directory.SetPropertiesAsync(
                        ClientDiagnostics,
                        Pipeline,
                        Uri,
                        fileAttributes: smbProps.FileAttributes?.ToAttributesString() ?? Constants.File.Preserve,
                        filePermission: filePermission,
                        fileCreationTime: smbProps.FileCreatedOn.ToFileDateTimeString() ?? Constants.File.Preserve,
                        fileLastWriteTime: smbProps.FileLastWrittenOn.ToFileDateTimeString() ?? Constants.File.Preserve,
                        filePermissionKey: smbProps.FilePermissionKey,
                        async: async,
                        operationName: Constants.File.Directory.SetHttpHeadersOperationName,
                        cancellationToken: cancellationToken)
                        .ConfigureAwait(false);

                    return Response.FromValue(new ShareDirectoryInfo(response.Value), response.GetRawResponse());
                }
                catch (Exception ex)
                {
                    Pipeline.LogException(ex);
                    throw;
                }
                finally
                {
                    Pipeline.LogMethodExit(nameof(ShareDirectoryClient));
                }
            }
        }

        #endregion SetHttpHeaders

        #region SetMetadata
        /// <summary>
        /// The <see cref="SetMetadata"/> operation sets one or more
        /// user-defined name-value pairs for the specified directory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/set-directory-metadata"/>.
        /// </summary>
        /// <param name="metadata">
        /// Custom metadata to set for this directory.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{StorageDirectoryInfo}"/> if successful.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual Response<ShareDirectoryInfo> SetMetadata(
            Metadata metadata,
            CancellationToken cancellationToken = default) =>
            SetMetadataInternal(
                metadata,
                false, // async
                cancellationToken)
                .EnsureCompleted();

        /// <summary>
        /// The <see cref="SetMetadataAsync"/> operation sets one or more
        /// user-defined name-value pairs for the specified directory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/set-directory-metadata"/>.
        /// </summary>
        /// <param name="metadata">
        /// Custom metadata to set for this directory.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{StorageDirectoryInfo}"/> if successful.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual async Task<Response<ShareDirectoryInfo>> SetMetadataAsync(
            Metadata metadata,
            CancellationToken cancellationToken = default) =>
            await SetMetadataInternal(
                metadata,
                true, // async
                cancellationToken)
                .ConfigureAwait(false);

        /// <summary>
        /// The <see cref="SetMetadataInternal"/> operation sets one or more
        /// user-defined name-value pairs for the specified directory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/set-directory-metadata"/>.
        /// </summary>
        /// <param name="metadata">
        /// Custom metadata to set for this directory.
        /// </param>
        /// <param name="async">
        /// Whether to invoke the operation asynchronously.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{StorageDirectoryInfo}"/> if successful.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        private async Task<Response<ShareDirectoryInfo>> SetMetadataInternal(
            Metadata metadata,
            bool async,
            CancellationToken cancellationToken)
        {
            using (Pipeline.BeginLoggingScope(nameof(ShareDirectoryClient)))
            {
                Pipeline.LogMethodEnter(
                    nameof(ShareDirectoryClient),
                    message: $"{nameof(Uri)}: {Uri}");
                try
                {
                    Response<RawStorageDirectoryInfo> response = await FileRestClient.Directory.SetMetadataAsync(
                        ClientDiagnostics,
                        Pipeline,
                        Uri,
                        metadata: metadata,
                        async: async,
                        operationName: Constants.File.Directory.SetMetadataOperationName,
                        cancellationToken: cancellationToken)
                        .ConfigureAwait(false);

                    return Response.FromValue(new ShareDirectoryInfo(response.Value), response.GetRawResponse());
                }
                catch (Exception ex)
                {
                    Pipeline.LogException(ex);
                    throw;
                }
                finally
                {
                    Pipeline.LogMethodExit(nameof(ShareDirectoryClient));
                }
            }
        }
        #endregion SetMetadata

        #region GetFilesAndDirectories
        /// <summary>
        /// The <see cref="GetFilesAndDirectories"/> operation returns an async
        /// sequence of files and subdirectories in this directory.
        /// Enumerating the files and directories may make multiple requests
        /// to the service while fetching all the values.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/list-directories-and-files"/>.
        /// </summary>
        /// <param name="prefix">
        /// Optional string that filters the results to return only
        /// files and directories whose name begins with the specified prefix.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// An <see cref="IEnumerable{T}" /> of <see cref="Response{StorageFileItem}"/>
        /// describing  the items in the directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual Pageable<ShareFileItem> GetFilesAndDirectories(
            string prefix = default,
            CancellationToken cancellationToken = default) =>
            new GetFilesAndDirectoriesAsyncCollection(this, prefix).ToSyncCollection(cancellationToken);

        /// <summary>
        /// The <see cref="GetFilesAndDirectoriesAsync"/> operation returns an
        /// async collection of files and subdirectories in this directory.
        /// Enumerating the files and directories may make multiple requests
        /// to the service while fetching all the values.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/list-directories-and-files"/>.
        /// </summary>
        /// <param name="prefix">
        /// Optional string that filters the results to return only
        /// files and directories whose name begins with the specified prefix.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="AsyncPageable{T}"/> describing the
        /// items in the directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual AsyncPageable<ShareFileItem> GetFilesAndDirectoriesAsync(
            string prefix = default,
            CancellationToken cancellationToken = default) =>
            new GetFilesAndDirectoriesAsyncCollection(this, prefix).ToAsyncCollection(cancellationToken);

        /// <summary>
        /// The <see cref="GetFilesAndDirectoriesInternal"/> operation returns a
        /// single segment of files and subdirectories in this directory, starting
        /// from the specified <paramref name="marker"/>.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/list-directories-and-files"/>.
        /// </summary>
        /// <param name="marker">
        /// An optional string value that identifies the segment of the list
        /// of items to be returned with the next listing operation.  The
        /// operation returns a non-empty <see cref="FilesAndDirectoriesSegment.NextMarker"/>
        /// if the listing operation did not return all items remaining to be
        /// listed with the current segment.  The NextMarker value can
        /// be used as the value for the <paramref name="marker"/> parameter
        /// in a subsequent call to request the next segment of list items.
        /// </param>
        /// <param name="prefix">
        /// Optional string that filters the results to return only
        /// files and directories whose name begins with the specified prefix.
        /// </param>
        /// <param name="pageSizeHint">
        /// Gets or sets a value indicating the size of the page that should be
        /// requested.
        /// </param>
        /// <param name="async">
        /// Whether to invoke the operation asynchronously.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{FilesAndDirectoriesSegment}"/> describing a
        /// segment of the items in the directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        internal async Task<Response<FilesAndDirectoriesSegment>> GetFilesAndDirectoriesInternal(
            string marker,
            string prefix,
            int? pageSizeHint,
            bool async,
            CancellationToken cancellationToken)
        {
            using (Pipeline.BeginLoggingScope(nameof(ShareDirectoryClient)))
            {
                Pipeline.LogMethodEnter(
                    nameof(ShareDirectoryClient),
                    message:
                    $"{nameof(Uri)}: {Uri}\n" +
                    $"{nameof(marker)}: {marker}\n" +
                    $"{nameof(prefix)}: {prefix}");
                try
                {
                    return await FileRestClient.Directory.ListFilesAndDirectoriesSegmentAsync(
                        ClientDiagnostics,
                        Pipeline,
                        Uri,
                        marker: marker,
                        prefix: prefix,
                        maxresults: pageSizeHint,
                        async: async,
                        operationName: Constants.File.Directory.ListFilesAndDirectoriesSegmentOperationName,
                        cancellationToken: cancellationToken)
                        .ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    Pipeline.LogException(ex);
                    throw;
                }
                finally
                {
                    Pipeline.LogMethodExit(nameof(ShareDirectoryClient));
                }
            }
        }
        #endregion GetFilesAndDirectories

        #region GetHandles
        /// <summary>
        /// The <see cref="GetHandles"/> operation returns an async sequence
        /// of the open handles on a directory or a file.  Enumerating the
        /// handles may make multiple requests to the service while fetching
        /// all the values.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/list-handles"/>.
        /// </summary>
        /// <param name="recursive">
        /// Optional. A boolean value that specifies if the operation should also apply to the files and subdirectories of the directory specified.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// An <see cref="IEnumerable{T}"/> of <see cref="Response{StorageHandle}"/>
        /// describing the handles in the directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual Pageable<ShareFileHandle> GetHandles(
            bool? recursive = default,
            CancellationToken cancellationToken = default) =>
            new GetDirectoryHandlesAsyncCollection(this, recursive).ToSyncCollection(cancellationToken);

        /// <summary>
        /// The <see cref="GetHandlesAsync"/> operation returns an async
        /// sequence of the open handles on a directory or a file.
        /// Enumerating the handles may make multiple requests to the service
        /// while fetching all the values.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/list-handles"/>.
        /// </summary>
        /// <param name="recursive">
        /// Optional. A boolean value that specifies if the operation should also apply to the files and subdirectories of the directory specified.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="AsyncPageable{T}"/> describing the
        /// handles on the directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual AsyncPageable<ShareFileHandle> GetHandlesAsync(
            bool? recursive = default,
            CancellationToken cancellationToken = default) =>
            new GetDirectoryHandlesAsyncCollection(this, recursive).ToAsyncCollection(cancellationToken);

        /// <summary>
        /// The <see cref="GetHandlesAsync"/> operation returns a list of open
        /// handles on a directory or a file.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/list-handles"/>.
        /// </summary>
        /// <param name="marker">
        /// An optional string value that identifies the segment of the list
        /// of items to be returned with the next listing operation.  The
        /// operation returns a non-empty <see cref="StorageHandlesSegment.NextMarker"/>
        /// if the listing operation did not return all items remaining to be
        /// listed with the current segment.  The NextMarker value can
        /// be used as the value for the <paramref name="marker"/> parameter
        /// in a subsequent call to request the next segment of list items.
        /// </param>
        /// <param name="maxResults">
        /// Optional. Specifies the maximum number of handles taken on files and/or directories to return.
        /// </param>
        /// <param name="recursive">
        /// Optional. A boolean value that specifies if the operation should also apply to the files and subdirectories of the directory specified.
        /// </param>
        /// <param name="async">
        /// Whether to invoke the operation asynchronously.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{StorageHandlesSegment}"/> describing a
        /// segment of the handles in the directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        internal async Task<Response<StorageHandlesSegment>> GetHandlesInternal(
            string marker,
            int? maxResults,
            bool? recursive,
            bool async,
            CancellationToken cancellationToken)
        {
            using (Pipeline.BeginLoggingScope(nameof(ShareDirectoryClient)))
            {
                Pipeline.LogMethodEnter(
                    nameof(ShareDirectoryClient),
                    message:
                    $"{nameof(Uri)}: {Uri}\n" +
                    $"{nameof(marker)}: {marker}\n" +
                    $"{nameof(maxResults)}: {maxResults}\n" +
                    $"{nameof(recursive)}: {recursive}");
                try
                {
                    return await FileRestClient.Directory.ListHandlesAsync(
                        ClientDiagnostics,
                        Pipeline,
                        Uri,
                        marker: marker,
                        maxresults: maxResults,
                        recursive: recursive,
                        async: async,
                        operationName: Constants.File.Directory.GetHandlesOperationName,
                        cancellationToken: cancellationToken)
                        .ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    Pipeline.LogException(ex);
                    throw;
                }
                finally
                {
                    Pipeline.LogMethodExit(nameof(ShareDirectoryClient));
                }
            }
        }
        #endregion GetHandles

        #region ForceCloseHandles
        /// <summary>
        /// The <see cref="ForceCloseHandle"/> operation closes a handle opened on a directory
        /// or a file at the service. It supports closing a single handle specified by <paramref name="handleId"/>.
        ///
        /// This API is intended to be used alongside <see cref="GetHandles"/> to force close handles that
        /// block operations, such as renaming a directory. These handles may have leaked or been lost track of by
        /// SMB clients. The API has client-side impact on the handle being closed, including user visible
        /// errors due to failed attempts to read or write files. This API is not intended for use as a replacement
        /// or alternative for SMB close.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/force-close-handles"/>.
        /// </summary>
        /// <param name="handleId">
        /// Specifies the handle ID to be closed.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{CloseHandlesResult}"/> describing the status of the
        /// <see cref="ForceCloseHandle"/> operation.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual Response<CloseHandlesResult> ForceCloseHandle(
            string handleId,
            CancellationToken cancellationToken = default)
        {
            Response<StorageClosedHandlesSegment> response = ForceCloseHandlesInternal(
                handleId,
                null,
                null,
                false, // async
                cancellationToken,
                Constants.File.Directory.ForceCloseHandleOperationName)
                .EnsureCompleted();

            return Response.FromValue(
                response.ToCloseHandlesResult(),
                response.GetRawResponse());
        }

        /// <summary>
        /// The <see cref="ForceCloseHandle"/> operation closes a handle opened on a directory
        /// or a file at the service. It supports closing a single handle specified by <paramref name="handleId"/>.
        ///
        /// This API is intended to be used alongside <see cref="GetHandlesAsync"/> to force close handles that
        /// block operations, such as renaming a directory. These handles may have leaked or been lost track of by
        /// SMB clients. The API has client-side impact on the handle being closed, including user visible
        /// errors due to failed attempts to read or write files. This API is not intended for use as a replacement
        /// or alternative for SMB close.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/force-close-handles"/>.
        /// </summary>
        /// <param name="handleId">
        /// Specifies the handle ID to be closed.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{CloseHandlesResult}"/> describing the status of the
        /// <see cref="ForceCloseHandleAsync"/> operation.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual async Task<Response<CloseHandlesResult>> ForceCloseHandleAsync(
            string handleId,
            CancellationToken cancellationToken = default)
        {
            Response<StorageClosedHandlesSegment> response = await ForceCloseHandlesInternal(
                handleId,
                null,
                null,
                true, // async
                cancellationToken,
                Constants.File.Directory.ForceCloseHandleOperationName)
                .ConfigureAwait(false);

            return Response.FromValue(
                response.ToCloseHandlesResult(),
                response.GetRawResponse());
        }

        /// <summary>
        /// The <see cref="ForceCloseAllHandles"/> operation closes all handles opened on a directory
        /// or a file at the service. It optionally supports recursively closing handles on subresources
        /// when the resource is a directory.
        ///
        /// This API is intended to be used alongside <see cref="GetHandles"/> to force close handles that
        /// block operations, such as renaming a directory. These handles may have leaked or been lost track of by
        /// SMB clients. The API has client-side impact on the handle being closed, including user visible
        /// errors due to failed attempts to read or write files. This API is not intended for use as a replacement
        /// or alternative for SMB close.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/force-close-handles"/>.
        /// </summary>
        /// <param name="recursive">
        /// Optional. A boolean value that specifies if the operation should also apply to the files and subdirectories of the directory specified.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="CloseHandlesResult"/> describing the status of the
        /// <see cref="ForceCloseAllHandles"/> operation.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual CloseHandlesResult ForceCloseAllHandles(
            bool? recursive = default,
            CancellationToken cancellationToken = default) =>
            ForceCloseAllHandlesInternal(
                recursive,
                false, // async
                cancellationToken)
                .EnsureCompleted();

        /// <summary>
        /// The <see cref="ForceCloseAllHandlesAsync"/> operation closes all handles opened on a directory
        /// or a file at the service. It optionally supports recursively closing handles on subresources
        /// when the resource is a directory.
        ///
        /// This API is intended to be used alongside <see cref="GetHandlesAsync"/> to force close handles that
        /// block operations, such as renaming a directory. These handles may have leaked or been lost track of by
        /// SMB clients. The API has client-side impact on the handle being closed, including user visible
        /// errors due to failed attempts to read or write files. This API is not intended for use as a replacement
        /// or alternative for SMB close.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/force-close-handles"/>.
        /// </summary>
        /// <param name="recursive">
        /// Optional. A boolean value that specifies if the operation should also apply to the files and subdirectories of the directory specified.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="CloseHandlesResult"/> describing the status of the
        /// <see cref="ForceCloseAllHandlesAsync"/> operation.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        public virtual async Task<CloseHandlesResult> ForceCloseAllHandlesAsync(
            bool? recursive = default,
            CancellationToken cancellationToken = default) =>
            await ForceCloseAllHandlesInternal(
                recursive,
                true, // async
                cancellationToken)
                .ConfigureAwait(false);

        /// <summary>
        /// The <see cref="ForceCloseAllHandlesAsync"/> operation closes all handles opened on a directory
        /// or a file at the service. It optionally supports recursively closing handles on subresources
        /// when the resource is a directory.
        ///
        /// This API is intended to be used alongside <see cref="GetHandlesAsync"/> to force close handles that
        /// block operations. These handles may have leaked or been lost track of by
        /// SMB clients. The API has client-side impact on the handle being closed, including user visible
        /// errors due to failed attempts to read or write files. This API is not intended for use as a replacement
        /// or alternative for SMB close.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/force-close-handles"/>.
        /// </summary>
        /// <param name="recursive">
        /// Optional. A boolean value that specifies if the operation should also apply to the files and subdirectories of the directory specified.
        /// </param>
        /// <param name="async">
        /// Whether to invoke the operation asynchronously.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="CloseHandlesResult"/> describing the status of the
        /// <see cref="ForceCloseAllHandlesInternal"/> operation.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        private async Task<CloseHandlesResult> ForceCloseAllHandlesInternal(
            bool? recursive,
            bool async,
            CancellationToken cancellationToken)
        {
            int handlesClosed = 0;
            int handlesFailed = 0;
            string marker = null;
            do
            {
                Response<StorageClosedHandlesSegment> response =
                    await ForceCloseHandlesInternal(
                        Constants.CloseAllHandles,
                        marker,
                        recursive,
                        async,
                        cancellationToken)
                    .ConfigureAwait(false);
                marker = response.Value.Marker;
                handlesClosed += response.Value.NumberOfHandlesClosed;
                handlesFailed += response.Value.NumberOfHandlesFailedToClosed;

            } while (!string.IsNullOrEmpty(marker));

            return new CloseHandlesResult()
            {
                ClosedHandlesCount = handlesClosed,
                FailedHandlesCount = handlesFailed
            };
        }

        /// <summary>
        /// The <see cref="ForceCloseAllHandlesAsync"/> operation closes a handle or handles opened on a directory
        /// or a file at the service. It supports closing a single handle specified by <paramref name="handleId"/> on a file or
        /// directory or closing all handles opened on that resource. It optionally supports recursively closing
        /// handles on subresources when the resource is a directory.
        ///
        /// This API is intended to be used alongside <see cref="GetHandlesAsync"/> to force close handles that
        /// block operations, such as renaming a directory. These handles may have leaked or been lost track of by
        /// SMB clients. The API has client-side impact on the handle being closed, including user visible
        /// errors due to failed attempts to read or write files. This API is not intended for use as a replacement
        /// or alternative for SMB close.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/force-close-handles"/>.
        /// </summary>
        /// <param name="handleId">
        /// Optional. Specifies the handle ID to be closed. If not specified, or if equal to &quot;*&quot;, will close all handles.
        /// </param>
        /// <param name="marker">
        /// An optional string value that identifies the segment of the handles
        /// to be closed with the next call to <see cref="ForceCloseAllHandlesAsync"/>.  The
        /// operation returns a non-empty <see cref="StorageClosedHandlesSegment.Marker"/>
        /// if the operation did not return all items remaining to be
        /// closed with the current segment.  The NextMarker value can
        /// be used as the value for the <paramref name="marker"/> parameter
        /// in a subsequent call to request the closure of the next segment of handles.
        /// </param>
        /// <param name="recursive">
        /// Optional. A boolean value that specifies if the operation should also apply to the files and subdirectories of the directory specified.
        /// </param>
        /// <param name="async">
        /// Whether to invoke the operation asynchronously.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <param name="operationName">
        /// Optional. Used to indicate the name of the operation.
        /// </param>
        /// <returns>
        /// A <see cref="Response{StorageClosedHandlesSegment}"/> describing a
        /// segment of the handles closed.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        private async Task<Response<StorageClosedHandlesSegment>> ForceCloseHandlesInternal(
            string handleId,
            string marker,
            bool? recursive,
            bool async,
            CancellationToken cancellationToken,
            string operationName = Constants.File.Directory.ForceCloseAllHandlesOperationName)
        {
            using (Pipeline.BeginLoggingScope(nameof(ShareDirectoryClient)))
            {
                Pipeline.LogMethodEnter(
                    nameof(ShareDirectoryClient),
                    message:
                    $"{nameof(Uri)}: {Uri}\n" +
                    $"{nameof(handleId)}: {handleId}\n" +
                    $"{nameof(marker)}: {marker}\n" +
                    $"{nameof(recursive)}: {recursive}");
                try
                {
                    return await FileRestClient.Directory.ForceCloseHandlesAsync(
                        ClientDiagnostics,
                        Pipeline,
                        Uri,
                        marker: marker,
                        handleId: handleId,
                        recursive: recursive,
                        async: async,
                        operationName: operationName,
                        cancellationToken: cancellationToken)
                        .ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    Pipeline.LogException(ex);
                    throw;
                }
                finally
                {
                    Pipeline.LogMethodExit(nameof(ShareDirectoryClient));
                }
            }
        }
        #endregion ForceCloseHandles

        #region CreateSubdirectory
        /// <summary>
        /// The <see cref="CreateSubdirectory"/> operation creates a new
        /// subdirectory under this directory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/create-directory"/>.
        /// </summary>
        /// <param name="subdirectoryName">The name of the subdirectory.</param>
        /// <param name="metadata">
        /// Optional custom metadata to set for this directory.
        /// </param>
        /// <param name="smbProperties">
        /// Optional SMB properties to set for the subdirectory.
        /// </param>
        /// <param name="filePermission">
        /// Optional file permission to set for the subdirectory.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{DirectoryClient}"/> referencing the
        /// newly created directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        [ForwardsClientCalls]
        public virtual Response<ShareDirectoryClient> CreateSubdirectory(
            string subdirectoryName,
            Metadata metadata = default,
            FileSmbProperties smbProperties = default,
            string filePermission = default,
            CancellationToken cancellationToken = default)
        {
            ShareDirectoryClient subdir = GetSubdirectoryClient(subdirectoryName);
            Response<ShareDirectoryInfo> response = subdir.Create(
                metadata,
                smbProperties,
                filePermission,
                cancellationToken);
            return Response.FromValue(subdir, response.GetRawResponse());
        }

        /// <summary>
        /// The <see cref="CreateSubdirectoryAsync"/> operation creates a new
        /// subdirectory under this directory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/create-directory"/>.
        /// </summary>
        /// <param name="subdirectoryName">The name of the subdirectory.</param>
        /// <param name="metadata">
        /// Optional custom metadata to set for the subdirectory.
        /// </param>
        /// <param name="smbProperties">
        /// Optional SMB properties to set for the subdirectory.
        /// </param>
        /// <param name="filePermission">
        /// Optional file permission to set for the subdirectory.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{DirectoryClient}"/> referencing the
        /// newly created directory.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        [ForwardsClientCalls]
        public virtual async Task<Response<ShareDirectoryClient>> CreateSubdirectoryAsync(
            string subdirectoryName,
            Metadata metadata = default,
            FileSmbProperties smbProperties = default,
            string filePermission = default,
            CancellationToken cancellationToken = default)
        {
            ShareDirectoryClient subdir = GetSubdirectoryClient(subdirectoryName);
            Response<ShareDirectoryInfo> response = await subdir.CreateAsync(
                    metadata,
                    smbProperties,
                    filePermission,
                    cancellationToken)
                .ConfigureAwait(false);
            return Response.FromValue(subdir, response.GetRawResponse());
        }
        #endregion CreateSubdirectory

        #region DeleteSubdirectory
        /// <summary>
        /// The <see cref="DeleteSubdirectory"/> operation removes the
        /// specified empty subdirectory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/delete-directory"/>.
        /// </summary>
        /// <param name="subdirectoryName">The name of the subdirectory.</param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response"/> if successful.
        /// </returns>
        /// <remarks>
        /// Note that the directory must be empty before it can be deleted.
        /// </remarks>
        [ForwardsClientCalls]
        public virtual Response DeleteSubdirectory(
            string subdirectoryName,
            CancellationToken cancellationToken = default) =>
            GetSubdirectoryClient(subdirectoryName).Delete(cancellationToken);

        /// <summary>
        /// The <see cref="DeleteSubdirectoryAsync"/> operation removes the
        /// specified empty subdirectory.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/rest/api/storageservices/delete-directory"/>.
        /// </summary>
        /// <param name="subdirectoryName">The name of the subdirectory.</param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response"/> if successful.
        /// </returns>
        /// <remarks>
        /// Note that the directory must be empty before it can be deleted.
        /// </remarks>
        [ForwardsClientCalls]
        public virtual async Task<Response> DeleteSubdirectoryAsync(
            string subdirectoryName,
            CancellationToken cancellationToken = default) =>
            await GetSubdirectoryClient(subdirectoryName)
                .DeleteAsync(cancellationToken)
                .ConfigureAwait(false);
        #endregion DeleteSubdirectory

        #region CreateFile
        /// <summary>
        /// Creates a new file or replaces an existing file.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/create-file"/>.
        /// </summary>
        /// <remarks>
        /// This method only initializes the file.
        /// To add content, use <see cref="ShareFileClient.UploadRangeAsync(ShareFileRangeWriteType, HttpRange, System.IO.Stream, byte[], IProgress{long}, FileRequestConditions, CancellationToken)"/>.
        /// </remarks>
        /// <param name="fileName">The name of the file.</param>
        /// <param name="maxSize">
        /// Required. Specifies the maximum size for the file.
        /// </param>
        /// <param name="httpHeaders">
        /// Optional standard HTTP header properties that can be set for the file.
        /// </param>
        /// <param name="metadata">
        /// Optional custom metadata to set for the file.
        /// </param>
        /// <param name="smbProperties">
        /// Optional SMB properties to set for the file.
        /// </param>
        /// <param name="filePermission">
        /// Optional file permission to set for the file.
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="FileRequestConditions"/> to add conditions
        /// on creating the file.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{FileClient}"/> referencing the file.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        [ForwardsClientCalls]
        public virtual Response<ShareFileClient> CreateFile(
            string fileName,
            long maxSize,
            ShareFileHttpHeaders httpHeaders = default,
            Metadata metadata = default,
            FileSmbProperties smbProperties = default,
            string filePermission = default,
            FileRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            ShareFileClient file = GetFileClient(fileName);
            Response<ShareFileInfo> response = file.Create(
                maxSize,
                httpHeaders,
                metadata,
                smbProperties,
                filePermission,
                conditions,
                cancellationToken);
            return Response.FromValue(file, response.GetRawResponse());
        }

        /// <summary>
        /// Creates a new file or replaces an existing file.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/create-file"/>.
        /// </summary>
        /// <remarks>
        /// This method only initializes the file.
        /// To add content, use <see cref="ShareFileClient.UploadRange(ShareFileRangeWriteType, HttpRange, System.IO.Stream, byte[], IProgress{long}, FileRequestConditions, CancellationToken)"/>.
        /// </remarks>
        /// <param name="fileName">The name of the file.</param>
        /// <param name="maxSize">
        /// Required. Specifies the maximum size for the file.
        /// </param>
        /// <param name="httpHeaders">
        /// Optional standard HTTP header properties that can be set for the file.
        /// </param>
        /// <param name="metadata">
        /// Optional custom metadata to set for the file.
        /// </param>
        /// <param name="smbProperties">
        /// Optional SMB properties to set for the file.
        /// </param>
        /// <param name="filePermission">
        /// Optional file permission to set for the file.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{FileClient}"/> referencing the file.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        [ForwardsClientCalls]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "AZC0002:DO ensure all service methods, both asynchronous and synchronous, take an optional CancellationToken parameter called cancellationToken.", Justification = "<Pending>")]
        public virtual Response<ShareFileClient> CreateFile(
            string fileName,
            long maxSize,
            ShareFileHttpHeaders httpHeaders,
            Metadata metadata,
            FileSmbProperties smbProperties,
            string filePermission,
            CancellationToken cancellationToken)
        {
            ShareFileClient file = GetFileClient(fileName);
            Response<ShareFileInfo> response = file.Create(
                maxSize,
                httpHeaders,
                metadata,
                smbProperties,
                filePermission,
                conditions: default,
                cancellationToken);
            return Response.FromValue(file, response.GetRawResponse());
        }

        /// <summary>
        /// Creates a new file or replaces an existing file.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/create-file"/>.
        /// </summary>
        /// <remarks>
        /// This method only initializes the file.
        /// To add content, use <see cref="ShareFileClient.UploadRangeAsync(ShareFileRangeWriteType, HttpRange, System.IO.Stream, byte[], IProgress{long}, FileRequestConditions, CancellationToken)"/>.
        /// </remarks>
        /// <param name="fileName">The name of the file.</param>
        /// <param name="maxSize">
        /// Required. Specifies the maximum size for the file.
        /// </param>
        /// <param name="httpHeaders">
        /// Optional standard HTTP header properties that can be set for the file.
        /// </param>
        /// <param name="metadata">
        /// Optional custom metadata to set for the file.
        /// </param>
        /// <param name="smbProperties">
        /// Optional SMB properties to set for the file.
        /// </param>
        /// <param name="filePermission">
        /// Optional file permission to set for the file.
        /// </param>
        /// <param name="conditions">
        /// Optional <see cref="FileRequestConditions"/> to add conditions
        /// on creating the file.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{FileClient}"/> referencing the file.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        [ForwardsClientCalls]
        public virtual async Task<Response<ShareFileClient>> CreateFileAsync(
            string fileName,
            long maxSize,
            ShareFileHttpHeaders httpHeaders = default,
            Metadata metadata = default,
            FileSmbProperties smbProperties = default,
            string filePermission = default,
            FileRequestConditions conditions = default,
            CancellationToken cancellationToken = default)
        {
            ShareFileClient file = GetFileClient(fileName);
            Response<ShareFileInfo> response = await file.CreateAsync(
                maxSize,
                httpHeaders,
                metadata,
                smbProperties,
                filePermission,
                conditions,
                cancellationToken).ConfigureAwait(false);
            return Response.FromValue(file, response.GetRawResponse());
        }

        /// <summary>
        /// Creates a new file or replaces an existing file.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/create-file"/>.
        /// </summary>
        /// <remarks>
        /// This method only initializes the file.
        /// To add content, use <see cref="ShareFileClient.UploadRange(ShareFileRangeWriteType, HttpRange, System.IO.Stream, byte[], IProgress{long}, FileRequestConditions, CancellationToken)"/>.
        /// </remarks>
        /// <param name="fileName">The name of the file.</param>
        /// <param name="maxSize">
        /// Required. Specifies the maximum size for the file.
        /// </param>
        /// <param name="httpHeaders">
        /// Optional standard HTTP header properties that can be set for the file.
        /// </param>
        /// <param name="metadata">
        /// Optional custom metadata to set for the file.
        /// </param>
        /// <param name="smbProperties">
        /// Optional SMB properties to set for the file.
        /// </param>
        /// <param name="filePermission">
        /// Optional file permission to set for the file.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response{FileClient}"/> referencing the file.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        [ForwardsClientCalls]
        public virtual async Task<Response<ShareFileClient>> CreateFileAsync(
            string fileName,
            long maxSize,
            ShareFileHttpHeaders httpHeaders,
            Metadata metadata,
            FileSmbProperties smbProperties,
            string filePermission,
            CancellationToken cancellationToken = default)
        {
            ShareFileClient file = GetFileClient(fileName);
            Response<ShareFileInfo> response = await file.CreateAsync(
                maxSize,
                httpHeaders,
                metadata,
                smbProperties,
                filePermission,
                conditions: default,
                cancellationToken).ConfigureAwait(false);
            return Response.FromValue(file, response.GetRawResponse());
        }
        #endregion CreateFile

        #region DeleteFile
        /// <summary>
        /// The <see cref="DeleteFile(string, FileRequestConditions, CancellationToken)"/>
        /// operation immediately removes the file from the storage account.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/delete-file2"/>.
        /// </summary>
        /// <param name="fileName">The name of the file.</param>
        /// <param name="conditions">
        /// Optional <see cref="FileRequestConditions"/> to add conditions
        /// on creating the file.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response"/> on successfully deleting.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        [ForwardsClientCalls]
        public virtual Response DeleteFile(
            string fileName,
            FileRequestConditions conditions = default,
            CancellationToken cancellationToken = default) =>
            GetFileClient(fileName).Delete(
                conditions,
                cancellationToken);

        /// <summary>
        /// The <see cref="DeleteFile(string, CancellationToken)"/>
        /// operation immediately removes the file from the storage account.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/delete-file2"/>.
        /// </summary>
        /// <param name="fileName">The name of the file.</param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response"/> on successfully deleting.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        [ForwardsClientCalls]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "AZC0002:DO ensure all service methods, both asynchronous and synchronous, take an optional CancellationToken parameter called cancellationToken.", Justification = "<Pending>")]
        public virtual Response DeleteFile(
            string fileName,
            CancellationToken cancellationToken) =>
            GetFileClient(fileName).Delete(
                conditions: default,
                cancellationToken);

        /// <summary>
        /// The <see cref="DeleteFile(string, FileRequestConditions, CancellationToken)"/>
        /// operation immediately removes the file from the storage account.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/delete-file2"/>.
        /// </summary>
        /// <param name="fileName">The name of the file.</param>
        /// <param name="conditions">
        /// Optional <see cref="FileRequestConditions"/> to add conditions
        /// on creating the file.
        /// </param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response"/> on successfully deleting.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will be thrown if
        /// a failure occurs.
        /// </remarks>
        [ForwardsClientCalls]
        public virtual async Task<Response> DeleteFileAsync(
            string fileName,
            FileRequestConditions conditions = default,
            CancellationToken cancellationToken = default) =>
            await GetFileClient(fileName)
                .DeleteAsync(
                    conditions,
                    cancellationToken)
                .ConfigureAwait(false);

        /// <summary>
        /// The <see cref="DeleteFileAsync(string, CancellationToken)"/>
        /// operation immediately removesthe file from the storage account.
        ///
        /// For more information, see <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/delete-file2"/>.
        /// </summary>
        /// <param name="fileName">The name of the file.</param>
        /// <param name="cancellationToken">
        /// Optional <see cref="CancellationToken"/> to propagate
        /// notifications that the operation should be cancelled.
        /// </param>
        /// <returns>
        /// A <see cref="Response"/> on successfully deleting.
        /// </returns>
        /// <remarks>
        /// A <see cref="RequestFailedException"/> will bse thrown if
        /// a failure occurs.
        /// </remarks>
        [ForwardsClientCalls]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "AZC0002:DO ensure all service methods, both asynchronous and synchronous, take an optional CancellationToken parameter called cancellationToken.", Justification = "<Pending>")]
        public virtual async Task<Response> DeleteFileAsync(
            string fileName,
            CancellationToken cancellationToken) =>
            await GetFileClient(fileName)
                .DeleteAsync(
                    conditions: default,
                    cancellationToken)
                .ConfigureAwait(false);
        #endregion DeleteFile
    }
}
