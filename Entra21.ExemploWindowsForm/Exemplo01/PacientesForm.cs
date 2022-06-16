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
        private int  indicelinhaSelecionada = -1;
        private int codigo = 1;
        private int codigoSelecionado = -1;
        public PacientesForm()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter as informações dos campos
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text);
            var peso = Convert.ToDouble(textBoxPeso.Text);

            // Calculo IMC
            var imc = peso / (altura * altura);

            // Adiciona linha no dataGridView de pacientes
            dataGridView1.Rows.Add(new object[]
            {
                codigo++, nome, altura, peso, imc.ToString("F")
            });
            if (indicelinhaSelecionada == -1)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    codigo++, nome, altura, peso, imc
                });

                return;
            }

            dataGridView1.Rows[indicelinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[indicelinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridView1.Rows[indicelinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridView1.Rows[indicelinhaSelecionada].Cells[4].Value = imc.ToString();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indiceLinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente");

                return;
            }

            var opcaoEscolhida = MessageBox.Show("Deseja realmente apagar?", "Aviso", MessageBoxButtons.YesNo);

            // Verifica se o usuário escolheu realmente aoagar o registro
            if (opcaoEscolhida == DialogResult.Yes)
            {
                // REmove a linha utilizando o indice do DataGridView
                dataGridView1.Rows.RemoveAt(indiceLinhaSelecionada);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            indicelinhaSelecionada = dataGridView1.SelectedRows[0].Index;

            if (indicelinhaSelecionada == -1)
            {
                MessageBox.Show("Selecione um paciente");
                return;
            }

            // Obter a linha 
            var linhaSelecionada = dataGridView1.SelectedRows[0];

            // Obter a informação da linha selecionada passado a coluna desejada
            codigoSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var nome = linhaSelecionada.Cells[1].Value.ToString();
            var altura = Convert.ToDouble(linhaSelecionada.Cells[2].Value);
            var peso = Convert.ToDouble(linhaSelecionada.Cells[3].Value);

            textBoxNome.Text = nome;
            textBoxAltura.Text = altura.ToString();
            textBoxPeso.Text = peso.ToString();


        }
    }
}
