// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.WebHooks.Filters;
using Microsoft.AspNetCore.WebHooks.Metadata;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Methods to add services for the Dropbox receiver.
    /// </summary>
    internal static class DropboxServiceCollectionSetup
    {
        /// <summary>
        /// Add services for the Dropbox receiver.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to update.</param>
        public static void AddDropboxServices(IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            WebHookMetadata.Register<DropboxMetadata>(services);
            services.TryAddSingleton<DropboxVerifySignatureFilter>();
        }
    }
}
