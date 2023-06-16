using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaClasses
{
    internal class Retangulo
    {

        public double Largura;
        public double Altura;
        public string? Nome;

        public double Area() 
        {
        
            double A = Largura * Altura;
            return A;
        
        
        }

        public double Perimetro() 
        {
        
            double P = (2 * Altura) + (2 * Largura);
            return P;
        
        
        }

        public double Diagonal() 
        { 
        
            double D = Math.Sqrt(Math.Pow(Largura, 2) +  Math.Pow(Altura, 2));
            return D;


        }

        public override string ToString()
        {
            return "Área: "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + " " + " | "
                + "PERIMETRO = "
                + " "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + " " + " | "
                + "DIAGONAL = "
                + " "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);

        }


    }
}
