using System;

namespace ProjetoAulaClasses
{
     class Triangulo1
    {
        public double A; //atributos
        public double B; //atributos
        public double C; //atributos

        public double Area() //métodos
        { 
            double p = (A + B + C) / 2.0; 
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        
        
        }
    }
}
