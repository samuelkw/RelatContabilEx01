using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_cs
{
    public class Utils
    {
        public static String preencher(String valor, int tam, String car, int opt)
        {
            switch (opt)
            {
                case 1:
                    while (valor.Length < tam)
                    {
                        valor = valor + car;
                    }
                    break;
                case 2:
                    while (valor.Length < tam)
                    {
                        valor = car + valor;
                    }
                    break;
            }
            return valor;
        }

        public static String poeBarra(String valor)
        {
            valor = valor.TrimEnd().EndsWith("\\") ? valor.TrimEnd() : valor.TrimEnd() + "\\";
            return valor;
        }
    }
}
