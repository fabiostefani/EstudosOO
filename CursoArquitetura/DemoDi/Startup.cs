using DemoDi.Casos.Generics;
using DemoDi.Casos.LifeCycle;
using DemoDi.Casos.MultiplasClasses;
using DemoDi.Casos.VidaReal;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace DemoDi
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
            #region Vida Real
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            #endregion

            #region LifeCycle
            services.AddTransient<IOperacaoTransient, Operacao>(); //vários objetos  sendo criados na instância
            services.AddScoped<IOperacaoScoped, Operacao>(); //unico objeto por request
            services.AddSingleton<IOperacaoSingleton, Operacao>(); //unico objeto para toda a aplicação/instância
            services.AddSingleton<IOperacaoSingletonInstance>(new Operacao(Guid.Empty));
            services.AddTransient<OperacaoService>();
            #endregion

            #region Generics
            services.AddScoped(typeof(IRepositorioGenerico<>), typeof(RepositorioGenerico<>));
            #endregion

            #region MultiplasClasses
            services.AddTransient<ServicoA>();
            services.AddTransient<ServicoB>();
            services.AddTransient<ServicoC>();
            services.AddTransient<Func<string, IServico>>(serviceProvider => key =>
            {
                switch (key)
                {
                    case "A":
                        return serviceProvider.GetService<ServicoA>();
                    case "B":
                        return serviceProvider.GetService<ServicoB>();
                    case "C":
                        return serviceProvider.GetService<ServicoC>();
                    default:
                        return null;
                }
            });
            #endregion

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
        }
    }
}
