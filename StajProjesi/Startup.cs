using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using StajProjesi.Data.Entities;
using StajProjesi.Data;

namespace StajProjesi
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
            services.AddDbContext<Data.StajProjesiContext>(o => o.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddDbContext<UserContext>(o => o.UseSqlServer(Configuration["ConnectionStrings:IdentityConnection"]));
            //services.AddDbContext<UserContext>();


            services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<UserContext>();

            //services.AddIdentity<AppUser, IdentityRole>(opt =>
            // {
            //     //opt.Password.RequireDigit = false;
            //     //opt.Password.RequireLowercase = false;
            //     //opt.Password.RequiredLength = 1;
            //     //opt.Password.RequireUppercase = false;
            //     //opt.Password.RequireNonAlphanumeric = false;
            // }).AddEntityFrameworkStores<UserContext>();

            //services.AddIdentityCore<AppUser>(opt =>
            // {
            //     //opt.Password.RequireDigit = false;
            //     //opt.Password.RequireLowercase = false;
            //     //opt.Password.RequiredLength = 1;
            //     //opt.Password.RequireUppercase = false;
            //     //opt.Password.RequireNonAlphanumeric = false;
            // }).AddEntityFrameworkStores<UserContext>();

            services.AddControllersWithViews();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
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

            //IdentityInitializer.OlusturAdmin(userManager, roleManager);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
