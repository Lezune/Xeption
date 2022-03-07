﻿// ---------------------------------------------------------------
// Copyright (c) Hassan Habib All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;

namespace Xeption
{
    public static class XeptionExtensions
    {
        public static bool IsFrom(this Exception exception, string origin) =>
            exception.TargetSite?.ReflectedType?.Name == origin;

        public static bool IsNotFrom(this Exception exception, string origin) =>
            exception.TargetSite?.ReflectedType?.Name != origin;
    }
}
