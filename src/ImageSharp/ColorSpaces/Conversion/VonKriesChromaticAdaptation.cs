﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System.Numerics;
using SixLabors.ImageSharp.ColorSpaces.Conversion.Implementation;

namespace SixLabors.ImageSharp.ColorSpaces.Conversion
{
    /// <summary>
    /// Basic implementation of the von Kries chromatic adaptation model
    /// </summary>
    /// <remarks>
    /// Transformation described here:
    /// http://www.brucelindbloom.com/index.html?Eqn_ChromAdapt.html
    /// </remarks>
    public class VonKriesChromaticAdaptation : IChromaticAdaptation
    {
        private readonly CieXyzAndLmsConverter converter;

        /// <summary>
        /// Initializes a new instance of the <see cref="VonKriesChromaticAdaptation"/> class.
        /// </summary>
        public VonKriesChromaticAdaptation()
            : this(new CieXyzAndLmsConverter())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VonKriesChromaticAdaptation"/> class.
        /// </summary>
        /// <param name="transformationMatrix">
        /// The transformation matrix used for the conversion (definition of the cone response domain).
        /// <see cref="LmsAdaptationMatrix"/>
        /// </param>
        public VonKriesChromaticAdaptation(Matrix4x4 transformationMatrix)
            : this(new CieXyzAndLmsConverter(transformationMatrix))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VonKriesChromaticAdaptation"/> class.
        /// </summary>
        /// <param name="converter">The color converter</param>
        internal VonKriesChromaticAdaptation(CieXyzAndLmsConverter converter) => this.converter = converter;

        /// <inheritdoc/>
        public CieXyz Transform(in CieXyz sourceColor, in CieXyz sourceWhitePoint, in CieXyz targetWhitePoint)
        {
            if (sourceWhitePoint.Equals(targetWhitePoint))
            {
                return sourceColor;
            }

            Lms sourceColorLms = this.converter.Convert(sourceColor);
            Lms sourceWhitePointLms = this.converter.Convert(sourceWhitePoint);
            Lms targetWhitePointLms = this.converter.Convert(targetWhitePoint);

            Vector3 vector = targetWhitePointLms.ToVector3() / sourceWhitePointLms.ToVector3();
            var targetColorLms = new Lms(Vector3.Multiply(vector, sourceColorLms.ToVector3()));

            return this.converter.Convert(targetColorLms);
        }
    }
}