using System;

namespace CursoCSharp.Aula2
{
    class Aula3
    {
        static void Main245()
        {
            //double MEDIA_APROVACAO = 7;
            //double MEDIA_REPROVACAO = 6;

            //Console.Write("Digite a 1° nota: ");
            //double.TryParse(Console.ReadLine(), out double nota1);

            //Console.Write("Digite a 2° nota: ");
            //double.TryParse(Console.ReadLine(), out double nota2);

            //double media = (nota1 + nota2) / 2;

            //if (media >= MEDIA_APROVACAO)
            //{
            //    Console.WriteLine($"A sua média é : {media}");
            //    Console.WriteLine("Aprovado");
            //}
            //else if (media < MEDIA_REPROVACAO)
            //{
            //    Console.WriteLine($"A sua média é : {media}");
            //    Console.WriteLine("Reprovado");
            //}
            //else
            //{
            //    Console.WriteLine($"A sua média é : {media}");
            //    Console.WriteLine("Aprovado Conselho");
            //}

            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }
        }
    }
}
