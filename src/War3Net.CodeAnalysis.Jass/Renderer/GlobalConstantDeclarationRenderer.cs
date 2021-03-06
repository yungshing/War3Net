﻿// ------------------------------------------------------------------------------
// <copyright file="GlobalConstantDeclarationRenderer.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

#pragma warning disable SA1649 // File name should match first type name

using War3Net.CodeAnalysis.Jass.Syntax;

namespace War3Net.CodeAnalysis.Jass.Renderer
{
    public partial class JassRenderer
    {
        public void Render(GlobalConstantDeclarationSyntax globalConstantDeclaration)
        {
            if (_options.InlineConstants) // TODO: don't inline if the expression is relatively large? (compared to its entire declaration)
            {
                _constants.Add(globalConstantDeclaration.IdentifierNameNode.ValueText, globalConstantDeclaration.EqualsValueClause.ValueNode);
            }
            else
            {
                Render(globalConstantDeclaration.ConstantKeywordToken);
                WriteSpace();
                Render(globalConstantDeclaration.TypeNameNode);
                WriteSpace();
                Render(globalConstantDeclaration.IdentifierNameNode);
                Render(globalConstantDeclaration.EqualsValueClause);
                Render(globalConstantDeclaration.LineDelimiterNode);
            }
        }
    }
}