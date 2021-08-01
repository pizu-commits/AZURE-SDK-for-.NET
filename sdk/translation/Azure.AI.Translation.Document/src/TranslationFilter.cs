﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace Azure.AI.Translation.Document
{
    /// <summary>
    /// A class which defines filtering and ordering options
    /// for listing all submitted translation operations.
    /// </summary>
    public class TranslationFilter
    {
        /// <summary>
        /// Initializes and instance of <see cref="TranslationFilter"/>.
        /// </summary>
        /// <param name="createdAfter">Filter translations by <see cref="TranslationStatus.CreatedOn"/>. Get translations created after a certain date in UTC format.</param>
        /// <param name="createdBefore">Filter translations by <see cref="TranslationStatus.CreatedOn"/>. Get translations created before a certain date in UTC format.</param>
        /// <param name="ids">Filter results by <see cref="TranslationStatus.Id"/>. Get translations with certain IDs.</param>
        /// <param name="orderBy">Defines sorting options for the result. See <see cref="TranslationFilterOrder"/> for more information on which sorting options to use.</param>
        /// <param name="statuses">Filter results by <see cref="TranslationStatus.Status"/>.</param>
        public TranslationFilter(
            DateTimeOffset? createdAfter = null,
            DateTimeOffset? createdBefore = null,
            IList<string> ids = null,
            IList<TranslationFilterOrder> orderBy = null,
            IList<DocumentTranslationStatus> statuses = null)
        {
            CreatedAfter = createdAfter;
            CreatedBefore = createdBefore;
            Ids = ids;
            OrderBy = orderBy;
            Statuses = statuses;
        }
        /// <summary>
        /// Filter results by <see cref="TranslationStatus.CreatedOn"/>.
        /// Get translations created after a certain date in UTC format.
        /// </summary>
        public DateTimeOffset? CreatedAfter { get; set; }
        /// <summary>
        /// Filter results by <see cref="TranslationStatus.CreatedOn"/>.
        /// Get translations created before a certain date in UTC format.
        /// </summary>
        public DateTimeOffset? CreatedBefore { get; set; }
        /// <summary>
        /// Filter results by <see cref="TranslationStatus.Id"/>.
        /// </summary>
        public IList<string> Ids { get; }
        /// <summary>
        /// Defines sorting options for the result.
        /// See <see cref="TranslationFilterOrder"/> for more information on which sorting options to use.
        /// </summary>
        public IList<TranslationFilterOrder> OrderBy { get; }
        /// <summary>
        /// Filter results by <see cref="TranslationStatus.Status"/>.
        /// See <see cref="DocumentTranslationStatus"/> to know which statuses to use.
        /// </summary>
        public IList<DocumentTranslationStatus> Statuses { get; }
    }
}
