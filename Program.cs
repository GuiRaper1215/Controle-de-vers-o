using System;

class Program
{
    static void Main()
    {
        // Coeficientes da equação
        Console.Write("Digite o coeficiente a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o coeficiente b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o coeficiente c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Calculando o discriminante
        double delta = b * b - 4 * a * c;

        // Verificando as raízes
        if (delta > 0)
        {
            double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double r2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"As raízes são: R1 = {r1} e R2 = {r2}");
        }
        else if (delta == 0)
        {
            double r = -b / (2 * a);
            Console.WriteLine($"A raiz é: R = {r}");
        }
        else
        {
            Console.WriteLine("Não existem raízes reais.");
        }
    }
}
