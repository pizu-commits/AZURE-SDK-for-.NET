﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using Azure.AI.InkRecognizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Azure.AI.InkRecognizer
{
    internal static class InkRecognitionResponse
    {
        internal static RecognitionRoot Parse(string response)
        {
            try
            {
                List<InkRecognitionUnit> recoUnits = new List<InkRecognitionUnit>();
                RecognitionRoot root = null;

                var document = JsonDocument.Parse(response);
                foreach (var property in document.RootElement.EnumerateObject())
                {
                    if (property.Name == "recognitionUnits")
                    {
                        (root, recoUnits) = _parseRecognitionUnits(property.Value);
                        if (root == null)
                        {
                            //this is the preview version
                            root = new RecognitionRoot(new JsonElement());
                        }
                        root.SetInkRecognitionUnits(recoUnits);

                        // Post process Ink Recognition units
                        _setParentAndChildrenNodes(root);
                    }
                }
                return root;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        private static Tuple<RecognitionRoot, List<InkRecognitionUnit>> _parseRecognitionUnits(JsonElement recoUnitsJson)
        {
            try
            {
                List<InkRecognitionUnit> recoUnits = new List<InkRecognitionUnit>();
                RecognitionRoot root = null;

                foreach (var recoUnitJson in recoUnitsJson.EnumerateArray())
                {
                    var category = recoUnitJson.GetProperty("category").GetString();
                    switch (category)
                    {
                        case "unknown":
                            var unclassifiedInk = new Unclassified(recoUnitJson);
                            recoUnits.Add(unclassifiedInk);
                            break;
                        case "writingRegion":
                            var recognizedWritingRegion = new RecognizedWritingRegion(recoUnitJson);
                            recoUnits.Add(recognizedWritingRegion);
                            break;
                        case "paragraph":
                            var recognizedParagraph = new RecognizedParagraph(recoUnitJson);
                            recoUnits.Add(recognizedParagraph);
                            break;
                        case "line":
                            var recognizedLine = new RecognizedLine(recoUnitJson);
                            recoUnits.Add(recognizedLine);
                            break;
                        case "inkWord":
                            var inkWord = new InkWord(recoUnitJson);
                            recoUnits.Add(inkWord);
                            break;
                        case "inkBullet":
                            var inkBullet = new InkBullet(recoUnitJson);
                            recoUnits.Add(inkBullet);
                            break;
                        case "inkDrawing":
                            var inkDrawing = new InkDrawing(recoUnitJson);
                            recoUnits.Add(inkDrawing);
                            break;
                        case "listItem":
                            var inkList = new RecognizedListItem(recoUnitJson);
                            recoUnits.Add(inkList);
                            break;
                    }
                }
                return Tuple.Create(root, recoUnits);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        private static void _setParentAndChildrenNodes(RecognitionRoot root)
        {
            var recoUnits = root.GetInkRecognitionUnits();

            foreach (var recoUnit in recoUnits)
            {
                // Set parent node and children nodes for Ink Recognition units
                _setParentNode(root, recoUnit);
                _setChildrenNodes(root, recoUnit);
            }
        }

        private static void _setParentNode(RecognitionRoot root, InkRecognitionUnit recoUnit)
        {
            var parentId = recoUnit.ParentId;
            recoUnit.Parent = root.FindInkRecognitionUnit(parentId);
        }

        private static void _setChildrenNodes(RecognitionRoot root, InkRecognitionUnit recoUnit)
        {
            var children = new List<InkRecognitionUnit>();
            if (recoUnit.ChildIds != null)
            {
                foreach (var childId in recoUnit.ChildIds)
                {
                    children.Add(root.FindInkRecognitionUnit(childId));
                }
            }
            recoUnit.Children = children;
        }
    }
}
