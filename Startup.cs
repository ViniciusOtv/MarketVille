using MarktVille.DAL;
using MarktVille.Repository;
using MarktVille.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;

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

        public ILocationRepository LocationRepository { get; }

        public IUserRepository UserRepository { get; }

        public ICategoryRepository CategoryRepository { get; }

        public ISubCategoryRepository SubCategoryRepository { get; }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
           services.AddDbContext<DatabaseDb>(options =>
           
           options.UseSqlServer(Configuration.GetConnectionString("Ville_dev"))
           );

            services.Configure<CookiePolicyOptions>(options =>
            {
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

            services.AddSingleton<IProductService, ProductService>();

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddSerilog();
            });
        }

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
                    
                }
            });
        }
    }
}