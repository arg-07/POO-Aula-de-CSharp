using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAulaClasses
{
    class Produto
    {
        private string? _nome;
        private double _preco;
        private int _quantidade;

        public Produto() { }

        public Produto(String? nome, double preco, int quantidade) 
        {
        
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        
        }

        public double ValorTotalEmEstoque() 
        { 
        
            return _preco * _quantidade;
        
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

        public double Preco
        {
        
            get { return _preco; }
        
        }

        public double GetPreco() 
        {

            return _preco;
        
        }

        public int Quantidade 
        {

            get { return _quantidade; }
        
        
        }

        public int GetQuantidade() 
        {
        
            return _quantidade;
        
        
        }

        public void AdicionarProdutos(int quantidade) 
        {

            _quantidade = _quantidade + quantidade; 
        
        }

        public void RemoverProdutos(int quantidade)
        {

            _quantidade = _quantidade - quantidade;

        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
