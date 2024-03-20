// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Properties for task that validates migration input for SQL to Azure SQL Database Managed Instance. </summary>
    public partial class ValidateMigrationInputSqlServerSqlMITaskProperties : ProjectTaskProperties
    {
        /// <summary> Initializes a new instance of <see cref="ValidateMigrationInputSqlServerSqlMITaskProperties"/>. </summary>
        public ValidateMigrationInputSqlServerSqlMITaskProperties()
        {
            Output = new ChangeTrackingList<ValidateMigrationInputSqlServerSqlMITaskOutput>();
            TaskType = TaskType.ValidateMigrationInputSqlServerAzureSqlDBMI;
        }

        /// <summary> Initializes a new instance of <see cref="ValidateMigrationInputSqlServerSqlMITaskProperties"/>. </summary>
        /// <param name="taskType"> Task type. </param>
        /// <param name="errors"> Array of errors. This is ignored if submitted. </param>
        /// <param name="state"> The state of the task. This is ignored if submitted. </param>
        /// <param name="commands">
        /// Array of command properties.
        /// Please note <see cref="CommandProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MongoDBCancelCommand"/>, <see cref="MongoDBFinishCommand"/>, <see cref="MigrateMISyncCompleteCommandProperties"/>, <see cref="MigrateSyncCompleteCommandProperties"/> and <see cref="MongoDBRestartCommand"/>.
        /// </param>
        /// <param name="clientData"> Key value pairs of client data to attach meta data information to task. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="input"> Task input. </param>
        /// <param name="output"> Task output. This is ignored if submitted. </param>
        internal ValidateMigrationInputSqlServerSqlMITaskProperties(TaskType taskType, IReadOnlyList<ODataError> errors, TaskState? state, IReadOnlyList<CommandProperties> commands, IDictionary<string, string> clientData, IDictionary<string, BinaryData> serializedAdditionalRawData, ValidateMigrationInputSqlServerSqlMITaskInput input, IReadOnlyList<ValidateMigrationInputSqlServerSqlMITaskOutput> output) : base(taskType, errors, state, commands, clientData, serializedAdditionalRawData)
        {
            Input = input;
            Output = output;
            TaskType = taskType;
        }

        /// <summary> Task input. </summary>
        public ValidateMigrationInputSqlServerSqlMITaskInput Input { get; set; }
        /// <summary> Task output. This is ignored if submitted. </summary>
        public IReadOnlyList<ValidateMigrationInputSqlServerSqlMITaskOutput> Output { get; }
    }
}
