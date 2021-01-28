﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Azure.Core.Serialization;
using NUnit.Framework;

namespace Azure.Core.Tests
{
    public class AzureCoreExtensionsTests

    {
        [Test]
        public async Task CanCreateBinaryDataFromCustomType()
        {
            var payload = new Model { A = "value", B = 5, C = 3 };
            var serializer = new JsonObjectSerializer();

            await AssertData(await serializer.SerializeAsync(payload));
            await AssertData(serializer.Serialize(payload));
            await AssertData(await serializer.SerializeAsync(payload, typeof(Model)));
            await AssertData(serializer.Serialize(payload, typeof(Model)));
            await AssertData(await serializer.SerializeAsync(payload, null));
            await AssertData(serializer.Serialize(payload, null));

            async Task AssertData(BinaryData data)
            {
                Assert.AreEqual(payload.A, data.ToObject<Model>(serializer).A);
                Assert.AreEqual(payload.B, data.ToObject<Model>(serializer).B);
                Assert.AreEqual(0, data.ToObject<Model>(serializer).C);
                Assert.AreEqual(payload.A, (await data.ToObjectAsync<Model>(serializer)).A);
                Assert.AreEqual(payload.B, (await data.ToObjectAsync<Model>(serializer)).B);
                Assert.AreEqual(0, (await data.ToObjectAsync<Model>(serializer)).C);
            }
        }

        [Test]
        public async Task CanCreateBinaryDataFromCustomTypePassingBaseType()
        {
            var payload = new ExtendedModel() { A = "value", B = 5, C = 3, F = 5 };
            var serializer = new JsonObjectSerializer();

            await AssertData(await serializer.SerializeAsync(payload, typeof(Model)));
            await AssertData(serializer.Serialize(payload, typeof(Model)));

            async Task AssertData(BinaryData data)
            {
                Assert.AreEqual(payload.A, data.ToObject<Model>(serializer).A);
                Assert.AreEqual(payload.B, data.ToObject<Model>(serializer).B);
                Assert.AreEqual(0, data.ToObject<Model>(serializer).C);
                Assert.AreEqual(payload.A, (await data.ToObjectAsync<Model>(serializer)).A);
                Assert.AreEqual(payload.B, (await data.ToObjectAsync<Model>(serializer)).B);
                Assert.AreEqual(0, (await data.ToObjectAsync<Model>(serializer)).C);
                Assert.AreEqual(0, (await data.ToObjectAsync<ExtendedModel>(serializer)).F);
            }
        }

        [Test]
        public async Task CanCreateBinaryDataFromNullObject()
        {
            Model model = null;
            var serializer = new JsonObjectSerializer();

            await AssertData(await serializer.SerializeAsync(model));
            await AssertData(serializer.Serialize(model));
            await AssertData(await serializer.SerializeAsync(model, typeof(Model)));
            await AssertData(serializer.Serialize(model, typeof(Model)));
            await AssertData(await serializer.SerializeAsync(model, null));
            await AssertData(serializer.Serialize(model, null));

            async Task AssertData(BinaryData data)
            {
                Assert.IsNull(data.ToObject<Model>(serializer));
                Assert.IsNull(await data.ToObjectAsync<Model>(serializer));
            }
        }

        public class Model
        {
            public string A { get; set; }

            public int B { get; set; }

            [JsonIgnore]
            public int C { get; set; }
        }

        public class ExtendedModel : Model
        {
            public ExtendedModel()
            {
            }

            internal ExtendedModel(int readOnlyD)
            {
                ReadOnlyD = readOnlyD;
            }

            [JsonPropertyName("d")]
            public int ReadOnlyD { get; }

            internal int IgnoredE { get; set; }

            public int F { get; set; }
        }
    }
}
