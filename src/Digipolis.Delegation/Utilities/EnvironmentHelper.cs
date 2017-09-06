﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digipolis.Delegation.Utilities
{
    public class EnvironmentHelper
    {
        public static bool IsRequiredEnvironment(IServiceCollection services, string requiredEnvironment)
        {
            var hostingEnvironment = services.BuildServiceProvider().GetRequiredService<IHostingEnvironment>();
            return hostingEnvironment.IsEnvironment(requiredEnvironment);
        }

        public static bool IsDevelopmentOrRequiredEnvironment(IServiceCollection services, string requiredEnvironment)
        {
            var hostingEnvironment = services.BuildServiceProvider().GetRequiredService<IHostingEnvironment>();
            return hostingEnvironment.IsDevelopment() || hostingEnvironment.IsEnvironment(requiredEnvironment);
        }

        public static bool IsDevelopmentEnvironment(IServiceCollection services)
        {
            var hostingEnvironment = services.BuildServiceProvider().GetRequiredService<IHostingEnvironment>();
            return hostingEnvironment.IsDevelopment();
        }
    }
}
