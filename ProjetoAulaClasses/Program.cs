using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}





//using ProjetoAulaClasses;
//using System;
//using System.Globalization;
//using System.Security.Cryptography.X509Certificates;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Produto p = new Produto("tv", 500.00, 10);

//            //p.SetNome("T");
//            p.Nome = "T";

//            Console.WriteLine(p.Nome);
//            Console.WriteLine(p.GetQuantidade());
//            Console.WriteLine(p.Preco);

//            Console.ReadLine();

//        }

//    }

//}



//using ProjetoAulaClasses;
//using System;
//using System.Globalization;
//using System.Security.Cryptography.X509Certificates;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Entre com os dados do produto");
//            Console.Write("Nome: ");
//            string nome = Console.ReadLine();
//            Console.WriteLine("Preço: ");
//            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


//            Produto p = new Produto(nome, preco);

//            Produto p3 = new Produto { Nome = "tv",Preco = 24.23 };

//            Console.WriteLine("Dados do produto: " + p);

//            Console.WriteLine();
//            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
//            int qte = int.Parse(Console.ReadLine());
//            p.AdicionarProdutos(qte);
//            Console.WriteLine("Dados atualizados: " + p);


//            Console.WriteLine();
//            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
//            qte = int.Parse(Console.ReadLine());
//            p.RemoverProdutos(qte);
//            Console.WriteLine("Dados atualizados: " + p);

//            Console.ReadLine();

//        }

//    }

//}























//using ProjetoAulaClasses;
//using System;
//using System.Globalization;


//namespace Course
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {


//            Console.WriteLine("Entre com o valor do raio: ");
//            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            double circ = Calculadora.circunferencia(raio);
//            double volume = Calculadora.Volume(raio);

//            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
//            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
//            Console.WriteLine("Valor de PI: " + Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture));

//            Console.ReadLine();

//        }


//    }

//}

















//using ProjetoAulaClasses;
//using System;
//using System.Globalization;


//namespace Course
//{
//    class Program
//    {
//        static double pi = 3.14;
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Entre com o valor do raio: ");
//            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            double circ = circunferencia(raio);

//            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));

//            double volume = Volume(raio);
//            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
//            Console.WriteLine("Valor de PI: " + pi.ToString("F2", CultureInfo.InvariantCulture));

//            Console.ReadLine();

//        }

//        static double circunferencia(double r) 
//        {

//            return 2.0 * pi * r; 

//        } 

//        static double Volume(double r) 
//        {

//            return 4.0 / 3.0 * pi * Math.Pow(r, 3);

//        }

//    }

//}













//using ProjetoAulaClasses;
//using System;
//using System.Globalization;
//using System.Security.Cryptography.X509Certificates;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Escola L = new Escola();

//            Console.WriteLine("Digite o nome do aluno:");
//            L.Nome = Console.ReadLine();

//            Console.WriteLine("Digite a primeira Nota:");
//            L.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Digite a segunda Nota:");
//            L.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Digite a terceira Nota:");
//            L.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 


//            Console.WriteLine(L);

//            Console.ReadLine();




//        }

//    }

//}









//using ProjetoAulaClasses;
//using System;
//using System.Globalization;
//using System.Security.Cryptography.X509Certificates;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Funcionario f = new Funcionario();

//            Console.WriteLine("Entre com o nome do funcionário:");
//            f.Nome = Console.ReadLine();


//            Console.WriteLine("Entre com o salário bruto:");
//            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Digite o valor do imposto sindical:");
//            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Digite a porcentagem para a base do aumento de salário:");
//            double qte = double.Parse(Console.ReadLine());
//            f.AumentarSalario(qte);


//            Console.WriteLine(f);

//            Console.ReadLine();




//        }

//    }

//}






//using ProjetoAulaClasses;
//using System;
//using System.Globalization;
//using System.Security.Cryptography.X509Certificates;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Retangulo r = new Retangulo();

//            Console.WriteLine("Entre com a largura do retangulo");
//            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Entre com a altura do retangulo");
//            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            double areax = r.Area();
//            double aperimetro = r.Perimetro();
//            double adiagonal = r.Diagonal();

//            Console.WriteLine(r);

//            Console.ReadLine();




//        }

//    }

//}

























//using ProjetoAulaClasses;
//using System;
//using System.Globalization;
//using System.Security.Cryptography.X509Certificates;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Produto p = new Produto();

//            Console.WriteLine("Entre com os dados do produto");
//            Console.Write("Nome: ");
//            p.Nome = Console.ReadLine();
//            Console.WriteLine("Preço: ");
//            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            Console.Write("Quantidade no Estoque: ");
//            p.Quantidade = int.Parse(Console.ReadLine());

//            Console.WriteLine("Dados do produto: " + p);

//            Console.WriteLine();
//            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
//            int qte = int.Parse(Console.ReadLine());
//            p.AdicionarProdutos(qte);
//            Console.WriteLine("Dados atualizados: " + p);


//            Console.WriteLine();
//            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
//            qte = int.Parse(Console.ReadLine());
//            p.RemoverProdutos(qte);
//            Console.WriteLine("Dados atualizados: " + p);

//            Console.ReadLine();

//        }

//    }

//}












//using ProjetoAulaClasses;
//using System;
//using System.Globalization;
//using System.Security.Cryptography.X509Certificates;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Triangulo1 x, y;

//            x = new Triangulo1();
//            y = new Triangulo1 ();

//            Console.WriteLine("Entre com as medidas do triãngulo X:");
//            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            Console.WriteLine("Entre com as medidas do triãngulo y:");
//            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            double areax = x.Area();

//            double areay = y.Area();

//            Console.WriteLine("Area de x = " + areax.ToString("F2", CultureInfo.InvariantCulture));

//            Console.WriteLine("Area de y = " + areay.ToString("F2", CultureInfo.InvariantCulture));

//            if (areax > areay)
//            {
//                Console.WriteLine("O triângulo x é maior do que o triângulo y!");

//            }
//            else
//            {
//                Console.WriteLine("O triângulo y é maior do que o triângulo x!");
//            }

//            Console.ReadLine();

//        }

//    }

//}
