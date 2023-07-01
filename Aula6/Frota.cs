using System;

namespace CursoCSharp.Aula6
{
    class Frota
    {
        public static void Main1010()
        {
            Carro carro = new Carro();

            carro.marca = "BMW";
            carro.modelo = "320i";
            carro.ano = 2023;
            carro.aro = 17;
            carro.anoModelo = 2024;

            Carro carro2 = new Carro();

            carro2.marca = "AUDI";
            carro2.modelo = "A1";
            carro2.ano = 2023;
            carro2.aro = 20;
            carro2.anoModelo = 2024;
        }
    }
}
