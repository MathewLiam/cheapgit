namespace cheapgit.web
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Piranha;
    using Piranha.AttributeBuilder;
    using Piranha.AspNetCore.Identity.SQLServer;
    using Piranha.Data.EF.SQLServer;
    using Piranha.Manager.Editor;
    using cheapgit.web.Models.Blocks;
    using cheapgit.web.Models.Pages;
    using cheapgit.web.Models.Posts;

    public class Startup
    {
        private readonly IConfiguration _config;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="configuration">The current configuration</param>
        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Service setup
            services.AddPiranha(options =>
            {
                options.AddRazorRuntimeCompilation = true;

                options.UseBlobStorage(_config.GetConnectionString("blobstorage"));
                options.UseImageSharp();
                options.UseManager();
                options.UseTinyMCE();
                options.UseMemoryCache();
                options.UseEF<SQLServerDb>(db =>
                    db.UseSqlServer(_config.GetConnectionString("piranha")));
                options.UseIdentityWithSeed<IdentitySQLServerDb>(db =>
                    db.UseSqlServer(_config.GetConnectionString("piranha")));

                /***
                 * Here you can configure the different permissions
                 * that you want to use for securing content in the
                 * application.
                options.UseSecurity(o =>
                {
                    o.UsePermission("WebUser", "Web User");
                });
                 */
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApi api)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Initialize Piranha
            App.Init(api);

            // Initialize custom blocks
            App.Blocks.Register<ContactUsBlock>();


            // Build content types
            new ContentTypeBuilder(api)
                .AddAssembly(typeof(Startup).Assembly)
                .Build()
                .DeleteOrphans();

            new PageTypeBuilder(api)
                .AddType(typeof(CategoryArchive))
                .AddType(typeof(SearchLandingPage))
                .Build();

            new SiteTypeBuilder(api)
                .AddType(typeof(Store))
                .Build();

            new PostTypeBuilder(api)
                .AddType(typeof(ProductPage))
                .Build();

            // Configure Tiny MCE
            EditorConfig.FromFile("editorconfig.json");

            // Middleware setup
            app.UsePiranha(options => {
                options.UseManager();
                options.UseTinyMCE();
                options.UseIdentity();
            });

            App.Permissions["Application"].Add(new Piranha.Security.PermissionItem
            {
                Name = "WebUser",
                Title = "Web User"
            });
        }
    }
}
