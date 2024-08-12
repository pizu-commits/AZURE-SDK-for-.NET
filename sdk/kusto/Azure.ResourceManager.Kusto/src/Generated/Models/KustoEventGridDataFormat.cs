// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The data format of the message. Optionally the data format can be added to each message. </summary>
    public readonly partial struct KustoEventGridDataFormat : IEquatable<KustoEventGridDataFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KustoEventGridDataFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KustoEventGridDataFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MultiJsonValue = "MULTIJSON";
        private const string JsonValue = "JSON";
        private const string CsvValue = "CSV";
        private const string TsvValue = "TSV";
        private const string ScsvValue = "SCSV";
        private const string SohsvValue = "SOHSV";
        private const string PsvValue = "PSV";
        private const string TxtValue = "TXT";
        private const string RawValue = "RAW";
        private const string SingleJsonValue = "SINGLEJSON";
        private const string AvroValue = "AVRO";
        private const string TsveValue = "TSVE";
        private const string ParquetValue = "PARQUET";
        private const string OrcValue = "ORC";
        private const string ApacheAvroValue = "APACHEAVRO";
        private const string W3CLogFileValue = "W3CLOGFILE";

        /// <summary> MULTIJSON. </summary>
        public static KustoEventGridDataFormat MultiJson { get; } = new KustoEventGridDataFormat(MultiJsonValue);
        /// <summary> JSON. </summary>
        public static KustoEventGridDataFormat Json { get; } = new KustoEventGridDataFormat(JsonValue);
        /// <summary> CSV. </summary>
        public static KustoEventGridDataFormat Csv { get; } = new KustoEventGridDataFormat(CsvValue);
        /// <summary> TSV. </summary>
        public static KustoEventGridDataFormat Tsv { get; } = new KustoEventGridDataFormat(TsvValue);
        /// <summary> SCSV. </summary>
        public static KustoEventGridDataFormat Scsv { get; } = new KustoEventGridDataFormat(ScsvValue);
        /// <summary> SOHSV. </summary>
        public static KustoEventGridDataFormat Sohsv { get; } = new KustoEventGridDataFormat(SohsvValue);
        /// <summary> PSV. </summary>
        public static KustoEventGridDataFormat Psv { get; } = new KustoEventGridDataFormat(PsvValue);
        /// <summary> TXT. </summary>
        public static KustoEventGridDataFormat Txt { get; } = new KustoEventGridDataFormat(TxtValue);
        /// <summary> RAW. </summary>
        public static KustoEventGridDataFormat Raw { get; } = new KustoEventGridDataFormat(RawValue);
        /// <summary> SINGLEJSON. </summary>
        public static KustoEventGridDataFormat SingleJson { get; } = new KustoEventGridDataFormat(SingleJsonValue);
        /// <summary> AVRO. </summary>
        public static KustoEventGridDataFormat Avro { get; } = new KustoEventGridDataFormat(AvroValue);
        /// <summary> TSVE. </summary>
        public static KustoEventGridDataFormat Tsve { get; } = new KustoEventGridDataFormat(TsveValue);
        /// <summary> PARQUET. </summary>
        public static KustoEventGridDataFormat Parquet { get; } = new KustoEventGridDataFormat(ParquetValue);
        /// <summary> ORC. </summary>
        public static KustoEventGridDataFormat Orc { get; } = new KustoEventGridDataFormat(OrcValue);
        /// <summary> APACHEAVRO. </summary>
        public static KustoEventGridDataFormat ApacheAvro { get; } = new KustoEventGridDataFormat(ApacheAvroValue);
        /// <summary> W3CLOGFILE. </summary>
        public static KustoEventGridDataFormat W3CLogFile { get; } = new KustoEventGridDataFormat(W3CLogFileValue);
        /// <summary> Determines if two <see cref="KustoEventGridDataFormat"/> values are the same. </summary>
        public static bool operator ==(KustoEventGridDataFormat left, KustoEventGridDataFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KustoEventGridDataFormat"/> values are not the same. </summary>
        public static bool operator !=(KustoEventGridDataFormat left, KustoEventGridDataFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KustoEventGridDataFormat"/>. </summary>
        public static implicit operator KustoEventGridDataFormat(string value) => new KustoEventGridDataFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KustoEventGridDataFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KustoEventGridDataFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
