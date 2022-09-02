using Desafio01_Alura.OperacoesSimples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01_Alura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de operações aritméticas simples");

            int num1 = 9;
            int num2 = 3;

            Operacoes op = new Operacoes();

            Console.WriteLine("A soma de " + num1 + " e " + num2 + " é igual a " + op.Adicao.CalcularAdicao(num1, num2));
            Console.WriteLine("A subtração de " + num1 + " e " + num2 + " é igual a " + op.Subtracao.CalcularSubtracao(num1, num2));
            Console.WriteLine("A divisão de " + num1 + " e " + num2 + " é igual a " + op.Divisao.CalcularDivisao(num1, num2));
            Console.WriteLine("A multiplicação de " + num1 + " e " + num2 + " é igual a " + op.Multiplicacao.CalcularMultiplicacao(num1, num2));

            Console.ReadKey();
        }
    }
}
