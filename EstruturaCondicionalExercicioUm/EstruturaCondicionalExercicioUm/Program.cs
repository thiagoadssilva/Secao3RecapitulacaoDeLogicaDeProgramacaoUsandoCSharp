using System;

namespace EstruturaCondicionalExercicioUm // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não");
            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else if(numero >= 0)
            {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
    }
}