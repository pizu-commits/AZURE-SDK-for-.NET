// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Azure.Developer.DevCenter.Models
{
    public partial class EnvironmentDefinition
    {
        /// <summary> Initializes a new instance of <see cref="EnvironmentDefinition"/>. </summary>
        /// <param name="id"> The ID of the environment definition. </param>
        /// <param name="name"> Name of the environment definition. </param>
        /// <param name="catalogName"> Name of the catalog. </param>
        /// <param name="description"> A short description of the environment definition. </param>
        /// <param name="parameters"> Input parameters passed to an environment. </param>
        /// <param name="parametersSchema"> JSON schema defining the parameters object passed to an environment. </param>
        /// <param name="templatePath"> Path to the Environment Definition entrypoint file. </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public EnvironmentDefinition(string id, string name, string catalogName, string description, IReadOnlyList<EnvironmentDefinitionParameter> parameters, string parametersSchema, string templatePath)
        {
            Id = id;
            Name = name;
            CatalogName = catalogName;
            Description = description;
            Parameters = parameters;
            ParametersSchema = parametersSchema;
            TemplatePath = templatePath;
        }
    }
}
