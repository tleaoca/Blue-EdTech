using Consultorio.Data;
using Consultorio.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Consultorio
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

            // Quando add um contexto, o addtransient tamb�m � executado
            services.AddDbContext<ConsultorioContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("Consultorio"))
            );


            // AddTransient � respons�vel por falar para o framework que,
            // quando a interface for necess�ria, seja utilizada a classe

            //services.AddTransient<IPacienteService, PacienteStaticService>();
            services.AddTransient<PacienteSqlService>();
            services.AddTransient<PacienteStaticService>();
            services.AddTransient<IPacienteService, PacienteSqlService>();
            services.AddTransient<IConsultaService, ConsultaSqlService>();
            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<ConsultorioContext>();
            services.AddAuthentication().AddFacebook(facebookOptions =>
                {
                    facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                    facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
                });
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    // classe / m�todo 
                    // ProdutoController -> Criar  -- 
                    // Home / Index 
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
