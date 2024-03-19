// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Xml;
using Azure.Core;

namespace Azure.ResourceManager.AppService
{
    internal static class ModelSerializationExtensions
    {
        public static object GetObject(this JsonElement element)
        {
            switch (element.ValueKind)
            {
                case JsonValueKind.String:
                    return element.GetString();
                case JsonValueKind.Number:
                    if (element.TryGetInt32(out int intValue))
                    {
                        return intValue;
                    }
                    if (element.TryGetInt64(out long longValue))
                    {
                        return longValue;
                    }
                    return element.GetDouble();
                case JsonValueKind.True:
                    return true;
                case JsonValueKind.False:
                    return false;
                case JsonValueKind.Undefined:
                case JsonValueKind.Null:
                    return null;
                case JsonValueKind.Object:
                    var dictionary = new Dictionary<string, object>();
                    foreach (var jsonProperty in element.EnumerateObject())
                    {
                        dictionary.Add(jsonProperty.Name, jsonProperty.Value.GetObject());
                    }
                    return dictionary;
                case JsonValueKind.Array:
                    var list = new List<object>();
                    foreach (var item in element.EnumerateArray())
                    {
                        list.Add(item.GetObject());
                    }
                    return list.ToArray();
                default:
                    throw new NotSupportedException($"Not supported value kind {element.ValueKind}");
            }
        }

        public static byte[] GetBytesFromBase64(this JsonElement element, string format)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return format switch
            {
                "U" => TypeFormatters.FromBase64UrlString(element.GetRequiredString()),
                "D" => element.GetBytesFromBase64(),
                _ => throw new ArgumentException($"Format is not supported: '{format}'", nameof(format))
            };
        }

        public static DateTimeOffset GetDateTimeOffset(this JsonElement element, string format) => format switch
        {
            "U" when element.ValueKind == JsonValueKind.Number => DateTimeOffset.FromUnixTimeSeconds(element.GetInt64()),
            _ => TypeFormatters.ParseDateTimeOffset(element.GetString(), format)
        };

        public static TimeSpan GetTimeSpan(this JsonElement element, string format) => TypeFormatters.ParseTimeSpan(element.GetString(), format);

