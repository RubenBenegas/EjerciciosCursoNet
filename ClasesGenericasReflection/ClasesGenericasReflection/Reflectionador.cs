using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesGenericasReflection
{
    public class Reflectionador
    {
        //T es generico
        public Type ObtenerType<T>() 
        {
            //Obtenemos el tipo de la clase que le pasamos
            var type = typeof(T);

            //Devolvemos el tipo
            return type;
        }
    }
}
