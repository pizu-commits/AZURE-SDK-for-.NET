// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Network trace. </summary>
    public partial class NetworkTrace
    {
        /// <summary> Initializes a new instance of NetworkTrace. </summary>
        internal NetworkTrace()
        {
        }

        /// <summary> Initializes a new instance of NetworkTrace. </summary>
        /// <param name="path"> Local file path for the captured network trace file. </param>
        /// <param name="status"> Current status of the network trace operation, same as Operation.Status (InProgress/Succeeded/Failed). </param>
        /// <param name="message"> Detailed message of a network trace operation, e.g. error message in case of failure. </param>
        internal NetworkTrace(string path, string status, string message)
        {
            Path = path;
            Status = status;
            Message = message;
        }

        /// <summary> Local file path for the captured network trace file. </summary>
        public string Path { get; }
        /// <summary> Current status of the network trace operation, same as Operation.Status (InProgress/Succeeded/Failed). </summary>
        public string Status { get; }
        /// <summary> Detailed message of a network trace operation, e.g. error message in case of failure. </summary>
        public string Message { get; }
    }
}
