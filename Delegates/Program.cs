// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public delegate double OperacaoMatematica(double valor1, double valor2);
        static void Main(string[] args)
        {
            OperacaoMatematica Soma = Somar;
            OperacaoMatematica Subtrai = Subtrair;
            OperacaoMatematica Multiplica = Multiplicar;
            OperacaoMatematica Divide = Dividir;

            Console.WriteLine($"Resultado da soma:{Soma(1, 2)}");
            Console.WriteLine($"Resultado da subtração:{Subtrai(1, 2)}");
            Console.WriteLine($"Resultado da multiplicação:{Multiplica(1, 2)}");
            Console.WriteLine($"Resultado da divisão:{Divide(1, 2)}");

        }
        static double Somar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }
        static double Subtrair(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
        static double Dividir(double valor1, double valor2)
        {
            return valor1 / valor2;
        }
        static double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }
    }
}



