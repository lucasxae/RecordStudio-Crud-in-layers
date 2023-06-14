using System;
using System.Data;
using RevisaoProva.DAL;
using RevisaoProva.DTO;

namespace RevisaoProva.BLL
{
    internal class BLL_Musica
    {

        //Criar o método para as funcões do banco de dados

        ConexaoBD bd = new ConexaoBD();
        string sql;

        //Função para inserir valores em uma tabela
        public void Inserir_Musica(DTO_Musica musica)
        {
            try
            {
                //Linha de comando usada em SQL onde o valor '{0}' é o primeiro valor do programa, nesse caso o musica.Nome
                sql = string.Format("insert into TBL_Musica values(null, '{0}', '{1}', '{2}')", musica.Nome, musica.NomeAutor, musica.NomeGravadora);
                //Rodar o comando acima no banco de dados.
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir_Musica(DTO_Musica musica)
        {
            try
            {
                sql = string.Format("delete from TBL_Musica where idMusica = '{0}'", musica.Id);
                bd.AlterarTabela(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listar_Musicas()
        {
            try
            {
                sql = string.Format("select * from TBL_Musica");
                return bd.ConsultarTabelas(sql);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
