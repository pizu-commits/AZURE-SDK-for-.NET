﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.Json;

namespace Azure.AI.InkRecognizer.Models
{
    /// <summary>
    /// The InkRecognitionUnit class represents a single entity recognized by the InkRecognizer service.
    /// </summary>
    public abstract class InkRecognitionUnit : IEquatable<InkRecognitionUnit>
    {
        /// <summary>
        /// Represents unique identifier for the model unit.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Represents the category of model unit.
        /// </summary>
        public InkRecognitionUnitKind Kind { get; }

        /// <summary>
        /// The parent of a model unit is the unit containing current unit.
        /// </summary>
        public InkRecognitionUnit Parent { get; internal set; } = null;

        /// <summary>
        /// The children of a model unit represent the units contained in a container unit.
        /// An example is the relationship between a line and the words on the line.
        /// </summary>
        public IEnumerable<InkRecognitionUnit> Children { get; internal set; } = null;

        /// <summary>
        /// The rectangular area that contains all the strokes in a model unit.
        /// </summary>
        public RectangleF BoundingBox { get; internal set; }

        /// <summary>
        /// The rotated bounding box is the oriented rectangular area that contains all the
        /// strokes in a model unit.
        /// </summary>
        public IEnumerable<PointF> RotatedBoundingBox { get; }

        /// <summary>
        /// Returns the stroke ids for the strokes that are part of the model unit
        /// </summary>
        public IEnumerable<long> StrokeIds { get; }

        // internal members
        internal List<long> ChildIds { get; set; }
        internal long ParentId { get; set; }

        /// <summary>
        /// Protected constructor to allow mocking
        /// </summary>
        protected InkRecognitionUnit()
        {

        }

        internal InkRecognitionUnit(JsonElement recoUnitJson)
        {
            ChildIds = new List<long>();

            Id = recoUnitJson.GetProperty("id").GetInt64();
            Kind = GetInkRecognitionUnitKind(recoUnitJson.GetProperty("category").GetString());
            ParentId = recoUnitJson.GetProperty("parentId").GetInt64();
            JsonElement childrenIdJson;

            var strokeIdJson = recoUnitJson.GetProperty("strokeIds").EnumerateArray();
            var strokeIds = new List<long>();
            foreach (var strokeId in strokeIdJson)
            {
                strokeIds.Add(strokeId.GetInt64());
            }
            StrokeIds = strokeIds;

            var rotatedRectMembers = recoUnitJson.GetProperty("rotatedBoundingRectangle").EnumerateArray();
            var rotatedBoundingBox = new List<PointF>();
            foreach (var pointProperties in rotatedRectMembers)
            {
                var point = new PointF();
                foreach (var coordinates in pointProperties.EnumerateObject())
                {
                    if (coordinates.Name == "x")
                    {
                        point.X = (float)coordinates.Value.GetDouble();
                    }
                    else if (coordinates.Name == "y")
                    {
                        point.Y = (float)coordinates.Value.GetDouble();
                    }
                }
                rotatedBoundingBox.Add(point);
            }
            RotatedBoundingBox = rotatedBoundingBox;

            var boundingRectJson = recoUnitJson.GetProperty("boundingRectangle").EnumerateObject();
            RectangleF boundingBox = new RectangleF();
            foreach (var rectProperty in boundingRectJson)
            {
                if (rectProperty.Name == "topX")
                {
                    boundingBox.X = (float)rectProperty.Value.GetDouble();
                }
                else if (rectProperty.Name == "topY")
                {
                    boundingBox.Y = (float)rectProperty.Value.GetDouble();
                }
                else if (rectProperty.Name == "width")
                {
                    boundingBox.Width = (float)rectProperty.Value.GetDouble();
                }
                else if (rectProperty.Name == "height")
                {
                    boundingBox.Height = (float)rectProperty.Value.GetDouble();
                }
            }
            BoundingBox = boundingBox;

            var hasChildren = recoUnitJson.TryGetProperty("childIds", out childrenIdJson);
            if (hasChildren)
            {
                foreach (var childId in childrenIdJson.EnumerateArray())
                {
                    ChildIds.Add(childId.GetInt64());
                }
            }
        }

