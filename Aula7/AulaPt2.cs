using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula7
{
    class AulaPt2
    {
        public string Modelo;
        public string Marca;
        public int Ano;
        public AulaPt2(string modelo, string marca, int ano)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
        }

        public AulaPt2() { }
    }

    class Exemplo01
    {
        public static void Main123()
        {
            AulaPt2 Carro01 = new AulaPt2
            {
                Modelo = "Celta",
                Marca = "GM",
                Ano = 2009
            };

            AulaPt2 Carro02 = new AulaPt2("FOX", "VW", 2017);

            Console.WriteLine($"Modelo: {Carro01.Modelo}");
            Console.WriteLine($"Modelo: {Carro02.Modelo}");

        }
    }
}
