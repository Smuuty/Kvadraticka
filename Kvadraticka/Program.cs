using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Zadej koeficient a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Zadej koeficient b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Zadej koeficient c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Tuple<double, double> result = vyreskvadro(a, b, c);

        Console.WriteLine($"vysledek 1: {result.Item1}");
        Console.WriteLine($"vysledek 2: {result.Item2}");
    }

    static Tuple<double, double> vyreskvadro (double a, double b, double c)
    {
        
        double delta = b * b - 4 * a * c;

      
        if (delta < 0)
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-delta) / (2 * a);
            return Tuple.Create(realPart, imaginaryPart);
        }

        
        double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double root2 = (-b - Math.Sqrt(delta)) / (2 * a);

        return Tuple.Create(root1, root2);
    }
}
