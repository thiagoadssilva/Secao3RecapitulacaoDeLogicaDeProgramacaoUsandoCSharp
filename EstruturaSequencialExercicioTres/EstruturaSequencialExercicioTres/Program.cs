using System;

namespace EstruturaSequencialExercicioTres // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe 4 números para operação:");

            int a, b, c, d;
            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            d = int.Parse(vet[3]);

            int resultado = (a * b - c * d);

            Console.WriteLine($"Diferença = {resultado}");
        }
    }
}