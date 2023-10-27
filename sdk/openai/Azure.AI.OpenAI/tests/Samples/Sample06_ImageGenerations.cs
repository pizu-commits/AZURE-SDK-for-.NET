// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.AI.OpenAI.Tests.Samples
{
    public partial class ImageGenerationsSamples
    {
        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task ImageGenerations()
        {
            string endpoint = "https://myaccount.openai.azure.com/";
            var client = new OpenAIClient(new Uri(endpoint), new DefaultAzureCredential());
            bool usingAzure = true;
            bool requestUrls = true;

            #region Snippet:GenerateImages
            Response<ImageGenerations> response = await client.GetImageGenerationsAsync(
                new ImageGenerationOptions()
                {
                    // DeploymentName only needs to be set when using Azure OpenAI or an explicit OpenAI "model"
                    DeploymentName = usingAzure ? "my-deployment-name" : string.Empty,
                    Prompt = "a happy monkey eating a banana, in watercolor",
                    // Generations may request either URLs to retrieve the image from (default) or the direct binary data
                    ResponseFormat = requestUrls ? ImageGenerationResponseFormat.Url : ImageGenerationResponseFormat.Base64,
                    Size = ImageSize.Size256x256,
                });

            // Image Generations responses provide URLs you can use to retrieve requested images or the binary data,
            // depending on which response format was requested.
            Uri imageUri = response.Value.Data[0].Url;
            string imageBase64Data = response.Value.Data[0].Base64Data;
            #endregion
        }
    }
}