        public static char GetChar(this JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.String)
            {
                var text = element.GetString();
                if (text == null || text.Length != 1)
                {
                    throw new NotSupportedException($"Cannot convert \"{text}\" to a char");
                }
                return text[0];
            }
            else
            {
                throw new NotSupportedException($"Cannot convert {element.ValueKind} to a char");
            }
        }

        [Conditional("DEBUG")]
        public static void ThrowNonNullablePropertyIsNull(this JsonProperty property)
        {
            throw new JsonException($"A property '{property.Name}' defined as non-nullable but received as null from the service. This exception only happens in DEBUG builds of the library and would be ignored in the release build");
        }

        public static string GetRequiredString(this JsonElement element)
        {
            var value = element.GetString();
            if (value == null)
            {
                throw new InvalidOperationException($"The requested operation requires an element of type 'String', but the target element has type '{element.ValueKind}'.");
            }
            return value;
        }

        public static void WriteStringValue(this Utf8JsonWriter writer, DateTimeOffset value, string format)
        {
            writer.WriteStringValue(TypeFormatters.ToString(value, format));
        }

        public static void WriteStringValue(this Utf8JsonWriter writer, DateTime value, string format)
        {
            writer.WriteStringValue(TypeFormatters.ToString(value, format));
        }

        public static void WriteStringValue(this Utf8JsonWriter writer, TimeSpan value, string format)
        {
            writer.WriteStringValue(TypeFormatters.ToString(value, format));
        }

        public static void WriteStringValue(this Utf8JsonWriter writer, char value)
        {
            writer.WriteStringValue(value.ToString(CultureInfo.InvariantCulture));
        }

        public static void WriteBase64StringValue(this Utf8JsonWriter writer, byte[] value, string format)
        {
            if (value == null)
            {
                writer.WriteNullValue();
                return;
            }
            switch (format)
            {
                case "U":
                    writer.WriteStringValue(TypeFormatters.ToBase64UrlString(value));
                    break;
                case "D":
                    writer.WriteBase64StringValue(value);
                    break;
                default:
                    throw new ArgumentException($"Format is not supported: '{format}'", nameof(format));
            }
        }

        public static void WriteNumberValue(this Utf8JsonWriter writer, DateTimeOffset value, string format)
        {
            if (format != "U")
            {
                throw new ArgumentOutOfRangeException(nameof(format), "Only 'U' format is supported when writing a DateTimeOffset as a Number.");
            }
            writer.WriteNumberValue(value.ToUnixTimeSeconds());
        }

        public static void WriteObjectValue(this Utf8JsonWriter writer, object value)
        {
            switch (value)
            {
                case null:
                    writer.WriteNullValue();
                    break;
                case IUtf8JsonSerializable serializable:
                    serializable.Write(writer);
                    break;
                case byte[] bytes:
                    writer.WriteBase64StringValue(bytes);
                    break;
                case BinaryData bytes0:
                    writer.WriteBase64StringValue(bytes0);
                    break;
                case JsonElement json:
                    json.WriteTo(writer);
                    break;
                case int i:
                    writer.WriteNumberValue(i);
                    break;
                case decimal d:
                    writer.WriteNumberValue(d);
                    break;
                case double d0:
                    if (double.IsNaN(d0))
                    {
                        writer.WriteStringValue("NaN");
                    }
                    else
                    {
                        writer.WriteNumberValue(d0);
                    }
                    break;
                case float f:
                    writer.WriteNumberValue(f);
                    break;
                case long l:
                    writer.WriteNumberValue(l);
                    break;
                case string s:
                    writer.WriteStringValue(s);
                    break;
                case bool b:
                    writer.WriteBooleanValue(b);
                    break;
                case Guid g:
                    writer.WriteStringValue(g);
                    break;
                case DateTimeOffset dateTimeOffset:
                    writer.WriteStringValue(dateTimeOffset, "O");
                    break;
                case DateTime dateTime:
                    writer.WriteStringValue(dateTime, "O");
                    break;
                case IEnumerable<KeyValuePair<string, object>> enumerable:
                    writer.WriteStartObject();
                    foreach (var pair in enumerable)
                    {
                        writer.WritePropertyName(pair.Key);
                        writer.WriteObjectValue(pair.Value);
                    }
                    writer.WriteEndObject();
                    break;
                case IEnumerable<object> objectEnumerable:
                    writer.WriteStartArray();
                    foreach (var item in objectEnumerable)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                    break;
                case TimeSpan timeSpan:
                    writer.WriteStringValue(timeSpan, "P");
                    break;
                default:
                    throw new NotSupportedException($"Not supported type {value.GetType()}");
            }
        }

        private static class TypeFormatters
        {
            private const string RoundtripZFormat = "yyyy-MM-ddTHH:mm:ss.fffffffZ";
            public const string DefaultNumberFormat = "G";

            public static string ToString(bool value) => value ? "true" : "false";

            public static string ToString(DateTime value, string format) => value.Kind switch
            {
                DateTimeKind.Utc => ToString((DateTimeOffset)value, format),
                _ => throw new NotSupportedException($"DateTime {value} has a Kind of {value.Kind}. Azure SDK requires it to be UTC. You can call DateTime.SpecifyKind to change Kind property value to DateTimeKind.Utc.")
            };

            public static string ToString(DateTimeOffset value, string format) => format switch
            {
                "D" => value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                "U" => value.ToUnixTimeSeconds().ToString(CultureInfo.InvariantCulture),
                "O" => value.ToUniversalTime().ToString(RoundtripZFormat, CultureInfo.InvariantCulture),
                "o" => value.ToUniversalTime().ToString(RoundtripZFormat, CultureInfo.InvariantCulture),
                "R" => value.ToString("r", CultureInfo.InvariantCulture),
                _ => value.ToString(format, CultureInfo.InvariantCulture)
            };

            public static string ToString(TimeSpan value, string format) => format switch
            {
                "P" => XmlConvert.ToString(value),
                _ => value.ToString(format, CultureInfo.InvariantCulture)
            };

            public static string ToString(byte[] value, string format) => format switch
            {
                "U" => ToBase64UrlString(value),
                "D" => Convert.ToBase64String(value),
                _ => throw new ArgumentException($"Format is not supported: '{format}'", nameof(format))
            };

            public static string ToBase64UrlString(byte[] value)
            {
                int numWholeOrPartialInputBlocks = checked(value.Length + 2) / 3;
                int size = checked(numWholeOrPartialInputBlocks * 4);
                char[] output = new char[size];

                int numBase64Chars = Convert.ToBase64CharArray(value, 0, value.Length, output, 0);

                int i = 0;
                for (; i < numBase64Chars; i++)
                {
                    char ch = output[i];
                    if (ch == '+')
                    {
                        output[i] = '-';
                    }
                    else
                    {
                        if (ch == '/')
                        {
                            output[i] = '_';
                        }
                        else
                        {
                            if (ch == '=')
                            {
                                break;
                            }
                        }
                    }
                }

                return new string(output, 0, i);
            }

            public static byte[] FromBase64UrlString(string value)
            {
                int paddingCharsToAdd = (value.Length % 4) switch
                {
                    0 => 0,
                    2 => 2,
                    3 => 1,
                    _ => throw new InvalidOperationException("Malformed input")
                };
                char[] output = new char[(value.Length + paddingCharsToAdd)];
                int i = 0;
                for (; i < value.Length; i++)
                {
                    char ch = value[i];
                    if (ch == '-')
                    {
                        output[i] = '+';
                    }
                    else
                    {
                        if (ch == '_')
                        {
                            output[i] = '/';
                        }
                        else
                        {
                            output[i] = ch;
                        }
                    }
                }

                for (; i < output.Length; i++)
                {
                    output[i] = '=';
                }

                return Convert.FromBase64CharArray(output, 0, output.Length);
            }

            public static DateTimeOffset ParseDateTimeOffset(string value, string format) => format switch
            {
                "U" => DateTimeOffset.FromUnixTimeSeconds(long.Parse(value, CultureInfo.InvariantCulture)),
                _ => DateTimeOffset.Parse(value, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal)
            };

            public static TimeSpan ParseTimeSpan(string value, string format) => format switch
            {
                "P" => XmlConvert.ToTimeSpan(value),
                _ => TimeSpan.ParseExact(value, format, CultureInfo.InvariantCulture)
            };
        }
    }
}
