// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkStatement. </summary>
    public partial class SparkStatement
    {
        /// <summary> Initializes a new instance of SparkStatement. </summary>
        /// <param name="id"></param>
        internal SparkStatement(int id)
        {
            Id = id;
        }

        /// <summary> Initializes a new instance of SparkStatement. </summary>
        /// <param name="id"></param>
        /// <param name="code"></param>
        /// <param name="state"></param>
        /// <param name="output"></param>
        internal SparkStatement(int id, string code, string state, SparkStatementOutput output)
        {
            Id = id;
            Code = code;
            State = state;
            Output = output;
        }

        /// <summary> Gets the id. </summary>
        public int Id { get; }
        /// <summary> Gets the code. </summary>
        public string Code { get; }
        /// <summary> Gets the state. </summary>
        public string State { get; }
        /// <summary> Gets the output. </summary>
        public SparkStatementOutput Output { get; }
    }
}
