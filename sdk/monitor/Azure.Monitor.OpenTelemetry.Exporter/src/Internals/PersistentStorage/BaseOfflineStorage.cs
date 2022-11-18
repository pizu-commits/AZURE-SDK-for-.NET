// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using OpenTelemetry.Extensions.PersistentStorage;
using System.Timers;

namespace Azure.Monitor.OpenTelemetry.Exporter.Internals.PersistentStorage
{
    internal abstract class BaseOfflineStorage<T> : IDisposable
    {
        protected readonly FileBlobProvider fileBlobProvider;

        private readonly Timer _transmitFromStorageTimer;

        protected BaseOfflineStorage(FileBlobProvider fileBlobProvider)
        {
            this.fileBlobProvider = fileBlobProvider;
            _transmitFromStorageTimer = new Timer(120000);
            _transmitFromStorageTimer.Elapsed += TransmitFromStorage;
            _transmitFromStorageTimer.AutoReset = true;
            _transmitFromStorageTimer.Enabled = true;
        }

        /// <summary>
        /// Gets byte encoded request data saved on file and converts that in to
        /// request object of type T that can be passed in to
        /// export client for transmitting data to backend.
        /// </summary>
        /// <param name="data">byte encoded request data.</param>
        /// <returns>
        /// Returns a request object that can be passed in to the export client
        /// for transmitting data to backend.
        /// </returns>
        protected abstract T ConvertFileContentToExportRequest(byte[] data);

        /// <summary>
        /// Gets request object of type T and converts it in to
        /// byte array that will be saved on file.
        /// </summary>
        /// <param name="request">request object of type T.</param>
        /// <returns>Request content converted to byte array.</returns>
        protected abstract byte[] GetFileContent(T request);

        /// <summary>
        /// Exports telemetry stored offline to backend.
        /// </summary>
        /// <param name="request">request object</param>
        /// <param name="success">indicates whether call succeeded or failed.</param>
        /// <param name="retryAfterPeriod">Period to extend lease of blob in case of failure.</param>
        protected abstract void Export(T request, out bool success, out int retryAfterPeriod);

        protected void SaveTelemetryOffline(T request, int retryAfterPeriod)
        {
            var data = this.GetFileContent(request);
            this.fileBlobProvider.TryCreateBlob(data, retryAfterPeriod, out _);
        }

        protected void SaveTelemetryOffline(byte[] data, int retryAfterPeriod)
        {
            this.fileBlobProvider.TryCreateBlob(data, retryAfterPeriod, out _);
        }

        private void TransmitFromStorage(object sender, ElapsedEventArgs e)
        {
            while (true)
            {
                if (fileBlobProvider.TryGetBlob(out var blob) && blob.TryLease(1000))
                {
                    if (blob.TryRead(out var data))
                    {
                        var request = ConvertFileContentToExportRequest(data);

                        Export(request, out var success, out var retryAfterPeriod);

                        if (!success && retryAfterPeriod > 0)
                        {
                            blob.TryLease(retryAfterPeriod);
                        }
                        else
                        {
                            blob.TryDelete();
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public void Dispose()
        {
            _transmitFromStorageTimer.Dispose();
        }
    }
}
