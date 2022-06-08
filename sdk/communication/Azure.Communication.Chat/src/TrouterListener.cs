// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Communication.Chat.Models;
using Azure.Communication.Chat.TrouterStubs;
using Azure.Core;

namespace Azure.Communication.Chat
{
    internal class TrouterListener
    {
        public event EventHandler<TrouterRequest> TrouterRequestReceived;

        public Task<TrouterResponse> OnTrouterRequest(TrouterRequest request)
        {
            if (TrouterRequestReceived != null)
            {
                TrouterRequestReceived?.Invoke(this, request);
            }

            return Task.FromResult(new TrouterResponse());
        }
    }
}
