using System;

namespace AREAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("base");
            double base1 = double.Parse(Console.ReadLine());
            Console.WriteLine("altura");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("raio");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("RELATÓRIO FINAL: ");
            double areaQ = altura * altura;
            Console.WriteLine("AREA QUADRADO: " + areaQ);
            double areaC = 3.141592 * Math.Pow(r, 2);
            Console.WriteLine("AREA DO CÍRULO: " + areaC);
            double aTrapezio = ((base1 + altura) * r) / 2;
            Console.WriteLine("AREA DO TRAPEZIO: " + aTrapezio);
            double areaR = base1 * altura;
            Console.WriteLine("AREA RETANGULO: " + areaR);
            
        }
    }
}
