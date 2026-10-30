using System;

namespace CS5
{
    class Program
    {
        static void Main(string[]args)
        {
            //Unidad 1: Estructuras de control II
            //Unidad 2: Funciones II
            //Sesion 12: Instruccion while 30/09/2026
            //Sintaxis: While
            //Inicializacion;
            //While(Expresion)
            //{
            //Bloque de instrucciones
            //     iterador;
            //}
            // Iterar: repetir
            // Ejemplo 1: Ciclo ascendente (rango: 1-3)
            //m: Variable de control
            int m = 1; // Inicializacion
            while(m <= 3) //Expresion
            {
                //Bloque de instrucciones
                Console.WriteLine($"m:{m}");
                m += 1; //Iterador
            }
            //Ejercitacion
            //1. Definir un ciclo para imprimir tu nombre 5 veces.
            //Nota: Para la expresion, utilizar el operador <.
            //a. Ciclo ascendente
            int n = 0;
            
            while(n < 5)
            {
                Console.WriteLine("Mi nombre es Jose Enrique S.P.");
                n += 1;
            }
            //b. Ciclo descendente
            int b = 3;

            while(b >= 1)
            {
                Console.WriteLine($"b:{b}");
                b -= 1;
            }
            //C. Incrementos (Ciclo ascendente)
            //Secuencia 3 6 9 12 15 18
            int c = 3;

            while(c <= 18)
            {
                Console.WriteLine($"c:{c}");
                c += 3;
            }
            //d. Decrementos
            //Ejercitacion
            //1. Definir un ciclo para imprimir "331" 8 veces.
            //Nota: Para la solucion, define un ciclo descendente con decrementos de 2 unidades.
            int d = 16;

            while(d >= 2)
            {
                Console.WriteLine("Salon: 331");
                d -= 2;
            }
            // Acitividad 1: Ciclo Infinito
            // 1. Definir un ciclo infinito ascendente.
            // 2. Definir un ciclo infinito descendente.
            //Nota: Para la solucion, utilizar el operador de diferencia.
            
            int i = 0;

            while(i > -1)
            {
                Console.WriteLine($"i:{i}");
                i += 1;
            }
            
            int e = -1;

            while(e != 0)
            {
                Console.WriteLine($"i:{e}");
                e -= 1;
            }

            // Jose Enrique S. P. 331-36
            //Actividad 2: Maraton
            //Una corredora de nombre Diana, tiene una zancada(aproximada) de 0.63m. Si el sabado, 10 de octubre, correra un maraton (21km), cuantas zancadas necesitara para terminar el circuito?
            //Nota: Para la solucion, emplear un ciclo while.
            
            double zancada = 0.00063;

            while(zancada <= 1)
            {
                double Total_zancadas = 21 / zancada;
                Console.WriteLine($"Total de zancadas que debe correr:{Total_zancadas}");
                zancada ++;
            }

            double recorrido = 0;
            double zancadas = 0;
            int H = 0;
            int recorrido_H = 2000;
            while(recorrido<21000)
            {

                 Console.WriteLine($"Zancadas recorridas:{zancadas}, distancia recorrida:{recorrido}, Hidratacion:{H}");
                recorrido += 0.63;
                zancadas += 1;
                if (recorrido >= recorrido_H)
                {
                    H += 1;
                    recorrido_H += 2000;
                }
            
            }
            //sesion 14: ciclo for
            //1. ciclo for
            //Sintaxis ciclo for
            //for(inicializacion; expresion; iterador)
            //{
                 //Bloque de instrucciones
           // }

            //Ejemplo: secuencia 35-41
            for (int l = 35; l <= 41; l+=1)
            {
                Console.WriteLine($"l:{l}"); 
            }
            //1. D  efinir un ciclo for para la siguiente secuencia: -33 -34 -35 -36 -37 -38 -39
            for (int f = -33; f >= -39; f -= 1)
            {
                Console.WriteLine($"e:{f*-1}");
            }


            Console.WriteLine("Ciclo 2: Ascendente");
            for (int a = 9; a <=15; a += 1)
            {
    
                {
                Console.WriteLine($"a:{a}");
                }
            }

            //Ejercicio titulos y capitulos
            int titulo = 1;
            for (int a = 1; a <=539; a += 88, titulo +=1)
            {
                Console.WriteLine($"Titulo:{titulo}");
                Console.WriteLine($"Numero:{a}");
            }
        }
    }
}
