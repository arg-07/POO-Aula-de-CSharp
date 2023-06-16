using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaClasses
{
    internal class Funcionario
    {
        public string? Nome;
        public double SalarioBruto;
        public double Imposto;
        public double SalarioAtual;
        

        public double SalarioLiquido() 
        { 
        
            double S = SalarioBruto - Imposto;
            return S;
        
        }

        public void AumentarSalario(double porcentagem) 
        { 
        
            SalarioAtual = SalarioBruto + ((SalarioBruto * porcentagem) / 100.00);
        
        
        
        }


        public override string ToString()
        {
            return "Funcionário: "
                + Nome
                + " " + " | "
                + "Salário Bruto = "
                + " "
                + SalarioBruto
                + " " + " | "
                + "Salário liquito = "
                + " " + "$"
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)
                + " " + " | | | | | | "
                + "Dados atualizados: "
                + " "
                + Nome
                + " " + " | "
                + "Salário Atual = "
                + " " + "$"
                + SalarioAtual.ToString("F2", CultureInfo.InvariantCulture);


        }






    }
}
