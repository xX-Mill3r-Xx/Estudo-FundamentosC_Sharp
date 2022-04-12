using System;

namespace _013Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            /*Listas*/

            /*Percorrendo um array*/

            int[] meuArray = new int[10];

            //Inserindo valores
            for(int i = 0; i < 10; i++)
            {
                meuArray[i] = i;
                //Console.WriteLine($"O valor do meu array é {meuArray[i]}");
            }

            //Exibindo valores
            foreach(var obj in meuArray)
            {
                Console.WriteLine($"Valor {obj}");
            }
        }
    }
}
