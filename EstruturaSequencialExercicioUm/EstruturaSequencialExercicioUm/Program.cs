using System;

namespace EstruturaSequencialExercicioUm // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());

            int resultado = valor1 + valor2;

            Console.WriteLine($"Soma = {resultado}");
        }
    }
}