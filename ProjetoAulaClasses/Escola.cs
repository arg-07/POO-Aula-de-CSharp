using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaClasses
{
    internal class Escola
    {

        public string? Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal() 
        {
        
            return Nota1 + Nota2 + Nota3;
        
        
        }

        public string Resultado() 
        {
        
            if (NotaFinal() >= 210.0) 
            {

              return "Aprovado";
            
            }
            else 
            {

               return "Reprovado";  


            }
        
        
        }

        public double Falta()
        {
            if (NotaFinal() >= 210.0) 
            {

                return 0.0;
            
            }
            else 
            {

                return 210.0 - NotaFinal();

            }
            
            
        }

        public override string ToString()
        {
            return "Nome do aluno: "
                + Nome
                + " " + " | "
                + "Nota Final = "
                + " "
                + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                + " " + " | "
                + "Resultado = "
                + " "
                + Resultado()
                + " " + " | "
                + "Faltaram: "
                + " "
                + Falta().ToString("F2", CultureInfo.InvariantCulture)
                + " "
                + "Pontos";


        }







    }
}
