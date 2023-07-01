using System;

namespace CursoCSharp.Aula9
{
    class Params
    {
        public static void Apresentar(params string[] marcas)
        {
            foreach(string marca in marcas)
            {
                Console.WriteLine($"Tops Melhores Marcas {marca}");
            }
        }
        public static void Main123()
        {
            Apresentar("Apple", "Coca - Cola", "Samsung", "Toyota", "Mercedes - Benz", "Nike", "Adidas", "BMW", "Microsoft", "Amazon");
        }
    }
}
