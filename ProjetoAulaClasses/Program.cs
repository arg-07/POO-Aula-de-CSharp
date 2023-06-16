using ProjetoAulaClasses;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura do retangulo");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com a altura do retangulo");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areax = r.Area();
            double aperimetro = r.Perimetro();
            double adiagonal = r.Diagonal();

            Console.WriteLine(r);

            //Console.WriteLine("Area = " + areax.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();



            //Console.WriteLine("Dados do produto: " + p);

            //Console.WriteLine();
            //Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);
            //Console.WriteLine("Dados atualizados: " + p);


            //Console.WriteLine();
            //Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);
            //Console.WriteLine("Dados atualizados: " + p);



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
