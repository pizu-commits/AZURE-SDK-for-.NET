// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Compute.Fluent
{
    using Microsoft.Azure.Management.Resource.Fluent.Core;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// An immutable client-side representation of an Azure virtual machine extension.
    /// An extension associated with a virtual machine will be created from a VirtualMachineExtensionImage.
    /// </summary>
    public interface IVirtualMachineExtension  :
        IVirtualMachineExtensionBase,
        IExternalChildResource<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineExtension,Microsoft.Azure.Management.Compute.Fluent.IVirtualMachine>
    {
        /// <return>Observable that emits virtual machine extension instance view.</return>
        Task<VirtualMachineExtensionInstanceView> GetInstanceViewAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <return>The instance view of the virtual machine extension.</return>
        VirtualMachineExtensionInstanceView GetInstanceView();
    }
}