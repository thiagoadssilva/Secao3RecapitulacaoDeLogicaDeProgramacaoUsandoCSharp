using System;
using System.Globalization;

namespace EstruturaSequencialExercicioCinco // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pecaUm, pecaDois,numeroPecaUm, numeroPecaDois;
            double valorUnitarioPecaUm, valorUnitarioPecaDois, resultado;


            Console.WriteLine("Informe o código de primeira peça:");
            pecaUm = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de primeira peça:");
            numeroPecaUm = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor unitário de primeira peça:");
            valorUnitarioPecaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o código de segunda peça:");
            pecaDois = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de segunda peça:");
            numeroPecaDois = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor unitário de segunda peça:");
            valorUnitarioPecaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            resultado = (valorUnitarioPecaUm * numeroPecaUm) + (valorUnitarioPecaDois * numeroPecaDois);

            Console.WriteLine($"VALOR A PAGAR: R$ {resultado.ToString("F2")}");


        }
    }
}