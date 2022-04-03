using System;

namespace _004DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tipos de projetos
             Definiçoes:

            - Class Library;
              - O resultado final é uma dll, não possui interface;

            - Console Application
              - O resultado final é uma aplicação que roda no terminal. Pode receber dados, esperar input do usuario;

            - Projetos Web;
              - ASP.NET Web
              - ASP.NET MVC
              - ASP.NET WebAPI

            -Projetos Teste;
              - Microsoft Tests
             */

            /* Comandos do CLI
             
            - Novo Console Application = dotnet new console
            - Nova Class Library = dotnet new classlib
            - Novo Projeto ASP.NET Core = dotnet new web
            - Novo Projeto ASP.NET Core = dotnet new mvc
            - Novo Projeto ASP.NET Core = dotnet new webapi
            - Novo Projeto Microsoft Tests = dotnet new mstest

            obs.: Criar um projeto é o mesmo que gerar os arquivos iniciais de uma aplicação;
            - Vai sempre gerar os arquivos na pasta atual;
            - Para especificar a pasta podemos usar o "-o" exemplo: dotnet new console -o MeuApp
            vai criar uma nova pasta chamada MeuApp com os arquivos dentro;
             */
        }
    }
}
