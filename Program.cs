using System;
using System.Globalization;
using Projetinho;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
          Triangulo X, Y;
          X = new Triangulo();
          Y = new Triangulo();
            

            System.Console.WriteLine("Entre com as medidas do triangulo X");
            X.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                
            X.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                
            X.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

             double p = (X.A + X.B + X.C) / 2.0;
             double areaX = Math.Sqrt(p * (p - X.A) * (p - X.B) * (p - X.C));


            System.Console.WriteLine("Entre com as medidas do triangulo Y");
            X.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                
            X.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                
            X.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            p = (Y.A + Y.B + Y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - Y.A) * (p - Y.B) * (p - Y.C));

            Console.Clear();



            System.Console.WriteLine("Área do X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));             
            System.Console.WriteLine("Área do Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                System.Console.WriteLine("Maior área: X");
                System.Console.WriteLine("-------------");
            }
            else if (areaY > areaX)
            {
                System.Console.WriteLine("Maior área: Y");
                System.Console.WriteLine("-------------");
            }
            else
            {
                System.Console.WriteLine("O valor da áreas são iguais");
                System.Console.WriteLine("---------------------------");
            }
                               
        }
    }
}