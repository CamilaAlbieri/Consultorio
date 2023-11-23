
using System.Text.Json;
using AutoMapper;
using Consultorio.Domain.Base;
using Consultorio.Domain.Entities;
using Consultorio.Repository.Context;
using Consultorio.Repository.Repository;
using Consultorio.Service.Services;
using Consultorio.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Consultorio.Teste
{

    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;

        public ServiceProvider ConfiguraServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "Consultorio";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Especialidade>, BaseRepository<Especialidade>>();
            services.AddScoped<IBaseService<Especialidade>, BaseService<Especialidade>>();

            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Especialidade, Especialidade>(); }).CreateMapper());
            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestEspecialidade()
        {
            var sp = ConfiguraServices();
            var _userService = sp.GetService<IBaseService<Especialidade>>();
            var especialidade = new Especialidade
            {
                Nome = "Ortodontia"
            };

            var result = _userService?.Add<Especialidade, Especialidade, EspecialidadeValidator>(especialidade);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }


    }
}

