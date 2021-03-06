﻿using MarktVille.DAL;
using MarktVille.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MarktVille
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public Startup(IProductRepository productRepository, IStoreRepository storeRepository, ILocationRepository locationRepository,
            IUserRepository userRepository, ICategoryRepository categoryRepository, ISubCategoryRepository subCategoryRepository)
        {
            ProductRepository = productRepository;
            StoreRepository = storeRepository;
            LocationRepository = locationRepository;
            UserRepository = userRepository;
            CategoryRepository = categoryRepository;
            SubCategoryRepository = subCategoryRepository;

        }

        public IProductRepository ProductRepository { get; }

        public IStoreRepository StoreRepository { get; }

        public ILocationRepository LocationRepository { get;  }

        public IUserRepository UserRepository { get; }

        public ICategoryRepository CategoryRepository { get;  }

        public ISubCategoryRepository SubCategoryRepository { get; }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           services.AddDbContext<DatabaseDb>(options =>
           
           options.UseSqlServer(Configuration.GetConnectionString("Ville_dev"))
           );

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            }
        );

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IStoreRepository, StoreRepository>();
            services.AddSingleton<ILocationRepository, LocationRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<ICategoryRepository, CategoryRepository>();
            services.AddSingleton<ISubCategoryRepository, SubCategoryRepository>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    //spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
