using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using ConsumeWebApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using System.Threading.Tasks;

namespace ConsumeWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<IISOptions>(iis =>
            {
                iis.AuthenticationDisplayName = "Windows";
                iis.AutomaticAuthentication = false;
            });

            // configures IIS in-proc settings
            services.Configure<IISServerOptions>(iis =>
            {
                //iis.AuthenticationDisplayName = "Windows";
                iis.AutomaticAuthentication = false;
            });
            services.AddControllersWithViews();
            IServiceCollection serviceCollection = services.AddDbContextPool<ConsumeApiDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DBConnection")));
            services.AddScoped<IRequest,RequestRepository>();
            services.AddIdentity<IdentityUser, IdentityRole>()
             .AddEntityFrameworkStores<ConsumeApiDbContext>();

            services.AddMvc(config => 
            {
              var policy = new AuthorizationPolicyBuilder()
                        .RequireAuthenticatedUser()
                        .Build();
              config.Filters.Add(new AuthorizeFilter(policy));
                });
                
            }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider services)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();
         
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                 name: "default",
                 pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        CreateRoles(services).Wait();
        }
        private async Task CreateRoles(IServiceProvider serviceProvider)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            IdentityResult roleResult;
            IdentityResult userRoleResult;
            var adminRoleCheck = await RoleManager.RoleExistsAsync("Admin");
            if (!adminRoleCheck)
            {
                roleResult = await RoleManager.CreateAsync(new IdentityRole("Admin"));
            }
            var userRoleCheck = await RoleManager.RoleExistsAsync("User");
            if (!userRoleCheck)
            {
                userRoleResult = await RoleManager.CreateAsync(new IdentityRole("User"));
                Console.WriteLine("User Role created" + userRoleCheck);
            }
            IdentityUser appUser = new IdentityUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com"
            };
            var existedUser = await UserManager.FindByEmailAsync("");
            if (existedUser == null)
            {
                IdentityResult result = await UserManager.CreateAsync(appUser, "Admin@123");
                if (result.Succeeded)
                    Console.WriteLine("User Created");

                IdentityUser user = await UserManager.FindByEmailAsync("admin@gmail.com");
                var User = new IdentityUser();
                await UserManager.AddToRoleAsync(appUser, "Admin");
            }

        }
    }
}
