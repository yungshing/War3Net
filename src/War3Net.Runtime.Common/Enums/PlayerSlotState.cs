﻿// ------------------------------------------------------------------------------
// <copyright file="PlayerSlotState.cs" company="Drake53">
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
    public sealed class PlayerSlotState
    {
        private static readonly Dictionary<int, PlayerSlotState> _states = GetTypes().ToDictionary(t => (int)t, t => new PlayerSlotState(t));

        private readonly Type _type;

        private PlayerSlotState(Type type)
        {
            _type = type;
        }

        public enum Type
        {
            Empty = 0,
            Playing = 1,
            Left = 2,
        }

        public static PlayerSlotState? GetPlayerSlotState(int i)
        {
            return _states.TryGetValue(i, out var playerSlotState) ? playerSlotState : null;
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