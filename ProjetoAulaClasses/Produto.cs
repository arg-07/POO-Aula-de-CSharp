using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAulaClasses
{
    class Produto
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;

        public Produto(String? nome, double preco, int quantidade) 
        {
        
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        
        }

        public Produto(string? nome, double preco) 
        {
        
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        
        
        }

        public double ValorTotalEmEstoque() 
        { 
        
            return Preco * Quantidade;
        
        }

        public void AdicionarProdutos(int quantidade) 
        {

            Quantidade = Quantidade + quantidade; 
        
        }

        public void RemoverProdutos(int quantidade)
        {

            Quantidade = Quantidade - quantidade;

        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
