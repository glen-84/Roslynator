﻿// Copyright (c) Josef Pihrt and Contributors. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections;

namespace Roslynator.Collections;

internal class Enumerator : IEnumerator
{
    public static readonly IEnumerator Instance = new Enumerator();

    protected Enumerator()
    {
    }

    public object Current
    {
        get { throw new InvalidOperationException(); }
    }

    public bool MoveNext()
    {
        return false;
    }

    public void Reset()
    {
        throw new InvalidOperationException();
    }
}
