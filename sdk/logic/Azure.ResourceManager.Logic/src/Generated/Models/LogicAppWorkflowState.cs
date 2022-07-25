// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary>
    /// The workflow state.
    /// Serialized Name: WorkflowState
    /// </summary>
    public readonly partial struct LogicAppWorkflowState : IEquatable<LogicAppWorkflowState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LogicAppWorkflowState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LogicAppWorkflowState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string CompletedValue = "Completed";
        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";
        private const string DeletedValue = "Deleted";
        private const string SuspendedValue = "Suspended";

        /// <summary>
        /// NotSpecified
        /// Serialized Name: WorkflowState.NotSpecified
        /// </summary>
        public static LogicAppWorkflowState NotSpecified { get; } = new LogicAppWorkflowState(NotSpecifiedValue);
        /// <summary>
        /// Completed
        /// Serialized Name: WorkflowState.Completed
        /// </summary>
        public static LogicAppWorkflowState Completed { get; } = new LogicAppWorkflowState(CompletedValue);
        /// <summary>
        /// Enabled
        /// Serialized Name: WorkflowState.Enabled
        /// </summary>
        public static LogicAppWorkflowState Enabled { get; } = new LogicAppWorkflowState(EnabledValue);
        /// <summary>
        /// Disabled
        /// Serialized Name: WorkflowState.Disabled
        /// </summary>
        public static LogicAppWorkflowState Disabled { get; } = new LogicAppWorkflowState(DisabledValue);
        /// <summary>
        /// Deleted
        /// Serialized Name: WorkflowState.Deleted
        /// </summary>
        public static LogicAppWorkflowState Deleted { get; } = new LogicAppWorkflowState(DeletedValue);
        /// <summary>
        /// Suspended
        /// Serialized Name: WorkflowState.Suspended
        /// </summary>
        public static LogicAppWorkflowState Suspended { get; } = new LogicAppWorkflowState(SuspendedValue);
        /// <summary> Determines if two <see cref="LogicAppWorkflowState"/> values are the same. </summary>
        public static bool operator ==(LogicAppWorkflowState left, LogicAppWorkflowState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LogicAppWorkflowState"/> values are not the same. </summary>
        public static bool operator !=(LogicAppWorkflowState left, LogicAppWorkflowState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LogicAppWorkflowState"/>. </summary>
        public static implicit operator LogicAppWorkflowState(string value) => new LogicAppWorkflowState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LogicAppWorkflowState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LogicAppWorkflowState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
