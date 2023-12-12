

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
                var strCon = File.ReadAllText(@"Conf\DatabaseSettings.txt");
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
            Services.AddScoped<IBaseRepository<DentistaEspecialidade>, BaseRepository<DentistaEspecialidade>>();



            // Services

            Services.AddScoped<IBaseService<Atende>, BaseService<Atende>>();
            Services.AddScoped<IBaseService<Consulta>, BaseService<Consulta>>();
            Services.AddScoped<IBaseService<Convenio>, BaseService<Convenio>>();
            Services.AddScoped<IBaseService<Dentista>, BaseService<Dentista>>();
            Services.AddScoped<IBaseService<Especialidade>, BaseService<Especialidade>>();
            Services.AddScoped<IBaseService<Paciente>, BaseService<Paciente>>();
            Services.AddScoped<IBaseService<DentistaEspecialidade>, BaseService<DentistaEspecialidade>>();


            // Formulários
            Services.AddTransient<CadastroConsulta, CadastroConsulta>();
            Services.AddTransient<CadastroConvenio, CadastroConvenio>();
            Services.AddTransient<CadastroDentista, CadastroDentista>();
            Services.AddTransient<CadastroEspecialidade, CadastroEspecialidade>();
            Services.AddTransient<CadastroPaciente, CadastroPaciente>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Atende, AtendeModel>()
                    .ForMember(d => d.IdDentista, d => d.MapFrom(x => $"{x.Dentista!.Id}"))
                    .ForMember(d => d.NomeDentista, d => d.MapFrom(x => $"{x.Dentista!.Nome}"))
                    .ForMember(d => d.idConvenio, d => d.MapFrom(x => $"{x.Convenio!.Id}"))
                    .ForMember(d => d.nomeConvenio, d => d.MapFrom(x => $"{x.Convenio!.Nome}"));

                config.CreateMap<Consulta, ConsultaModel>()
                    .ForMember(d => d.idDentista, d => d.MapFrom(x => $"{x.Dentista!.Id}"))
                    .ForMember(d => d.nomeDentista, d => d.MapFrom(x => $"{x.Dentista!.Nome}"))
                    .ForMember(d => d.idPaciente, d => d.MapFrom(x => $"{x.Paciente!.Id}"))
                    .ForMember(d => d.nomePaciente, d => d.MapFrom(x => $"{x.Paciente!.Nome}"));

                config.CreateMap<DentistaEspecialidade, DentistaEspecialidadeModel>()
                    .ForMember(d => d.idDentista, d => d.MapFrom(x => $"{x.Dentista!.Id}"))
                    .ForMember(d => d.idEspecialidade, d => d.MapFrom(x => $"{x.Especialidade!.Id}"))
                    .ForMember(d => d.nomeDentista, d => d.MapFrom(x => $"{x.Dentista!.Nome}"))
                    .ForMember(d => d.nomeEspecialidade, d => d.MapFrom(x => $"{x.Especialidade!.Nome}"));

                config.CreateMap<Paciente, PacienteModel>()
                    .ForMember(d => d.idConvenio, d => d.MapFrom(x => $"{x.Convenio!.Id}"))
                    .ForMember(d => d.nomeConvenio, d => d.MapFrom(x => $"{x.Convenio!.Nome}"));


                config.CreateMap<Especialidade, EspecialidadeModel>();

                config.CreateMap<Convenio, ConvenioModel>();

                config.CreateMap<Dentista, DentistaModel>();
                    //.ForMember(d => d.Especialidades, d => d.MapFrom(x => $"{x.Especialidades}"));


            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }

    }

}

