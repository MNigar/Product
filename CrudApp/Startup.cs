using CrudApp.Db;
using CrudApp.Resource;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp
{
   
    public class Startup
    {
        public IConfiguration _configuration { get; private set; }
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ProductContext>(options =>
            {
                options.UseSqlServer(_configuration["ConnectionStrings:DefaultConnection"]);
            });

            services.AddMvc().AddViewLocalization().AddDataAnnotationsLocalization(opt => {

                opt.DataAnnotationLocalizerProvider = (type, factory) => factory.Create(typeof(SharedResource));
            });
            services.Configure<RequestLocalizationOptions>(op =>
            {
                var supportedCultures = new List<CultureInfo>
                {
                    new CultureInfo("az"),
                    new CultureInfo("en")            
                };
                op.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("az");
                op.SupportedCultures = supportedCultures;
                op.SupportedUICultures = supportedCultures;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            //app.UseStaticFiles(new StaticFileOptions
            //{
            //    FileProvider = new PhysicalFileProvider(
            //        Path.Combine(Directory.GetCurrentDirectory(), "Templates")),
            //    RequestPath = "/StaticFiles"
            //});
            //app.UseStaticFiles(new StaticFileOptions
            //{
            //    FileProvider = new PhysicalFileProvider(
            //         Path.Combine(Directory.GetCurrentDirectory(), "Template")),
            //    RequestPath = "/StaticFile"
            //});

            app.UseRequestLocalization();

            app.UseStatusCodePages();
            app.UseMvcWithDefaultRoute();
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
             app.UseMvc(routes =>
             {
                 routes.MapRoute(
               name: "areas",
               template: "{area:exists}/{controller=Category}/{action=Index}/{id?}");

                 routes.MapRoute(
                     name: "default",
                     template: "{controller=Product}/{action=Index}/{id?}");
             });
        }
    }
}
