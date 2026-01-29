using System;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número de máximo 8 cifras:");
            string entrada = Console.ReadLine();

            if (long.TryParse(entrada, out long numero) && entrada.Length <= 8) // este tryparse valida que sea un numero y la longitud determinada
            {
                int resultado = CalcularRaizDigital(numero);
                Console.WriteLine("El valor reducido a un solo dígito es: " + resultado); 
            }
            else
            {
                Console.WriteLine("Debe ingresar un número válido de máximo 8 cifras.");
            }
        }

        public static int CalcularRaizDigital(long numero) // esta funcion se encarga de calcular el resultado de la suma de digitos hasta que quede un solo digito
        {
            
            while (numero >= 10) // este ciclo se encarga de repetir la suma de digitos hasta que el numero sea menor a 10
            {
                int suma = 0;

                
                string numStr = numero.ToString(); // convierte el numero a string para poder iterar sobre sus digitos
                for (int i = 0; i < numStr.Length; i++)
                {
                    suma += numStr[i] - '0'; // convierte el numero mayor a una suma de sus digitos
                }

                numero = suma; 
            }

            return (int)numero; 
        }
    }
}