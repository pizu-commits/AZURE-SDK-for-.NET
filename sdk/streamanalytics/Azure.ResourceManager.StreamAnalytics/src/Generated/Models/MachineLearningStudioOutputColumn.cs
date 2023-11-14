// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes an output column for the Azure Machine Learning Studio endpoint. </summary>
    public partial class MachineLearningStudioOutputColumn
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningStudioOutputColumn"/>. </summary>
        public MachineLearningStudioOutputColumn()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningStudioOutputColumn"/>. </summary>
        /// <param name="name"> The name of the output column. </param>
        /// <param name="dataType"> The (Azure Machine Learning supported) data type of the output column. A list of valid  Azure Machine Learning data types are described at https://msdn.microsoft.com/en-us/library/azure/dn905923.aspx . </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningStudioOutputColumn(string name, string dataType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            DataType = dataType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the output column. </summary>
        public string Name { get; set; }
        /// <summary> The (Azure Machine Learning supported) data type of the output column. A list of valid  Azure Machine Learning data types are described at https://msdn.microsoft.com/en-us/library/azure/dn905923.aspx . </summary>
        public string DataType { get; set; }
    }
}
