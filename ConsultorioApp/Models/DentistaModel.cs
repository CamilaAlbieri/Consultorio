﻿using Consultorio.Domain.Entities;

namespace ConsultorioApp.Models
{
    public class DentistaModel
    {
        
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? CPF { get; set; }
        //public List<DentistaEspecialidade>? Especialidades { get; set; }

        /*public String idEspecialidade { get; set; }
        public String nomeEspecialidade { get; set; }*/
    }

    public class DentistaEspecialidadeModel
    {
        public int Id { get; set; }
        public int idDentista { get; set; }
        public String? nomeDentista { get; set; }
        public String? nomeEspecialidade { get; set; }
        public int idEspecialidade { get; set; }

    }
}