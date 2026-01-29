using System;

class Program
{
    static void Main(string[] args)
    {
        char opcion = 's'; // Variable que controla si el usuario quiere repetir el programa

        do
        {
            Console.WriteLine("Ingrese un número entero para calcular su factorial:");
            string entradaNumero = Console.ReadLine();

            if (!int.TryParse(entradaNumero, out int n)) // Intenta convertir el texto a número entero
            {
                Console.WriteLine("Entrada inválida. Debe ingresar un número entero."); // Solo si no es un número válido
            }
            else if (n < 0)
            {
                Console.WriteLine("El factorial no está definido para números negativos.");
            }
            else
            {
                long factorial = 1; // Variable para almacenar el resultado del factorial

                for (int i = 1; i <= n; i++) // Cíclo for para calcular el factorial
                {
                    factorial *= i;
                }

                Console.WriteLine($"El factorial de {n} es: {factorial}"); // Muestra el resultado
            }

            Console.WriteLine("\n¿Desea ingresar otro número? (s = Si / n = Salir)"); // Pregunta si el usuario desea continuar en el programa
            string entrada = Console.ReadLine();

            if (string.IsNullOrEmpty(entrada)) // Si el usuario no escribe nada, se asume que desea salir
            {
                opcion = 'n';
            }
            else
            {
                opcion = char.ToLower(entrada[0]); // Se toa solo la primera letra y se convierte a minúscula
            }

        } while (opcion == 's'); // El programa se repite solo si la opción es "s"

        Console.WriteLine("\nPrograma finalizado."); // Mensaje que se muestra al salir del programa
    }
}

