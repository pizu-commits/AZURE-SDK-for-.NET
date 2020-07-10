﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.AI.FormRecognizer.Training;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// TODO.
    /// </summary>
    public static class FormRecognizerModelFactory
    {
        // TODO: Should we include Operations?

        /// <summary>
        /// Initializes a new instance of the <see cref="Training.AccountProperties"/> class.
        /// </summary>
        /// <param name="customModelCount">The current count of trained custom models.</param>
        /// <param name="customModelLimit">The maximum number of models that can be trained for this subscription.</param>
        /// <returns>A new <see cref="Training.AccountProperties"/> instance for mocking.</returns>
        public static AccountProperties AccountProperties(int customModelCount, int customModelLimit) =>
            new AccountProperties(customModelCount, customModelLimit);

        // TODO: BoundingBox
        // TODO: CopyAuthorization
        // TODO: CustomFormModel

        /// <summary>
        /// Initializes a new instance of the <see cref="Training.CustomFormModelField"/> class.
        /// </summary>
        /// <param name="name">Canonical name; uniquely identifies a field within the form.</param>
        /// <param name="label">The label of this field on the form.</param>
        /// <param name="accuracy">The estimated recognition accuracy for this field.</param>
        /// <returns>A new <see cref="Training.CustomFormModelField"/> instance for mocking.</returns>
        public static CustomFormModelField CustomFormModelField(string name, string label, float? accuracy) =>
            new CustomFormModelField(name, label, accuracy);

        /// <summary>
        /// Initializes a new instance of the <see cref="Training.CustomFormModelInfo"/> class.
        /// </summary>
        /// <param name="modelId">The unique identifier of the model.</param>
        /// <param name="trainingStartedOn">The date and time (UTC) when model training was started.</param>
        /// <param name="trainingCompletedOn">The date and time (UTC) when model training completed.</param>
        /// <param name="status">The status of the model.</param>
        /// <returns>A new <see cref="Training.CustomFormModelInfo"/> instance for mocking.</returns>
        public static CustomFormModelInfo CustomFormModelInfo(string modelId, DateTimeOffset trainingStartedOn, DateTimeOffset trainingCompletedOn, CustomFormModelStatus status) =>
            new CustomFormModelInfo(modelId, trainingStartedOn, trainingCompletedOn, status);

        /// <summary>
        /// Initializes a new instance of the <see cref="Training.CustomFormSubmodel"/> class.
        /// </summary>
        /// <param name="formType">The type of form this submodel recognizes.</param>
        /// <param name="accuracy">The mean of the accuracies of this model's <see cref="Training.CustomFormModelField"/> instances.</param>
        /// <param name="fields">A dictionary of the fields that this submodel will recognize from the input document.</param>
        /// <returns>A new <see cref="Training.CustomFormSubmodel"/> instance for mocking.</returns>
        public static CustomFormSubmodel CustomFormSubmodel(string formType, float? accuracy, IReadOnlyDictionary<string, CustomFormModelField> fields) =>
            new CustomFormSubmodel(formType, accuracy, fields);

        // TODO: FieldData
        // TODO: FieldValue
        // TODO: should we include mockability for FormElement?
        // TODO: FormField
        // TODO: should we add for FormField{T}?

        /// <summary>
        /// Initializes a new instance of the <see cref="Models.FormLine"/> class.
        /// </summary>
        /// <param name="boundingBox">The quadrilateral bounding box that outlines the text of this element.</param>
        /// <param name="pageNumber">The 1-based number of the page in which this element is present.</param>
        /// <param name="text">The text of this form element.</param>
        /// <param name="words">A list of the words that make up the line.</param>
        /// <returns>A new <see cref="Models.FormLine"/> instance for mocking.</returns>
        public static FormLine FormLine(BoundingBox boundingBox, int pageNumber, string text, IReadOnlyList<FormWord> words) =>
            new FormLine(boundingBox, pageNumber, text, words);

        /// <summary>
        /// Initializes a new instance of the <see cref="Models.FormPage"/> class.
        /// </summary>
        /// <param name="pageNumber">The 1-based page number in the input document.</param>
        /// <param name="width">The width of the image/PDF in pixels/inches, respectively.</param>
        /// <param name="height">The height of the image/PDF in pixels/inches, respectively.</param>
        /// <param name="textAngle">The general orientation of the text in clockwise direction, measured in degrees between (-180, 180].</param>
        /// <param name="unit">The unit used by the width, height and <see cref="BoundingBox"/> properties. For images, the unit is &quot;pixel&quot;. For PDF, the unit is &quot;inch&quot;.</param>
        /// <param name="lines">A list of recognized lines of text.</param>
        /// <param name="tables">A list of recognized tables contained in this page.</param>
        /// <returns>A new <see cref="Models.FormPage"/> instance for mocking.</returns>
        public static FormPage FormPage(int pageNumber, float width, float height, float textAngle, LengthUnit unit, IReadOnlyList<FormLine> lines, IReadOnlyList<FormTable> tables) =>
            new FormPage(pageNumber, width, height, textAngle, unit, lines, tables);

        // TODO: FormPageCollection

        /// <summary>
        /// Initializes a new instance of the <see cref="Models.FormPageRange"/> struct.
        /// </summary>
        /// <param name="firstPageNumber">The first page number of the range.</param>
        /// <param name="lastPageNumber">The last page number of the range.</param>
        /// <returns>A new <see cref="Models.FormPageRange"/> instance for mocking.</returns>
        public static FormPageRange FormPageRange(int firstPageNumber, int lastPageNumber) =>
            new FormPageRange(firstPageNumber, lastPageNumber);

        /// <summary>
        /// Initializes a new instance of the <see cref="Models.FormRecognizerError"/> class.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="message">The error message.</param>
        /// <returns>A new <see cref="Models.FormRecognizerError"/> instance for mocking.</returns>
        public static FormRecognizerError FormRecognizerError(string errorCode, string message) =>
            new FormRecognizerError(errorCode, message);

        /// <summary>
        /// Initializes a new instance of the <see cref="Models.FormTable"/> class.
        /// </summary>
        /// <param name="pageNumber">The 1-based number of the page in which this table is present.</param>
        /// <param name="columnCount">The number of columns in this table.</param>
        /// <param name="rowCount">The number of rows in this table.</param>
        /// <param name="cells">A list of cells contained in this table.</param>
        /// <returns>A new <see cref="Models.FormTable"/> instance for mocking.</returns>
        public static FormTable FormTable(int pageNumber, int columnCount, int rowCount, IReadOnlyList<FormTableCell> cells) =>
            new FormTable(pageNumber, columnCount, rowCount, cells);

        /// <summary>
        /// Initializes a new instance of the <see cref="Models.FormTableCell"/> class.
        /// </summary>
        /// <param name="boundingBox">The quadrilateral bounding box that outlines the text of this element.</param>
        /// <param name="pageNumber">The 1-based number of the page in which this element is present.</param>
        /// <param name="text">The text of this form element.</param>
        /// <param name="columnIndex">The column index of the cell.</param>
        /// <param name="rowIndex">The row index of the cell.</param>
        /// <param name="columnSpan">The number of columns spanned by this cell.</param>
        /// <param name="rowSpan">The number of rows spanned by this cell.</param>
        /// <param name="isHeader"><c>true</c> if this cell is a header cell. Otherwise, <c>false</c>.</param>
        /// <param name="isFooter"><c>true</c> if this cell is a footer cell. Otherwise, <c>false</c>.</param>
        /// <param name="confidence">Measures the degree of certainty of the recognition result.</param>
        /// <param name="fieldElements">A list of references to the field elements constituting this cell.</param>
        /// <returns>A new <see cref="Models.FormTableCell"/> instance for mocking.</returns>
        public static FormTableCell FormTableCell(BoundingBox boundingBox, int pageNumber, string text, int columnIndex, int rowIndex, int columnSpan, int rowSpan, bool isHeader, bool isFooter, float confidence, IReadOnlyList<FormElement> fieldElements) =>
            new FormTableCell(boundingBox, pageNumber, text, columnIndex, rowIndex, columnSpan, rowSpan, isHeader, isFooter, confidence, fieldElements);

        /// <summary>
        /// Initializes a new instance of the <see cref="Models.FormWord"/> class.
        /// </summary>
        /// <param name="boundingBox">The quadrilateral bounding box that outlines the text of this element.</param>
        /// <param name="pageNumber">The 1-based number of the page in which this element is present.</param>
        /// <param name="text">The text of this form element.</param>
        /// <param name="confidence">Measures the degree of certainty of the recognition result.</param>
        /// <returns>A new <see cref="Models.FormWord"/> instance for mocking.</returns>
        public static FormWord FormWord(BoundingBox boundingBox, int pageNumber, string text, float confidence) =>
            new FormWord(boundingBox, pageNumber, text, confidence);

        // TODO: RecognizedForm
        // TODO: RecognizedFormCollection
        // TODO: RecognizeOptions?

        /// <summary>
        /// Initializes a new instance of the <see cref="Training.TrainingDocumentInfo"/> class.
        /// </summary>
        /// <param name="documentName">Training document name.</param>
        /// <param name="pageCount">Total number of pages trained.</param>
        /// <param name="errors">List of errors.</param>
        /// <param name="status">Status of the training operation.</param>
        /// <returns>A new <see cref="Training.TrainingDocumentInfo"/> instance for mocking.</returns>
        public static TrainingDocumentInfo TrainingDocumentInfo(string documentName, int pageCount, IEnumerable<FormRecognizerError> errors, TrainingStatus status) =>
            new TrainingDocumentInfo(documentName, pageCount, errors, status);

        // TODO: TrainingFileFilter??? Shouldn't it have a public constructor?
    }
}
