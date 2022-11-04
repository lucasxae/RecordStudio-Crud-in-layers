using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEP_Prova2_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        area objarea = new area();
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
               objarea.Altura = double.Parse(txt_altura.Text);  
               objarea.Bbase = double.Parse(txt_base.Text);
           
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error. \n" + ex.Message);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

MessageBox.Show(objarea.CalcularArea().ToString());

            if(objarea.CalcularArea() > 5)
            {
                MessageBox.Show("O tamanho da área ultrapassou o limite do  tamanho especificado");
            }
            else
            {
                MessageBox.Show("o tamanho está dentro dos padrões especificados");
            }

        
        }
    }
}
