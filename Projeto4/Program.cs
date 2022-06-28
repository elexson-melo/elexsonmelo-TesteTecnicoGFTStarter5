using System;

namespace GFT_Teste4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número entre 3 e 999 para verificar seus números primos: ");
            int n = int.Parse(Console.ReadLine());
            bool primo = true;

            while (n <= 3 && n >= 999)
            {
                Console.WriteLine("Número inválido, digite novamente");
                Console.WriteLine("Digite um número entre 3 e 999 para verificar seus números primos: ");
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 2; i < n; i++)
            {
                if (i % 2 == 0 && i / i == 1)
                {
                    Console.Write("Números primos: " + i + " ");
                }
            }
        }
    }
}