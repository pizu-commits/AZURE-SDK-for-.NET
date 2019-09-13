﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.InkRecognizer
{
    class HttpErrorDetails
    {
        string _errorCode;
        string _message;
        string _target;
        string _fullMessage = string.Empty;
        List<HttpErrorDetails> _details;

        public HttpErrorDetails(string errorJson)
        {
            var document = JsonDocument.Parse(errorJson);
            Parse(document.RootElement);
        }

        private void Parse(JsonElement errorResponse)
        {
            _details = new List<HttpErrorDetails>();

            foreach (var errorProperty in errorResponse.EnumerateObject())
            {
                if (errorProperty.Name == "code")
                {
                    _errorCode = errorProperty.Value.GetString();
                }
                else if (errorProperty.Name == "message")
                {
                    _message = errorProperty.Value.GetString();
                }
                else if (errorProperty.Name == "target")
                {
                    _target = errorProperty.Value.GetString();
                }
                else if (errorProperty.Name == "details")
                {
                    foreach (var errorDetail in errorProperty.Value.EnumerateArray())
                    {
                        _details.Add(new HttpErrorDetails(errorDetail.ToString()));
                    }
                }
            }
        }

        public override string ToString()
        {
            if (_fullMessage == string.Empty)
            {
                string msg = "";
                msg += (_errorCode != null) ? "Http Error code : " + _errorCode + ";" : "";
                msg += (_target != null) ? " Target : " + _target + ";" : "";
                msg += (_message != null) ? "Message : " + _message + ";" : "";

                if (_details.Count != 0)
                {
                    msg += "\n Error Details : ";
                    foreach (var errDetail in _details)
                    {
                        msg += "\n" + errDetail.ToString();
                    }
                }
                _fullMessage = msg;
            }
            return _fullMessage;
        }
    }
}
