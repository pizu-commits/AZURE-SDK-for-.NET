// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.RecoveryServicesBackup.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesBackup.Samples
{
    public partial class Sample_BackupProtectionIntentResource
    {
        // Validate Enable Protection on Azure Vm
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ValidateProtectionIntent_ValidateEnableProtectionOnAzureVm()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/AzureIaasVm/ProtectionIntent_Validate.json
            // this example is just showing the usage of "ProtectionIntent_Validate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("southeastasia");
            PreValidateEnableBackupContent content = new PreValidateEnableBackupContent()
            {
                ResourceType = BackupDataSourceType.Vm,
                ResourceId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/arunaupgrade/providers/Microsoft.Compute/VirtualMachines/upgrade1"),
                VaultId = new ResourceIdentifier("/Subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myRG/providers/Microsoft.RecoveryServices/Vaults/myVault"),
                Properties = "",
            };
            PreValidateEnableBackupResult result = await subscriptionResource.ValidateProtectionIntentAsync(location, content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get ProtectionIntent for an item
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetProtectionIntentForAnItem()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/AzureWorkload/BackupProtectionIntent_Get.json
            // this example is just showing the usage of "ProtectionIntent_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupProtectionIntentResource created on azure
            // for more information of creating BackupProtectionIntentResource, please refer to the document of BackupProtectionIntentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myRG";
            string vaultName = "myVault";
            string fabricName = "Azure";
            string intentObjectName = "249D9B07-D2EF-4202-AA64-65F35418564E";
            ResourceIdentifier backupProtectionIntentResourceId = BackupProtectionIntentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, fabricName, intentObjectName);
            BackupProtectionIntentResource backupProtectionIntent = client.GetBackupProtectionIntentResource(backupProtectionIntentResourceId);

            // invoke the operation
            BackupProtectionIntentResource result = await backupProtectionIntent.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackupProtectionIntentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or Update Azure Vm Protection Intent
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateAzureVmProtectionIntent()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/AzureIaasVm/ProtectionIntent_CreateOrUpdate.json
            // this example is just showing the usage of "ProtectionIntent_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupProtectionIntentResource created on azure
            // for more information of creating BackupProtectionIntentResource, please refer to the document of BackupProtectionIntentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myRG";
            string vaultName = "myVault";
            string fabricName = "Azure";
            string intentObjectName = "vm;iaasvmcontainerv2;chamsrgtest;chamscandel";
            ResourceIdentifier backupProtectionIntentResourceId = BackupProtectionIntentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, fabricName, intentObjectName);
            BackupProtectionIntentResource backupProtectionIntent = client.GetBackupProtectionIntentResource(backupProtectionIntentResourceId);

            // invoke the operation
            BackupProtectionIntentData data = new BackupProtectionIntentData(new AzureLocation("placeholder"))
            {
                Properties = new ResourceProtectionIntent()
                {
                    SourceResourceId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/chamsrgtest/providers/Microsoft.Compute/virtualMachines/chamscandel"),
                    PolicyId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myRG/providers/Microsoft.RecoveryServices/vaults/myVault/backupPolicies/myPolicy"),
                },
            };
            ArmOperation<BackupProtectionIntentResource> lro = await backupProtectionIntent.UpdateAsync(WaitUntil.Completed, data);
            BackupProtectionIntentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackupProtectionIntentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete Protection intent from item
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteProtectionIntentFromItem()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/AzureWorkload/BackupProtectionIntent_Delete.json
            // this example is just showing the usage of "ProtectionIntent_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupProtectionIntentResource created on azure
            // for more information of creating BackupProtectionIntentResource, please refer to the document of BackupProtectionIntentResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myRG";
            string vaultName = "myVault";
            string fabricName = "Azure";
            string intentObjectName = "249D9B07-D2EF-4202-AA64-65F35418564E";
            ResourceIdentifier backupProtectionIntentResourceId = BackupProtectionIntentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, fabricName, intentObjectName);
            BackupProtectionIntentResource backupProtectionIntent = client.GetBackupProtectionIntentResource(backupProtectionIntentResourceId);

            // invoke the operation
            await backupProtectionIntent.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
