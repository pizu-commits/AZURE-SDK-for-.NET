// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceRecommendation : IUtf8JsonSerializable, IJsonModel<AppServiceRecommendation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceRecommendation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceRecommendation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceRecommendation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceRecommendation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(RecommendationId))
            {
                writer.WritePropertyName("recommendationId"u8);
                writer.WriteStringValue(RecommendationId.Value);
            }
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(ResourceScope))
            {
                writer.WritePropertyName("resourceScope"u8);
                writer.WriteStringValue(ResourceScope.Value.ToString());
            }
            if (Optional.IsDefined(RuleName))
            {
                writer.WritePropertyName("ruleName"u8);
                writer.WriteStringValue(RuleName);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level.Value.ToSerialString());
            }
            if (Optional.IsDefined(Channels))
            {
                writer.WritePropertyName("channels"u8);
                writer.WriteStringValue(Channels.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(CategoryTags))
            {
                writer.WritePropertyName("categoryTags"u8);
                writer.WriteStartArray();
                foreach (var item in CategoryTags)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ActionName))
            {
                writer.WritePropertyName("actionName"u8);
                writer.WriteStringValue(ActionName);
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteNumberValue(Enabled.Value);
            }
            if (Optional.IsCollectionDefined(States))
            {
                writer.WritePropertyName("states"u8);
                writer.WriteStartArray();
                foreach (var item in States)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(NextNotificationOn))
            {
                writer.WritePropertyName("nextNotificationTime"u8);
                writer.WriteStringValue(NextNotificationOn.Value, "O");
            }
            if (Optional.IsDefined(NotificationExpirationOn))
            {
                writer.WritePropertyName("notificationExpirationTime"u8);
                writer.WriteStringValue(NotificationExpirationOn.Value, "O");
            }
            if (Optional.IsDefined(NotifiedOn))
            {
                writer.WritePropertyName("notifiedTime"u8);
                writer.WriteStringValue(NotifiedOn.Value, "O");
            }
            if (Optional.IsDefined(Score))
            {
                writer.WritePropertyName("score"u8);
                writer.WriteNumberValue(Score.Value);
            }
            if (Optional.IsDefined(IsDynamic))
            {
                writer.WritePropertyName("isDynamic"u8);
                writer.WriteBooleanValue(IsDynamic.Value);
            }
            if (Optional.IsDefined(ExtensionName))
            {
                writer.WritePropertyName("extensionName"u8);
                writer.WriteStringValue(ExtensionName);
            }
            if (Optional.IsDefined(BladeName))
            {
                writer.WritePropertyName("bladeName"u8);
                writer.WriteStringValue(BladeName);
            }
            if (Optional.IsDefined(ForwardLink))
            {
                writer.WritePropertyName("forwardLink"u8);
                writer.WriteStringValue(ForwardLink);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        AppServiceRecommendation IJsonModel<AppServiceRecommendation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceRecommendation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceRecommendation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceRecommendation(document.RootElement, options);
        }

        internal static AppServiceRecommendation DeserializeAppServiceRecommendation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<Guid> recommendationId = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<ResourceScopeType> resourceScope = default;
            Optional<string> ruleName = default;
            Optional<string> displayName = default;
            Optional<string> message = default;
            Optional<NotificationLevel> level = default;
            Optional<RecommendationChannel> channels = default;
            Optional<IReadOnlyList<string>> categoryTags = default;
            Optional<string> actionName = default;
            Optional<int> enabled = default;
            Optional<IList<string>> states = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<DateTimeOffset> nextNotificationTime = default;
            Optional<DateTimeOffset> notificationExpirationTime = default;
            Optional<DateTimeOffset> notifiedTime = default;
            Optional<double> score = default;
            Optional<bool> isDynamic = default;
            Optional<string> extensionName = default;
            Optional<string> bladeName = default;
            Optional<string> forwardLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("recommendationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recommendationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("resourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceScope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceScope = new ResourceScopeType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ruleName"u8))
                        {
                            ruleName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("message"u8))
                        {
                            message = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("level"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            level = property0.Value.GetString().ToNotificationLevel();
                            continue;
                        }
                        if (property0.NameEquals("channels"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            channels = property0.Value.GetString().ToRecommendationChannel();
                            continue;
                        }
                        if (property0.NameEquals("categoryTags"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            categoryTags = array;
                            continue;
                        }
                        if (property0.NameEquals("actionName"u8))
                        {
                            actionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("states"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            states = array;
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("nextNotificationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nextNotificationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("notificationExpirationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            notificationExpirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("notifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            notifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("score"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            score = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("isDynamic"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDynamic = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("extensionName"u8))
                        {
                            extensionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bladeName"u8))
                        {
                            bladeName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("forwardLink"u8))
                        {
                            forwardLink = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceRecommendation(id, name, type, systemData.Value, Optional.ToNullable(creationTime), Optional.ToNullable(recommendationId), resourceId.Value, Optional.ToNullable(resourceScope), ruleName.Value, displayName.Value, message.Value, Optional.ToNullable(level), Optional.ToNullable(channels), Optional.ToList(categoryTags), actionName.Value, Optional.ToNullable(enabled), Optional.ToList(states), Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(nextNotificationTime), Optional.ToNullable(notificationExpirationTime), Optional.ToNullable(notifiedTime), Optional.ToNullable(score), Optional.ToNullable(isDynamic), extensionName.Value, bladeName.Value, forwardLink.Value, kind.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                builder.AppendLine($" '{Kind}'");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(CreatedOn))
            {
                builder.Append("    creationTime:");
                var formattedDateTimeString = TypeFormatters.ToString(CreatedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(RecommendationId))
            {
                builder.Append("    recommendationId:");
                builder.AppendLine($" '{RecommendationId.Value.ToString()}'");
            }

            if (Optional.IsDefined(ResourceId))
            {
                builder.Append("    resourceId:");
                builder.AppendLine($" '{ResourceId.ToString()}'");
            }

            if (Optional.IsDefined(ResourceScope))
            {
                builder.Append("    resourceScope:");
                builder.AppendLine($" '{ResourceScope.ToString()}'");
            }

            if (Optional.IsDefined(RuleName))
            {
                builder.Append("    ruleName:");
                builder.AppendLine($" '{RuleName}'");
            }

            if (Optional.IsDefined(DisplayName))
            {
                builder.Append("    displayName:");
                builder.AppendLine($" '{DisplayName}'");
            }

            if (Optional.IsDefined(Message))
            {
                builder.Append("    message:");
                builder.AppendLine($" '{Message}'");
            }

            if (Optional.IsDefined(Level))
            {
                builder.Append("    level:");
                builder.AppendLine($" '{Level.ToString()}'");
            }

            if (Optional.IsDefined(Channels))
            {
                builder.Append("    channels:");
                builder.AppendLine($" '{Channels.ToString()}'");
            }

            if (Optional.IsCollectionDefined(CategoryTags))
            {
                if (CategoryTags.Any())
                {
                    builder.Append("    categoryTags:");
                    builder.AppendLine(" [");
                    foreach (var item in CategoryTags)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"      '{item}'");
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsDefined(ActionName))
            {
                builder.Append("    actionName:");
                builder.AppendLine($" '{ActionName}'");
            }

            if (Optional.IsDefined(Enabled))
            {
                builder.Append("    enabled:");
                builder.AppendLine($" {Enabled.Value}");
            }

            if (Optional.IsCollectionDefined(States))
            {
                if (States.Any())
                {
                    builder.Append("    states:");
                    builder.AppendLine(" [");
                    foreach (var item in States)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"      '{item}'");
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsDefined(StartOn))
            {
                builder.Append("    startTime:");
                var formattedDateTimeString = TypeFormatters.ToString(StartOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(EndOn))
            {
                builder.Append("    endTime:");
                var formattedDateTimeString = TypeFormatters.ToString(EndOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(NextNotificationOn))
            {
                builder.Append("    nextNotificationTime:");
                var formattedDateTimeString = TypeFormatters.ToString(NextNotificationOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(NotificationExpirationOn))
            {
                builder.Append("    notificationExpirationTime:");
                var formattedDateTimeString = TypeFormatters.ToString(NotificationExpirationOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(NotifiedOn))
            {
                builder.Append("    notifiedTime:");
                var formattedDateTimeString = TypeFormatters.ToString(NotifiedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(Score))
            {
                builder.Append("    score:");
                builder.AppendLine($" '{Score.Value.ToString()}'");
            }

            if (Optional.IsDefined(IsDynamic))
            {
                builder.Append("    isDynamic:");
                var boolValue = IsDynamic.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(ExtensionName))
            {
                builder.Append("    extensionName:");
                builder.AppendLine($" '{ExtensionName}'");
            }

            if (Optional.IsDefined(BladeName))
            {
                builder.Append("    bladeName:");
                builder.AppendLine($" '{BladeName}'");
            }

            if (Optional.IsDefined(ForwardLink))
            {
                builder.Append("    forwardLink:");
                builder.AppendLine($" '{ForwardLink}'");
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<AppServiceRecommendation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceRecommendation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceRecommendation)} does not support '{options.Format}' format.");
            }
        }

        AppServiceRecommendation IPersistableModel<AppServiceRecommendation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceRecommendation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceRecommendation(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(AppServiceRecommendation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceRecommendation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
