using System;

namespace sa03_brick_race
{
    internal static class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                ExibirMenu();
                string opcao = Console.ReadLine()?.Trim() ?? string.Empty;

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Iniciando o jogo...");
                        Console.WriteLine("Pressione Enter para continuar.");
                        Console.ReadLine();
                        break;

                    case "2":
                        ExibirInstrucoes();
                        break;

                    case "0":
                        Console.WriteLine("Encerrando o programa...");
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Pressione Enter para voltar ao menu.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private static void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("=== BRICK RACE ===");
            Console.WriteLine("1 - Iniciar jogo");
            Console.WriteLine("2 - Instruções");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
        }

        private static void ExibirInstrucoes()
        {
            Console.Clear();
            Console.WriteLine("INSTRUÇÕES DO JOGO");
            Console.WriteLine();
            Console.WriteLine("Objetivo: evite os obstáculos e sobreviva o maior tempo possível.");
            Console.WriteLine("Controles:");
            Console.WriteLine("- A ou seta esquerda: mover para a esquerda");
            Console.WriteLine("- D ou seta direita: mover para a direita");
            Console.WriteLine("- ESC: sair da partida");
            Console.WriteLine();
            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();
        }
    }
}
