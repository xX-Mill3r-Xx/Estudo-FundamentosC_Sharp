using System;

namespace _014Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            /**/
            var arr = new int[3];

            /*Bloco try/catch*/
            try
            {
                //for (int i = 0; i < 10; i++)
                //{
                //    Console.WriteLine(arr[i]);
                //}

                
                Console.Write("Entre com um valor string: ");
                string txt = Console.ReadLine();
                Cadastrar(txt);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine("Falha ao cadastrar o texto");
                Console.WriteLine(value: e.Message);
            }
            catch (MinhaExeption e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.QuandoAconteceu);
                Console.WriteLine(value: e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(value: e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ops, Deu ruim");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Chegou ao fim");
            }
        }

        static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new ArgumentNullException("O texto não pode ser nulo");
                throw new MinhaExeption(DateTime.Now);
            }
        }

        //Excessoes personalizadas
        public class MinhaExeption : SystemException
        {
            public DateTime QuandoAconteceu { get; set; }

            public MinhaExeption(DateTime quandoAconteceu)
            {
                QuandoAconteceu = quandoAconteceu;
            }
        }
    }
}
