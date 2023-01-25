using System;

namespace EstruturaCondicionalExercicioTres // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroA, numeroB;
            Console.WriteLine("Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem \"Sao Multiplos\" ou \"Nao sao \r\nMultiplos\", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em \r\nordem crescente ou decrescente");
            numeroA = int.Parse(Console.ReadLine());
            numeroB = int.Parse(Console.ReadLine());

            if (numeroA % numeroB == 0|| numeroB % numeroA == 0) {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não São Multiplos");
            }
        }
    }
}