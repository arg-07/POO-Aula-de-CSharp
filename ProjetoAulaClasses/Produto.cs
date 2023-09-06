using System;
using System.Collections.Generic;
using System.Globalization;


namespace ProjetoAulaClasses
{
    class Produto
    {
        //atributos

        public string? Nome;
        public double Preco;
        public int Quantidade;


        //métodos

        public double ValorTotalEmEstoque() 
        { 
        
            return Preco * Quantidade;
        
        
        }

        public void AdicionarProdutos(int quantidade) 
        {
        
            Quantidade = Quantidade + quantidade ;
        
        
        }

        public void RemoverProdutos(int quantidade)
        {

            Quantidade = Quantidade - quantidade;


        }



        //sobreposição de um Tostring

        public override string ToString()
        {
            return Nome
                        + ", $ "
                        + Preco.ToString("F2", CultureInfo.InvariantCulture)
                        + ", "
                        + Quantidade
                        + " Unidades, Total: $ "
                        + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
                        
        }






    }
}
