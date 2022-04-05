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
             
            Definiçoes:
            - Tambem conhecidos como build-in types, são tipos cujo outos tipos (Complexos) irão derivar;
            - Definir o tipo correto otimiza a execução do programa;
            - São chamados de Tipos de Valor (Value Types);
            - Armazenam o valor e não a referencia para um item na memoria;
            - São classificados em 
              - Tipos simples (Simple Types)
              - Enumeradores (Enums)
              - Estrtuturas (Structs)
              - Tipos Nulos (Nullable Types)

            - Cada tipo possui uma capacidade;
            - Caso esta capacidade exceda, o programa gera um erro;
            - Esta capacidade pré-definida ajuda na otimização do seu programa, por ex.: o int que usamos previamente
              -2,147,483,648 até 2,147,483,647
            */

            /*Byte
             
            - O tipo byte é utilizado para representar um byte de fato
            - Em diversos casos, precisamos da cadeia de bytes de um arquivo por exemplo, tambem chamado de byte array;
            - Temos tambem o sbyte que permite valores negativos;
             - byte(8-bit) = 0 até 255;
             - sbyte(8-bite) = -128 até 127

            - Note que o sbyte permite valores negativos, por isso no nome sbyte, que siguinifica Signed Byte;

             */

            #region byte
            //byte meuByte = 127;
            //Console.WriteLine(meuByte);
            #endregion

            /*
             Object:

            Definiçoes:
            - Tipo generico que recebe valor ou objeto;
            - Não possui intelisense (Ajuda dos editores) por ser um tipo desconhecido;
            _ Evitar o uso;

            Exemplos.:
             */

            #region Object
            //object idade = 25;
            //object nome = "Miller";
            #endregion

            /*
             Null

            Definiçoes;
            - Siguinifica vazio, nada;
            - Diferente de zero ou uma string vazia;
            - Todo tipo, primitivo ou complexo, pode receber o valor null;
            - O tipo deve ser marcado como Nullable Type;

            Exemplo de marcação para definir um tipo como null;
             */

            #region Null
            //int? numero = null;
            //string? nome = null;
            #endregion

            /*Alias
             
            Definiçoes;
            - Alias é um apelido que todo tipo no .Net tem;
            Exemplo:
              - System.String tem o alias string

            obs.: Como o C# é Case Sensitive, tanto faz se escrevermos um ou outro, porem, o recomendado é sempre usar o alias;

            Exemplo.: No caso abaixo, o resultado é o mesmo;
             */

            #region Alias
            //int idade = 25; // alias
            //Int32 idade1 = 25; //tipo
            #endregion

            /*Valores padroes;
             
            Quando definimos um tipo em C#, ele sempre vem com um valor padrão, nunca nulo;

            Definiçoes:
            - Todo tipo built-in ja possui um valor padrao;
            - Se nenhum valor for informado, seu valor sera o valor padrão;
            exemplos valores padroes;
              - int = 0;
              - float = 0f;
              - decimal = 0m;
              - bool = false;
              - char = '\0';
              - string = "";
             */

            /*Conversão de dados;
             Implicitas;

            Definiçoes: 
            - É comum precisarmos trasformar um dado do tipo X para tipo Y;
            - Existem dois tipos de conversão, as inplicitas e as explicitas;
            - As implicitas são coversões que podem ser executadas apenas com a passagem de dados. Possui tipos compativeis;

            Exemplo de uma conversão implicita:
             */

            #region Implicita
            //float valor = 25.8f; //valor tipo float;
            //int outro = 25; // valor tipo inteiro;

            //valor = outro; // o tipo float aceita um valor do tipo inteiro;
            #endregion

            /*Conversão de dados;
            Explicitas; 

            Definiçoes;
            - Ocorre quando os tipos não são compativeis;
            - É dada pelo uso do tipo entre parenteses antes da atribuição;
            - Segue as mesmas regras anteriores;

            Exemplo de uma conversão explicita;
             */

            #region Explicita
            //int inteiro = 100;
            //uint inteiroSemSinal = (uint)inteiro; // Convensão explicita;
            #endregion

            /*Metodo Parse
             
            Definiçoes:
            - Metodo presente em todo tipo primitivo;
            - Usado para converter um caractere ou string para um tipo qualquer;
            - Caso haja alguma incompatibilidade, gera um erro;

            Exemplo.:
             */

            #region Parse
            //int numInteiro = int.Parse("100");
            #endregion

            /*Metodo Convert
             
            Definiçoes:
            - Similar ao parse;
            Permite converter varios tipos de valores;
            - Devemos informar o tipo na chamada da conversão;

            Exemplo:
             */

            #region Convert
            //int inteiro = Convert.ToInt32("100");
            #endregion

            /*Metodos e Funçoes
             
            Definiçoes:
            - Podemos segmentar nosso programa em funçoes
            - Tambem conhecidos como metodos;
            - Possui um retorno, um nome e parametro;
            - Esta composiçao é chamada de assinatura;
            - Começa sempre com letra maiuscula;

             */
            #region Um metodo void na pratica
            MeuMetodo();
            #endregion

            #region Metodo com retorno na pratica
            string nome = RetornaNome("Miller");
            #endregion

            Console.ReadLine();
        }

        static void MeuMetodo()
        {
            Console.WriteLine("Um metodo na pratica");
        }

        static string RetornaNome(string nome)
        {
            return "nome";
        }
    }
}
