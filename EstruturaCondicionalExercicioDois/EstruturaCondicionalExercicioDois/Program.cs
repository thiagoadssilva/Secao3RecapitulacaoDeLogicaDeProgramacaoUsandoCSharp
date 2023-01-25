using System;

namespace EstruturaCondicionalExercicioDois // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"Numero: {numero} é PAR");
            }
            else
            {
                Console.WriteLine($"Numero: {numero} é IMPAR");
            }
        }
    }
}