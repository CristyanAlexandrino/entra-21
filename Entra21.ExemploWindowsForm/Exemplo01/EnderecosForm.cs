﻿using Newtonsoft.Json;

namespace Entra21.ExemploWindowsForm.Exemplo01
{
    public partial class EnderecosForm : Form
    {
        private EnderecoServico enderecoServico;
        private PacienteServico pacienteServico;
       
        // Construtor: construir o objeto que está sendo instanciado com as devidas informações ou rotinas
        public EnderecosForm()
        {
            InitializeComponent();

            enderecoServico = new EnderecoServico();

            ObterDadosCep();

            // Instanciado o objeto de PacienteServico o permitirá listar os pacientes no ComboBox e decorrente será possível o usúario
            // selecionar o mesmo
            pacienteServico = new PacienteServico();

            // Deve apresentar os dados quanto a tela for carregada
            PreencherDataGridViewComEnderecos();

            // Preencherá o ComboBox(Campo de seleção) com os pacientes
            PreencherComboBoxComNomesDosPacientes();


        }

        private void PreencherComboBoxComNomesDosPacientes()
        {
            // Obter lista dos pacientes, que foram cadastrados, ou seja, armazenados no JSON
            var pacientes = pacienteServico.ObterTodos();

            //Percorrer todos os pacientes adicionando na ComboBox
            for (int i = 0; i < pacientes.Count; i++)
            {
                var paciente = pacientes[i];
                comboBoxPaciente.Items.Add(paciente.Nome);
            } 

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            maskedTextBoxCep.Text = "";
            textBoxEnderecoCompleto.Text = "";
            comboBoxPaciente.SelectedIndex = -1;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter os dados preenchidos pelo usuárioa armazenando em variáveis
            var cep = maskedTextBoxCep.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var nomePaciente = Convert.ToString(comboBoxPaciente.SelectedItem);

            // Construir o objeto de endereço com as variáveis
            var endereço = new Endereco();
            endereço.Cep = cep;
            endereço.EnderecoCompleto = enderecoCompleto;
            endereço.Paciente = pacienteServico.ObterPorNomePaciente(nomePaciente);

            //Salvar este endereço na lista de endereços e no serviço e no arquivo JSON
            enderecoServico.Adicionar(endereço);

            // TODO: adicionar ele na lista do DataGridView

            PreencherDataGridViewComEnderecos();


        }
        private void PreencherDataGridViewComEnderecos()
        {
            //Obter todos os endereços da lista de endereços
            var enderecos = enderecoServico.ObterTodos();

            // Remover todas as linhas do dataGridView
            dataGridView1.Rows.Clear();

            // Remover todas as linhas de endereços
            dataGridView1.ClearSelection();

            // Percorrer cada um dos endereços adicionado uma nova linhana tabela 
            for (int i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                // Cria uma nova linha no DataGridView
                dataGridView1.Rows.Add(new object[]
                {
                    endereco.Condigo,
                    endereco.EnderecoCompleto,
                    endereco.Cep,
                    endereco.Paciente.Nome
                });
            }
        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-","");
            
            // HttpClient permite fazer requisições para obter ou enviar dados para outros sistemas
            var httpClient = new HttpClient();

            // Executando a requisição para o Site ViaCep para obter os dados do endereço do cep
            var resultado = httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

            // Verificar se a requisição deu certo
            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Obter a resposta da requisição
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosEndereço = JsonConvert.DeserializeObject<EnderecoDadosRequisicao>(resposta);

                textBoxEnderecoCompleto.Text =
                    $"{dadosEndereço.Uf} - {dadosEndereço.Localidade} - {dadosEndereço.Bairro} - {dadosEndereço.Logradouro}";
            }
        }
    }
}
