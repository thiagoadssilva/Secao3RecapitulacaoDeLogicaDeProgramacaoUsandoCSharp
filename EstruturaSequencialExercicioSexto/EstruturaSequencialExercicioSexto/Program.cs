using System;
using System.Globalization;

namespace EstruturaSequencialExercicioSexto // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numeroA, numeroB, numeroC;
            double resultadoA, resultadoB, resultadoC, resultadoD, resultadoE;

            Console.WriteLine("Informe o primeiro A ex: 2.15:");
            numeroA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o segundo B ex: 2.15:");
            numeroB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o terceiro C ex: 2.15:");
            numeroC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultadoA = (numeroA * numeroC) / 2;
            Console.WriteLine($"TRIANGULO: {resultadoA.ToString("F3")}");
            resultadoB = Math.PI * Math.Pow(numeroC, 2);
            Console.WriteLine($"CIRCULO: {resultadoB.ToString("F3")}");
            resultadoC = ((numeroA + numeroB) * numeroC) / 2;
            Console.WriteLine($"TRAPEZIO: {resultadoC.ToString("F3")}");
            resultadoD = Math.Pow(numeroB, 2);
            Console.WriteLine($"QUADRADO: {resultadoD.ToString("F3")}");
            resultadoE = numeroA * numeroB;
            Console.WriteLine($"RETANGULO: {resultadoE.ToString("F3")}");
        }
    }
}