using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace terceiroDesafioCSharp.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public void Ligar()
        {
            Console.WriteLine($"Ligando do meu {Modelo}");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação");
        }
        
        public abstract void InstalarAplicativo(string nome);
    }
}