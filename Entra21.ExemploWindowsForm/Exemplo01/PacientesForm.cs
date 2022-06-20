using Newtonsoft.Json;
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
        private List<Paciente> pacientes;
        private int indicelinhaSelecionada = -1;
        private int codigo = 0;
        private int codigoSelecionado = -1;
        public PacientesForm()
        {
            InitializeComponent();

            // Cria uma lista de objetos para armazenar os pacientes
            pacientes = new List<Paciente>();

           // Ler do arquivo JSON os pacientes cadastrados anteriormente
            LerArquivosApresentandoPacientes();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter as informações dos campos
            var nome = textBoxNome.Text.Trim();
            var altura = Convert.ToDouble(textBoxAltura.Text);
            var peso = Convert.ToDouble(textBoxPeso.Text);

            // Calculo IMC
            var imc = CalcularImc(peso,altura);


            // Verifica se está em modo de adição
            if (indicelinhaSelecionada == -1)
            {
                // Adicionar linha no datagridview do pacientes
                dataGridView1.Rows.Add(new object[]
                {
                    ++codigo, nome, altura, peso, imc
                });

                AdicionarPacienteSalvandoEmArquivo(codigo, nome, peso, altura);

                return;
            }

            dataGridView1.Rows[indicelinhaSelecionada].Cells[1].Value = nome;
            dataGridView1.Rows[indicelinhaSelecionada].Cells[2].Value = altura.ToString();
            dataGridView1.Rows[indicelinhaSelecionada].Cells[3].Value = peso.ToString();
            dataGridView1.Rows[indicelinhaSelecionada].Cells[4].Value = imc.ToString();

            EditarDados(nome, peso, altura);




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

                // Remove o paciente da lista de pacientes
                pacientes.RemoveAt(indiceLinhaSelecionada);

                // Atualiza o arquivo com lista de pacientes com o paciente removido
                SalvarEmArquivos();
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

        private void LimparCampos()
        {
            textBoxNome.Text = "";
            textBoxPeso.Text = "";
            textBoxAltura.Text = "";
        }

        private void EditarDados(string nome, double peso, double altura)
        {
            pacientes[indicelinhaSelecionada].Nome = nome;
            pacientes[indicelinhaSelecionada].Peso = peso;
            pacientes[indicelinhaSelecionada].Altura = altura;

            SalvarEmArquivos();

            LimparCampos();

        }
        private void AdicionarPacienteSalvandoEmArquivo(int codigo, string nome, double peso, double altura)
        {
            var paciente = new Paciente
            {
                Codigo = codigo,
                Nome = nome,
                Altura = altura,
                Peso = peso,
            };

            pacientes.Add(paciente);

            SalvarEmArquivos();
            LimparCampos();
        }

        private void SalvarEmArquivos()
        {

           // Converter uma Lista de objetos em uma string contendo o JSON
            var pacientesJsown = JsonConvert.SerializeObject(pacientes);
            var caminho = "pacientes.json";
           // Salvar a string contendo o JSON em um aruico no formato JSON
            File.WriteAllText(caminho, pacientesJsown);
        }

        private void LerArquivosApresentandoPacientes()
        {
            if (File.Exists("pacientes.json") == false)
                return;
            

            
            var conteudoArquivos = File.ReadAllText("pacientes.json");
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(conteudoArquivos);

            var maiorCodigo = int.MinValue;

            for (int i = 0; i < pacientes.Count; i++)
            {
                var paciente = pacientes[i];

                dataGridView1.Rows.Add(new object[]
                {
                    paciente.Codigo, paciente.Nome,
                    paciente.Altura, paciente.Peso,
                    CalcularImc(paciente.Peso, paciente.Altura)

                });
               // Rotina para descobrir o paciente com o maior codigo
                if (paciente.Codigo > maiorCodigo)
                    maiorCodigo = paciente.Codigo;


            }
            // Validar se conseguiu encontrar algum código, caso contrario deve atualizar o código de novo paciente
            if (maiorCodigo != int.MinValue)
                codigo = maiorCodigo;


        }

        private double CalcularImc(double peso, double altura)
        {
            // Peso / altura
            return peso / Math.Pow(altura, 2);
        }

    }
}
