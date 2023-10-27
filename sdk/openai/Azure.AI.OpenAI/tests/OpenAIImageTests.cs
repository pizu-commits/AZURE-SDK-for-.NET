// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.OpenAI.Tests
{
    public class OpenAIImageTests : OpenAITestBase
    {
        public OpenAIImageTests(bool isAsync)
            : base(isAsync)//, RecordedTestMode.Live)
        {
        }

        [RecordedTest]
        [TestCase(OpenAIClientServiceTarget.Azure, ImageDataType.Url)]
        [TestCase(OpenAIClientServiceTarget.Azure, ImageDataType.Base64)]
        [TestCase(OpenAIClientServiceTarget.Azure, ImageDataType.None)]
        [TestCase(OpenAIClientServiceTarget.NonAzure, ImageDataType.Url)]
        [TestCase(OpenAIClientServiceTarget.NonAzure, ImageDataType.Base64)]
        [TestCase(OpenAIClientServiceTarget.NonAzure, ImageDataType.None)]
        public async Task CanGenerateImages(OpenAIClientServiceTarget serviceTarget, ImageDataType imageDataType)
        {
            OpenAIClient client = GetDevelopmentTestClient(
                serviceTarget,
                "AOAI_IMAGE_GENERATION_RESOURCE_URL",
                "AOAI_IMAGE_GENERATION_RESOURCE_API_KEY");
            Assert.That(client, Is.InstanceOf<OpenAIClient>());

            string deploymentName = GetDeploymentOrModelName(serviceTarget, OpenAIClientScenario.ImageGenerations);
            const string prompt = "a simplistic picture of a cyberpunk money dreaming of electric bananas";
            var requestOptions = new ImageGenerationOptions()
            {
                DeploymentName = deploymentName,
                Prompt = prompt,
                Size = ImageSize.Size256x256,
                ImageCount = 2,
                User = "placeholder",
            };
            if (imageDataType != ImageDataType.None)
            {
                requestOptions.ResponseFormat = imageDataType switch
                {
                    ImageDataType.Url => ImageGenerationResponseFormat.Url,
                    ImageDataType.Base64 => ImageGenerationResponseFormat.Base64,
                    _ => throw new ArgumentException("Unhandled image data type"),
                };
            }
            Assert.That(requestOptions, Is.InstanceOf<ImageGenerationOptions>());

            Response<ImageGenerations> imagesResponse = await client.GetImageGenerationsAsync(requestOptions);

            Response rawResponse = imagesResponse.GetRawResponse();
            Assert.That(rawResponse, Is.Not.Null);
            Assert.That(rawResponse.IsError, Is.False);

            ImageGenerations imageGenerations = imagesResponse.Value;
            Assert.That(imageGenerations, Is.InstanceOf<ImageGenerations>());
            Assert.That(imageGenerations, Is.Not.Null);
            Assert.That(imageGenerations.Created, Is.GreaterThan(new DateTimeOffset(new DateTime(2023, 1, 1))));

            Assert.That(imageGenerations.Data, Is.Not.Null.Or.Empty);
            Assert.That(imageGenerations.Data.Count, Is.EqualTo(requestOptions.ImageCount));

            for (int i = 0; i < imageGenerations.Data.Count; i++)
            {
                ImageGenerationData dataItem = imageGenerations.Data[i];
                Assert.That(dataItem, Is.Not.Null);
                if (imageDataType == ImageDataType.Url || imageDataType == ImageDataType.None)
                {
                    Assert.That(dataItem.Url, Is.Not.Null.Or.Empty);
                    Assert.That(dataItem.Base64Data, Is.Null);
                }
                else if (imageDataType == ImageDataType.Base64)
                {
                    Assert.That(dataItem.Url, Is.Null);
                    Assert.That(dataItem.Base64Data, Is.Not.Null);
                }
                else
                {
                    throw new NotImplementedException("test not updated for new expected data type");
                }
            }
        }

        public enum ImageDataType
        {
            None,
            Url,
            Base64,
        }
    }
}
