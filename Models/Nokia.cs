using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace terceiroDesafioCSharp.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo {nome} pela Google Play Store");
        }
    }
}