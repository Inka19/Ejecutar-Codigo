using System;

namespace PAC_Desarrollo_Entrega_1S2324
{
    public class Program
    {
        static void Main(string[] args)
        {
            //--- Declaracion de variables
            int numero = 0;
            int[] sec_fibo;


            //------------------------------------------------------------------------------------------ Ejecución libre del programa

            //-------------------------- Se valida que el número introducido sea correcto
            do
            {
                Console.Write("Inserta el número elementos de Fibonacci a calcular: ");
                numero = Int32.Parse(Console.ReadLine());

            } while (NumeroValido(numero) == false);

            //-------------------------- Se obtiene la secuencia Fibonacci
            sec_fibo = SecuenciaFibo(numero);

            //-------------------------- Se obtiene la secuencia Fibonacci invertida
            sec_fibo = SecuenciaReverse(sec_fibo);

            //-------------------------- Se obtiene la primera posición donde aparece el número que más veces está en el array
            Console.WriteLine(PosicionNumeroMasVisto(sec_fibo));

            //--- Fin de la ejecución del programa
            Console.ReadKey();
        }

        public static bool NumeroValido(int numero)
        {
            /*
             * 
             * 
             * 
             *          A IMPLEMENTAR POR EL ALUMNO
             * 
             * 
             * 
             * 
             */
        }

        public static int[] SecuenciaFibo(int numero)
        {
            /*
             * 
             * 
             * 
             *          A IMPLEMENTAR POR EL ALUMNO
             * 
             * 
             * 
             * 
             */
        }

        public static int[] SecuenciaReverse(int[] directo)
        {
            /*
             * 
             * 
             * 
             *          A IMPLEMENTAR POR EL ALUMNO
             * 
             * 
             * 
             * 
             */
        }

        public static string PosicionNumeroMasVisto(int[] arr_secuencia)
        {
            //--- Se inicializan variables
            int posicion = 0;
            int valor = 0;
            int recuento = 0;

            /*
             * 
             * 
             * 
             *          A IMPLEMENTAR POR EL ALUMNO
             * 
             * 
             * 
             * 
             */

            if (recuento > 1)
            {
                return "El valor " + valor + " se repite " + recuento + " veces según la posicion " + posicion + " del array bidimensional.";
            }
            else
            {
                return "Todos los valores de la secuencia aparecen por igual.";
            }
        }
    }
}