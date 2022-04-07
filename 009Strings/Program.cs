using System;
using System.Globalization;
using System.Text;

namespace _009Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Guids
             */
            var id = Guid.NewGuid(); // Criando um indentificador global unico;
            id.ToString(); // transforma o id para string

            id = new Guid("9687a4e3-a3fa-4cd0-b32d-2504d6a3b9fd");

            Console.WriteLine(id);
            /*O resultado deste identificador é um Hash, que gera um numero unico e com poucas ou quase nenhuma chance de se reptir dentro da nossa aplicação*/

            /*----------------------------------------------------------------------------------------------------------*/
            /*Interpolação de Strings
             */
            double price = 10.2;
            string text = $"O preço do produto é: R${price.ToString("F2", CultureInfo.InvariantCulture)}"; // Exemplo de uma string usando a interpolação de caracteres;
            Console.WriteLine(text);

            /*Obs.: Usei o using System.Globalization; para converter as casas decimais do price*/
            text = string.Format("O preço do produto é {0}", price); // O string.Format - formata uma cadeia de caracteres;
            Console.WriteLine(text);

            text = "O preço do produto é: R$" + price; //Forma normal de concatenação;
            Console.WriteLine(text);
            /*----------------------------------------------------------------------------------------------------------*/

            /*Comparação de textos
             */
            string text1 = "Testando";
            Console.WriteLine(text1.CompareTo("Testando")); // Comparando

            text1 = "Esse texto é um teste?";
            Console.WriteLine(text1.Contains("teste")); // Este metodo, compara se a string passada contem um ou mais caracteres definidos entre parametros;

            /*----------------------------------------------------------------------------------------------------------*/

            /*Equals*/
            Console.WriteLine(text1.Equals("Testando")); // Este metodo compara se o texto1´é igual a string passada entre parametros;
            // Todos os objetos dentro do C# possuem este metodo;

            /*----------------------------------------------------------------------------------------------------------*/

            /*Indices*/
            // Os indices indicam uma posição dentro de uma lista ou array;
            string teste = "Este texto é um teste";
            Console.WriteLine(teste.IndexOf("texto")); // indica que a primeira posição em que a palavra texto aparece neste caso é a posição 5
            //obs.: Lembrando que os indices em C# começam com 0;

            Console.WriteLine(teste.LastIndexOf("s")); // indica que a ultima posição da letra passada entre parametros foi a posição numero 18;
            /*----------------------------------------------------------------------------------------------------------*/

            /*Metodos Adicionais*/

            Console.WriteLine(teste.ToLower()); // Converte o texto todo para minusculo;
            Console.WriteLine(teste.ToUpper()); // Converte o texto todo para maiusculo;
            Console.WriteLine(teste.Insert(5, "X")); // substitui o texto original pela passada entre parametros na posição do incice passado;
            Console.WriteLine(teste.Remove(5,5)); // Remove todo o conteudo passado a partr da posição passada e na quantidade de caracteres passado em seguida; Exemplo, (5,5) vai remover a partir do 5° caracter - 5 caracteres do valor passado;
            Console.WriteLine(teste.Length); // retorna em inteiro o tamanho do valor contido na variavel;

            /*----------------------------------------------------------------------------------------------------------*/

            /*Manipulando strings*/

            Console.WriteLine(teste.Replace("Este", "Isto")); // Substitui tudo passado pelo segundo valor passado;
            var divisao = teste.Split(' '); // pega toda a string e quebra em espaços;
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);
            Console.WriteLine(divisao[4]);

            var resultado = teste.Substring(5, 5);
            Console.WriteLine(resultado);

            /*----------------------------------------------------------------------------------------------------------*/

            /*StringBuilder*/

            //Modo errado de escrever 
            var texto2 = "Novo Texto";
            texto2 += " 123456789";
            Console.WriteLine(texto2);

            //usando o StringBuilder
            var texto3 = new StringBuilder();
            texto3.Append("Esta é uma boa forma de escrever grandes textos");
            Console.WriteLine(texto3);

            Console.ReadLine();
        }
    }
}
