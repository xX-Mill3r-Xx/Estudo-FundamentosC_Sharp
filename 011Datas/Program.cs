using System;

namespace _011Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Tipos em C# que são dedicados a datas
             */

            //tipo dateTime;
            Console.Clear();
            DateTime data = new DateTime(); // O tipo dateTime é um Struct
            //Obs.: O new DateTime quando chamado assim, mostra a data padrão;

            /*Obtendo datas*/
            //data = DateTime.Now; // Mostra a data de hoje
            data = new DateTime(2022, 10, 12, 8, 23, 14); // formatado com os valores passados;

            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);

            /*Formatando datas*/
            // para anos = YYYY
            // para mes = MM
            // pada dias = dd
            // para Horas = HH
            // para minutos = mm
            // para segundos = ss

            var format = string.Format("{0:dd/MM/yyyy HH:mm:ss}", data);
            Console.WriteLine($"Formato: {format}");

            /*Padroes de formatação*/
            var padrao = string.Format("{0:f}", data); // só um exemplo de formatação
            Console.WriteLine(padrao);

            /*Adcionando valores*/

            var dia = data.AddDays(12);
            data.AddYears(3);
            Console.WriteLine(dia);

            /*TimeSpan*/
            var timeSpan = new TimeSpan();
            Console.WriteLine($"Time span = {timeSpan}");
            var meSpanNanoSeg = new TimeSpan(1);
            Console.WriteLine($"Um nano segundos = {meSpanNanoSeg}");
            var timeSpanHMS = new TimeSpan(5, 12, 8);
            Console.WriteLine($"Hora minuto e segundo = {timeSpanHMS}");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Para saber quantos dias em um mes = Mes 4: {DateTime.DaysInMonth(2022,4)}");
        }
    }
}
