// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.StreamAnalytics.Models;

namespace Azure.ResourceManager.StreamAnalytics.Samples
{
    public partial class Sample_StreamingJobResource
    {
        // Update a streaming job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAStreamingJob()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/StreamingJob_Update.json
            // this example is just showing the usage of "StreamingJobs_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg6936";
            string jobName = "sj59";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // invoke the operation
            StreamingJobData data = new StreamingJobData(new AzureLocation("placeholder"))
            {
                EventsOutOfOrderMaxDelayInSeconds = 21,
                EventsLateArrivalMaxDelayInSeconds = 13,
            };
            StreamingJobResource result = await streamingJob.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a streaming job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAStreamingJob()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/StreamingJob_Delete.json
            // this example is just showing the usage of "StreamingJobs_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg6936";
            string jobName = "sj59";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // invoke the operation
            await streamingJob.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get a streaming job and do not use the $expand OData query parameter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAStreamingJobAndDoNotUseTheExpandODataQueryParameter()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/StreamingJob_Get_NoExpand.json
            // this example is just showing the usage of "StreamingJobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg6936";
            string jobName = "sj59";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // invoke the operation
            StreamingJobResource result = await streamingJob.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a streaming job and use the $expand OData query parameter to expand inputs, outputs, transformation, and functions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAStreamingJobAndUseTheExpandODataQueryParameterToExpandInputsOutputsTransformationAndFunctions()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/StreamingJob_Get_Expand.json
            // this example is just showing the usage of "StreamingJobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg3276";
            string jobName = "sj7804";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // invoke the operation
            string expand = "inputs,outputs,transformation,functions";
            StreamingJobResource result = await streamingJob.GetAsync(expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StreamingJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all streaming jobs in a subscription and do not use the $expand OData query parameter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetStreamingJobs_ListAllStreamingJobsInASubscriptionAndDoNotUseTheExpandODataQueryParameter()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/StreamingJob_List_BySubscription_NoExpand.json
            // this example is just showing the usage of "StreamingJobs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (StreamingJobResource item in subscriptionResource.GetStreamingJobsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StreamingJobData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List all streaming jobs in a subscription and use the $expand OData query parameter to expand inputs, outputs, transformation, and functions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetStreamingJobs_ListAllStreamingJobsInASubscriptionAndUseTheExpandODataQueryParameterToExpandInputsOutputsTransformationAndFunctions()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/StreamingJob_List_BySubscription_Expand.json
            // this example is just showing the usage of "StreamingJobs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            string expand = "inputs,outputs,transformation,functions";
            await foreach (StreamingJobResource item in subscriptionResource.GetStreamingJobsAsync(expand: expand))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StreamingJobData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Start a streaming job with CustomTime output start mode
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Start_StartAStreamingJobWithCustomTimeOutputStartMode()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/StreamingJob_Start_CustomTime.json
            // this example is just showing the usage of "StreamingJobs_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg6936";
            string jobName = "sj59";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // invoke the operation
            StartStreamingJobContent content = new StartStreamingJobContent()
            {
                OutputStartMode = StreamingJobOutputStartMode.CustomTime,
                OutputStartOn = DateTimeOffset.Parse("2012-12-12T12:12:12Z"),
            };
            await streamingJob.StartAsync(WaitUntil.Completed, content: content);

            Console.WriteLine($"Succeeded");
        }

        // Start a streaming job with JobStartTime output start mode
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Start_StartAStreamingJobWithJobStartTimeOutputStartMode()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/StreamingJob_Start_JobStartTime.json
            // this example is just showing the usage of "StreamingJobs_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg6936";
            string jobName = "sj59";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // invoke the operation
            StartStreamingJobContent content = new StartStreamingJobContent()
            {
                OutputStartMode = StreamingJobOutputStartMode.JobStartTime,
            };
            await streamingJob.StartAsync(WaitUntil.Completed, content: content);

            Console.WriteLine($"Succeeded");
        }

        // Start a streaming job with LastOutputEventTime output start mode
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Start_StartAStreamingJobWithLastOutputEventTimeOutputStartMode()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/StreamingJob_Start_LastOutputEventTime.json
            // this example is just showing the usage of "StreamingJobs_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg6936";
            string jobName = "sj59";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // invoke the operation
            StartStreamingJobContent content = new StartStreamingJobContent()
            {
                OutputStartMode = StreamingJobOutputStartMode.LastOutputEventTime,
            };
            await streamingJob.StartAsync(WaitUntil.Completed, content: content);

            Console.WriteLine($"Succeeded");
        }

        // Stop a streaming job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Stop_StopAStreamingJob()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/StreamingJob_Stop.json
            // this example is just showing the usage of "StreamingJobs_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg6936";
            string jobName = "sj59";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // invoke the operation
            await streamingJob.StopAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Scale a streaming job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Scale_ScaleAStreamingJob()
        {
            // Generated from example definition: specification/streamanalytics/resource-manager/Microsoft.StreamAnalytics/preview/2021-10-01-preview/examples/StreamingJob_Scale.json
            // this example is just showing the usage of "StreamingJobs_Scale" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StreamingJobResource created on azure
            // for more information of creating StreamingJobResource, please refer to the document of StreamingJobResource
            string subscriptionId = "56b5e0a9-b645-407d-99b0-c64f86013e3d";
            string resourceGroupName = "sjrg6936";
            string jobName = "sj59";
            ResourceIdentifier streamingJobResourceId = StreamingJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, jobName);
            StreamingJobResource streamingJob = client.GetStreamingJobResource(streamingJobResourceId);

            // invoke the operation
            ScaleStreamingJobContent content = new ScaleStreamingJobContent()
            {
                StreamingUnits = 36,
            };
            await streamingJob.ScaleAsync(WaitUntil.Completed, content: content);

            Console.WriteLine($"Succeeded");
        }
    }
}
