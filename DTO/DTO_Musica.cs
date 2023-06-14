using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoProva.DTO
{
    internal class DTO_Musica
    {

        //Esse arquivo serve para guardar variaveis para serem usadas por outros arquivos como por exemplo do formulário ao bll.
        //Crie as variaveis de acordo com a tabela e para criar o get e set selecione o nome da variável e aperte CONTROL + R + E

        private int id;
        private string nome, nomeAutor, nomeGravadora;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string NomeAutor { get => nomeAutor; set => nomeAutor = value; }
        public string NomeGravadora { get => nomeGravadora; set => nomeGravadora = value; }
    }
}
