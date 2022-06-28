using System;

namespace GFT_Teste1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Construindo matriz....");

            Console.WriteLine("Qual será o numero de linhas?");

            var linhas = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Qual será o numero de colunas?");

            var colunas = Int32.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];


            for (var coluna = 0; coluna < colunas; coluna++)
            {
                for (var linha = 0; linha < linhas; linha++)
                {
                    System.Console.WriteLine($"Qual será o valor da célula de posicão {linha}:{coluna}?");
                    matriz[linha, coluna] = Int32.Parse(Console.ReadLine());
                }
            }

            for (var coluna = 0; coluna < colunas; coluna++)
            {
                for (var linha = 0; linha < linhas; linha++)
                {
                    System.Console.WriteLine($"");

                    System.Console.WriteLine($"Valores ao redor da célula de posicão {linha}:{coluna}");
                    try
                    {
                        var celulaTeste = matriz[linha - 1, coluna];
                        System.Console.WriteLine($"Célula esquerda: {celulaTeste}");
                    }
                    catch (System.Exception ex)
                    {
                        System.Console.WriteLine("Não tem nenhum valor à esquerda.");
                    }
                    try
                    {
                        var celulaTeste = matriz[linha + 1, coluna];
                        System.Console.WriteLine($"Célula direita: {celulaTeste}");
                    }
                    catch (System.Exception ex)
                    {
                        System.Console.WriteLine("Não tem nenhum valor à direita.");
                    }
                    try
                    {
                        var celulaTeste = matriz[linha, coluna - 1];
                        System.Console.WriteLine($"Célula acima: {celulaTeste}");
                    }
                    catch (System.Exception ex)
                    {
                        System.Console.WriteLine("Não tem nenhum valor acima.");
                    }
                    try
                    {
                        var celulaTeste = matriz[linha, coluna + 1];
                        System.Console.WriteLine($"Célula abaixo: {celulaTeste}");
                    }
                    catch (System.Exception ex)
                    {
                        System.Console.WriteLine("Não tem nenhum valor abaixo.");
                    }
                }
            }
        }
    }
}
