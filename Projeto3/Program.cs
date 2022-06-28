using System;

namespace GFT_Teste3
{
    class Program
    {
        public static void Main(string[] args)
        {

            var trabalhadores = new List<Trabalhador>();

            var trabalhador1 = new Trabalhador("Joao", 10, 40);
            trabalhadores.Add(trabalhador1);

            var trabalhador2 = new Trabalhador("Cleber", 15, 30);
            trabalhadores.Add(trabalhador2);

            var trabalhador3 = new Trabalhador("Cleiton", 17, 50);
            trabalhadores.Add(trabalhador3);

            var trabalhador4 = new Trabalhador("Matheus", 8, 80);
            trabalhadores.Add(trabalhador4);

            var trabalhador5 = new Trabalhador("Jorge", 30, 10);
            trabalhadores.Add(trabalhador5);


            Console.WriteLine("Olá, temos os seguintes trabalhadores registrados: ");

            int i = 1;

            foreach (var trabalhador in trabalhadores)
            {
                System.Console.WriteLine($"{i}- Nome: {trabalhador.Nome}");
                i++;
            }


            int opcaoUsuario = 0;

            do
            {
                Console.WriteLine("Qual trabalhador você deseja consultar?");

                opcaoUsuario = Int32.Parse(Console.ReadLine());

                if (opcaoUsuario < 1 || opcaoUsuario > i) Console.WriteLine("Opção inválida. Tente novamente.");


            } while (opcaoUsuario < 1 || opcaoUsuario > i);


            var trabalhadorConsultado = trabalhadores[opcaoUsuario - 1];

            Console.WriteLine($"Trabalhador consultado: {trabalhadorConsultado.Nome} | Salário por Hora: R${trabalhadorConsultado.SalarioHora} | Horas trabalhadas: {trabalhadorConsultado.HorasTrabalhadas}");

            Console.WriteLine($"Salário calculado: R${trabalhadorConsultado.SalarioTotal}");
        }
    }
}
