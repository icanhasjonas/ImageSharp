﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SixLabors.ImageSharp.ColorSpaces.Conversion.Implementation;

namespace SixLabors.ImageSharp.ColorSpaces.Conversion
{
    /// <content>
    /// Allows conversion to <see cref="Hsl"/>.
    /// </content>
    public partial class ColorSpaceConverter
    {
        private static readonly HslAndRgbConverter HslAndRgbConverter = new HslAndRgbConverter();

        /// <summary>
        /// Converts a <see cref="CieLab"/> into a <see cref="Hsl"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="Hsl"/></returns>
        public Hsl ToHsl(in CieLab color)
        {
            var xyzColor = this.ToCieXyz(color);

            return this.ToHsl(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="CieLab"/> into <see cref="Hsl"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(Span<CieLab> source, Span<Hsl> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref CieLab sourceRef = ref MemoryMarshal.GetReference(source);
            ref Hsl destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref CieLab sp = ref Unsafe.Add(ref sourceRef, i);
                ref Hsl dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHsl(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="CieLch"/> into a <see cref="Hsl"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="Hsl"/></returns>
        public Hsl ToHsl(in CieLch color)
        {
            var xyzColor = this.ToCieXyz(color);

            return this.ToHsl(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="CieLch"/> into <see cref="Hsl"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(Span<CieLch> source, Span<Hsl> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref CieLch sourceRef = ref MemoryMarshal.GetReference(source);
            ref Hsl destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref CieLch sp = ref Unsafe.Add(ref sourceRef, i);
                ref Hsl dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHsl(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="CieLchuv"/> into a <see cref="Hsl"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="Hsl"/></returns>
        public Hsl ToHsl(in CieLchuv color)
        {
            var xyzColor = this.ToCieXyz(color);

            return this.ToHsl(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="CieLchuv"/> into <see cref="Hsl"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(Span<CieLchuv> source, Span<Hsl> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref CieLchuv sourceRef = ref MemoryMarshal.GetReference(source);
            ref Hsl destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref CieLchuv sp = ref Unsafe.Add(ref sourceRef, i);
                ref Hsl dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHsl(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="CieLuv"/> into a <see cref="Hsl"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="Hsl"/></returns>
        public Hsl ToHsl(in CieLuv color)
        {
            var xyzColor = this.ToCieXyz(color);

            return this.ToHsl(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="CieLuv"/> into <see cref="Hsl"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(Span<CieLuv> source, Span<Hsl> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref CieLuv sourceRef = ref MemoryMarshal.GetReference(source);
            ref Hsl destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref CieLuv sp = ref Unsafe.Add(ref sourceRef, i);
                ref Hsl dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHsl(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="CieXyy"/> into a <see cref="Hsl"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="Hsl"/></returns>
        public Hsl ToHsl(in CieXyy color)
        {
            var xyzColor = this.ToCieXyz(color);

            return this.ToHsl(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="CieXyy"/> into <see cref="Hsl"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(Span<CieXyy> source, Span<Hsl> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref CieXyy sourceRef = ref MemoryMarshal.GetReference(source);
            ref Hsl destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref CieXyy sp = ref Unsafe.Add(ref sourceRef, i);
                ref Hsl dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHsl(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="CieXyz"/> into a <see cref="Hsl"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="Hsl"/></returns>
        public Hsl ToHsl(in CieXyz color)
        {
            var rgb = this.ToRgb(color);

            return HslAndRgbConverter.Convert(rgb);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="CieXyz"/> into <see cref="Hsl"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(Span<CieXyz> source, Span<Hsl> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref CieXyz sourceRef = ref MemoryMarshal.GetReference(source);
            ref Hsl destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref CieXyz sp = ref Unsafe.Add(ref sourceRef, i);
                ref Hsl dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHsl(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="Cmyk"/> into a <see cref="Hsl"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="Hsl"/></returns>
        public Hsl ToHsl(in Cmyk color)
        {
            var rgb = this.ToRgb(color);

            return HslAndRgbConverter.Convert(rgb);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="Cmyk"/> into <see cref="Hsl"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(Span<Cmyk> source, Span<Hsl> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref Cmyk sourceRef = ref MemoryMarshal.GetReference(source);
            ref Hsl destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref Cmyk sp = ref Unsafe.Add(ref sourceRef, i);
                ref Hsl dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHsl(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="Hsv"/> into a <see cref="Hsl"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="Hsl"/></returns>
        public Hsl ToHsl(in Hsv color)
        {
            var rgb = this.ToRgb(color);

            return HslAndRgbConverter.Convert(rgb);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="Hsv"/> into <see cref="Hsl"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(Span<Hsv> source, Span<Hsl> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref Hsv sourceRef = ref MemoryMarshal.GetReference(source);
            ref Hsl destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref Hsv sp = ref Unsafe.Add(ref sourceRef, i);
                ref Hsl dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHsl(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="HunterLab"/> into a <see cref="Hsl"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="Hsl"/></returns>
        public Hsl ToHsl(in HunterLab color)
        {
            var xyzColor = this.ToCieXyz(color);

            return this.ToHsl(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="HunterLab"/> into <see cref="Hsl"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(Span<HunterLab> source, Span<Hsl> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref HunterLab sourceRef = ref MemoryMarshal.GetReference(source);
            ref Hsl destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref HunterLab sp = ref Unsafe.Add(ref sourceRef, i);
                ref Hsl dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHsl(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="LinearRgb"/> into a <see cref="Hsl"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="Hsl"/></returns>
        public Hsl ToHsl(in LinearRgb color)
        {
            var rgb = this.ToRgb(color);

            return HslAndRgbConverter.Convert(rgb);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="LinearRgb"/> into <see cref="Hsl"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(Span<LinearRgb> source, Span<Hsl> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref LinearRgb sourceRef = ref MemoryMarshal.GetReference(source);
            ref Hsl destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref LinearRgb sp = ref Unsafe.Add(ref sourceRef, i);
                ref Hsl dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHsl(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="Lms"/> into a <see cref="Hsl"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="Hsl"/></returns>
        public Hsl ToHsl(Lms color)
        {
            var xyzColor = this.ToCieXyz(color);

            return this.ToHsl(xyzColor);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="Lms"/> into <see cref="Hsl"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(Span<Lms> source, Span<Hsl> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref Lms sourceRef = ref MemoryMarshal.GetReference(source);
            ref Hsl destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref Lms sp = ref Unsafe.Add(ref sourceRef, i);
                ref Hsl dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHsl(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="Rgb"/> into a <see cref="Hsl"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="Hsl"/></returns>
        public Hsl ToHsl(in Rgb color) => HslAndRgbConverter.Convert(color);

        /// <summary>
        /// Performs the bulk conversion from <see cref="Rgb"/> into <see cref="Hsl"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(Span<Rgb> source, Span<Hsl> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref Rgb sourceRef = ref MemoryMarshal.GetReference(source);
            ref Hsl destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref Rgb sp = ref Unsafe.Add(ref sourceRef, i);
                ref Hsl dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHsl(sp);
            }
        }

        /// <summary>
        /// Converts a <see cref="YCbCr"/> into a <see cref="Hsl"/>
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <see cref="Hsl"/></returns>
        public Hsl ToHsl(in YCbCr color)
        {
            var rgb = this.ToRgb(color);

            return HslAndRgbConverter.Convert(rgb);
        }

        /// <summary>
        /// Performs the bulk conversion from <see cref="YCbCr"/> into <see cref="Hsl"/>
        /// </summary>
        /// <param name="source">The span to the source colors</param>
        /// <param name="destination">The span to the destination colors</param>
        /// <param name="count">The number of colors to convert.</param>
        public void Convert(Span<YCbCr> source, Span<Hsl> destination, int count)
        {
            Guard.SpansMustBeSizedAtLeast(source, nameof(source), destination, nameof(destination), count);

            ref YCbCr sourceRef = ref MemoryMarshal.GetReference(source);
            ref Hsl destRef = ref MemoryMarshal.GetReference(destination);

            for (int i = 0; i < count; i++)
            {
                ref YCbCr sp = ref Unsafe.Add(ref sourceRef, i);
                ref Hsl dp = ref Unsafe.Add(ref destRef, i);
                dp = this.ToHsl(sp);
            }
        }
    }
}