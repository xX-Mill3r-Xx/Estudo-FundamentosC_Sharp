using System;
using System.IO;

namespace _008EditorDeTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Text Editor";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            /**/
            Console.Clear();
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que voce deseja fazer?");
            Console.WriteLine("1 - Abrir Arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - SAIR");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;

                case 1:
                    Open();
                    break;

                case 2:
                    Edit();
                    break;

                default:
                    Menu();
                    break;
            }
        }

        static void Open()
        {
            Console.Clear();
            Console.Write("Digite o caminho: ");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.WriteLine();
            Console.ReadLine();
            Menu();
        }

        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("----------------------------------------------------------------------------------------");

            string text = "";
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.Write("Digite o caminho: ");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.WriteLine($"Arquivo salvo com sucesso! {path}");
            Console.ReadLine();
            Menu();
        }
    }
}
