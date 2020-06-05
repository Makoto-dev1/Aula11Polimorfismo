using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculos Player = new Calculos();

            //nenhum argumento
            System.Console.WriteLine( Player.Calcular() );

            //1 argumento int
            System.Console.WriteLine( Player.Calcular(100) );

            //2 argumentos int
            System.Console.WriteLine( Player.Calcular(100,50) );

            //2 argumentos string
            System.Console.WriteLine( Player.Calcular("Jack", "Sparrow") );


        }
    }
}
