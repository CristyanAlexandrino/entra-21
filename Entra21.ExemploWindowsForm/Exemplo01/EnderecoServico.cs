using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemploWindowsForm.Exemplo01
{
    internal class EnderecoServico
    {
        private List<Endereco> enderecos;

        // Construtor: mais pra frente
        public EnderecoServico()
        {
            enderecos = new List<Endereco>();
        }

        // Método Adicionar recebe como parâmentro o objeto endereço completo do Form(Controller)
        public void Adicionar(Endereco endereco)
        {
            enderecos.Add(endereco);

            SalvarArquivo();
        }

        public void Editar(Endereco enderecoParaAlterar)
        {
            // Percorre a lista de endereços afim de encontrar o endereço que deve ser alterado
            for (int i = 0; i < enderecos.Count; i++)
            {
                // Obtém o endereço da lista de endereços
                var endereco = enderecos[i];

                // Verifica se o código de enredeço percorrido é o enredeço que deve ser alterado
                if (endereco.Condigo == enderecoParaAlterar.Condigo)
                {
                    // Atualizado campos de endereço encontrado
                    endereco.EnderecoCompleto = enderecoParaAlterar.EnderecoCompleto;
                    endereco.Cep = enderecoParaAlterar.Cep;
                    endereco.Paciente = enderecoParaAlterar.Paciente;

                    SalvarArquivo();

                    return;
                }

            }
        }
        public void Apagar(int codigoParaApagar)
        {
            for (int i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                if (endereco.Condigo == codigoParaApagar)
                {
                    
                    // Remove o endereço entronado da lista de endereços
                    enderecos.Remove(endereco);

                    SalvarArquivo();

                    return;
                }
            }
        }
        // Método que permite listar todos os endereços
        public List<Endereco> ObterTodos()
        {
            return enderecos;
        }
        public Endereco ObterPorCodigo(int codigo)
        {
            // Percorre a lista de endereços afim de encontrar o endereço com o código desejado
            for (int i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                if (endereco.Condigo == codigo)
                    return endereco;
                
            }
            // Retonar null pois não encontrou o endereço com o código desejado
            return null;
        }

        public void SalvarArquivo()
        {
            var enderecoEmJson = JsonConvert.SerializeObject(enderecos);
            File.WriteAllText("enderecos.json", enderecoEmJson);

        }
        public void LerArquivo()
        {
            if (File.Exists("endereco.json") == false)
                return;

            var enderecoEmJson = File.ReadAllText("enderecos.json");
            enderecos = JsonConvert.DeserializeObject<List<Endereco>>(enderecoEmJson);
                
            
        }
    }
}
