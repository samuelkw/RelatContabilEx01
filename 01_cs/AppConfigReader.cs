using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_cs
{
    public class AppConfigReader
    {
        public String strConn { get; set; }

        public AppConfigReader()
        {
             AppSettingsReader lerAppCfg = new AppSettingsReader();
            try
            {
                strConn = lerAppCfg.GetValue("STRCONN", typeof(String)).ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao ler arquivo de configuração");
                throw e;
            }
        }

    }
}
