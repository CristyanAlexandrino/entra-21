﻿using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    // Dois pontos seguidos de uma interface, quer dizer que a classe
    // será obrigada a implementar os métodos(contratos) estabelecidos
    // na interface 
    internal class TipoPersonagemService : ITipoPersonagemService
    {
        public void Cadastrar(TipoPersonagem tipoPersonagem)
        {
           
            var conexao = new Conexao().Conectar();
            // Criar o comando para executar no banco de dados
            SqlCommand comando = conexao.CreateCommand();

            // Especificando o comando que será executado
            comando.CommandText = "INSERT INTO tipos_personagens (tipo) VALUES ('" +
                tipoPersonagem.Tipo + "')";

            // Executando o comando de insert na tabela de tipos personagens
            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public List<TipoPersonagem> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, tipo FROM tipos_personagens";

            // Criando tabela em memória para posteriormente carregar os
            // registros obtidos com o SELECT
            var tabelaEmMemoria = new DataTable();

            // Carregando na tabela em memória os registros encontrados
            // com o comando SELECT
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Criando uma lista para armazenar os registros da consulta do SELECT
            var tiposPersonagens = new List<TipoPersonagem>();

            // Percorrido cada um dos registros da 
            // tabelaEmMemória(registros do SELECT)
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                // Obtido o registro da linha que está sendo percorrida
                var linha = tabelaEmMemoria.Rows[i];

                // Instanciando objeto da classe TipoPersonagem
                // preenchendo com as informações do SELECT, da linha
                // que está sendo percorrida
                var tipoPersonagem = new TipoPersonagem();
                tipoPersonagem.Id = Convert.ToInt32(linha["id"].ToString());
                tipoPersonagem.Tipo = linha["tipo"].ToString();

                // Adicionando tipoPersonagem instanciado na lista
                // de TiposPersonagens
                tiposPersonagens.Add(tipoPersonagem);
            }

            // Fechado a conexão com o banco de dados
            comando.Connection.Close();

            return tiposPersonagens;
        }

        public void Apagar(int id)
        {
            // Conectar com o BD
            var conexao = new Conexao().Conectar();

            // Criar comando para executar o delete
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM tipos_personagens WHERE id = " + id;

            // Executando o comando
            comando.ExecuteNonQuery();

            // Fechar conexão com o BD
            comando.Connection.Close();
        }
    }
}
