using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Facade.CrossCutting;
using DesignPatterns.Structural.Facade.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DesignPatterns
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
            services.AddScoped<ILogger, Logger>();
            services.AddScoped<ILogNetMaster, LogNetMasterService>();
            services.AddScoped<IConfigurationManager, ConfigurationManager>();
            services.AddScoped<IPayPalGateway, PayPalGateway>();
            services.AddScoped<IPagamentoCartaoCreditoFacade, PagamentoCartaoCreditoFacade>();
            services.AddScoped<IPagamento, PagamentoCartaoCreditoService>();

            services.AddScoped<Behavioral.Strategy.CrossCutting.IPayPalGateway, Behavioral.Strategy.CrossCutting.PayPalGateway>();
            services.AddScoped<Behavioral.Strategy.CrossCutting.IConfigurationManager, Behavioral.Strategy.CrossCutting.ConfigurationManager>();

            services.AddScoped<Behavioral.Strategy.IPagamentoCartaoCreditoFacade, Behavioral.Strategy.PagamentoCartaoCreditoFacade>();
            services.AddScoped<Behavioral.Strategy.IPagamentoBoletoFacade, Behavioral.Strategy.PagamentoBoletoFacade>();
            services.AddScoped<Behavioral.Strategy.IPagamentoTransferenciaFacade, Behavioral.Strategy.PagamentoTransferenciaFacade>();
            services.AddScoped<Behavioral.Strategy.IPagamentoFactory, Behavioral.Strategy.PagamentoFactory>();
            services.AddScoped<Behavioral.Strategy.PagamentoBoletoService>();




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
