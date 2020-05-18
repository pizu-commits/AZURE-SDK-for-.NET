﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.AI.FormRecognizer.Training;
using Azure.Core;
using Azure.Core.TestFramework;

namespace Azure.AI.FormRecognizer.Tests
{
    public class FormRecognizerLiveTestBase : RecordedTestBase<FormRecognizerTestEnvironment>
    {
        public FormRecognizerLiveTestBase(bool isAsync) : base(isAsync)
        {
            Sanitizer = new FormRecognizerRecordedTestSanitizer();
            Matcher = new FormRecognizerRecordMatcher();
        }

        /// <summary>
        /// Creates a <see cref="FormRecognizerClient" /> with the endpoint and API key provided via environment
        /// variables and instruments it to make use of the Azure Core Test Framework functionalities.
        /// </summary>
        /// <param name="useTokenCredential">Whether or not to use a <see cref="TokenCredential"/> to authenticate. An <see cref="AzureKeyCredential"/> is used by default.</param>
        /// <returns>The instrumented <see cref="FormRecognizerClient" />.</returns>
        protected FormTrainingClient CreateInstrumentedFormTrainingClient(bool useTokenCredential = false)
        {
            var endpoint = new Uri(TestEnvironment.Endpoint);
            var options = Recording.InstrumentClientOptions(new FormRecognizerClientOptions());
            FormTrainingClient client;

            if (useTokenCredential)
            {
                client = new FormTrainingClient(endpoint, TestEnvironment.Credential, options);
            }
            else
            {
                var credential = new AzureKeyCredential(TestEnvironment.ApiKey);
                client = new FormTrainingClient(endpoint, credential, options);
            }

            return InstrumentClient(client);
        }

        /// <summary>
        /// Trains a model and returns the associated <see cref="DisposableTrainedModel"/> instance, from which
        /// the model ID can be obtained. Upon disposal, the model will be deleted.
        /// </summary>
        /// <param name="useTrainingLabels">If <c>true</c>, use a label file created in the &lt;link-to-label-tool-doc&gt; to provide training-time labels for training a model. If <c>false</c>, the model will be trained from forms only.</param>
        /// <returns>A <see cref="DisposableTrainedModel"/> instance from which the trained model ID can be obtained.</returns>
        protected async Task<DisposableTrainedModel> CreateDisposableTrainedModelAsync(bool useTrainingLabels)
        {
            var trainingClient = CreateInstrumentedFormTrainingClient();
            var trainingFilesUri = new Uri(TestEnvironment.BlobContainerSasUrl);

            DisposableTrainedModel trainedModel;

            // TODO: sanitize body and enable body recording here.
            using (Recording.DisableRequestBodyRecording())
            {
                trainedModel = await DisposableTrainedModel.TrainModelAsync(trainingClient, trainingFilesUri, useTrainingLabels);
            }

            return trainedModel;
        }
    }
}
