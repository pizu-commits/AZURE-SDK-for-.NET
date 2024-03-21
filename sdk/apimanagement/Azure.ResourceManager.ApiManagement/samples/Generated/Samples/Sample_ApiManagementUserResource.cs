// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiManagementUserResource
    {
        // ApiManagementHeadUser
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEntityTag_ApiManagementHeadUser()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementHeadUser.json
            // this example is just showing the usage of "User_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementUserResource created on azure
            // for more information of creating ApiManagementUserResource, please refer to the document of ApiManagementUserResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string userId = "5931a75ae4bbd512a88c680b";
            ResourceIdentifier apiManagementUserResourceId = ApiManagementUserResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, userId);
            ApiManagementUserResource apiManagementUser = client.GetApiManagementUserResource(apiManagementUserResourceId);

            // invoke the operation
            bool result = await apiManagementUser.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetUser
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetUser()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementGetUser.json
            // this example is just showing the usage of "User_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementUserResource created on azure
            // for more information of creating ApiManagementUserResource, please refer to the document of ApiManagementUserResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string userId = "5931a75ae4bbd512a88c680b";
            ResourceIdentifier apiManagementUserResourceId = ApiManagementUserResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, userId);
            ApiManagementUserResource apiManagementUser = client.GetApiManagementUserResource(apiManagementUserResourceId);

            // invoke the operation
            ApiManagementUserResource result = await apiManagementUser.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            UserContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementUpdateUser
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementUpdateUser()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementUpdateUser.json
            // this example is just showing the usage of "User_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementUserResource created on azure
            // for more information of creating ApiManagementUserResource, please refer to the document of ApiManagementUserResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string userId = "5931a75ae4bbd512a88c680b";
            ResourceIdentifier apiManagementUserResourceId = ApiManagementUserResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, userId);
            ApiManagementUserResource apiManagementUser = client.GetApiManagementUserResource(apiManagementUserResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            ApiManagementUserPatch patch = new ApiManagementUserPatch()
            {
                Email = "foobar@outlook.com",
                FirstName = "foo",
                LastName = "bar",
            };
            ApiManagementUserResource result = await apiManagementUser.UpdateAsync(ifMatch, patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            UserContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementDeleteUser
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ApiManagementDeleteUser()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementDeleteUser.json
            // this example is just showing the usage of "User_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementUserResource created on azure
            // for more information of creating ApiManagementUserResource, please refer to the document of ApiManagementUserResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string userId = "5931a75ae4bbd512288c680b";
            ResourceIdentifier apiManagementUserResourceId = ApiManagementUserResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, userId);
            ApiManagementUserResource apiManagementUser = client.GetApiManagementUserResource(apiManagementUserResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await apiManagementUser.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementUserGenerateSsoUrl
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GenerateSsoUri_ApiManagementUserGenerateSsoUrl()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementUserGenerateSsoUrl.json
            // this example is just showing the usage of "User_GenerateSsoUrl" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementUserResource created on azure
            // for more information of creating ApiManagementUserResource, please refer to the document of ApiManagementUserResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string userId = "57127d485157a511ace86ae7";
            ResourceIdentifier apiManagementUserResourceId = ApiManagementUserResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, userId);
            ApiManagementUserResource apiManagementUser = client.GetApiManagementUserResource(apiManagementUserResourceId);

            // invoke the operation
            GenerateSsoUriResult result = await apiManagementUser.GenerateSsoUriAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementUserToken
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSharedAccessToken_ApiManagementUserToken()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementUserToken.json
            // this example is just showing the usage of "User_GetSharedAccessToken" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementUserResource created on azure
            // for more information of creating ApiManagementUserResource, please refer to the document of ApiManagementUserResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string userId = "userId1718";
            ResourceIdentifier apiManagementUserResourceId = ApiManagementUserResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, userId);
            ApiManagementUserResource apiManagementUser = client.GetApiManagementUserResource(apiManagementUserResourceId);

            // invoke the operation
            UserTokenContent content = new UserTokenContent()
            {
                KeyType = TokenGenerationUsedKeyType.Primary,
                ExpireOn = DateTimeOffset.Parse("2019-04-21T00:44:24.2845269Z"),
            };
            UserTokenResult result = await apiManagementUser.GetSharedAccessTokenAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementListUserGroups
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetUserGroups_ApiManagementListUserGroups()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementListUserGroups.json
            // this example is just showing the usage of "UserGroup_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementUserResource created on azure
            // for more information of creating ApiManagementUserResource, please refer to the document of ApiManagementUserResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string userId = "57681833a40f7eb6c49f6acf";
            ResourceIdentifier apiManagementUserResourceId = ApiManagementUserResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, userId);
            ApiManagementUserResource apiManagementUser = client.GetApiManagementUserResource(apiManagementUserResourceId);

            // invoke the operation and iterate over the result
            await foreach (ApiManagementGroupResource item in apiManagementUser.GetUserGroupsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiManagementGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementListUserIdentities
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetUserIdentities_ApiManagementListUserIdentities()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementListUserIdentities.json
            // this example is just showing the usage of "UserIdentities_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementUserResource created on azure
            // for more information of creating ApiManagementUserResource, please refer to the document of ApiManagementUserResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string userId = "57f2af53bb17172280f44057";
            ResourceIdentifier apiManagementUserResourceId = ApiManagementUserResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, userId);
            ApiManagementUserResource apiManagementUser = client.GetApiManagementUserResource(apiManagementUserResourceId);

            // invoke the operation and iterate over the result
            await foreach (UserIdentityContract item in apiManagementUser.GetUserIdentitiesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementUserConfirmationPasswordSend
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task SendUserConfirmationPassword_ApiManagementUserConfirmationPasswordSend()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementUserConfirmationPasswordSend.json
            // this example is just showing the usage of "UserConfirmationPassword_Send" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementUserResource created on azure
            // for more information of creating ApiManagementUserResource, please refer to the document of ApiManagementUserResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string userId = "57127d485157a511ace86ae7";
            ResourceIdentifier apiManagementUserResourceId = ApiManagementUserResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, userId);
            ApiManagementUserResource apiManagementUser = client.GetApiManagementUserResource(apiManagementUserResourceId);

            // invoke the operation
            await apiManagementUser.SendUserConfirmationPasswordAsync();

            Console.WriteLine($"Succeeded");
        }
    }
}
