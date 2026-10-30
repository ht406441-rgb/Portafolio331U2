using System;

namespace CS7
{
    
    class Program
    {
        static void Main(string[]args)
        {
            //Sesion 15: Funciones
            /*
            Funcion: Bloque de instrucciones para realizar una tarea especifica, que se ejecuta, unicamente, cuando es invocado.
            Sintaxis: Definicion de funcion

            tipo_dato_devuelto identificador_funcion(parametros)
            {
               Bloque de instrucciones
            }
            Nota1: Los parametros se definen incluyendo el tipo de dato.
            Nota2: Los parametros van separados por comas.
            Sintaxis: Invocacion funcion
            identificador_funcion(argumentos);
            argumento: Es el valor del parametro.
            */

            //ejemplo 1: funcion vacia sin parametros
            void Saludar()
            {
                string salon = "Exactas 331";
                Console.WriteLine($"Hola, {salon}!");
            }
            //Invocacion
            Saludar();

            //Ejercitacion
            //1. definir e invocar una funcion para imprimir: nombre, clave y salon.
            void datos()
            {
                string nombre = "Jose ESP";
                string clave = "331-36";
                int salon = 331;
                Console.WriteLine($"Datos de estudiante:{nombre},{clave},{salon}");
            }
            datos();
            //Ejercicio 2: Definir y invocar una funcion sin parametros para desplegar el horario de hoy.
            void Horario()
            {
                Console.WriteLine($"Horario: 7:00(Calculo), 7:50(FH), 8:40(Programación), 9:50(Psicología), 10:40(Idiomas), 11:50-12:40(Dibujo Tecnico)");
            }
            Horario();
            //Sesion 16: Funcion con parametros
            //return ; palabra reservada para terminar una funcion y devolver una expresion.
            //ejemplo 1: Doble
            //definicion
            int CalculadoraDoble(int numero)
            {
                int resultado = 2*numero;
                return resultado;
            }
            //Invocacion
            int devolucion;
            devolucion = CalculadoraDoble(9);
            Console.WriteLine($"Devolucion:{devolucion}");
            //ejercitacion
            //1. Definir e invocar una funcion que devuelva la evaluacion de la siguiente expresion:
            //f(x) = 4x - 7 /5
            double funcion(double x)
            {
               double y;
               y = 4*x-7/5D;
               return y;
            }
            double res_devuelto;
            res_devuelto = funcion(5);
            Console.WriteLine($"y={res_devuelto}");

        }
    }
}