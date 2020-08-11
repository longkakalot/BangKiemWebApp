using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BangKiemWebApp.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BangKiemWebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //public sealed class ConnectionString  
        //{  
        //    public ConnectionString(string value) => Value = value;  
  
        //    public string Value { get; }  
        //}  

        public class ConnectionStrings
        {
            public string Db06 { get; set; }

            public string Db29 { get; set; }
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<ConnectionStrings>(Configuration.GetSection("ConnectionStrings"));
            //var connectionString06 = new ConnectionString(Configuration.GetConnectionString("Db06")); 
            //services.AddSingleton(connectionString06);

            services.AddTransient<IDanhMucRepo, DanhMucRepo>();
            services.AddTransient<INoiDungRepo, NoiDungRepo>();
            services.AddTransient<IBenhNhanRepo, BenhNhanRepo>();
            services.AddTransient<IBangKiemRepo, BangKiemRepo>();
            services.AddTransient<IBaoCaoRepo, BaoCaoRepo>();

            //services.AddSingleton<DapperBaseRepo>();
            services.AddHttpContextAccessor();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            loggerFactory.AddFile("Logs/mylog-{Date}.txt");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
