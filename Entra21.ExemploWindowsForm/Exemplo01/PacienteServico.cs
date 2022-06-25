using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemploWindowsForm.Exemplo01
{
    internal class PacienteServico
    {
        private List<Paciente> pacientes;
        
        public PacienteServico()
        {
            pacientes = new List<Paciente>();

            LerArquivo();
        }

        // Método que espõe a lista de pacientes que tem o encapsulamento privado
        public List<Paciente> ObterTodos()
        {
            return pacientes;
        }

        public Paciente ObterPorNomePaciente(string nomePaciente)
        {
            // Percorrer a lista de pacientes para encontrar o paciente por nome
            for (int i = 0; i < pacientes.Count; i++)
            {
                //Obter o paciente que está sendo percorrido
                var paciente = pacientes[i];

                // Verificar se o paciente atual contém o nome do paciente escolhido
                if (paciente.Nome == nomePaciente)
                {
                    return paciente;
                }
            }
               // Retonar null quando não encontrar nenhum paciente com o nome do paciente escolhido
            return null;
        }
        private void LerArquivo()
        {
            // Verificar se o arquivo não existe
            if (File.Exists("pacientes.json") == false)
                return;

            // Ler Arquivo JSON com a lista de pacientes
            var pacientesJson = File.ReadAllText("pacientes.json");

            // Converter JSON para lista de objetos de pacientes
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(pacientesJson);

            
        }
    }
}
