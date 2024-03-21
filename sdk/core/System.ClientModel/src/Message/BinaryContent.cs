﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Buffers;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.ClientModel;

/// <summary>
/// Represents binary content that can be sent to a cloud service as part of
/// a <see cref="PipelineRequest"/>.
/// </summary>
public abstract class BinaryContent : IDisposable
{
    private static readonly ModelReaderWriterOptions ModelWriteWireOptions = new ModelReaderWriterOptions("W");

    /// <summary>
    /// Creates an instance of <see cref="BinaryContent"/> that contains the
    /// bytes held in the provided <see cref="BinaryData"/> instance.
    /// </summary>
    /// <param name="value">The <see cref="BinaryData"/> containing the bytes
    /// this <see cref="BinaryContent"/> will hold.</param>
    /// <returns>An an instance of <see cref="BinaryContent"/> that contains the
    /// bytes held in the provided <see cref="BinaryData"/> instance.</returns>
    public static BinaryContent Create(BinaryData value)
        => new BinaryDataBinaryContent(value.ToMemory());

    /// <summary>
    /// Creates an instance of <see cref="BinaryContent"/> that contains the
    /// bytes resulting from writing the value of the provided
    /// <see cref="IPersistableModel{T}"/>.
    /// </summary>
    /// <param name="model">The <see cref="IPersistableModel{T}"/> to write.</param>
    /// <param name="options">The <see cref="ModelReaderWriterOptions"/>, if any,
    /// that indicates what format the <paramref name="model"/> will be written in.
    /// </param>
    /// <returns>An instance of <see cref="BinaryContent"/> that wraps a <see cref="IPersistableModel{T}"/>.</returns>
    public static BinaryContent Create<T>(T model, ModelReaderWriterOptions? options = default) where T : IPersistableModel<T>
        => new ModelBinaryContent<T>(model, options ?? ModelWriteWireOptions);

    /// <summary>
    /// Creates an instance of <see cref="BinaryContent"/> that contains the
    /// bytes held in the provided <see cref="Stream"/> instance.
    /// </summary>
    /// <param name="stream">The <see cref="Stream"/> containing the bytes
    /// this <see cref="BinaryContent"/> will hold.</param>
    /// <returns>An an instance of <see cref="BinaryContent"/> that contains the
    /// bytes held in the provided <see cref="Stream"/> instance.</returns>
    public static BinaryContent Create(Stream stream)
        => new StreamBinaryContent(stream);

    /// <summary>
    /// Attempts to compute the length of the underlying body content, if available.
    /// </summary>
    /// <param name="length">The length of the underlying data.</param>
    public abstract bool TryComputeLength(out long length);

    /// <summary>
    /// Writes contents of this <see cref="BinaryContent"/> instance to the
    /// provided <see cref="Stream"/>.
    /// </summary>
    /// <param name="stream">The stream to write the binary content to.</param>
    /// <param name="cancellationToken">To <see cref="CancellationToken"/> to
    /// use for the write operation.</param>
    public abstract Task WriteToAsync(Stream stream, CancellationToken cancellationToken = default);

    /// <summary>
    /// Writes contents of this <see cref="BinaryContent"/> instance to the
    /// provided <see cref="Stream"/>.
    /// </summary>
    /// <param name="stream">The stream to write the binary content to.</param>
    /// <param name="cancellationToken">To <see cref="CancellationToken"/> to
    /// use for the write operation.</param>
    public abstract void WriteTo(Stream stream, CancellationToken cancellationToken = default);

    /// <inheritdoc/>
    public abstract void Dispose();

    private sealed class BinaryDataBinaryContent : BinaryContent
    {
        private readonly ReadOnlyMemory<byte> _bytes;

        public BinaryDataBinaryContent(ReadOnlyMemory<byte> bytes)
        {
            _bytes = bytes;
        }

        public override bool TryComputeLength(out long length)
        {
            length = _bytes.Length;
            return true;
        }

        public override void WriteTo(Stream stream, CancellationToken cancellation)
        {
            byte[] buffer = _bytes.ToArray();
            stream.Write(buffer, 0, buffer.Length);
        }

