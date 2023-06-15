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

            Triangulo1 x, y;

            x = new Triangulo1();
            y = new Triangulo1 ();

            Console.WriteLine("Entre com as medidas do triãngulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triãngulo y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areax = x.Area();

            double areay = y.Area();

            Console.WriteLine("Area de x = " + areax.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Area de y = " + areay.ToString("F2", CultureInfo.InvariantCulture));

            if (areax > areay)
            {
                Console.WriteLine("O triângulo x é maior do que o triângulo y!");

            }
            else
            {
                Console.WriteLine("O triângulo y é maior do que o triângulo x!");
            }

            Console.ReadLine();

        }

    }

}
