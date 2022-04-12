using System;
using System.Globalization; // import para formatação

namespace _012Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            /*Para trabalharmos com valores de moedas, geralmente utilizamos o decimal*/

            decimal valor = 10.25m;
            Console.WriteLine($"O valor é {valor} - Padrao BR");

            /*Formatando moedas*/

            Console.WriteLine($"O valor formatado {valor.ToString("F2", CultureInfo.InvariantCulture)} - Padrao USA");

        }
    }
}