        public override async Task WriteToAsync(Stream stream, CancellationToken cancellation)
            => await stream.WriteAsync(_bytes, cancellation).ConfigureAwait(false);

        public override void Dispose() { }
    }

    private sealed class ModelBinaryContent<T> : BinaryContent where T : IPersistableModel<T>
    {
        private readonly T _model;
        private readonly ModelReaderWriterOptions _options;

        // Used when _model is an IJsonModel
        private UnsafeBufferSequence.Reader? _sequenceReader;

        // Used when _model is an IModel
        private BinaryData? _data;

        public ModelBinaryContent(T model, ModelReaderWriterOptions options)
        {
            _model = model;
            _options = options;
        }

        private UnsafeBufferSequence.Reader SequenceReader
        {
            get
            {
                if (_model is not IJsonModel<T> jsonModel)
                {
                    throw new InvalidOperationException("Cannot use Writer with non-IJsonModel model type.");
                }

                _sequenceReader ??= new ModelWriter<T>(jsonModel, _options).ExtractReader();
                return _sequenceReader;
            }
        }

        private BinaryData Data
        {
            get
            {
                if (ModelReaderWriter.ShouldWriteAsJson(_model, _options))
                {
                    throw new InvalidOperationException("Should use ModelWriter instead of _model.Write with IJsonModel.");
                }

                _data ??= _model.Write(_options);
                return _data;
            }
        }

        public override bool TryComputeLength(out long length)
        {
            length = ModelReaderWriter.ShouldWriteAsJson(_model, _options) ? SequenceReader.Length : Data.ToMemory().Length;

            return true;
        }

#if NETFRAMEWORK || NETSTANDARD2_0
        private byte[]? _bytes;
        private byte[] Bytes => _bytes ??= Data.ToArray();
#endif

        public override void WriteTo(Stream stream, CancellationToken cancellation)
        {
            if (ModelReaderWriter.ShouldWriteAsJson(_model, _options))
            {
                SequenceReader.CopyTo(stream, cancellation);
                return;
            }

#if NETFRAMEWORK || NETSTANDARD2_0
            stream.Write(Bytes, 0, Bytes.Length);
#else
            stream.Write(Data.ToMemory().Span);
#endif
        }

        public override async Task WriteToAsync(Stream stream, CancellationToken cancellation)
        {
            if (ModelReaderWriter.ShouldWriteAsJson(_model, _options))
            {
                await SequenceReader.CopyToAsync(stream, cancellation).ConfigureAwait(false);
                return;
            }

            await stream.WriteAsync(Data.ToMemory(), cancellation).ConfigureAwait(false);
        }

        public override void Dispose()
        {
            var sequenceReader = _sequenceReader;
            if (sequenceReader != null)
            {
                _sequenceReader = null;
                sequenceReader.Dispose();
            }
        }
    }

    private sealed class StreamBinaryContent : BinaryContent
    {
        private readonly Stream _stream;
        private readonly long _origin;

        public StreamBinaryContent(Stream stream)
        {
            if (!stream.CanSeek)
            {
                throw new ArgumentException("Stream must be seekable.", nameof(stream));
            }

            _stream = stream;
            _origin = stream.Position;
        }

        public override bool TryComputeLength(out long length)
        {
            // CanSeek is validated in constructor - it will always be true.
            length = _stream.Length - _origin;
            return true;
        }

        public override void WriteTo(Stream stream, CancellationToken cancellationToken)
        {
            _stream.Seek(_origin, SeekOrigin.Begin);
            _stream.CopyTo(stream, cancellationToken);
            _stream.Flush();
        }

        public override async Task WriteToAsync(Stream stream, CancellationToken cancellationToken)
        {
            _stream.Seek(_origin, SeekOrigin.Begin);
            await _stream.CopyToAsync(stream, cancellationToken).ConfigureAwait(false);
            await _stream.FlushAsync(cancellationToken).ConfigureAwait(false);
        }

        public override void Dispose()
        {
            _stream.Dispose();
        }
    }
}
