using Entra21.BancoDados01.Ado.Net.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens
{
    public partial class TiposPersonagensListagemForm : Form
    {
        private TipoPersonagemService tipoPersonagemService;
        public TiposPersonagensListagemForm()
        {
            InitializeComponent();
            //  Instanciando
            tipoPersonagemService = new TipoPersonagemService();
        }

        private void TiposPersonagensListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistroDataGridView1();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var tipoPersonagemCadastroEdicaoForm = new TipoPersonagemCadastroEdicaoForm();

            tipoPersonagemCadastroEdicaoForm.ShowDialog();

            AtualizarRegistroDataGridView1();

        }

        private void AtualizarRegistroDataGridView1()
        {
            // Obter todos os tipos de personagens cadastrados na tabela 
            // tipos personagens
            var tiposPersonagens = tipoPersonagemService.ObterTodos();

            // removido todos os registros do dataGridView1
            dataGridView1.Rows.Clear();

            // Percorrido todos os tipos de personagens encontrados para 
            // adicionar no DataGridView permitindo o usuário visualiza-los
            for (int i = 0; i < tiposPersonagens.Count; i++)
            {
                var tipoPersonagem = tiposPersonagens[i];

                dataGridView1.Rows.Add(new object[]
                {
                tipoPersonagem.Id,
                tipoPersonagem.Tipo

                });

            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            tipoPersonagemService.Apagar(id);

            AtualizarRegistroDataGridView1();

            MessageBox.Show("Registro apagado com sucesso");

        }
    }
}
