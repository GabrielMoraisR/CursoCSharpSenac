using System;

namespace CursoCSharp.Aula7
{
    class Feirante
    {
        public string Nome;
        public string Categoria;
        public string PlacaVeiculo;
        public int NumeroBarraca;
        public double Metragem;
    }

    class TesteAulaDz7
    {
        public static void Main33()
        {
            Feirante Feirante1 = new Feirante
            {
                Nome = "Barraca do Mauro",
                Categoria = "Pastel",
                PlacaVeiculo = "AAA1B22",
                NumeroBarraca = 1,
                Metragem = 10.50,
            };

            Feirante Feirante2 = new Feirante
            {
                Nome = "Barraca da Maria",
                Categoria = "Frutas",
                PlacaVeiculo = "BBB3C44",
                NumeroBarraca = 2,
                Metragem = 8.75,
            };

            Feirante Feirante3 = new Feirante
            {
                Nome = "Barraca do João",
                Categoria = "Comida Vegana",
                PlacaVeiculo = "CCC5D66",
                NumeroBarraca = 3,
                Metragem = 12.20,
            };

            Feirante Feirante4 = new Feirante
            {
                Nome = "Barraca da Ana",
                Categoria = "Doces",
                PlacaVeiculo = "DDD7E88",
                NumeroBarraca = 4,
                Metragem = 6.80,
            };

            Feirante Feirante5 = new Feirante
            {
                Nome = "Barraca do Carlos",
                Categoria = "Churrasco",
                PlacaVeiculo = "EEE9F00",
                NumeroBarraca = 5,
                Metragem = 15.60,
            };

            Console.WriteLine($"Nome do Feirante: {Feirante1.Nome}");
            Console.WriteLine($"Tipo da Barraca: {Feirante1.Categoria}");
            Console.WriteLine($"Placa do Veículo: {Feirante1.PlacaVeiculo}");
            Console.WriteLine($"N° da Barraca: {Feirante1.NumeroBarraca}");
            Console.WriteLine($"Metragem da Barraca: {Feirante1.Metragem}");
            Console.WriteLine();

            Console.WriteLine($"Nome do Feirante: {Feirante2.Nome}");
            Console.WriteLine($"Tipo da Barraca: {Feirante2.Categoria}");
            Console.WriteLine($"Placa do Veículo: {Feirante2.PlacaVeiculo}");
            Console.WriteLine($"N° da Barraca: {Feirante2.NumeroBarraca}");
            Console.WriteLine($"Metragem da Barraca: {Feirante2.Metragem}");
            Console.WriteLine();

            Console.WriteLine($"Nome do Feirante: {Feirante3.Nome}");
            Console.WriteLine($"Tipo da Barraca: {Feirante3.Categoria}");
            Console.WriteLine($"Placa do Veículo: {Feirante3.PlacaVeiculo}");
            Console.WriteLine($"N° da Barraca: {Feirante3.NumeroBarraca}");
            Console.WriteLine($"Metragem da Barraca: {Feirante3.Metragem}");
            Console.WriteLine();

            Console.WriteLine($"Nome do Feirante: {Feirante4.Nome}");
            Console.WriteLine($"Tipo da Barraca: {Feirante4.Categoria}");
            Console.WriteLine($"Placa do Veículo: {Feirante4.PlacaVeiculo}");
            Console.WriteLine($"N° da Barraca: {Feirante4.NumeroBarraca}");
            Console.WriteLine($"Metragem da Barraca: {Feirante4.Metragem}");
            Console.WriteLine();

            Console.WriteLine($"Nome do Feirante: {Feirante5.Nome}");
            Console.WriteLine($"Tipo da Barraca: {Feirante5.Categoria}");
            Console.WriteLine($"Placa do Veículo: {Feirante5.PlacaVeiculo}");
            Console.WriteLine($"N° da Barraca: {Feirante5.NumeroBarraca}");
            Console.WriteLine($"Metragem da Barraca: {Feirante5.Metragem}");
            Console.WriteLine();
        }
    }
}
