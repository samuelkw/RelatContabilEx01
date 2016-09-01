using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_cs
{
    public class Lancamento
    {
        private String conta;
        private String descr;
        private Double saldo;

        public String Conta
        {
            get { return conta; }
            set { conta = value; }
        }
        public String Descr
        {
            get { return descr; }
            set { descr = value; }
        }
        public Double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public String getLinhaLancamento() {
            String linha = "";
            linha += Utils.preencher(conta, 15," ", 2) + " ";
            linha += Utils.preencher(descr, 50, " ", 1) + " ";
            linha += Utils.preencher(saldo.ToString(), 18, " ", 2);
            return linha;
        }

    }
}
