using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web
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
            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            StaticFileOptions option = new StaticFileOptions();
            FileExtensionContentTypeProvider contentTypeProvider = (FileExtensionContentTypeProvider)option.ContentTypeProvider ??
            new FileExtensionContentTypeProvider();

            contentTypeProvider.Mappings.Add(".mem", "application/octet-stream");
            contentTypeProvider.Mappings.Add(".data", "application/octet-stream");
            contentTypeProvider.Mappings.Add(".memgz", "application/octet-stream");
            contentTypeProvider.Mappings.Add(".datagz", "application/octet-stream");
            contentTypeProvider.Mappings.Add(".unity3dgz", "application/octet-stream");
            contentTypeProvider.Mappings.Add(".jsgz", "application/x-javascript; charset=UTF-8");
            option.ContentTypeProvider = contentTypeProvider;
            app.UseStaticFiles(option);
        }
    }
}
