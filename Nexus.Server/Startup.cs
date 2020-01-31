using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Nexus.Server.Model;
using Nexus.Server.Repositories;
using Nexus.Server.Services;

// ReSharper disable ConvertToUsingDeclaration

namespace Nexus.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<NexusContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("NexusReferential")));

            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            services.AddScoped<IPersonalDetailsService, PersonalDetailsService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            UpdateDatabase(app);
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(options =>
                options
                    .WithOrigins("http://localhost:5000",
                        "https://localhost:5001")
                    .AllowAnyMethod());

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
        
        private static void UpdateDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<NexusContext>())
                {
                    context.Database.Migrate();
                }
            }
        }
    }
}