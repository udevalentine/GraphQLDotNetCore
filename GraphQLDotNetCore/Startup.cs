using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQLDotNetCore.Domain.Model;
using GraphQLDotNetCore.GraphQl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GraphQLDotNetCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Add Server service
            services.AddDbContext<MyAppContext>(opt =>
         opt.UseSqlServer(Configuration.GetConnectionString("GraphQl"), sqlServerOptionsAction: sqlOptions =>
         {
             sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 3,
                        maxRetryDelay: TimeSpan.FromSeconds(30),
                        errorNumbersToAdd: null);
         })
         , ServiceLifetime.Transient
         );
            services.AddControllers();
            services.AddTransient<IDependencyResolver>(f => new FuncDependencyResolver(f.GetRequiredService));
            services.AddTransient<GraphSchema>();
            services.AddGraphQL(f => f.ExposeExceptions = true)
                .AddGraphTypes(ServiceLifetime.Transient);
            services.Configure<KestrelServerOptions>(option => option.AllowSynchronousIO = true);
            services.Configure<IISServerOptions>(option => option.AllowSynchronousIO = true);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseGraphQL<GraphSchema>();
            app.UseGraphQLPlayground(options: new GraphQLPlaygroundOptions());
        }
    }
}