        private InkRecognitionUnitKind GetInkRecognitionUnitKind(string recoUnitKindString)
        {
            switch (recoUnitKindString)
            {
                case "writingRegion":
                    return InkRecognitionUnitKind.RecognizedWritingRegion;
                case "paragraph":
                    return InkRecognitionUnitKind.RecognizedParagraph;
                case "line":
                    return InkRecognitionUnitKind.RecognizedLine;
                case "inkWord":
                    return InkRecognitionUnitKind.InkWord;
                case "inkBullet":
                    return InkRecognitionUnitKind.InkBullet;
                case "inkDrawing":
                    return InkRecognitionUnitKind.InkDrawing;
                case "root":
                    return InkRecognitionUnitKind.RecognizedRoot;
                default:
                    throw new InvalidEnumArgumentException("Invalid InkRecognitionUnitKind");
            }
        }

        /// <summary>
        /// Check if two InkRecognitionUnit objects are equal.
        /// </summary>
        /// <param name="other">The object to compare to.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Equals(InkRecognitionUnit other)
        {
            if (other != null && Id == other.Id)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns a hash code for InkRecognitionUnit object.
        /// </summary>
        /// <returns>Hash code for the current InkRecognitionUnit object</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    /// <summary>
    /// The Unclassified class represents the collection of one or more ink strokes that were not
    /// recognized.
    /// </summary>
    public class Unclassified : InkRecognitionUnit
    {
        internal Unclassified(JsonElement recoUnitJson) : base(recoUnitJson)
        {
        }
    }
    /// <summary>
    /// The WritingRegion represents a certain part of a writing surface that the user has written at least
    /// one word on.
    /// </summary>
    public class RecognizedWritingRegion : InkRecognitionUnit
    {
        internal RecognizedWritingRegion(JsonElement recoUnitJson) : base(recoUnitJson)
        {}

        /// <summary>
        /// The recognized string within the writingRegion
        /// </summary>
        public string RecognizedText {
            get {
                return string.Join("\n\n",
                Children.Select(paragraph => ((RecognizedParagraph)paragraph).RecognizedText));
            }
        }

        /// <summary>
        /// The paragraphs within the writing region
        /// </summary>
        public IEnumerable<RecognizedParagraph> Paragraphs {
            get
            {
                return Children.Select(child => child as RecognizedParagraph);
            }
        }
    }

    /// <summary>
    /// The Paragraph class represents the collection of one or more ink strokes that were recognized
    /// as a paragraph
    /// </summary>
    public class RecognizedParagraph : InkRecognitionUnit
    {
        internal RecognizedParagraph(JsonElement recoUnitJson) : base(recoUnitJson)
        {}

        /// <summary>
        /// The recognized string within the paragraph
        /// </summary>
        public string RecognizedText {
            get{
                return string.Join("\n",
                Children.Select(line => ((RecognizedLine)line).RecognizedText));
            }
        }

        /// <summary>
        /// The lines within the paragraph
        /// </summary>
        public IEnumerable<RecognizedLine> Lines {
            get
            {
                return Children.Select(child => child as RecognizedLine);
            }
        }
    }

    /// <summary>
    /// The ListItem class represents the collection of one or more ink strokes that were recognized
    /// as a list - set of lines with bullets.
    /// </summary>
    public class RecognizedListItem : InkRecognitionUnit
    {
        internal RecognizedListItem(JsonElement recoUnitJson) : base(recoUnitJson)
        { }
    }

    /// <summary>
    /// The Line class represents the collection of one or more ink strokes that were recognized as a line
    /// </summary>
    public class RecognizedLine : InkRecognitionUnit
    {
        internal RecognizedLine(JsonElement recoUnitJson) : base(recoUnitJson)
        {
            var alternates = new List<string>();
            var alternatesJson = recoUnitJson.GetProperty("alternates").EnumerateArray();
            RecognizedText = recoUnitJson.GetProperty("recognizedText").GetString();

            foreach (var alternateJson in alternatesJson)
            {
                foreach(var alternateProperty in alternateJson.EnumerateObject())
                {
                    if (alternateProperty.Name == "recognizedString")
                    {
                        var recognizedString = alternateProperty.Value.GetString();
                        alternates.Add(recognizedString);
                    }
                }
            }
            Alternates = alternates;
        }

        /// <summary>
        /// The recognized string with the highest likelihood value.
        /// </summary>
        public string RecognizedText { get; }

        /// <summary>
        /// The bullet on the line if one is present.
        /// </summary>
        public InkBullet Bullet {
            get
            {
                foreach (var child in Children)
                {
                    if (child.Kind == InkRecognitionUnitKind.InkBullet)
                    {
                        return (InkBullet)child;
                    }
                }
                return null;
            }
        }
        /// <summary>
        /// A list of alternate line of words.
        /// </summary>
        public IEnumerable<string> Alternates { get; } = null;

        /// <summary>
        /// The words on the line.
        /// </summary>
        public IEnumerable<InkWord> Words {
            get
            {
                var words = new List<InkWord>();
                foreach (var child in Children)
                {
                    if (child.Kind == InkRecognitionUnitKind.InkWord)
                    {
                        var word = (InkWord)child;
                        words.Add(word);
                    }
                }
                return words;
            }
        }
    }

    /// <summary>
    /// The InkShape class represents the collection of one or more ink strokes that were recognized as
    /// a drawing/shape
    /// </summary>
    public class InkDrawing : InkRecognitionUnit
    {
        /// <summary>
        /// A list of InkDrawing objects when the confidence isn't 1.
        /// </summary>
        public IEnumerable<InkDrawing> Alternates { get; }

        /// <summary>
        /// The center point of the bounding rectangle of the model unit.
        /// </summary>
        public PointF Center { get; }

        /// <summary>
        /// A number between 0 and 1 which indicates the confidence level in the result.
        /// </summary>
        public float Confidence { get; }

        /// <summary>
        /// Array of point objects that represent points that are relevant to the type of shape.
        /// For example, for a triangle, points would include the x,y coordinates of the vertices of the
        /// recognized triangle. The points represent the coordinates of points used to create the perfectly
        /// drawn shape that is closest to the original input. They may not exactly match.
        /// </summary>
        public IEnumerable<PointF> Points { get; }

        /// <summary>
        /// The RecognizedShape enum representing the geometric shape that was recognized. If the drawing isn't one of
        /// the known geometric shapes, the value "Drawing" is returned.
        /// </summary>
        public RecognizedShape RecognizedShape { get; }

        /// <summary>
        /// The angular orientation of an object relative to the horizontal axis.
        /// </summary>
        public float RotationAngle { get; }

        internal InkDrawing(JsonElement recoUnitJson) : base(recoUnitJson)
        {
            foreach (var property in recoUnitJson.EnumerateObject())
            {
                if (property.Name == "center")
                {
                    var x = 0.0f;
                    var y = 0.0f;

                    foreach (var centerProperty in property.Value.EnumerateObject())
                    {
                        if (centerProperty.Name == "x")
                        {
                            x = (float)centerProperty.Value.GetDouble();
                        }
                        else if (centerProperty.Name == "y")
                        {
                            y = (float)centerProperty.Value.GetDouble();
                        }
                    }
                    Center = new PointF(x, y);
                }
                else if (property.Name == "points")
                {
                    var points = new List<PointF>();
                    foreach (var pointProperties in property.Value.EnumerateArray())
                    {
                        var point = new PointF();
                        foreach (var pointProperty in pointProperties.EnumerateObject())
                        {
                            if (pointProperty.Name == "x")
                            {
                                point.X = (float)pointProperty.Value.GetDouble();
                            }
                            else if (pointProperty.Name == "y")
                            {
                                point.Y = (float)pointProperty.Value.GetDouble();
                            }
                        }
                        points.Add(point);
                    }
                    Points = points.AsReadOnly();
                }
                else if (property.Name == "recognizedObject")
                {
                    RecognizedShape = GetShape(property.Value.GetString());
                }
                else if (property.Name == "alternates")
                {
                    var alternates = new List<InkDrawing>();
                    foreach (var alternateJson in property.Value.EnumerateArray())
                    {
                        var alternate = new InkDrawing(alternateJson);
                        alternates.Add(alternate);
                    }
                    Alternates = alternates;
                }
                else if (property.Name == "rotationAngle")
                {
                    RotationAngle = (float)property.Value.GetDouble();
                }
                else if (property.Name == "confidence")
                {
                    Confidence = (float)property.Value.GetDouble();
                }
            }
        }

        private RecognizedShape GetShape(string shapeString)
        {
            switch (shapeString)
            {
                case "drawing":
                    return RecognizedShape.Drawing;
                case "square":
                    return RecognizedShape.Square;
                case "rectangle":
                    return RecognizedShape.Rectangle;
                case "circle":
                    return RecognizedShape.Circle;
                case "ellipse":
                    return RecognizedShape.Ellipse;
                case "triangle":
                    return RecognizedShape.Triangle;
                case "isoscelesTriangle":
                    return RecognizedShape.Isoscelestriangle;
                case "equilateralTriangle":
                    return RecognizedShape.EquilateralTriangle;
                case "rightTriangle":
                    return RecognizedShape.RightTriangle;
                case "quadrilateral":
                    return RecognizedShape.Quadrilateral;
                case "diamond":
                    return RecognizedShape.Diamond;
                case "trapezoid":
                    return RecognizedShape.Trapezoid;
                case "parallelogram":
                    return RecognizedShape.Parallelogram;
                case "pentagon":
                    return RecognizedShape.Pentagon;
                case "hexagon":
                    return RecognizedShape.Hexagon;
                case "blockArrow":
                    return RecognizedShape.Blockarrow;
                case "heart":
                    return RecognizedShape.Heart;
                case "starSimple":
                    return RecognizedShape.Starsimple;
                case "starCrossed":
                    return RecognizedShape.Starcrossed;
                case "cloud":
                    return RecognizedShape.Cloud;
                case "line":
                    return RecognizedShape.Line;
                case "curve":
                    return RecognizedShape.Curve;
                case "polyLine":
                    return RecognizedShape.Polyline;
                default:
                    throw new Exception("Invalid value for Shape kind");
            }
        }
    }

    /// <summary>
    /// The InkWord class represents a collection of one or more ink strokes that were recognized as a
    /// word.
    /// </summary>
    public class InkWord : InkRecognitionUnit
    {
        internal InkWord(JsonElement recoUnitJson) : base(recoUnitJson)
        {
            RecognizedText = recoUnitJson.GetProperty("recognizedText").GetString();
            var alternateObject = recoUnitJson.GetProperty("alternates").EnumerateArray();
            var alternates = new List<string>();
            foreach (var alternateJson in alternateObject)
            {
                var recognizedString = alternateJson.GetProperty("recognizedString").GetString();
                alternates.Add(recognizedString);
            }
            Alternates = alternates;
        }

        /// <summary>
        /// The recognized string with the highest likelihood value.
        /// </summary>
        public string RecognizedText { get; }

        /// <summary>
        /// A list of alternate recognized words
        /// </summary>
        public IEnumerable<string> Alternates { get; }
    }

    /// <summary>
    /// The InkBullet class represents the collection of one or more ink strokes that were recognized as a
    /// bullet point on a line
    /// </summary>
    public class InkBullet : InkRecognitionUnit
    {
        internal InkBullet(JsonElement recoUnitJson) : base(recoUnitJson)
        {
            RecognizedText = recoUnitJson.GetProperty("recognizedText").GetString();
        }

        /// <summary>
        /// The recognized string of the bullet. If the bullet isn't recognized as a string (e.g. when the
        /// bullet is a complex shape), an empty string is returned.
        /// </summary>
        public string RecognizedText { get; }
    }

    /// <summary>
    /// The InkRecognitionUnitKind has all the different categories of model units available from the service.
    /// </summary>
    public enum InkRecognitionUnitKind
    {
        /// <summary>
        /// The root of the tree of recognition units returned by the service
        /// </summary>
        RecognizedRoot = 0,

        /// <summary>
        /// A writing region is a part of the writing surface that contains words.
        /// </summary>
        RecognizedWritingRegion = 1,

        /// <summary>
        /// A paragraph
        /// </summary>
        RecognizedParagraph = 2,

        /// <summary>
        /// A line
        /// </summary>
        RecognizedLine = 3,

        /// <summary>
        /// A drawing
        /// </summary>
        InkDrawing = 4,

        /// <summary>
        /// A word
        /// </summary>
        InkWord = 5,

        /// <summary>
        /// A bullet on a line of text
        /// </summary>
        InkBullet = 6,
        /// <summary>
        /// A list -collection of lines with bullets
        /// </summary>
        listItem = 7

    }

    /// <summary>
    /// The RecognizedShape enum represents different shapes that can be reported by the
    /// InkRecognizer service. Any unrecognized shape will be reported as "DRAWING"
    /// </summary>
    public enum RecognizedShape
    {
        Drawing = 0,
        Square = 1,
        Rectangle = 2,
        Circle = 3,
        Ellipse = 4,
        Triangle = 5,
        Isoscelestriangle = 6,
        EquilateralTriangle = 7,
        RightTriangle = 8,
        Quadrilateral = 9,
        Diamond = 10,
        Trapezoid = 11,
        Parallelogram = 12,
        Pentagon = 13,
        Hexagon = 14,
        Blockarrow = 15,
        Heart = 16,
        Starsimple = 17,
        Starcrossed = 18,
        Cloud = 19,
        Line = 20,
        Curve = 21,
        Polyline = 22
    }
}
