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

namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    public partial class PersonagemListagemForm : Form
    {
        // Definindo como readonly será permitida a criação da instancia somente no construtor
        private readonly PersonagemService _personagemService;

        // Aqui fica o construtor: tem como objetivo construir o objeto com propriedades
        // necessárias e execução de métodos obrigatórios,
        // ou seja, neste cenário desenhar a teaa e instancias o objeto do serviço
        // que permitirá gerenciar ps dados referente ao personagem
        public PersonagemListagemForm()
        {
            InitializeComponent();

            _personagemService = new PersonagemService();
        }

        private void PreencherDataGridViewComPersonagens()
        {
           var personagens = _personagemService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < personagens.Count; i++)
            {

            }
        }

        private void PersonagemListagemForm_Load(object sender, EventArgs e)
        {
            var personagemForm =  new PersonagemCadastroEdicaoForm();
            personagemForm.ShowDialog();

            PreencherDataGridViewComPersonagens();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
    
        }
    }
}
