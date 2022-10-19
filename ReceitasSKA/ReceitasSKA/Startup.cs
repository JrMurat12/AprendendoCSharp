using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ReceitasSKA.Data;
using ReceitasSKA.Services;
using static ReceitasSKA.Util.Infomacoes;

namespace ReceitasSKA
{
    public class Startup
    {
        const string UserDataBase = "User ID=IntegracaoTA; Password=@#ApI@TA@481925#;";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            Informacoes.ConexaoProtheus = Configuration["Configuracoes:ConexaoProtheus"] + UserDataBase;
            Informacoes.ConexaoAutomacaoAdimax = Configuration["Configuracoes:ConexaoAutomacaoAdimax"] + UserDataBase;
            Informacoes.ConexaoPcp = Configuration["Configuracoes:ConexaoPcp"] + UserDataBase;
            Informacoes.EnderecoProtheusMESApi = Configuration["Configuracoes:EnderecoProtheusMESApi"];
            Informacoes.SegundosTimeout = Convert.ToInt32(Configuration["Configuracoes:SegundosTimeout"]);
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(opts => opts.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("ReceitasConnection")));
            services.AddDbContext<AppDbContext>(opts => opts.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("ConexaoProtheus")));
            services.AddScoped<ReceitaService, ReceitaService>();
            services.AddScoped<AssociacaoReceitaService, AssociacaoReceitaService>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {

                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ReceitasSKA", Version = "v1" });
            });
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ReceitasSKA v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
