﻿using ITOps.ViewModelComposition;
using ITOps.ViewModelComposition.Gateway;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Divergent.CompositionGateway
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddRouting();
            services.AddViewModelComposition();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.UseCors(builder => 
                builder.AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin());
            app.RunCompositionGatewayWithDefaultRoutes();
        }
    }
}
