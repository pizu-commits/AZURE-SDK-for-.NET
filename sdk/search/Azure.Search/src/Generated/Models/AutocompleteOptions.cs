// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Search.Models;

namespace Azure.Search
{
    /// <summary> Parameters for fuzzy matching, and other autocomplete query behaviors. </summary>
    public partial class AutocompleteOptions
    {
        /// <summary> Initializes a new instance of AutocompleteOptions. </summary>
        public AutocompleteOptions()
        {
        }

        /// <summary> Initializes a new instance of AutocompleteOptions. </summary>
        /// <param name="searchText"> The search text on which to base autocomplete results. </param>
        /// <param name="mode"> Specifies the mode for Autocomplete. The default is &apos;oneTerm&apos;. Use &apos;twoTerms&apos; to get shingles and &apos;oneTermWithContext&apos; to use the current context while producing auto-completed terms. </param>
        /// <param name="filter"> An OData expression that filters the documents used to produce completed terms for the Autocomplete result. </param>
        /// <param name="useFuzzyMatching"> A value indicating whether to use fuzzy matching for the autocomplete query. Default is false. When set to true, the query will autocomplete terms even if there&apos;s a substituted or missing character in the search text. While this provides a better experience in some scenarios, it comes at a performance cost as fuzzy autocomplete queries are slower and consume more resources. </param>
        /// <param name="highlightPostTag"> A string tag that is appended to hit highlights. Must be set with highlightPreTag. If omitted, hit highlighting is disabled. </param>
        /// <param name="highlightPreTag"> A string tag that is prepended to hit highlights. Must be set with highlightPostTag. If omitted, hit highlighting is disabled. </param>
        /// <param name="minimumCoverage"> A number between 0 and 100 indicating the percentage of the index that must be covered by an autocomplete query in order for the query to be reported as a success. This parameter can be useful for ensuring search availability even for services with only one replica. The default is 80. </param>
        /// <param name="searchFieldsRaw"> The comma-separated list of field names to consider when querying for auto-completed terms. Target fields must be included in the specified suggester. </param>
        /// <param name="suggesterName"> The name of the suggester as specified in the suggesters collection that&apos;s part of the index definition. </param>
        /// <param name="size"> The number of auto-completed terms to retrieve. This must be a value between 1 and 100. The default is 5. </param>
        internal AutocompleteOptions(string searchText, AutocompleteMode? mode, string filter, bool? useFuzzyMatching, string highlightPostTag, string highlightPreTag, double? minimumCoverage, string searchFieldsRaw, string suggesterName, int? size)
        {
            SearchText = searchText;
            Mode = mode;
            Filter = filter;
            UseFuzzyMatching = useFuzzyMatching;
            HighlightPostTag = highlightPostTag;
            HighlightPreTag = highlightPreTag;
            MinimumCoverage = minimumCoverage;
            SearchFieldsRaw = searchFieldsRaw;
            SuggesterName = suggesterName;
            Size = size;
        }

        /// <summary> A value indicating whether to use fuzzy matching for the autocomplete query. Default is false. When set to true, the query will autocomplete terms even if there&apos;s a substituted or missing character in the search text. While this provides a better experience in some scenarios, it comes at a performance cost as fuzzy autocomplete queries are slower and consume more resources. </summary>
        public bool? UseFuzzyMatching { get; set; }
        /// <summary> A string tag that is appended to hit highlights. Must be set with highlightPreTag. If omitted, hit highlighting is disabled. </summary>
        public string HighlightPostTag { get; set; }
        /// <summary> A string tag that is prepended to hit highlights. Must be set with highlightPostTag. If omitted, hit highlighting is disabled. </summary>
        public string HighlightPreTag { get; set; }
        /// <summary> A number between 0 and 100 indicating the percentage of the index that must be covered by an autocomplete query in order for the query to be reported as a success. This parameter can be useful for ensuring search availability even for services with only one replica. The default is 80. </summary>
        public double? MinimumCoverage { get; set; }
    }
}
