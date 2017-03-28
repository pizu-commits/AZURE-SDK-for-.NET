// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Servicebus.Fluent
{
    using NamespaceAuthorizationRule.Definition;
    using ResourceManager.Fluent.Core;
    using ResourceManager.Fluent.Core.CollectionActions;
    using Management.Fluent.ServiceBus;

    /// <summary>
    /// Entry point to namespace authorization rules management API.
    /// </summary>
    public interface INamespaceAuthorizationRules  :
        IAuthorizationRules<Microsoft.Azure.Management.Servicebus.Fluent.INamespaceAuthorizationRule>,
        ISupportsCreating<NamespaceAuthorizationRule.Definition.IBlank>,
        IHasInner<INamespacesOperations>
    {
    }
}