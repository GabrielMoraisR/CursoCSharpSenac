using System;

namespace CursoCSharp.Aula2
{
    class ForEach
    {
        public static void Main1a01()
        {
            //int[] fiveElements = new int[5] { 0, 1, 2, 3, 4 };

            //Console.WriteLine($"O Arraay selecionado foi: {fiveElements[1]}");

            //string[] notNumber = new string[10]{"1","2","3","4","5","6","7","8","9","10"};

            //notNumber[0] = "0";
            //notNumber[1] = "1";
            //notNumber[2] = "10";
            //notNumber[3] = "3";
            //notNumber[4] = "4";
            //notNumber[5] = "5";

            //Console.WriteLine($"O Arraay selecionado foi: {notNumber[2]}");

            //string nome = "ADAMASTOR";

            //foreach (char letra in nome)
            //{
            //    Console.WriteLine(letra);
            //}

            int numero = 1;
            while (numero <= 10)
            {
                Console.WriteLine(numero);
                numero++;
            }

            Console.WriteLine("-----------------");

            for (int j = 0; j <= 20; j += 2)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("-----------------");

            int numero1;

            do
            {
                Console.WriteLine("Digite um número:");
                numero1 = int.Parse(Console.ReadLine());
            } while (numero1 != 0);

            Console.WriteLine("-----------------");


            string[] cities = new string[5]{ "New York", "Los Angeles", "Chicago", "Houston", "Phoenix"};

            foreach (string letra in cities)
            {
                Console.WriteLine(letra);
            }

            Console.WriteLine("-----------------");

            int numero3;
            Console.Write("Digite um número inteiro positivo: ");
            numero3 = int.Parse(Console.ReadLine());
            int i = 0;
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= numero3);
        }
    }
}