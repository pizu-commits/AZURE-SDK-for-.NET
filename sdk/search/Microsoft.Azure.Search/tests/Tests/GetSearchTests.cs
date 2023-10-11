// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Azure.Search.Tests
{
    using Microsoft.Azure.Search.Models;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
    using Microsoft.Spatial;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Threading;
    using Xunit;
    using Index = Models.Index;

    public class GetSearchTests : SearchTests
    {
        [Fact]
        public void CanSearchStaticallyTypedDocuments()
        {
            Run(TestCanSearchStaticallyTypedDocuments);
        }

        [Fact]
        public void CanSearchDynamicDocuments()
        {
            Run(TestCanSearchDynamicDocuments);
        }

        [Fact]
        public void SearchThrowsWhenRequestIsMalformed()
        {
            Run(TestSearchThrowsWhenRequestIsMalformed);
        }

        [Fact]
        public void DefaultSearchModeIsAny()
        {
            Run(TestDefaultSearchModeIsAny);
        }

        [Fact]
        public void CanSearchWithSearchModeAll()
        {
            Run(TestCanSearchWithSearchModeAll);
        }

        [Fact]
        public void CanGetResultCountInSearch()
        {
            Run(TestCanGetResultCountInSearch);
        }

        [Fact]
        public void CanFilter()
        {
            Run(TestCanFilter);
        }

        [Fact]
        public void CanUseHitHighlighting()
        {
            Run(TestCanUseHitHighlighting);
        }

        [Fact]
        public void OrderByProgressivelyBreaksTies()
        {
            Run(TestOrderByProgressivelyBreaksTies);
        }

        [Fact]
        public void SearchWithoutOrderBySortsByScore()
        {
            Run(TestSearchWithoutOrderBySortsByScore);
        }

        [Fact]
        public void CanSearchWithSelectedFields()
        {
            Run(TestCanSearchWithSelectedFields);
        }

        [Fact]
        public void CanSearchWithLuceneSyntax()
        {
            Run(TestCanSearchWithLuceneSyntax);
        }

        [Fact]
        public void CanSearchWithRegex()
        {
            Run(TestCanSearchWithRegex);
        }

        [Fact]
        public void CanSearchWithSynonyms()
        {
            Run(TestCanSearchWithSynonyms);
        }

        [Fact]
        public void CanSearchWithSpecialCharsInRegex()
        {
            Run(TestCanSearchWithEscapedSpecialCharsInRegex);
        }

        [Fact]
        public void SearchThrowsWhenSpecialCharInRegexIsUnescaped()
        {
            Run(TestSearchThrowsWhenSpecialCharInRegexIsUnescaped);
        }

        [Fact]
        public void CanUseTopAndSkipForClientSidePaging()
        {
            Run(TestCanUseTopAndSkipForClientSidePaging);
        }

        [Fact]
        public void SearchWithScoringProfileBoostsScore()
        {
            Run(TestSearchWithScoringProfileBoostsScore);
        }

        [Fact]
        public void CanSearchWithRangeFacets()
        {
            Run(TestCanSearchWithRangeFacets);
        }

        [Fact]
        public void CanSearchWithValueFacets()
        {
            Run(TestCanSearchWithValueFacets);
        }

        [Fact]
        [Trait(TestTraits.AcceptanceType, TestTraits.LiveBVT)]
        public void CanContinueSearchForStaticallyTypedDocuments()
        {
            Run(TestCanContinueSearchForStaticallyTypedDocuments);
        }

        [Fact]
        [Trait(TestTraits.AcceptanceType, TestTraits.LiveBVT)]
        public void CanContinueSearchForDynamicDocuments()
        {
            Run(TestCanContinueSearchForDynamicDocuments);
        }

        [Fact]
        [Trait(TestTraits.AcceptanceType, TestTraits.LiveBVT)]
        public void CanContinueSearchWithoutTop()
        {
            Run(TestCanContinueSearchWithoutTop);
        }

        [Fact]
        [Trait(TestTraits.AcceptanceType, TestTraits.LiveBVT)]
        public void CanSearchWithMinimumCoverage()
        {
            Run(TestCanSearchWithMinimumCoverage);
        }

        [Fact]
        public void CanSearchWithDateTimeInStaticModel()
        {
            Run(TestCanSearchWithDateTimeInStaticModel);
        }

        [Fact]
        public void CanRoundTripNonNullableValueTypes()
        {
            Run(TestCanRoundTripNonNullableValueTypes);
        }

        [Fact]
        public void NullCannotBeConvertedToValueType()
        {
            Run(TestNullCannotBeConvertedToValueType);
        }

        [Fact]
        public void CanFilterNonNullableType()
        {
            Run(TestCanFilterNonNullableType);
        }

        [Fact]
        public void CanSearchWithCustomContractResolver()
        {
            Run(TestCanSearchWithCustomContractResolver);
        }

        [Fact]
        public void CanSearchWithCustomConverterViaSettings()
        {
            Run(TestCanSearchWithCustomConverterViaSettings);
        }

        [Fact]
        public void CanSearchWithCustomConverter()
        {
            Run(TestCanSearchWithCustomConverter);
        }

        protected override SearchIndexClient GetClient()
        {
            SearchIndexClient client = base.GetClient();
            client.UseHttpGetForQueries = true;
            return client;
        }

        protected override SearchIndexClient GetClientForQuery()
        {
            SearchIndexClient client = base.GetClientForQuery();
            client.UseHttpGetForQueries = true;
            return client;
        }

        [Fact]
        public void MyTest()
        {
            var serviceName = Environment.GetEnvironmentVariable("SEARCH_SERVICE_NAME");
            var apiKey = Environment.GetEnvironmentVariable("SEARCH_ADMIN_API_KEY");
            //-----------Create Index---------------------
            Index index = new()
            {
                Name = "testindex",
                Fields = new[]
                {
                    Field.New("Id", DataType.String, isKey: true, isFilterable: true, isSortable: true, isFacetable: true),
                    Field.New("Name", DataType.String, isSearchable: true, isFilterable: true, isSortable: true, isFacetable: false),
                    Field.New("Location", DataType.GeographyPoint, isFilterable: true, isSortable: true),
                },
            };
            SearchServiceClient searchClient = new SearchServiceClient(serviceName, new SearchCredentials(apiKey));
            searchClient.Indexes.Create(index);

            //-----------Upload data---------------------
            SearchIndexClient client = new SearchIndexClient(serviceName, index.Name, new SearchCredentials(apiKey));

            var batch = IndexBatch.New(new[]
               {
                    IndexAction.Upload(
                        new Document()
                        {
                            ["Id"] = "1",
                            ["Name"] = "Rainier",
                            ["Location"] = GeographyPoint.Create(-75.5646879643, 39.7093928328)
                        }),
                });

            client.Documents.Index(batch);
            Thread.Sleep(TimeSpan.FromSeconds(2));

            //-----------Search Data---------------------
            DocumentSearchResult<Document> response = client.Documents.Search<Document>("Rainier");
            foreach (SearchResult<Document> result in response.Results)
            {
                var document = result.Document;
                dynamic location = document["Location"];
                Console.WriteLine(location);
            }
        }
    }
}
