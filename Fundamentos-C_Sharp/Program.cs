using System;

namespace Fundamentos_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introdução a Linguagem de programação;

            #region Linguagem de programação

            /*
             * Linguagem de programação
             * 
              Definiçoes;

            - É uma forma (Comunicação) como dizemos para o computador executar algo.
            - Computadores não falam nossa limbgua, usam binario.
            - Uma LP faz este intermediario.
            - O que escrevemos será traduzido para binario.
            - Em resumo, temos um arquivo texto que 
             - Nos conseguimos ler
             - Será traduzido para binario

            Obs.: Este processo de "Tradução" é conhecido como compilação.
            - Existem varias linguagens de programação, cada uma com seu compilador.
            - Cada compilador trabalha de uma forma;

            Nota:(Compilador: - Agente que executa a compilação, que é transformar o texto que escrevemos para binario(0 e 1));
             */

            #endregion

            /*-------------------------------------------------------------------------------------------------------------*/

            #region Baixo e Alto nivel

            /*Baixo e Alto nivel
             Definições;

            - Ao enviar uma instrução ao computador estamos falando em nivel de maquina.
            - Estas instruçoes sempre serão no formato binario.
            - Quanto mais detalhada a necessidade, mais baixo o nivel.
            - As linguagens mais modernas como C# e Java são consideradas de alto nivel.

            - Optamos por linguagens de alto nivel, por fornecer um acesso a tudo que precisamos a nivel de hardware ja pronto;
             */

            #endregion

            /*-------------------------------------------------------------------------------------------------------------*/

            #region Linguagens Compiladas

            /*Linguagens Compiladas
             Definiçoões;

            #Linguagens Compiladas
            - Dada quando existe o processo de compilação da mesma.
            - Consiste em receber um arquivo e converte-lo para binario.
            - Normalmente otimizado para leitura de humanos.

            #Linguagens Interpretada:
            - Arquivo de texto:
              - Lidos e interpretados por um interprete.
              - Feito em tempo de execução.
            - JavaScript é interpretado

            Nota:(Tempo de execução: - É o que acontece durante a execução do codigo pelo computador ou interpretador)

            No caso do JavaScript.
            - O navegador é escrito em uma linguagem de alto nivel
            - Possui um interpretador
            - Lê e executa um arquivo de texto JavaScript
             */

            #endregion

            /*-------------------------------------------------------------------------------------------------------------*/

            #region Linguagens compiladas Vs Interpretadas

            /*Linguagens compiladas Vs Interpretadas
             
            Definições;

            - Provavelmente utilizará ambas
            - Não se prenda a uma linguagem
            - Aprenda bem uma, mas conheça outras

            #Prós da Linguagen Interpretadas:
            - Não precisa ser compilada.
            - Correções mais faceis de serem executadas.
            - Mais simples de serem distribuidas.

            #Contras da linguagem Interpretada
            - Detecção de erros.
              - Somente em tempo de execução.
            - Tamanho final da aplicação maior.
            - Menor otmização da execução
            - Multiplos arquivos.

            #Prós da linguagen Compilada
            - Tempo de compilção.
              - Detecção mais rapda de erros
            - Tamanho menor da aplicações.
            -Maior otimização da execução.
            - Apenas um arquivo final.

            #Contras da linguagem Compilada
            - Precisa de um compilador.
            - Pode ser mais burocratica.

             */
            #endregion

            /*-------------------------------------------------------------------------------------------------------------*/

            #region Tipagem de dados

            /*Tipagem de dados
             * Definições;
             * 
             * - Tambem chamadas de fortemente tipadas.
             * - Obrigam a especificar o tipo de dados da informação.
             * - Menor liberdade.
             * - Maior otimização.
             * 
             * Nota:(Tipo de dados: Um tipo de dado define o formato dele, onde definimos por exemplo que aquela informação é um numero, uma letra, uma cadeia de caracteres e assim por diante).
             * 
             * Resumo:
             * - Definir tipos é padronizar os dados
             *   - Para nos e para o precessador/memoria.
             * - O let em (JavaScript) utiliza sempre o mesmo tamanho de alocação.
             * - Tipando temos uma otimização.
             * 
             * No c# por exemplo:
             * int ocupa 32-bits
             * float ocupa 32-bits
             * double ocupa 64-bits
             * decimal ocupa 128-bits
             */

            #endregion

            /*-------------------------------------------------------------------------------------------------------------*/
        }
    }
}
