using Desafio01_Alura.OperacoesSimples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01_Alura
{
    public class Operacoes
    {
        public Adicao Adicao { get; private set; }
        public Subtracao Subtracao { get; private set; }
        public Divisao Divisao { get; private set; }
        public Multiplicacao Multiplicacao { get; private set; }

        public Operacoes()
        {
            this.Adicao = new Adicao();
            this.Subtracao = new Subtracao();
            this.Divisao = new Divisao();
            this.Multiplicacao = new Multiplicacao();
        }
    }
}
