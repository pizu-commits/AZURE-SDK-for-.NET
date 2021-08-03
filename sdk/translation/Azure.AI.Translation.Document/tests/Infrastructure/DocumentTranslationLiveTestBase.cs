﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Sas;

namespace Azure.AI.Translation.Document.Tests
{
    public abstract class DocumentTranslationLiveTestBase : RecordedTestBase<DocumentTranslationTestEnvironment>
    {
        protected TimeSpan PollingInterval => TimeSpan.FromSeconds(Mode == RecordedTestMode.Playback ? 0 : 30);

        public DocumentTranslationLiveTestBase(bool isAsync, RecordedTestMode? mode = null)
            : base(isAsync, mode)
        {
            Sanitizer = new DocumentTranslationRecordedTestSanitizer();
        }

        protected static readonly List<TestDocument> oneTestDocuments = new()
        {
            new TestDocument("Document1.txt", "First english test document"),
        };

        protected static readonly List<TestDocument> twoTestDocuments = new()
        {
            new TestDocument("Document1.txt", "First english test document"),
            new TestDocument("File2.txt", "Second english test file"),
        };

        public DocumentTranslationClient GetClient(
            AzureKeyCredential credential = default,
            DocumentTranslationClientOptions options = default,
            bool useTokenCredential = default)
        {
            var endpoint = new Uri(TestEnvironment.Endpoint);
            options ??= new DocumentTranslationClientOptions()
            {
                Diagnostics =
                {
                    LoggedHeaderNames = { "x-ms-request-id", "X-RequestId" },
                    IsLoggingContentEnabled = true
                }
            };

            if (useTokenCredential)
            {
                return InstrumentClient(new DocumentTranslationClient(endpoint, TestEnvironment.Credential, InstrumentClientOptions(options)));
            }
            else
            {
                credential ??= new AzureKeyCredential(TestEnvironment.ApiKey);
                return InstrumentClient(new DocumentTranslationClient(endpoint, credential, InstrumentClientOptions(options)));
            }
        }

        public BlobContainerClient GetBlobContainerClient(string containerName)
        {
            return InstrumentClient(new BlobContainerClient(TestEnvironment.StorageConnectionString, containerName, InstrumentClientOptions(new BlobClientOptions())));
        }
        public Uri CreateSourceContainer(List<TestDocument> documents)
        {
            Recording.DisableIdReuse();
            string containerName = "source" + Recording.GenerateId();
            var containerClient = GetBlobContainerClient(containerName);
            containerClient.Create(PublicAccessType.BlobContainer);

            UploadDocuments(containerClient, documents);

            var expiresOn = DateTimeOffset.UtcNow.AddHours(1);
            return containerClient.GenerateSasUri(BlobContainerSasPermissions.List | BlobContainerSasPermissions.Read, expiresOn);
        }

        public async Task<Uri> CreateSourceContainerAsync(List<TestDocument> documents)
        {
            Recording.DisableIdReuse();
            string containerName = "source" + Recording.GenerateId();
            var containerClient = GetBlobContainerClient(containerName);
            await containerClient.CreateAsync(PublicAccessType.BlobContainer).ConfigureAwait(false);

            await UploadDocumentsAsync(containerClient, documents);

            var expiresOn = DateTimeOffset.UtcNow.AddHours(1);
            return containerClient.GenerateSasUri(BlobContainerSasPermissions.List | BlobContainerSasPermissions.Read, expiresOn);
        }

        public Uri CreateTargetContainer(List<TestDocument> documents = default)
        {
            Recording.DisableIdReuse();
            string containerName = "target" + Recording.GenerateId();
            var containerClient = GetBlobContainerClient(containerName);
            containerClient.Create(PublicAccessType.BlobContainer);

            if (documents != default)
            {
                UploadDocuments(containerClient, documents);
            }

            var expiresOn = DateTimeOffset.UtcNow.AddHours(1);
            return containerClient.GenerateSasUri(BlobContainerSasPermissions.List | BlobContainerSasPermissions.Write, expiresOn);
        }

        public async Task<Uri> CreateTargetContainerAsync(List<TestDocument> documents = default)
        {
            Recording.DisableIdReuse();
            string containerName = "target" + Recording.GenerateId();
            var containerClient = GetBlobContainerClient(containerName);
            await containerClient.CreateAsync(PublicAccessType.BlobContainer).ConfigureAwait(false);

            if (documents != default)
            {
                await UploadDocumentsAsync(containerClient, documents);
            }

            var expiresOn = DateTimeOffset.UtcNow.AddHours(1);
            return containerClient.GenerateSasUri(BlobContainerSasPermissions.List | BlobContainerSasPermissions.Write, expiresOn);
        }
        public async Task<Uri> CreateGlossaryAsync(TestDocument document = default)
        {
            Recording.DisableIdReuse();
            var glossaryContainerName = "glossary" + Recording.GenerateId();
            var containerClient = GetBlobContainerClient(glossaryContainerName);
            await containerClient.CreateAsync(PublicAccessType.BlobContainer).ConfigureAwait(false);

            if (document != default)
            {
                await UploadDocumentsAsync(containerClient, new List<TestDocument> { document });
            }

            var expiresOn = DateTimeOffset.UtcNow.AddHours(1);
            var glossaryContainerSasUri = containerClient.GenerateSasUri(BlobContainerSasPermissions.Read | BlobContainerSasPermissions.Write, expiresOn);
            return new Uri(String.Format("{0}{1}{2}{3}/{4}{5}", glossaryContainerSasUri.Scheme, Uri.SchemeDelimiter, glossaryContainerSasUri.Authority, glossaryContainerSasUri.AbsolutePath, document.Name, glossaryContainerSasUri.Query));
        }

        public Uri CreateGlossary(TestDocument document = default)
        {
            Recording.DisableIdReuse();
            var glossaryContainerName = "glossary" + Recording.GenerateId();
            var containerClient = GetBlobContainerClient(glossaryContainerName);
            containerClient.Create(PublicAccessType.BlobContainer);

            if (document != default)
            {
                UploadDocuments(containerClient, new List<TestDocument> { document });
            }

            var expiresOn = DateTimeOffset.UtcNow.AddHours(1);
            var glossaryContainerSasUri = containerClient.GenerateSasUri(BlobContainerSasPermissions.Read | BlobContainerSasPermissions.Write, expiresOn);
            return new Uri(String.Format("{0}{1}{2}{3}/{4}{5}", glossaryContainerSasUri.Scheme, Uri.SchemeDelimiter, glossaryContainerSasUri.Authority, glossaryContainerSasUri.AbsolutePath, document.Name, glossaryContainerSasUri.Query));
        }

        private async Task UploadDocumentsAsync(BlobContainerClient containerClient, List<TestDocument> documents)
        {
            for (int i = 0; i < documents.Count; i++)
            {
                byte[] byteArray = Encoding.ASCII.GetBytes(documents[i].Content);
                MemoryStream stream = new MemoryStream(byteArray);
                await containerClient.UploadBlobAsync(documents[i].Name, stream);
            }
        }
        private void UploadDocuments(BlobContainerClient containerClient, List<TestDocument> documents)
        {
            for (int i = 0; i < documents.Count; i++)
            {
                byte[] byteArray = Encoding.ASCII.GetBytes(documents[i].Content);
                MemoryStream stream = new MemoryStream(byteArray);
                containerClient.UploadBlob(documents[i].Name, stream);
            }
        }
        public string GenerateRandomName(string baseName)
        {
            Recording.DisableIdReuse();
            return baseName + Recording.GenerateId();
        }
    }
}
