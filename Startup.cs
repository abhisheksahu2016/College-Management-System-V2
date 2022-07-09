using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
//
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
//
using CMS.Models.A1_DB;

namespace A1_Web_000000005
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<CMS_DBContext>(context => { context.UseInMemoryDatabase("CollegeMngtSystem"); });
            services.AddSession();
            services.AddAuthentication("CookieAuthentication")
                .AddCookie("CookieAuthentication", config =>
                {
                    config.Cookie.Name = "UserLoginCookie"; // Name of cookie     
                                                            //config.LoginPath = "/login/Login"; // Path for the redirect to user login page    
                    config.LoginPath = ""; // Path for the redirect to user login page    
                    config.AccessDeniedPath = "/Home/UserAccessDenied";
                });

            //services.AddAuthorization(config =>
            //{
            //    config.AddPolicy("UserPolicy", policyBuilder =>
            //    {
            //        policyBuilder.UserRequireCustomClaim(ClaimTypes.Name);
            //        policyBuilder.UserRequireCustomClaim(ClaimTypes.Name);
            //    });
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseSession();
            app.UseAuthentication();
            //app.UseAuthorization();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=login}/{action=Index}/{id?}");
            });
        }
    }
}
