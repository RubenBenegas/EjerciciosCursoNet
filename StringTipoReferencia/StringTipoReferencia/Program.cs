using System;
using System.Threading;

namespace StringTipoReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Los objetos del tipo string son por referencia, ya que son objetos inmutables, su valor puede ser establecido solo al inicializarse
            string a = "String 1";


            Console.WriteLine("===================================================================================================================");
            Console.WriteLine("||\tvar a = " + "\"" + a + "\" \tSe crea en el HEAP un objeto llamado \"String 1\" y \t\t\t\t\t ||\n||\t\t\t\tla variable \"a\" contiene una referencia que apunta a este. \t\t\t\t ||");
            Console.WriteLine("||\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ||");

            //Utilizamos el for para ir generando nuevos objetos en el HEAP y cambiando la referencia donde apunta a
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(500);
                a = "||\ta = \"String " + (i + 2) + "\" \t\tSe crea un nuevo objeto en el HEAP llamado \"String " + (i + 2) + "\" y \"a\" ahora apunta a este, || \n||\t\t\t\tdejando al anterior huerfano para que luego el GC lo limpie. \t\t\t\t ||"; 
                Console.WriteLine(a);
                Console.WriteLine("||\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ||");
            }

            Console.WriteLine("===================================================================================================================");
            Console.ReadKey();
        }
    }
}
