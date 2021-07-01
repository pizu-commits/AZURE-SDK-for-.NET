// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    /// <summary> Stack frame information. </summary>
    internal partial class StackFrame
    {
        /// <summary> Initializes a new instance of StackFrame. </summary>
        /// <param name="level"> . </param>
        /// <param name="method"> Method name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="method"/> is null. </exception>
        public StackFrame(int level, string method)
        {
            if (method == null)
            {
                throw new ArgumentNullException(nameof(method));
            }

            Level = level;
            Method = method;
        }

        public int Level { get; }
        /// <summary> Method name. </summary>
        public string Method { get; }
        /// <summary> Name of the assembly (dll, jar, etc.) containing this function. </summary>
        public string Assembly { get; set; }
        /// <summary> File name or URL of the method implementation. </summary>
        public string FileName { get; set; }
        /// <summary> Line number of the code implementation. </summary>
        public int? Line { get; set; }
    }
}
