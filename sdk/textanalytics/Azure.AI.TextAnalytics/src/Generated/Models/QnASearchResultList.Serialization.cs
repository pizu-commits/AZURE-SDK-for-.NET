// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    public partial class QnASearchResultList
    {
        internal static QnASearchResultList DeserializeQnASearchResultList(JsonElement element)
        {
            IReadOnlyList<QnASearchResult> answers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("answers"))
                {
                    List<QnASearchResult> array = new List<QnASearchResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QnASearchResult.DeserializeQnASearchResult(item));
                    }
                    answers = array;
                    continue;
                }
            }
            return new QnASearchResultList(answers.ToList<QnASearchResult>());
        }
    }
}
