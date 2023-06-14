using System;
using System.Data;
using System.Windows.Forms;
using RevisaoProva.BLL;
using RevisaoProva.DTO;

namespace RevisaoProva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Criar os objetos bll e dto para serem usados
        //O nome objbll_musica e objdto_musica são apenas variaveis, então podem ser trocadas por qualquer nome para ser usada depois.
        BLL_Musica objbll_musica = new BLL_Musica();
        DTO_Musica objdto_musica = new DTO_Musica();

        //Função para lstar a tabela no DataGridView
        public void ListarMusicas()
        {
            try
            {
                dataGridView1.DataSource = objbll_musica.Listar_Musicas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Função para limpar os campos do TextBoxes
        public void Limpar()
        {
            txtId.Clear();
            txtNomeAutor.Clear();
            txtNomeMusica.Clear();
            TxtNomeGravadora.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Aqui você deve setar as variaveis do seu DTO por aqui.
                objdto_musica.Nome = txtNomeMusica.Text;
                objdto_musica.NomeGravadora = TxtNomeGravadora.Text;
                objdto_musica.NomeAutor = txtNomeAutor.Text;

                //Passar os valores do DTO colocados acima para serem usados no BLL com o comando que deseja.
                objbll_musica.Inserir_Musica(objdto_musica);
                MessageBox.Show("Musica inserida com sucesso!");
                //Rodar as funções criadas acima para atualizar a tabela e limpar os campos digitados.
                ListarMusicas();
                Limpar();
            }
            catch(Exception ex)
            {
                //Caso dê erro acima, aqui irá fazer o código aparecer a mensagem de erro.
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                objdto_musica.Id = int.Parse(txtId.Text);
                objbll_musica.Excluir_Musica(objdto_musica);
                Limpar();
                ListarMusicas();
                MessageBox.Show("Musica excluida com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fecha a página atual.
            this.Close();
        }

        //Clique duas vezes no formulario que irá criar essa função, ela serve para rodar um comando quando a página for aberta.
        private void Form1_Load(object sender, EventArgs e)
        {
            //Com esse comando a tabela no DataGridView irá ser carregada automaticamente.
            ListarMusicas();
        }
    }
}
