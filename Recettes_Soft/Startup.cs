using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Recettes_Soft.Data;
using Recettes_Soft.Data.interfaces;
using Recettes_Soft.Data.services;

namespace Recettes_Soft
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            //relier service et interface de city
            services.AddScoped<ICategRecette,CategRecetteService>();
            services.AddScoped<IRecettes_services, Recettes_service>();
            services.AddScoped<IDepense_services, DepenseServices>();
            services.AddScoped<ICategDepense, CategDepenseService>();
            services.AddScoped<IBeneficiaire, Beneficiares_Services>();
            services.AddScoped<IFonction, FonctionService>();

            var sqlconnconfig = new SqlConnectionConfiguration(Configuration.GetConnectionString("SqlDbContext"));
            services.AddSingleton(sqlconnconfig);
            services.AddServerSideBlazor(o => o.DetailedErrors = true);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
