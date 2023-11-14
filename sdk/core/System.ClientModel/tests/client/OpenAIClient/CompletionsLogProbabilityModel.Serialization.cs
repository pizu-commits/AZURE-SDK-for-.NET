// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace OpenAI;

public partial class CompletionsLogProbabilityModel
{
    internal static CompletionsLogProbabilityModel DeserializeCompletionsLogProbabilityModel(JsonElement element)
    {
        if (element.ValueKind == JsonValueKind.Null)
        {
            return null;
        }
        IReadOnlyList<string> tokens = default;
        IReadOnlyList<float?> tokenLogprobs = default;
        IReadOnlyList<IDictionary<string, float?>> topLogprobs = default;
        IReadOnlyList<int> textOffset = default;
        foreach (var property in element.EnumerateObject())
        {
            if (property.NameEquals("tokens"u8))
            {
                List<string> array = new List<string>();
                foreach (var item in property.Value.EnumerateArray())
                {
                    array.Add(item.GetString());
                }
                tokens = array;
                continue;
            }
            if (property.NameEquals("token_logprobs"u8))
            {
                List<float?> array = new List<float?>();
                foreach (var item in property.Value.EnumerateArray())
                {
                    if (item.ValueKind == JsonValueKind.Null)
                    {
                        array.Add(null);
                    }
                    else
                    {
                        array.Add(item.GetSingle());
                    }
                }
                tokenLogprobs = array;
                continue;
            }
            if (property.NameEquals("top_logprobs"u8))
            {
                List<IDictionary<string, float?>> array = new List<IDictionary<string, float?>>();
                foreach (var item in property.Value.EnumerateArray())
                {
                    if (item.ValueKind == JsonValueKind.Null)
                    {
                        array.Add(null);
                    }
                    else
                    {
                        Dictionary<string, float?> dictionary = new Dictionary<string, float?>();
                        foreach (var property0 in item.EnumerateObject())
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                dictionary.Add(property0.Name, null);
                            }
                            else
                            {
                                dictionary.Add(property0.Name, property0.Value.GetSingle());
                            }
                        }
                        array.Add(dictionary);
                    }
                }
                topLogprobs = array;
                continue;
            }
            if (property.NameEquals("text_offset"u8))
            {
                List<int> array = new List<int>();
                foreach (var item in property.Value.EnumerateArray())
                {
                    array.Add(item.GetInt32());
                }
                textOffset = array;
                continue;
            }
        }
        return new CompletionsLogProbabilityModel(tokens, tokenLogprobs, topLogprobs, textOffset);
    }

    /// <summary> Deserializes the model from a raw response. </summary>
    /// <param name="response"> The response to deserialize the model from. </param>
    internal static CompletionsLogProbabilityModel FromResponse(PipelineResponse response)
    {
        using var document = JsonDocument.Parse(response.Content);
        return DeserializeCompletionsLogProbabilityModel(document.RootElement);
    }
}
