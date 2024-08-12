// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiIssueCommentResource
    {
        // ApiManagementHeadApiIssueComment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEntityTag_ApiManagementHeadApiIssueComment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/examples/ApiManagementHeadApiIssueComment.json
            // this example is just showing the usage of "ApiIssueComment_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueCommentResource created on azure
            // for more information of creating ApiIssueCommentResource, please refer to the document of ApiIssueCommentResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d2ef278aa04f0888cba3f3";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            string commentId = "599e29ab193c3c0bd0b3e2fb";
            ResourceIdentifier apiIssueCommentResourceId = ApiIssueCommentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId, commentId);
            ApiIssueCommentResource apiIssueComment = client.GetApiIssueCommentResource(apiIssueCommentResourceId);

            // invoke the operation
            bool result = await apiIssueComment.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetApiIssueComment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetApiIssueComment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/examples/ApiManagementGetApiIssueComment.json
            // this example is just showing the usage of "ApiIssueComment_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueCommentResource created on azure
            // for more information of creating ApiIssueCommentResource, please refer to the document of ApiIssueCommentResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d2ef278aa04f0888cba3f3";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            string commentId = "599e29ab193c3c0bd0b3e2fb";
            ResourceIdentifier apiIssueCommentResourceId = ApiIssueCommentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId, commentId);
            ApiIssueCommentResource apiIssueComment = client.GetApiIssueCommentResource(apiIssueCommentResourceId);

            // invoke the operation
            ApiIssueCommentResource result = await apiIssueComment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiIssueCommentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateApiIssueComment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementCreateApiIssueComment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/examples/ApiManagementCreateApiIssueComment.json
            // this example is just showing the usage of "ApiIssueComment_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueCommentResource created on azure
            // for more information of creating ApiIssueCommentResource, please refer to the document of ApiIssueCommentResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d1f7558aa04f15146d9d8a";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            string commentId = "599e29ab193c3c0bd0b3e2fb";
            ResourceIdentifier apiIssueCommentResourceId = ApiIssueCommentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId, commentId);
            ApiIssueCommentResource apiIssueComment = client.GetApiIssueCommentResource(apiIssueCommentResourceId);

            // invoke the operation
            ApiIssueCommentData data = new ApiIssueCommentData()
            {
                Text = "Issue comment.",
                CreatedOn = DateTimeOffset.Parse("2018-02-01T22:21:20.467Z"),
                UserId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.ApiManagement/service/apimService1/users/1"),
            };
            ArmOperation<ApiIssueCommentResource> lro = await apiIssueComment.UpdateAsync(WaitUntil.Completed, data);
            ApiIssueCommentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiIssueCommentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementDeleteApiIssueComment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ApiManagementDeleteApiIssueComment()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2022-08-01/examples/ApiManagementDeleteApiIssueComment.json
            // this example is just showing the usage of "ApiIssueComment_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiIssueCommentResource created on azure
            // for more information of creating ApiIssueCommentResource, please refer to the document of ApiIssueCommentResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string apiId = "57d1f7558aa04f15146d9d8a";
            string issueId = "57d2ef278aa04f0ad01d6cdc";
            string commentId = "599e29ab193c3c0bd0b3e2fb";
            ResourceIdentifier apiIssueCommentResourceId = ApiIssueCommentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, apiId, issueId, commentId);
            ApiIssueCommentResource apiIssueComment = client.GetApiIssueCommentResource(apiIssueCommentResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await apiIssueComment.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine($"Succeeded");
        }
    }
}
