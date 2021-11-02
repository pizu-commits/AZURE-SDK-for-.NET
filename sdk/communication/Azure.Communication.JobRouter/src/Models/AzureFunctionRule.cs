﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    [CodeGenSuppress("AzureFunctionRule")]
    [CodeGenSuppress("AzureFunctionRule", typeof(string))]
    public partial class AzureFunctionRule : RouterRule
    {
        /// <summary> Initializes a new instance of AzureFunctionRule. </summary>
        /// <param name="functionAppUrl"> URL for custom azure function. </param>
        /// <param name="functionName"> (Optional) User-friendly name for function. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppUrl"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="functionAppUrl"/> is empty. </exception>
        public AzureFunctionRule(string functionAppUrl, string functionName = null)
            : this(null, functionAppUrl, functionName, null)
        {
            Argument.AssertNotNullOrWhiteSpace(functionAppUrl, nameof(functionAppUrl));
            ValidateUrl(functionAppUrl);
        }

        /// <summary> Initializes a new instance of AzureFunctionRule. </summary>
        /// <param name="functionAppUrl"> URL for custom azure function. </param>
        /// <param name="functionName"> (Optional) User-friendly name for function. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppUrl"/> is null. </exception>
        public AzureFunctionRule(Uri functionAppUrl, string functionName = null)
            : this(null, functionAppUrl?.AbsoluteUri, functionName, null)
        {
            if (functionAppUrl == null)
            {
                throw new ArgumentNullException(nameof(functionAppUrl), "cannot be set to empty or null");
            }
        }

        /// <summary> Initializes a new instance of AzureFunctionRule. </summary>
        /// <param name="functionAppUrl"> URL for custom azure function. </param>
        /// <param name="credential"> Access credentials to Azure function. </param>
        /// <param name="functionName"> (Optional) User-friendly name for function. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppUrl"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="functionAppUrl"/> is empty. </exception>
        public AzureFunctionRule(string functionAppUrl, AzureFunctionRuleCredential credential, string functionName = null)
            : this(null, functionAppUrl, functionName, credential)
        {
            Argument.AssertNotNullOrWhiteSpace(functionAppUrl, nameof(functionAppUrl));
            ValidateUrl(functionAppUrl);
        }

        /// <summary> Initializes a new instance of AzureFunctionRule. </summary>
        /// <param name="functionAppUrl"> URL for custom azure function. </param>
        /// <param name="credential"> Access credentials to Azure function. </param>
        /// <param name="functionName"> (Optional) User-friendly name for function. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppUrl"/> is null. </exception>
        public AzureFunctionRule(Uri functionAppUrl, AzureFunctionRuleCredential credential, string functionName = null)
            : this(null, functionAppUrl?.AbsoluteUri, functionName, credential)
        {
            if (functionAppUrl == null)
            {
                throw new ArgumentNullException(nameof(functionAppUrl), "cannot be set to empty or null");
            }
        }

        internal static void ValidateUrl(string urlEndpoint)
        {
            try
            {
                var uri = new Uri(urlEndpoint);
            }
            catch (UriFormatException e)
            {
                throw e;
            }
        }
    }
}
