﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
namespace Microsoft.AdvocacyPlatform.Functions.Tests.Mocks.Module
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.AdvocacyPlatform.Contracts;
    using Microsoft.AdvocacyPlatform.Functions.Tests.Mocks.Client;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Module for AzureTranscriberMock.
    /// </summary>
    public class AzureTranscriberMockModule : Module
    {
        /// <summary>
        /// Loads a collection of services.
        /// </summary>
        /// <param name="services">The collection of services.</param>
        public override void Load(IServiceCollection services)
        {
            services.AddScoped<ITranscriber, AzureTranscriberMock>();
        }
    }
}
