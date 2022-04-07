using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("<MODO EDITOR>");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine();
            Inicio:
            Console.Write("Deseja salvar o arquivo? (s/n): ");
            char result = char.Parse(Console.ReadLine().ToLower());
            if(result == 's')
            {
                // aqui salva o arquivo
                Console.WriteLine("Arquivo salvo com sucesso!");
                Console.ReadKey();
                Viewer.Show(file.ToString());
            }
            else if(result == 'n')
            {
                // aqui volta para o editor;
                Show();
            }
            else
            {
                Console.WriteLine("Digite uma opção valida!");
                goto Inicio;
            }
        }
    }
}
