using System;

namespace PracticandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esto es una matriz unidimensional de 3 elementos
            int[] miMatrizUnidimencional = new int[3];

            //Asi es como se apunta a una posicion de la matriz unidimensional y se le asigna un valor
            miMatrizUnidimencional[0] = 1;
            miMatrizUnidimencional[1] = 2;
            miMatrizUnidimencional[2] = 3;

            //Usamos el comando WriteLine sin pasarle ninguna cadena solo para hacer un salto de linea
            Console.WriteLine();
            Console.WriteLine("Esta es mi matriz unidimensional:");
            Console.WriteLine();
            Console.WriteLine("Es una matriz de 1 fila con la cantidad de elementos (los podemos imaginar como columnas) que se indiquen");
            Console.WriteLine();
            Console.WriteLine("Fila: " + miMatrizUnidimencional[0].ToString() + " - " + miMatrizUnidimencional[1].ToString() + " - " + miMatrizUnidimencional[2].ToString());
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            
            //Esto es una matriz mulltidimensional de 2 dimensiones (se pueden utilizar tantas dimensiones como se deseen), en este caso permite 15 elementos
            int[,] miMatrizMultidimensional = new int[3, 5];

            // Asi es como se apunta a una posicion de la matriz multidimensional y se le asigna un valor
            miMatrizMultidimensional[0, 0] = 1;
            miMatrizMultidimensional[0, 1] = 2;
            miMatrizMultidimensional[0, 2] = 3;
            miMatrizMultidimensional[0, 3] = 4;
            miMatrizMultidimensional[0, 4] = 5;

            miMatrizMultidimensional[1, 0] = 1;
            miMatrizMultidimensional[1, 1] = 2;
            miMatrizMultidimensional[1, 2] = 3;
            miMatrizMultidimensional[1, 3] = 4;
            miMatrizMultidimensional[1, 4] = 5;

            miMatrizMultidimensional[2, 0] = 1;
            miMatrizMultidimensional[2, 1] = 2;
            miMatrizMultidimensional[2, 2] = 3;
            miMatrizMultidimensional[2, 3] = 4;
            miMatrizMultidimensional[2, 4] = 5;

            Console.WriteLine();
            Console.WriteLine("Esta es mi matriz multidimensional:");
            Console.WriteLine();
            Console.WriteLine("Es una matriz rectangular, puede tener varias filas y por cada fila \ntiene el mismo numero de elementos (los podemos imaginar como columnas)");
            Console.WriteLine();

            //Aqui solo recorremos la matriz para imprimirla por pantalla
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Fila " + (i + 1).ToString() + " de matriz multidimensional: ");
                for (int j = 0; j < 5; j++)
                {

                    //Este if solo lo usamos para que cuando llegue al ultimo elemento no muestre el guion separador, no tiene otro proposito
                    if (j < 4) //Esta es una forma de usar el if sin las llaves del bloque
                        Console.Write(miMatrizMultidimensional[i, j].ToString() + " - ");
                    else
                        Console.WriteLine(miMatrizMultidimensional[i, j].ToString());
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            //Esto es una matriz escalonada. Se utilizan cuando las dimensiones son desiguales, para no desperdiciar memoria reservando espacios que no se van a utilizar
            int[][] miMatrizEscalonada = new int[3][]; //Aqui definimos el tamanio de la primera dimension

            //Aqui por cada elemento de la primera dimension le asignamos la segunda dimension con su respectivo tamanio
            miMatrizEscalonada[0] = new int[4];
            miMatrizEscalonada[1] = new int[2];
            miMatrizEscalonada[2] = new int[3];

            // Asi es como se apunta a la posicion de cada elemento de una matriz escalonada y se le asigna un valor
            miMatrizEscalonada[0][0] = 1;
            miMatrizEscalonada[0][1] = 2;
            miMatrizEscalonada[0][2] = 3;
            miMatrizEscalonada[0][3] = 4;

            miMatrizEscalonada[1][0] = 1;
            miMatrizEscalonada[1][1] = 2;

            miMatrizEscalonada[2][0] = 1;
            miMatrizEscalonada[2][1] = 2;
            miMatrizEscalonada[2][2] = 3;

            Console.WriteLine();
            Console.WriteLine("Esta es mi matriz escalonada: ");
            Console.WriteLine();
            Console.WriteLine("Es una matriz en la que las filas pueden diferir la cantidad de elementos, \nes util cuando no queremos reservar memoria para elementos que no vamos a utilizar");
            Console.WriteLine();

            //Aqui solo recorremos la matriz del primer elemento para imprimirla por pantalla
            Console.Write("Fila 1 de matriz escalonada: ");
            for (int k = 0; k < 4; k++)
            {
                //Este if solo lo usamos para que cuando llegue al ultimo elemento no muestre el guion separador, no tiene otro proposito
                if (k < 3)  //Esta es una forma de usar el if sin las llaves del bloque
                    Console.Write(miMatrizEscalonada[0][k].ToString() + " - ");
                else
                    Console.WriteLine(miMatrizEscalonada[0][k].ToString());
            }

            //Aqui solo recorremos la matriz del segundo elemento para imprimirla por pantalla
            Console.Write("Fila 2 de matriz escalonada: ");
            for (int l = 0; l < 2; l++)
            {
                //Este if solo lo usamos para que cuando llegue al ultimo elemento no muestre el guion separador, no tiene otro proposito
                if (l < 1)  //Esta es una forma de usar el if sin las llaves del bloque                
                    Console.Write(miMatrizEscalonada[1][l].ToString() + " - ");
                else
                    Console.WriteLine(miMatrizEscalonada[1][l].ToString());
            }

            //Aqui solo recorremos la matriz del tercer elemento para imprimirla por pantalla
            Console.Write("Fila 3 de matriz escalonada: ");
            for (int m = 0; m < 3; m++)
            {
                //Este if solo lo usamos para que cuando llegue al ultimo elemento no muestre el guion separador, no tiene otro proposito
                if (m < 2)  //Esta es una forma de usar el if sin las llaves del bloque
                    Console.Write(miMatrizEscalonada[2][m].ToString() + " - ");
                else
                    Console.WriteLine(miMatrizEscalonada[2][m].ToString());
            }

            Console.ReadKey();

        }
    }
}
