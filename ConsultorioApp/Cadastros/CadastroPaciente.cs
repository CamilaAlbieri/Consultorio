﻿using Consultorio.Domain.Base;
using Consultorio.Domain.Entities;
using Consultorio.Service.Validators;
using ConsultorioApp.Models;
using ReaLTaiizor.Controls;

namespace Consultorio.App.Base
{
    public partial class CadastroPaciente : CadastroBase
    {
        private readonly IBaseService<Paciente> _pacienteService;
        private readonly IBaseService<Convenio> _convenioService;

        private List<PacienteModel>? pacientes;

        public CadastroPaciente(IBaseService<Paciente> pacienteService, IBaseService<Convenio> convenioService)
        {
            _pacienteService = pacienteService;
            _convenioService = convenioService;
            InitializeComponent();

        }

        private void PreencheObjeto(Paciente paciente)
        {
            paciente.Nome = txtNome.Text;
            paciente.Telefone = txtTelefone.Text;
            paciente.CPF = txtCPF.Text;
            paciente.Observacao = txtObservacao.Text;

            if (int.TryParse(cboConvenio.SelectedValue.ToString(), out var idGrupo))
            {
                var convenio = _convenioService.GetById<Convenio>(idGrupo);
                paciente.Convenio = convenio;
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var paciente = _pacienteService.GetById<Paciente>(id);
                        PreencheObjeto(paciente);
                        _pacienteService.Update<Paciente, Paciente, PacienteValidator>(paciente);
                    }


                }
                else
                {
                    var paciente = new Paciente();
                    PreencheObjeto(paciente);
                    _pacienteService.Add<Paciente, Paciente, PacienteValidator>(paciente);
                }

                tabCadastro.SelectedIndex = 1;
            }
            catch (Exception)
            {
                Utils.Utils.messageExclamation("Esse paciente já existe!", "Paciente");
            }
        }

            protected override void Deletar(int id)
        {
            try
            {
                _pacienteService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Consultório", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            pacientes = _pacienteService.Get<PacienteModel>(new[] { "Paciente" }).ToList();
            dataGridViewConsulta.DataSource = pacientes;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["IdConvenio"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            txtCPF.Text = linha?.Cells["CPF"].Value.ToString();
            txtObservacao.Text = linha?.Cells["Observação"].Value.ToString();
        }

    }
}
