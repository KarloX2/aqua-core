﻿// Copyright (c) Christof Senn. All rights reserved. See license.txt in the project root for license information.

#if NET || NETSTANDARD

namespace Aqua.TypeSystem.Emit
{
    using System;

    [AttributeUsageAttribute(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class EmittedTypeAttribute : Attribute
    {
    }
}

#endif