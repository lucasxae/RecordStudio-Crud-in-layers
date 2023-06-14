using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace RevisaoProva.DAL
{
    internal class ConexaoBD
    {

        //Conexão com o banco de dados, aqui você pode simplesmente copíar e colar no seu arquivo apartir daqui, apenas mude o campo [database] abaixo para o nome do seu banco de dados.
        private string string_conexao = "persist security info = false; server=localhost; database=bd_Gravadora; uid=root; pwd=; SslMode=none";
        private MySqlConnection conexao;

        //Função para conectar ao banco de dados para fazer uma operação/comando
        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Função para rodar uma operação/comando em sql no banco de dados conectado
        public void AlterarTabela(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        //Função para listar uma tabela
        public DataTable ConsultarTabelas(string sql)
        {
            try
            {
                Conectar();
                MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
                DataTable dados = new DataTable();
                consulta.Fill(dados);
                return dados;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
