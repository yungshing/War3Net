﻿// ------------------------------------------------------------------------------
// <copyright file="IntegerGameStateApi.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

#pragma warning disable CA1707 // Identifiers should not contain underscores
#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable SA1310 // Field names should not contain underscore
#pragma warning disable SA1401 // Fields should be private

using War3Net.Runtime.Common.Enums;

namespace War3Net.Runtime.Common.Api.Enums
{
    public static class IntegerGameStateApi
    {
        public static readonly IntegerGameState GAME_STATE_DIVINE_INTERVENTION = ConvertIGameState((int)IntegerGameState.Type.DivineIntervention);
        public static readonly IntegerGameState GAME_STATE_DISCONNECTED = ConvertIGameState((int)IntegerGameState.Type.Disconnected);

        public static IntegerGameState ConvertIGameState(int i)
        {
            return IntegerGameState.GetIntegerGameState(i);
        }
    }
}