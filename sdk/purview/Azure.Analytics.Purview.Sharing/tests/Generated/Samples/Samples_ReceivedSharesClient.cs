// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Purview.Sharing;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Analytics.Purview.Sharing.Samples
{
    public class Samples_ReceivedSharesClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetReceivedShare()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            Response response = client.GetReceivedShare("<receivedShareId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("shareKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetReceivedShare_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            Response response = await client.GetReceivedShareAsync("<receivedShareId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("shareKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetReceivedShare_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            Response response = client.GetReceivedShare("<receivedShareId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("shareKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetReceivedShare_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            Response response = await client.GetReceivedShareAsync("<receivedShareId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("shareKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ActivateTenantEmailRegistration()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new object());
            Response response = client.ActivateTenantEmailRegistration(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ActivateTenantEmailRegistration_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new object());
            Response response = await client.ActivateTenantEmailRegistrationAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ActivateTenantEmailRegistration_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    activationCode = "<activationCode>",
                },
            });
            Response response = client.ActivateTenantEmailRegistration(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("properties").GetProperty("activationCode").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("activationExpiration").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("email").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("registrationStatus").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("state").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("tenantId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ActivateTenantEmailRegistration_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    activationCode = "<activationCode>",
                },
            });
            Response response = await client.ActivateTenantEmailRegistrationAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("properties").GetProperty("activationCode").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("activationExpiration").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("email").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("registrationStatus").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("state").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("tenantId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RegisterTenantEmailRegistration()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            Response response = client.RegisterTenantEmailRegistration(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RegisterTenantEmailRegistration_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            Response response = await client.RegisterTenantEmailRegistrationAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_RegisterTenantEmailRegistration_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            Response response = client.RegisterTenantEmailRegistration(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("properties").GetProperty("activationCode").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("activationExpiration").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("email").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("registrationStatus").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("state").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("tenantId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_RegisterTenantEmailRegistration_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            Response response = await client.RegisterTenantEmailRegistrationAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("properties").GetProperty("activationCode").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("activationExpiration").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("email").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("registrationStatus").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("state").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("tenantId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAllAttachedReceivedShares()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            foreach (BinaryData item in client.GetAllAttachedReceivedShares("<referenceName>", null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("shareKind").ToString());
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAllAttachedReceivedShares_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            await foreach (BinaryData item in client.GetAllAttachedReceivedSharesAsync("<referenceName>", null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("shareKind").ToString());
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAllAttachedReceivedShares_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            foreach (BinaryData item in client.GetAllAttachedReceivedShares("<referenceName>", "<filter>", "<orderby>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("shareKind").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAllAttachedReceivedShares_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            await foreach (BinaryData item in client.GetAllAttachedReceivedSharesAsync("<referenceName>", "<filter>", "<orderby>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("shareKind").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAllDetachedReceivedShares()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            foreach (BinaryData item in client.GetAllDetachedReceivedShares(null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("shareKind").ToString());
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAllDetachedReceivedShares_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            await foreach (BinaryData item in client.GetAllDetachedReceivedSharesAsync(null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("shareKind").ToString());
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetAllDetachedReceivedShares_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            foreach (BinaryData item in client.GetAllDetachedReceivedShares("<filter>", "<orderby>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("shareKind").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetAllDetachedReceivedShares_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            await foreach (BinaryData item in client.GetAllDetachedReceivedSharesAsync("<filter>", "<orderby>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("shareKind").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("type").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrReplaceReceivedShare()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                properties = new object(),
                shareKind = "InPlace",
            });
            Operation<BinaryData> operation = client.CreateOrReplaceReceivedShare(WaitUntil.Completed, "<receivedShareId>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("shareKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrReplaceReceivedShare_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                properties = new object(),
                shareKind = "InPlace",
            });
            Operation<BinaryData> operation = await client.CreateOrReplaceReceivedShareAsync(WaitUntil.Completed, "<receivedShareId>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("shareKind").ToString());
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrReplaceReceivedShare_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    assetStoreKind = "AdlsGen2Account",
                    displayName = "<displayName>",
                    shareStatus = "Detached",
                    sink = new
                    {
                        properties = new
                        {
                            containerName = "<containerName>",
                            folder = "<folder>",
                            mountPath = "<mountPath>",
                        },
                        storeKind = "AdlsGen2Account",
                        storeReference = new
                        {
                            referenceName = "<referenceName>",
                            type = "ArmResourceReference",
                        },
                    },
                },
                shareKind = "InPlace",
            });
            Operation<BinaryData> operation = client.CreateOrReplaceReceivedShare(WaitUntil.Completed, "<receivedShareId>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("shareKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrReplaceReceivedShare_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            RequestContent content = RequestContent.Create(new
            {
                properties = new
                {
                    assetStoreKind = "AdlsGen2Account",
                    displayName = "<displayName>",
                    shareStatus = "Detached",
                    sink = new
                    {
                        properties = new
                        {
                            containerName = "<containerName>",
                            folder = "<folder>",
                            mountPath = "<mountPath>",
                        },
                        storeKind = "AdlsGen2Account",
                        storeReference = new
                        {
                            referenceName = "<referenceName>",
                            type = "ArmResourceReference",
                        },
                    },
                },
                shareKind = "InPlace",
            });
            Operation<BinaryData> operation = await client.CreateOrReplaceReceivedShareAsync(WaitUntil.Completed, "<receivedShareId>", content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("shareKind").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteReceivedShare()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            Operation<BinaryData> operation = client.DeleteReceivedShare(WaitUntil.Completed, "<receivedShareId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteReceivedShare_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            Operation<BinaryData> operation = await client.DeleteReceivedShareAsync(WaitUntil.Completed, "<receivedShareId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeleteReceivedShare_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            Operation<BinaryData> operation = client.DeleteReceivedShare(WaitUntil.Completed, "<receivedShareId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeleteReceivedShare_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            ReceivedSharesClient client = new ReceivedSharesClient(endpoint, credential);

            Operation<BinaryData> operation = await client.DeleteReceivedShareAsync(WaitUntil.Completed, "<receivedShareId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("error").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }
    }
}
