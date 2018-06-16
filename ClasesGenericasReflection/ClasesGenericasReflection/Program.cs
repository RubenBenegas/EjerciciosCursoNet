using System;
using System.Reflection;

namespace ClasesGenericasReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos un objeto de la clase Reflectionador
            var reflexionador1 = new Reflectionador();

            //Instanciamos un objeto del tipo type que lo obtenemos mediante el merodo ObtenerType pasandole una clase cualquiera (Es generico)
            var clase = reflexionador1.ObtenerType<String>();

            //Del objeto "clase" obtenemos sus propiedades
            var propiedades = clase.GetProperties();
            var metodos = clase.GetMethods();

            Console.WriteLine("El nombre de la clase es: " + clase.Name);

            if (propiedades.Length > 0)
            {
                Console.WriteLine("Sus propiedades son:");
                //Aqui recorremos las propiedades de clase
                foreach (var item in propiedades)
                {
                    //Mostrando el nombre y de que tipo son
                    Console.WriteLine(item.Name + " y es del tipo " + item.PropertyType.Name);
                }
            }
            else
            {
                Console.WriteLine("Esta clase no posee propiedades");
            }


            if (metodos.Length > 0)
            {
                Console.WriteLine("Sus metodos son:");

                //Aqui recorremos los metodos de clase
                foreach (var item in metodos)
                {
                    //Con este if pretendemos no mostrar los metodos get y set de las propiedades de la clase
                    if (!item.Name.Contains("set_") && !item.Name.Contains("get_"))
                    {
                        //Mostrando el nombre 
                        Console.WriteLine("\t" + item.Name + ":");

                        var n = 1;
                        if (item.GetParameters().Length > 0)
                        {
                            foreach (var param in item.GetParameters())
                            {

                                Console.WriteLine("\t\t" + n + " Parametro: " + param.ParameterType.Name + " " + param.Name);
                                n++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\t\tEste metodo no posee parametros");
                        }
                        
                    }

                }
            }
            else
            {
                Console.WriteLine("Esta clase no posee metodos");
            }
            Console.ReadKey();
        }
    }
}

