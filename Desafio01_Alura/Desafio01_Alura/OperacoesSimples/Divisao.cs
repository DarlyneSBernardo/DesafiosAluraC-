using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01_Alura.OperacoesSimples
{
    public class Divisao
    {
        public int CalcularDivisao(int valor1, int valor2)
        {
            if (valor2 == 0)
                return 0;
            else
                return valor1 / valor2;            
        }
    }
}
