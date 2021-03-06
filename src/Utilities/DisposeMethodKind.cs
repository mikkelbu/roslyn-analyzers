﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Analyzer.Utilities
{
    /// <summary>
    /// Describes different kinds of Dispose-like methods.
    /// </summary>
    public enum DisposeMethodKind
    {
        /// <summary>
        /// Not a dispose-like method.
        /// </summary>
        None,

        /// <summary>
        /// An override of <see cref="System.IDisposable.Dispose"/>.
        /// </summary>
        Dispose,

        /// <summary>
        /// A virtual method named Dispose that takes a single Boolean parameter, as
        /// is used when implementing the standard Dispose pattern.
        /// </summary>
        DisposeBool,

        /// <summary>
        /// A method named Close on a type that implements <see cref="System.IDisposable"/>.
        /// </summary>
        Close
    }
}
