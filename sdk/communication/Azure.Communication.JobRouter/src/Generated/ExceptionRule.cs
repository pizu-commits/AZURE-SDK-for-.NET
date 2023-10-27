// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> A rule that defines actions to execute upon a specific trigger. </summary>
    public partial class ExceptionRule
    {
        /// <summary> Initializes a new instance of ExceptionRule. </summary>
        /// <param name="trigger">
        /// The trigger for this exception rule
        /// Please note <see cref="ExceptionTrigger"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="QueueLengthExceptionTrigger"/> and <see cref="WaitTimeExceptionTrigger"/>.
        /// </param>
        /// <param name="actions">
        /// A dictionary collection of actions to perform once the exception is triggered.
        /// Key is the Id of each exception action.
        /// Please note <see cref="ExceptionAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CancelExceptionAction"/>, <see cref="ManualReclassifyExceptionAction"/> and <see cref="ReclassifyExceptionAction"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trigger"/> or <paramref name="actions"/> is null. </exception>
        internal ExceptionRule(ExceptionTrigger trigger, IReadOnlyDictionary<string, ExceptionAction> actions)
        {
            Argument.AssertNotNull(trigger, nameof(trigger));
            Argument.AssertNotNull(actions, nameof(actions));

            Trigger = trigger;
            Actions = actions;
        }

        /// <summary>
        /// The trigger for this exception rule
        /// Please note <see cref="ExceptionTrigger"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="QueueLengthExceptionTrigger"/> and <see cref="WaitTimeExceptionTrigger"/>.
        /// </summary>
        public ExceptionTrigger Trigger { get; }
    }
}
