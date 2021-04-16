// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SparkJobPropertiesConverter))]
    public partial class SparkJobProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("file");
            writer.WriteStringValue(File);
            if (Optional.IsDefined(ClassName))
            {
                writer.WritePropertyName("className");
                writer.WriteStringValue(ClassName);
            }
            if (Optional.IsDefined(Conf))
            {
                writer.WritePropertyName("conf");
                writer.WriteObjectValue(Conf);
            }
            if (Optional.IsCollectionDefined(Args))
            {
                writer.WritePropertyName("args");
                writer.WriteStartArray();
                foreach (var item in Args)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Jars))
            {
                writer.WritePropertyName("jars");
                writer.WriteStartArray();
                foreach (var item in Jars)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files");
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Archives))
            {
                writer.WritePropertyName("archives");
                writer.WriteStartArray();
                foreach (var item in Archives)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("driverMemory");
            writer.WriteStringValue(DriverMemory);
            writer.WritePropertyName("driverCores");
            writer.WriteNumberValue(DriverCores);
            writer.WritePropertyName("executorMemory");
            writer.WriteStringValue(ExecutorMemory);
            writer.WritePropertyName("executorCores");
            writer.WriteNumberValue(ExecutorCores);
            writer.WritePropertyName("numExecutors");
            writer.WriteNumberValue(NumExecutors);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SparkJobProperties DeserializeSparkJobProperties(JsonElement element)
        {
            Optional<string> name = default;
            string file = default;
            Optional<string> className = default;
            Optional<object> conf = default;
            Optional<IList<string>> args = default;
            Optional<IList<string>> jars = default;
            Optional<IList<string>> files = default;
            Optional<IList<string>> archives = default;
            string driverMemory = default;
            int driverCores = default;
            string executorMemory = default;
            int executorCores = default;
            int numExecutors = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("file"))
                {
                    file = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("className"))
                {
                    className = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("conf"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    conf = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("args"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    args = array;
                    continue;
                }
                if (property.NameEquals("jars"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    jars = array;
                    continue;
                }
                if (property.NameEquals("files"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    files = array;
                    continue;
                }
                if (property.NameEquals("archives"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    archives = array;
                    continue;
                }
                if (property.NameEquals("driverMemory"))
                {
                    driverMemory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("driverCores"))
                {
                    driverCores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("executorMemory"))
                {
                    executorMemory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("executorCores"))
                {
                    executorCores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numExecutors"))
                {
                    numExecutors = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SparkJobProperties(name.Value, file, className.Value, conf.Value, Optional.ToList(args), Optional.ToList(jars), Optional.ToList(files), Optional.ToList(archives), driverMemory, driverCores, executorMemory, executorCores, numExecutors, additionalProperties);
        }

        internal partial class SparkJobPropertiesConverter : JsonConverter<SparkJobProperties>
        {
            public override void Write(Utf8JsonWriter writer, SparkJobProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SparkJobProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSparkJobProperties(document.RootElement);
            }
        }
    }
}
