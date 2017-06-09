// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Authentication
{
    /// <summary>
    /// Provides failure context information to handler providers.
    /// </summary>
    public class FailureContext : HandleRequestContext<IAuthenticationHandler>
    {
        public FailureContext(IAuthenticationHandler handler, HttpContext context, Exception failure) : base(handler, context)
            => Failure = failure;

        /// <summary>
        /// User friendly error message for the error.
        /// </summary>
        public Exception Failure { get; set; }
    }
}
