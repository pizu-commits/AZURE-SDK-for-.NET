﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using Azure.Storage.Shared;

namespace Azure.Storage.Blobs
{
    internal class AppendBlobWriteStream : StorageWriteStream
    {
        private readonly AppendBlobClient _appendBlobClient;
        private readonly AppendBlobRequestConditions _conditions;

        public AppendBlobWriteStream(
            AppendBlobClient appendBlobClient,
            long bufferSize,
            long position,
            AppendBlobRequestConditions conditions,
            IProgress<long> progressHandler) : base(
                position,
                bufferSize,
                progressHandler)
        {
            ValidateBufferSize(bufferSize);
            _appendBlobClient = appendBlobClient;
            _conditions = conditions;
        }

        protected override async Task AppendInternal(
            bool async,
            CancellationToken cancellationToken)
        {
            if (_buffer.Length > 0)
            {
                _buffer.Position = 0;

                if (async)
                {
                    await _appendBlobClient.AppendBlockAsync(
                        _buffer,
                        conditions: _conditions,
                        progressHandler: _progressHandler,
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    _appendBlobClient.AppendBlock(
                        _buffer,
                        conditions: _conditions,
                        progressHandler: _progressHandler,
                        cancellationToken: cancellationToken);
                }
            }

            _buffer.Clear();
        }

        protected override async Task FlushInternal(bool async, CancellationToken cancellationToken)
            => await AppendInternal(async, cancellationToken).ConfigureAwait(false);

        protected override void ValidateBufferSize(long bufferSize)
        {
            if (bufferSize < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(bufferSize), "Must be >= 1");
            }

            if (bufferSize > Constants.Blob.Append.MaxAppendBlockBytes)
            {
                throw new ArgumentOutOfRangeException(nameof(bufferSize), "Must <= 4 MB");
            }
        }
    }
}
