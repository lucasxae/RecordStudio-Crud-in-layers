using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEP_Prova2_25
{
    internal class area
    {
        private double altura;
        private double bbase;


        public double Altura
        {
            get => altura;
            set { if (value >= 0 ) { this.altura = value; } else { throw new Exception("O valor da altura  não deve ser menor que 0"); } }

        }

        public double Bbase
        {
            get => bbase;
            set { if (value >= 0 ) { this.bbase = value; } else { throw new Exception("O valor da base não deve ser menor que 0"); } }
        }


        public double CalcularArea()
        {
            return this.bbase * this.altura;
        }
    }
}