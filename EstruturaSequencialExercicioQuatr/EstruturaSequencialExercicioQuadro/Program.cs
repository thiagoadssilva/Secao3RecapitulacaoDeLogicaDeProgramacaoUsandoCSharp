using System;
using System.Globalization;

namespace EstruturaSequencialExercicioQuadro // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número do funcionário:");
            int numeroFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas de trabalho por dia?");
            int horasTabalho = int.Parse(Console.ReadLine());

            Console.WriteLine("Quanto é o valor da hora");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = valorHora * horasTabalho;

            Console.WriteLine($"Number = {numeroFuncionario}");
            Console.WriteLine($"Salary = {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}