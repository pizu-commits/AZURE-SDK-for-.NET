// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The ImportDataAction. </summary>
    public partial class ImportDataAction : MachineLearningScheduleAction
    {
        /// <summary> Initializes a new instance of <see cref="ImportDataAction"/>. </summary>
        /// <param name="dataImportDefinition"> [Required] Defines Schedule action definition details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataImportDefinition"/> is null. </exception>
        public ImportDataAction(DataImport dataImportDefinition)
        {
            Argument.AssertNotNull(dataImportDefinition, nameof(dataImportDefinition));

            DataImportDefinition = dataImportDefinition;
            ActionType = ScheduleActionType.ImportData;
        }

        /// <summary> Initializes a new instance of <see cref="ImportDataAction"/>. </summary>
        /// <param name="actionType"> [Required] Specifies the action type of the schedule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="dataImportDefinition"> [Required] Defines Schedule action definition details. </param>
        internal ImportDataAction(ScheduleActionType actionType, IDictionary<string, BinaryData> serializedAdditionalRawData, DataImport dataImportDefinition) : base(actionType, serializedAdditionalRawData)
        {
            DataImportDefinition = dataImportDefinition;
            ActionType = actionType;
        }

        /// <summary> Initializes a new instance of <see cref="ImportDataAction"/> for deserialization. </summary>
        internal ImportDataAction()
        {
        }

        /// <summary> [Required] Defines Schedule action definition details. </summary>
        public DataImport DataImportDefinition { get; set; }
    }
}
