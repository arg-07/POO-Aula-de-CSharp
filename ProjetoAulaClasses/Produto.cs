using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAulaClasses
{
    class Produto
    {
        private string? _nome;
        //private double _preco;
        public double Preco { get; private set; }
        //private int _quantidade;
        public int Quantidade { get; private set; }

        public Produto() { }

        public Produto(String? nome, double preco, int quantidade) 
        {
        
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        
        }

        public double ValorTotalEmEstoque() 
        { 
        
            return Preco * Quantidade;
        
        }

        public string Nome
        {

            get
            {
                return _nome;
            }

            set
            {
                if (value != null && value.Length > 3)
                {

                    _nome = value;

                }
                else { Console.WriteLine("esse valor não é aceito"); }
            }



        }



        public String? GetNome() 
        {

            return _nome; 
        
        
        }

        public void SetNome(String? nome) 
        {
        
            if (nome != null && nome.Length > 3) 
            {

                _nome = nome;

            }
            else { Console.WriteLine( "esse valor não é aceito"  ); }
            
        
        
        }

        //public double Preco
        //{

        //    get { return _preco; }

    }

    public double GetPreco()
    {

        return Preco;

    }

    //public int Quantidade 
    //{

    //    get { return _quantidade; }


    //}

    public int GetQuantidade() 
        {
        
            return Quantidade;
        
        
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
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
