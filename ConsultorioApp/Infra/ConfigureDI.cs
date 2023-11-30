

using AutoMapper;
using Consultorio.App.Base;
using Consultorio.App.Cadastros;
using Consultorio.Domain.Base;
using Consultorio.Domain.Entities;
using Consultorio.Repository.Context;
using Consultorio.Repository.Repository;
using Consultorio.Service.Services;
using ConsultorioApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;

namespace Consultorio.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                var strCon = File.ReadAllText("Config/DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Atende>, BaseRepository<Atende>>();
            Services.AddScoped<IBaseRepository<Consulta>, BaseRepository<Consulta>>();
            Services.AddScoped<IBaseRepository<Convenio>, BaseRepository<Convenio>>();
            Services.AddScoped<IBaseRepository<Dentista>, BaseRepository<Dentista>>();
            Services.AddScoped<IBaseRepository<Especialidade>, BaseRepository<Especialidade>>();
            Services.AddScoped<IBaseRepository<Paciente>, BaseRepository<Paciente>>();

            // Services
            Services.AddScoped<IBaseRepository<Atende>, BaseService<Atende>>();
            Services.AddScoped<IBaseRepository<Consulta>, BaseService<Consulta>>();
            Services.AddScoped<IBaseRepository<Convenio>, BaseService<Convenio>>();
            Services.AddScoped<IBaseRepository<Dentista>, BaseService<Dentista>>();
            Services.AddScoped<IBaseRepository<Especialidade>, BaseService<Especialidade>>();
            Services.AddScoped<IBaseRepository<Paciente>, BaseService<Paciente>>();

            // Formulários
            Services.AddTransient<CadastroConsulta, CadastroConsulta>();
            Services.AddTransient<CadastroConvenio, CadastroConvenio>();
            Services.AddTransient<CadastroDentista, CadastroDentista>();
            Services.AddTransient<CadastroEspecialidade, CadastroEspecialidade>();
            Services.AddTransient<CadastroPaciente, CadastroPaciente>();
            Services.AddTransient<CadastroAtende, CadastroAtende>();


            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Atende, AtendeModel>()
                    .ForMember(d => d.IdDentista, d => d.MapFrom(x => $"{x.Dentista!.Id}"))
                    .ForMember(d => d.NomeDentista, d => d.MapFrom(x => $"{x.Dentista!.Nome}"));
                config.CreateMap<Consulta, ConsultaModel>
                    
                    

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }

    }

    }
}
