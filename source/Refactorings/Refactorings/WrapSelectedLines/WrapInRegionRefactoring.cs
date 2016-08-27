﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Pihrtsoft.CodeAnalysis.CSharp.Refactorings.WrapSelectedLines
{
    internal class WrapInRegionRefactoring : WrapSelectedLinesRefactoring
    {
        public override bool Indent
        {
            get { return true; }
        }

        public override string GetFirstLineText()
        {
            return "#region";
        }

        public override string GetLastLineText()
        {
            return "#endregion";
        }
    }
}
