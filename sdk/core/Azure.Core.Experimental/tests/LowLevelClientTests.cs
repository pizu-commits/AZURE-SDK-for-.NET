﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core.Experimental.Tests;
using Azure.Core.Experimental.Tests.Models;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Core.Tests
{
    public class LowLevelClientTests : ClientTestBase
    {
        public LowLevelClientTests(bool isAsync) : base(isAsync)
        {
        }

        private readonly Uri _url = new Uri("https://example.azurepetstore.com");

        public PetStoreClient CreateClient(HttpPipelineTransport transport)
        {
            var options = new PetStoreClientOptions()
            {
                Transport = transport
            };

            return new PetStoreClient(_url, new MockCredential(), options);
        }

        [Test]
        public async Task CanGetResponseFromLlcGetMethodAsync()
        {
            var mockResponse = new MockResponse(200);

            Pet pet = new Pet("snoopy", "beagle");
            mockResponse.SetContent(SerializationHelpers.Serialize(pet, SerializePet));

            var mockTransport = new MockTransport(mockResponse);
            PetStoreClient client = CreateClient(mockTransport);

            Response response = await client.GetPetAsync("snoopy", new RequestContext());
            var doc = JsonDocument.Parse(response.Content.ToMemory());

            Assert.AreEqual(200, response.Status);
            Assert.AreEqual("snoopy", doc.RootElement.GetProperty("name").GetString());
            Assert.AreEqual("beagle", doc.RootElement.GetProperty("species").GetString());
        }

        [Test]
        public async Task CanGetOutputModelOnSuccessCodeAsync()
        {
            var mockResponse = new MockResponse(200);

            Pet petResponse = new Pet("snoopy", "beagle");
            mockResponse.SetContent(SerializationHelpers.Serialize(petResponse, SerializePet));

            var mockTransport = new MockTransport(mockResponse);
            PetStoreClient client = CreateClient(mockTransport);

            Pet pet = await client.GetPetAsync("pet1");

            Assert.AreEqual("snoopy", pet.Name);
            Assert.AreEqual("beagle", pet.Species);
        }

        [Test]
        public async Task ModelCastThrowsOnErrorCodeAsync()
        {
            var mockResponse = new MockResponse(404);

            // Send the response through the pipeline so IsError is set.
            var mockTransport = new MockTransport(mockResponse);
            PetStoreClient client = CreateClient(mockTransport);

            Response response = await client.GetPetAsync("pet1", ErrorOptions.NoThrow);

            Assert.Throws<RequestFailedException>(() => { Pet pet = response; });
        }

        [Test]
        public void CannotGetOutputModelOnFailureCodeAsync()
        {
            var mockResponse = new MockResponse(404);

            var mockTransport = new MockTransport(mockResponse);
            PetStoreClient client = CreateClient(mockTransport);

            Assert.ThrowsAsync<RequestFailedException>(async () => await client.GetPetAsync("pet1"));
        }

        // Note: these two tests *currently* test different code paths:
        // 1) In the ResponseStatusOptions.Default case, we're going through code paths in
        //    ClientDiagnostics that we'll later migrate to ResponseClassifier (see https://github.com/azure/azure-sdk-for-net/issues/24031)
        //
        //    Because this one is thrown from client's `GetPetAsync()` method, where it calls
        //    _clientDiagnostics.CreateRFException() -- this happens via different constructors (Note: does it have to?  Could we refactor this?)
        //
        // 2) In the ResponseStatusOptions.NoThrow case, we're going through code paths in
        //    ResponseClassifier, which will become the only path after resolution of #24031
        //
        // Importantly, having these two tests validates our premise:
        //   ** The Grow-Up Story/HLC Helper approach has the same semantics

        [Test]
        public async Task GetRequestFailedException_StatusOptionDefault()
        {
            var mockResponse = new MockResponse(404);
            mockResponse.SetContent("{\"error\": { \"code\": \"MockStatusCode\" }}");
            mockResponse.AddHeader(HttpHeader.Names.ContentType, "application/json");

            var mockTransport = new MockTransport(mockResponse);
            PetStoreClient client = CreateClient(mockTransport);

            try
            {
                Pet pet = await client.GetPetAsync("pet1");
            }
            catch (RequestFailedException e)
            {
                Assert.AreEqual(404, e.Status);
                Assert.That(() => e.Message.StartsWith("Service request failed."));
                Assert.That(() => e.ErrorCode.StartsWith("MockStatusCode"));
            }
        }

        [Test]
        public async Task GetRequestFailedException_StatusOptionNoThrow()
        {
            var mockResponse = new MockResponse(404);
            mockResponse.SetContent("{\"error\": { \"code\": \"MockStatusCode\" }}");
            mockResponse.AddHeader(HttpHeader.Names.ContentType, "application/json");

            var mockTransport = new MockTransport(mockResponse);
            PetStoreClient client = CreateClient(mockTransport);

            try
            {
                // NOTE: is it weird that we're saying NoThrow here and it throws?
                // This looks confusing to me as someone reading this code.
                Pet pet = await client.GetPetAsync("pet1", ErrorOptions.NoThrow);
            }
            catch (RequestFailedException e)
            {
                Assert.AreEqual(404, e.Status);
                Assert.That(() => e.Message.StartsWith("Service request failed."));
                Assert.That(() => e.ErrorCode.StartsWith("MockStatusCode"));
            }
        }

        [Test]
        public void CanSuppressExceptions()
        {
            var mockResponse = new MockResponse(404);

            var mockTransport = new MockTransport(mockResponse);
            PetStoreClient client = CreateClient(mockTransport);

            RequestContext context = new RequestContext()
            {
                ErrorOptions = ErrorOptions.NoThrow
            };

            Response response = default;
            Assert.DoesNotThrowAsync(async () =>
            {
                response = await client.GetPetAsync("snoopy", context);
            });

            Assert.AreEqual(404, response.Status);
        }

        [Test]
        public async Task ThrowOnErrorDoesntThrowOnSuccess()
        {
            var mockResponse = new MockResponse(200);

            Pet pet = new Pet("snoopy", "beagle");
            mockResponse.SetContent(SerializationHelpers.Serialize(pet, SerializePet));

            var mockTransport = new MockTransport(mockResponse);
            PetStoreClient client = CreateClient(mockTransport);

            Response response = await client.GetPetAsync("snoopy", new RequestContext()
            {
                ErrorOptions = ErrorOptions.Default
            });
            var doc = JsonDocument.Parse(response.Content.ToMemory());

            Assert.AreEqual(200, response.Status);
            Assert.AreEqual("snoopy", doc.RootElement.GetProperty("name").GetString());
            Assert.AreEqual("beagle", doc.RootElement.GetProperty("species").GetString());
        }

        [Test]
        public void ThrowOnErrorThrowsOnError()
        {
            var mockResponse = new MockResponse(404);

            var mockTransport = new MockTransport(mockResponse);
            PetStoreClient client = CreateClient(mockTransport);

            Assert.ThrowsAsync<RequestFailedException>(async () =>
            {
                await client.GetPetAsync("snoopy", new RequestContext()
                {
                    ErrorOptions = ErrorOptions.Default
                });
            });
        }

        [Test]
        public async Task CanAddPerCallPolicy()
        {
            var petResponse = new MockResponse(200);

            Pet pet = new("snoopy", "beagle");
            petResponse.SetContent(SerializationHelpers.Serialize(pet, SerializePet));

            var mockTransport = new MockTransport(petResponse);
            PetStoreClient client = CreateClient(mockTransport);

            var context = new RequestContext();
            context.AddPolicy(new AddHeaderPolicy("PerCallHeader", "Value"), HttpPipelinePosition.PerCall);

            Response response = await client.GetPetAsync("snoopy", context);

            Request request = mockTransport.Requests[0];
            Assert.IsTrue(request.Headers.TryGetValues("PerCallHeader", out var values));
            Assert.AreEqual(1, values.Count());
            Assert.AreEqual("Value", values.ElementAt(0));
        }

        [Test]
        public async Task CanAddPerRetryPolicy()
        {
            var retryResponse = new MockResponse(408); // Request Timeout
            var petResponse = new MockResponse(200);

            Pet pet = new("snoopy", "beagle");
            petResponse.SetContent(SerializationHelpers.Serialize(pet, SerializePet));

            // retry twice -- this will add the header three times.
            var mockTransport = new MockTransport(retryResponse, retryResponse, petResponse);
            PetStoreClient client = CreateClient(mockTransport);

            var context = new RequestContext();
            context.AddPolicy(new AddHeaderPolicy("PerRetryHeader", "Value"), HttpPipelinePosition.PerRetry);

            Response response = await client.GetPetAsync("snoopy", context);

            Request request = mockTransport.Requests[0];
            Assert.IsTrue(request.Headers.TryGetValues("PerRetryHeader", out var values));
            Assert.AreEqual(3, values.Count());
            Assert.AreEqual("Value", values.ElementAt(0));
            Assert.AreEqual("Value", values.ElementAt(1));
            Assert.AreEqual("Value", values.ElementAt(2));
        }

        [Test]
        public async Task CanAddBeforeTransportPolicy()
        {
            var retryResponse = new MockResponse(408); // Request Timeout
            var petResponse = new MockResponse(200);

            Pet pet = new("snoopy", "beagle");
            petResponse.SetContent(SerializationHelpers.Serialize(pet, SerializePet));

            // retry twice
            var mockTransport = new MockTransport(retryResponse, retryResponse, petResponse);
            PetStoreClient client = CreateClient(mockTransport);

            var context = new RequestContext();
            context.AddPolicy(new AddHeaderPolicy("BeforeTransportHeader", "Value"), HttpPipelinePosition.BeforeTransport);

            Response response = await client.GetPetAsync("snoopy", context);

            Request request = mockTransport.Requests[0];
            Assert.IsTrue(request.Headers.TryGetValues("BeforeTransportHeader", out var values));
            Assert.AreEqual(3, values.Count());
            Assert.AreEqual("Value", values.ElementAt(0));
            Assert.AreEqual("Value", values.ElementAt(1));
            Assert.AreEqual("Value", values.ElementAt(2));
        }

        [Test]
        public async Task CanAddPoliciesAllPositions()
        {
            var retryResponse = new MockResponse(408); // Request Timeout
            var petResponse = new MockResponse(200);

            Pet pet = new("snoopy", "beagle");
            petResponse.SetContent(SerializationHelpers.Serialize(pet, SerializePet));

            // retry twice -- this will add the header three times.
            var mockTransport = new MockTransport(retryResponse, retryResponse, petResponse);
            PetStoreClient client = CreateClient(mockTransport);

            var context = new RequestContext();
            context.AddPolicy(new AddHeaderPolicy("PerCallHeader1", "PerCall1"), HttpPipelinePosition.PerCall);
            context.AddPolicy(new AddHeaderPolicy("PerCallHeader2", "PerCall2"), HttpPipelinePosition.PerCall);
            context.AddPolicy(new AddHeaderPolicy("PerRetryHeader", "PerRetry"), HttpPipelinePosition.PerRetry);
            context.AddPolicy(new AddHeaderPolicy("BeforeTransportHeader", "BeforeTransport"), HttpPipelinePosition.BeforeTransport);

            Response response = await client.GetPetAsync("snoopy", context);

            Request request = mockTransport.Requests[0];

            Assert.IsTrue(request.Headers.TryGetValues("PerCallHeader1", out var perCall1Values));
            Assert.AreEqual(1, perCall1Values.Count());
            Assert.AreEqual("PerCall1", perCall1Values.ElementAt(0));

            Assert.IsTrue(request.Headers.TryGetValues("PerCallHeader2", out var perCall2Values));
            Assert.AreEqual(1, perCall2Values.Count());
            Assert.AreEqual("PerCall2", perCall2Values.ElementAt(0));

            Assert.IsTrue(request.Headers.TryGetValues("PerRetryHeader", out var perRetryValues));
            Assert.AreEqual("PerRetry", perRetryValues.ElementAt(0));
            Assert.AreEqual("PerRetry", perRetryValues.ElementAt(1));
            Assert.AreEqual("PerRetry", perRetryValues.ElementAt(2));

            Assert.IsTrue(request.Headers.TryGetValues("BeforeTransportHeader", out var beforeTransportValues));
            Assert.AreEqual("BeforeTransport", beforeTransportValues.ElementAt(0));
            Assert.AreEqual("BeforeTransport", beforeTransportValues.ElementAt(1));
            Assert.AreEqual("BeforeTransport", beforeTransportValues.ElementAt(2));
        }

        [Test]
        public async Task ThrowsIfUsePipelineConstructor()
        {
            HttpPipeline pipeline = new HttpPipeline(new MockTransport());

            var context = new RequestContext();
            context.AddPolicy(new AddHeaderPolicy("PerCallHeader", "Value"), HttpPipelinePosition.PerCall);

            var message = pipeline.CreateMessage(context);

            bool throws = false;
            try
            {
                await pipeline.SendAsync(message, context.CancellationToken);
            }
            catch (InvalidOperationException)
            {
                throws = true;
            }

            Assert.IsTrue(throws);
        }

        #region Helpers
        private void SerializePet(ref Utf8JsonWriter writer, Pet pet)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("name");
            writer.WriteStringValue(pet.Name);

            writer.WritePropertyName("species");
            writer.WriteStringValue(pet.Species);

            writer.WriteEndObject();
        }

        public class AddHeaderPolicy : HttpPipelineSynchronousPolicy
        {
            private string _headerName;
            private string _headerVaue;

            public AddHeaderPolicy(string headerName, string headerValue) : base()
            {
                _headerName = headerName;
                _headerVaue = headerValue;
            }

            public override void OnSendingRequest(HttpMessage message)
            {
                message.Request.Headers.Add(_headerName, _headerVaue);
            }
        }
        #endregion
    }
}
