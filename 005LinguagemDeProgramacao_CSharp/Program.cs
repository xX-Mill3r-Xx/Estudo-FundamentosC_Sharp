using System;

namespace _005LinguagemDeProgramacao_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Variaveis

            Definição:
            Uma variavel é algo que utilizamos para armazenar uma informação;
            - Ser variavel, siguinifica que seu valor pode ser alterado a qualquer momento;
            - Sempre que criamos uma variavel, dizemos que estamos inicializando ela;

            Podemos usar um tipo ou palavra reservada var para criar uma variavel
            - NO c#, o tipo vem sempre antes do nome da variavel;
            - Podemos informar um valor ja na criação da variavel;
            - Se não informado, o valor padrão sera aplicado;

            Exemplos:

            int idade; Correto inicia com zero
            int idade = 25; Correto inicia com 25;
            var idade = 25; Correto inicia com 25;
            var idade; Errado

            ### BOAS PRATICAS ###

            - Utilize nomes coesos
            - Não utilize caracteres especiais
            - Não utilize numeros
            - A primeira letra de cada palavra é sempre minuscula
             */

            /* Exemplo de uma variavel do tipo string recebendo um texto;*/

            #region Hello World
            //Console.Write("Escreva Olá Mundo: ");
            //string helloWorld = Console.ReadLine();
            //Console.WriteLine($"Voce digitou seu primeiro '{helloWorld}', parabéns!");
            #endregion

            /*Constantes:
             * Caracteristicas;
             Uma constante é uma variavel que não pode ser alterada ou seja, ela é constante e nunca muda;
            - Uma vez criadas somos obrigados a atribuir um valor e feito isso, não poderão ser modificadas
            - Não funcionam com a utilização de var;
            - São mais otmizadas que variaveis;
            - Recomendadas para usos frequentes;

            - A definição de constante é dada pela palavra reservada const antes do tipo;
            - Caso não seja informado um valor, o valor padrão será atribuido;

            ### BOAS PRATICAS ###

            - É comum vermos constantes todas em maiusculo, separadas por _
            - A ideia é bater o olho e saber que aquilo é uma constante;
             */

            /*Exemplo de uma constante*/

            #region Constante
            //const double PI = 3.1415;
            //Console.WriteLine($"o valor de pi é {PI}. este valor é uma constante");
            #endregion

            /*Tipos Primitivos
             
            */

            Console.ReadLine();
        }
    }
}
