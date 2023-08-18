// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering
{
    public partial class KnowledgeBaseAnswerDialog
    {
        internal static KnowledgeBaseAnswerDialog DeserializeKnowledgeBaseAnswerDialog(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> isContextOnly = default;
            Core.Optional<IReadOnlyList<KnowledgeBaseAnswerPrompt>> prompts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isContextOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isContextOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("prompts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KnowledgeBaseAnswerPrompt> array = new List<KnowledgeBaseAnswerPrompt>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KnowledgeBaseAnswerPrompt.DeserializeKnowledgeBaseAnswerPrompt(item));
                    }
                    prompts = array;
                    continue;
                }
            }
            return new KnowledgeBaseAnswerDialog(Core.Optional.ToNullable(isContextOnly), Core.Optional.ToList(prompts));
        }
    }
}
