using System;
using System.Globalization;

namespace EstruturaSequencialExercicioDois // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do raio:");
            double valorRaio = double.Parse(Console.ReadLine());

            double valorTT = 3.14159;
            double resultado = valorTT * (valorRaio * valorRaio);

            Console.WriteLine($"A = {resultado.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}