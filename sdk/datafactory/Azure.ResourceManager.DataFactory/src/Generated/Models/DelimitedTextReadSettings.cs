// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Delimited text read settings. </summary>
    public partial class DelimitedTextReadSettings : FormatReadSettings
    {
        /// <summary> Initializes a new instance of DelimitedTextReadSettings. </summary>
        public DelimitedTextReadSettings()
        {
            FormatReadSettingsType = "DelimitedTextReadSettings";
        }

        /// <summary> Initializes a new instance of DelimitedTextReadSettings. </summary>
        /// <param name="formatReadSettingsType"> The read setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="skipLineCount"> Indicates the number of non-empty rows to skip when reading data from input files. Type: integer (or Expression with resultType integer). </param>
        /// <param name="compressionProperties">
        /// Compression settings.
        /// Please note <see cref="CompressionReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="TarGZipReadSettings"/>, <see cref="TarReadSettings"/> and <see cref="ZipDeflateReadSettings"/>.
        /// </param>
        internal DelimitedTextReadSettings(string formatReadSettingsType, IDictionary<string, BinaryData> additionalProperties, BinaryData skipLineCount, CompressionReadSettings compressionProperties) : base(formatReadSettingsType, additionalProperties)
        {
            SkipLineCount = skipLineCount;
            CompressionProperties = compressionProperties;
            FormatReadSettingsType = formatReadSettingsType ?? "DelimitedTextReadSettings";
        }

        /// <summary> Indicates the number of non-empty rows to skip when reading data from input files. Type: integer (or Expression with resultType integer). </summary>
        public BinaryData SkipLineCount { get; set; }
        /// <summary>
        /// Compression settings.
        /// Please note <see cref="CompressionReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="TarGZipReadSettings"/>, <see cref="TarReadSettings"/> and <see cref="ZipDeflateReadSettings"/>.
        /// </summary>
        public CompressionReadSettings CompressionProperties { get; set; }
    }
}
