﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExemploWindowsForm.Exemplo01
{
    public partial class PacientesForm : Form
    {
        private PacienteServico pacienteServico;

        public PacientesForm()
        {
            InitializeComponent();

            // Isntanciar um objeto do PacienteSercice, que é responsável por gerenciar os dados dos pacientes
            pacienteServico = new PacienteServico();

            // Ler do arquivo JSON os pacientes cadastrados anteriormente
            ListarPacientes();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter as informações dos campos
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text);
            var peso = Convert.ToDouble(textBoxPeso.Text);

            // Verifica se está em modo de adição
            if (dataGridView1.SelectedRows.Count == 0)
            {
                AdicionarPaciente(nome, peso, altura);

                return;
            }


            EditarDados(nome, peso, altura);

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            // Obter a quantidade que o usuario selecionou no DataGridView
            var quantiadeLinhasSelecionadas = dataGridView1.SelectedRows.Count;

            if (quantiadeLinhasSelecionadas == 0)
            {
                MessageBox.Show("Selecione um paciente");

                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            // Verifica se o usuário escolheu realmente apagar o registro
            if (opcaoEscolhida == DialogResult.Yes)
            {
                // Obtém o código do paciente escolhido para apagar
                var linhaSelecionada = dataGridView1.SelectedRows[0];
                var codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                // Apaga o paciente da lista de pacientes atualizando o arquivo JSON
                pacienteServico.Apagar(codigoSelecionado);

                ListarPacientes();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            // Obter a linha 
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter a informação da linha selecionada passado a coluna desejada
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();


        }


        private void EditarDados(string nome, double peso, double altura)
        {
            // Instanciar o paciente com os dados preenchidos na tela, para alterar o existente
            var paciente = new Paciente();
            paciente.Nome = nome;
            paciente.Peso = peso;
            paciente.Altura = altura;

            // Obter o código do registro escolhido para alterar
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var codigo = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            paciente.Codigo = codigo;

            // Alterar o paciente na lista de pacientes e atualizando o arquivo JSON
            pacienteServico.Editar(paciente);

            LimparCampos();

            ListarPacientes();

        }
        private void AdicionarPaciente(string nome, double peso, double altura)
        {
            var paciente = new Paciente
            {
                Codigo = pacienteServico.ObterUltimoCodigo() + 1,
                Nome = nome,
                Altura = altura,
                Peso = peso,
            };

            //Adicionar essa informação na lista e atualizar o arquivo JSON
            pacienteServico.Cadastrar(paciente);

            LimparCampos();

            ListarPacientes();
        }
        private void LimparCampos()
        {
            textBoxNome.Clear();
            textBoxPeso.Clear();
            textBoxAltura.Clear();

            dataGridView1.ClearSelection();
        }

        private void ListarPacientes()
        {
            // Obter a lista dos pacientes para listar para o usuário
            var pacientes = pacienteServico.ObterTodos();

            // Remover todos os itens do DataGridView, pois será adicionado novamente
            dataGridView1.Rows.Clear();

            for (int i = 0; i < pacientes.Count; i++)
            {
                var paciente = pacientes[i];

                dataGridView1.Rows.Add(new object[]
                {

                    paciente.Codigo,
                    paciente.Nome,
                    paciente.Altura,
                    paciente.Peso,
                    paciente.ObterImc()

                });

            }

            dataGridView1.ClearSelection();

        }

        private void PacientesForm_Load(object sender, EventArgs e)
        {
            ListarPacientes();
        }
    }
}
