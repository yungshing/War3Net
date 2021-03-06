﻿// ------------------------------------------------------------------------------
// <copyright file="PathingType.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;

namespace War3Net.Runtime.Common.Enums
{
    public sealed class PathingType
    {
        private static readonly Dictionary<int, PathingType> _types = GetTypes().ToDictionary(t => (int)t, t => new PathingType(t));

        private readonly Type _type;

        private PathingType(Type type)
        {
            _type = type;
        }

        public enum Type
        {
            Any = 0,
            Walkability = 1,
            Flyability = 2,
            Buildability = 3,
            PeonHarvestPathing = 4,
            BlightPathing = 5,
            Floatability = 6,
            AmphibiousPathing = 7,
        }

        public static PathingType GetPathingType(int i)
        {
            if (!_types.TryGetValue(i, out var pathingType))
            {
                pathingType = new PathingType((Type)i);
                _types.Add(i, pathingType);
            }

            return pathingType;
        }

        private static IEnumerable<Type> GetTypes()
        {
            foreach (Type type in Enum.GetValues(typeof(Type)))
            {
                yield return type;
            }
        }
    }
}