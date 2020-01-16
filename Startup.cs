using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Programatica.DummyApp.Mvc.Context;
using Programatica.DummyApp.Mvc.Handlers;
using Programatica.DummyApp.Mvc.Models;
using Programatica.Framework.Core.Adapter;
using Programatica.Framework.Data.Context;
using Programatica.Framework.Data.Models;
using Programatica.Framework.Data.Repository;
using Programatica.Framework.Services;
using Programatica.Framework.Services.Handlers;
using Programatica.Framework.Services.Injector;

namespace Programatica.DummyApp.Mvc
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
            // sqlserver context
            // uncomment this to use sql server
            //services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // inmemory context
            // comment this to use sql server
             SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(Configuration.GetConnectionString("DefaultConnection"));
            services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase(builder.InitialCatalog));

            // context
            services.AddTransient<IDbContext, AppDbContext>();

            // repository
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            // adapters
            services.AddTransient<IDateTimeAdapter, DateTimeAdapter>();
            services.AddTransient<IAuthUserAdapter, AuthUserAdapter>();
            services.AddTransient<IJsonSerializerAdapter, JsonSerializerAdapter>();


            // event handler
            services.AddTransient<IEventHandler<User>, UserValidatorEventHandler>();
            services.AddTransient<IEventHandler<User>, AuditEventHandler<User>>();
            services.AddTransient<IList<IEventHandler<User>>>(p => p.GetServices<IEventHandler<User>>().ToList());
            services.AddTransient<IList<IEventHandler<TrackChange>>>(p => p.GetServices<IEventHandler<TrackChange>>().ToList());

            // injector
            services.AddTransient(typeof(IInjector<>), typeof(Injector<>));

            // service
            services.AddTransient(typeof(IService<>), typeof(Service<>));


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
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

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
