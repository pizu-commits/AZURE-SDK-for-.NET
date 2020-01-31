﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.Testing;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Azure.AI.TextAnalytics.Samples
{
    [LiveOnly]
    public partial class TextAnalyticsSamples
    {
        [Test]
        public void AnalyzeSentimentBatch()
        {
            string endpoint = Environment.GetEnvironmentVariable("TEXT_ANALYTICS_ENDPOINT");
            string apiKey = Environment.GetEnvironmentVariable("TEXT_ANALYTICS_API_KEY");

            // Instantiate a client that will be used to call the service.
            var client = new TextAnalyticsClient(new Uri(endpoint), new TextAnalyticsApiKeyCredential(apiKey));

            #region Snippet:TextAnalyticsSample2AnalyzeSentimentBatch
            var inputs = new List<TextDocumentInput>
            {
                new TextDocumentInput("1", "That was the best day of my life!")
                {
                     Language = "en",
                },
                new TextDocumentInput("2", "This food is very bad. Everyone who ate with us got sick.")
                {
                     Language = "en",
                },
                new TextDocumentInput("3", "I'm not sure how I feel about this product.")
                {
                     Language = "en",
                },
                new TextDocumentInput("4", "Pike Place Market is my favorite Seattle attraction.  We had so much fun there.")
                {
                     Language = "en",
                }
            };

            AnalyzeSentimentResultCollection results = client.AnalyzeSentiment(inputs, new TextAnalyticsRequestOptions { IncludeStatistics = true });
            #endregion

            int i = 0;
            Debug.WriteLine($"Results of Azure Text Analytics \"Sentiment Analysis\" Model, version: \"{results.ModelVersion}\"");
            Debug.WriteLine("");

            foreach (AnalyzeSentimentResult result in results)
            {
                TextDocumentInput document = inputs[i++];

                Debug.WriteLine($"On document (Id={document.Id}, Language=\"{document.Language}\", Text=\"{document.Text}\"):");

                if (result.HasError)
                {
                    Debug.WriteLine($"    Document error: {result.Error.ErrorCode}.");
                    Debug.WriteLine($"    Message: {result.Error.Message}.");
                }
                else
                {
                    Debug.WriteLine($"Document sentiment is {result.DocumentSentiment.Sentiment}, with scores: ");
                    Debug.WriteLine($"    Positive score: {result.DocumentSentiment.SentimentScores.Positive:0.00}.");
                    Debug.WriteLine($"    Neutral score: {result.DocumentSentiment.SentimentScores.Neutral:0.00}.");
                    Debug.WriteLine($"    Negative score: {result.DocumentSentiment.SentimentScores.Negative:0.00}.");

                    Debug.WriteLine($"    Sentence sentiment results:");

                    foreach (TextSentiment sentenceSentiment in result.DocumentSentiment.Sentences)
                    {
                        Debug.WriteLine($"    On sentence \"{document.Text.Substring(sentenceSentiment.Offset, sentenceSentiment.Length)}\"");

                        Debug.WriteLine($"    Sentiment is {sentenceSentiment.Sentiment}, with scores: ");
                        Debug.WriteLine($"        Positive score: {sentenceSentiment.SentimentScores.Positive:0.00}.");
                        Debug.WriteLine($"        Neutral score: {sentenceSentiment.SentimentScores.Neutral:0.00}.");
                        Debug.WriteLine($"        Negative score: {sentenceSentiment.SentimentScores.Negative:0.00}.");
                    }

                    Debug.WriteLine($"    Document statistics:");
                    Debug.WriteLine($"        Character count: {result.Statistics.CharacterCount}");
                    Debug.WriteLine($"        Transaction count: {result.Statistics.TransactionCount}");
                    Debug.WriteLine("");
                }
            }

            Debug.WriteLine($"Batch operation statistics:");
            Debug.WriteLine($"    Document count: {results.Statistics.DocumentCount}");
            Debug.WriteLine($"    Valid document count: {results.Statistics.ValidDocumentCount}");
            Debug.WriteLine($"    Invalid document count: {results.Statistics.InvalidDocumentCount}");
            Debug.WriteLine($"    Transaction count: {results.Statistics.TransactionCount}");
            Debug.WriteLine("");
        }
    }
}
