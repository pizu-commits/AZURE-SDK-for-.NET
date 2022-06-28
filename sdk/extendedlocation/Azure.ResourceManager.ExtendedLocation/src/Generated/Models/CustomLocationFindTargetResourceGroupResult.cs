// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ExtendedLocation.Models
{
    /// <summary> The Find Target Resource Group operation response. </summary>
    public partial class CustomLocationFindTargetResourceGroupResult
    {
        /// <summary> Initializes a new instance of CustomLocationFindTargetResourceGroupResult. </summary>
        internal CustomLocationFindTargetResourceGroupResult()
        {
        }

        /// <summary> Initializes a new instance of CustomLocationFindTargetResourceGroupResult. </summary>
        /// <param name="matchedResourceSyncRule"> The matching resource sync rule is the particular resource sync rule that matched the match expressions and labels and had lowest priority. This is the rule responsible for mapping the target resource to the target resource group. </param>
        /// <param name="targetResourceGroup"> The target resource group of matching resource sync rule. The labels from the request will be used to find out matching resource sync rule against the selector property of the resource sync rule. The one with highest priority will be returned if there are multiple matching rules. </param>
        internal CustomLocationFindTargetResourceGroupResult(string matchedResourceSyncRule, string targetResourceGroup)
        {
            MatchedResourceSyncRule = matchedResourceSyncRule;
            TargetResourceGroup = targetResourceGroup;
        }

        /// <summary> The matching resource sync rule is the particular resource sync rule that matched the match expressions and labels and had lowest priority. This is the rule responsible for mapping the target resource to the target resource group. </summary>
        public string MatchedResourceSyncRule { get; }
        /// <summary> The target resource group of matching resource sync rule. The labels from the request will be used to find out matching resource sync rule against the selector property of the resource sync rule. The one with highest priority will be returned if there are multiple matching rules. </summary>
        public string TargetResourceGroup { get; }
    }
}
