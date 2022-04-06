using System;
using System.Globalization;
using Operacoes;

namespace _006CriandoUmaCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Neste modulo, embora eu tenha acompanhado as aulas do curso, tentei fazer esta calculadora usando o conhecimento do qual ja possuo.
            Os codigos ensinados pelo professor deste curso é em alguns aspectos difrente deste ao qual eu escrevi;
             */

            /*Layout*/
            #region Layout do sistema
            Console.Title = "Calculator";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            #endregion
            /**/

            /*Passando os valores*/
            #region Valores
            Console.Clear();
            Console.WriteLine();
            Console.Write("Entre com o Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.Write("Entre com o Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("-----------------------------------------------------------------");
            #endregion
            /**/

            /*Exibindo Valores*/
            #region Exibcao
            Console.WriteLine("Qual operação deseja realizar?");
            Console.Write("1 = soma\n" +
                "2 = subtração\n" +
                "3 = multiplicação\n" +
                "4 = divisão\n" +
                "5 = SAIR");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.Write("Entre com o valor correspondente: ");
            Inicio:
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Soma sum = new Soma(v1, v2);
                    Console.WriteLine(sum);
                    break;

                case 2:
                    Subtracao sub = new Subtracao(v1, v2);
                    Console.WriteLine(sub);
                    break;

                case 3:
                    Multiplicacao mult = new Multiplicacao(v1, v2);
                    Console.WriteLine(mult);
                    break;

                case 4:
                    Divisao div = new Divisao(v1, v2);
                    Console.WriteLine(div);
                    break;

                case 5:
                    System.Environment.Exit(0);
                    break;

                default:
                    Console.Write("Entre com o valor correspondente: ");
                    goto Inicio;
            }
            Console.WriteLine("-----------------------------------------------------------------");
            #endregion
            /**/

            Console.ReadLine();
        }
    }
}
