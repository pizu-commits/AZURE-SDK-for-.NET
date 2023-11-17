// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> Represents the request data used to generate images. </summary>
    public partial class ImageGenerationOptions
    {
        /// <summary> Initializes a new instance of ImageGenerationOptions. </summary>
        /// <param name="prompt"> A description of the desired images. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="prompt"/> is null. </exception>
        public ImageGenerationOptions(string prompt)
        {
            Argument.AssertNotNull(prompt, nameof(prompt));

            Prompt = prompt;
        }

        /// <summary> Initializes a new instance of ImageGenerationOptions. </summary>
        /// <param name="deploymentName"> The model to use for image generation. </param>
        /// <param name="prompt"> A description of the desired images. </param>
        /// <param name="imageCount">
        /// The number of images to generate.
        /// Dall-e-2 models support values between 1 and 10.
        /// Dall-e-3 models only support a value of 1.
        /// </param>
        /// <param name="size">
        /// The desired dimensions for generated images.
        /// Dall-e-2 models support 256x256, 512x512, or 1024x1024.
        /// Dall-e-3 models support 1024x1024, 1792x1024, or 1024x1792.
        /// </param>
        /// <param name="responseFormat"> The format in which image generation response items should be presented. </param>
        /// <param name="quality">
        /// The desired image generation quality level to use.
        /// Only configurable with dall-e-3 models.
        /// </param>
        /// <param name="style">
        /// The desired image generation style to use.
        /// Only configurable with dall-e-3 models.
        /// </param>
        /// <param name="user"> A unique identifier representing your end-user, which can help to monitor and detect abuse. </param>
        internal ImageGenerationOptions(string deploymentName, string prompt, int? imageCount, ImageSize? size, ImageGenerationResponseFormat? responseFormat, ImageGenerationQuality? quality, ImageGenerationStyle? style, string user)
        {
            DeploymentName = deploymentName;
            Prompt = prompt;
            ImageCount = imageCount;
            Size = size;
            ResponseFormat = responseFormat;
            Quality = quality;
            Style = style;
            User = user;
        }

        /// <summary> The model to use for image generation. </summary>
        public string DeploymentName { get; set; }
        /// <summary>
        /// The number of images to generate.
        /// Dall-e-2 models support values between 1 and 10.
        /// Dall-e-3 models only support a value of 1.
        /// </summary>
        public int? ImageCount { get; set; }
        /// <summary>
        /// The desired dimensions for generated images.
        /// Dall-e-2 models support 256x256, 512x512, or 1024x1024.
        /// Dall-e-3 models support 1024x1024, 1792x1024, or 1024x1792.
        /// </summary>
        public ImageSize? Size { get; set; }
        /// <summary>
        /// The desired image generation quality level to use.
        /// Only configurable with dall-e-3 models.
        /// </summary>
        public ImageGenerationQuality? Quality { get; set; }
        /// <summary>
        /// The desired image generation style to use.
        /// Only configurable with dall-e-3 models.
        /// </summary>
        public ImageGenerationStyle? Style { get; set; }
        /// <summary> A unique identifier representing your end-user, which can help to monitor and detect abuse. </summary>
        public string User { get; set; }
    }
}
