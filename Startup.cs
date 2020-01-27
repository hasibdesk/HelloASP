using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloASP.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HelloASP
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeter, Greeter>();
            services.AddSingleton<IRestaurantData, InMemoryRestaurantData>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc(configureRoutes);
            app.Run(async (context) =>
            {
                context.Response.ContentType = "text/plain";
                
                await context.Response.WriteAsync("<h1>Hello World</h1>");
            });
        }

        private void configureRoutes(IRouteBuilder routesBuilder)
        {
            // /Home/Index
            routesBuilder.MapRoute("Default", "{controller}/{action}/{id?}");
        }
    }
}
