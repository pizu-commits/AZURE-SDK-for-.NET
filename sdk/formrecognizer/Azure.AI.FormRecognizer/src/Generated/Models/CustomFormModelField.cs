// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.Training
{
    /// <summary> Report for a custom model training field. </summary>
    public partial class CustomFormModelField
    {
        /// <summary> Initializes a new instance of CustomFormModelField. </summary>
        /// <param name="name"> Training field name. </param>
        /// <param name="accuracy"> Estimated extraction accuracy for this field. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal CustomFormModelField(string name, float? accuracy)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Accuracy = accuracy;
        }
    }
}
