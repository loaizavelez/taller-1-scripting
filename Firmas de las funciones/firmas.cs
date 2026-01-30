namespace firmas_de_funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Frase(); // llama a la funcion Frase
            Console.WriteLine("La suma de 5 y 10 es: " + Suma(5, 10)); // llama a la funcion Suma con los argumentos 5 y 10 y muestra el resultado
            Console.WriteLine("¿El número 4 es par? " + EsPar(4)); // llama a la funcion EsPar con el argumento 4 y muestra el resultado
            string texto = Minuscula("ESTOY EN MINUSCULA");
            Console.WriteLine(texto); // muestra el resultado de la funcion Minuscula
            int[,] matriz1 = { {1, 2}, {3, 4} };
            Console.WriteLine("La suma de la matriz es: " + SumarMatriz(matriz1));
            MatrizSinParametro();
            DateTime fecha=Fecha();
            Console.WriteLine("La fecha y hora actual es: " + fecha);
            Console.WriteLine("Verificar si un número es impar:");
            EsImpar(5); // llama a la funcion EsImpar con el argumento 5
            Console.WriteLine("Mostrar fecha y hora actual:");
            FechaSinParametro(); // llama a la funcion Fecha



        }

        public static void Frase() // esta funcion imprime una frase en consola
        {
            Console.WriteLine("hola chicos");
        }

        public static int Suma(int a, int b) // esta funcion recibe dos numeros enteros y retorna su suma
        {
            return (a + b) / 2; // retorna la suma de los dos numeros
        }

        public static bool EsPar(int numero) 
        {
            
            return numero % 2 == 0; // retorna true si el numero es par
        }
        
        public static string Minuscula( string texto)
        {
            return texto.ToLower();
        }

         public static int SumarMatriz(int[,] matriz)
        {
            int suma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    suma += matriz[i, j];
                }
            }
            return suma;
        }

        public static int MatrizSinParametro()
        {
            Console.WriteLine("Ingrese el tamaño de la matriz:");
            int Fila = int.Parse(Console.ReadLine()); 
            int Columna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[Fila, Columna];
            
            for( int i = 0; i < Fila; i++)
            {
                for (int j = 0; j < Columna; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posicion [{i},{j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("La matriz es:"); 
            for( int i = 0; i < Fila; i++)
            {
                for (int j = 0; j < Columna; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }



            



           
        }

        public static DateTime Fecha()
        {
            return DateTime.Now;
        }

        public static void EsImpar(int numero)
        {
            bool EsImpar = numero % 2 == 0;

            if (!EsImpar)
            {
                Console.WriteLine("El número es impar.");
            }
            else
            {
                Console.WriteLine("El número no es impar.");
            }
        }
        

        public static void FechaSinParametro()
        {
            DateTime fechaActual = DateTime.Now;
            Console.WriteLine("Fecha y hora actual: " + fechaActual);
        }


        //------------------------------------------------------------------------

    }
        

namespace Firmas_Scripting_JJHP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SaludarNombre("Juan");

            Console.WriteLine("Area del cuadrado: " + AreaCuadrado(4));

            Console.WriteLine("Multiplicacion: " + Multiplicar(3, 5));

            int[] numeros = { 1, 2, 3 };
            MostrarNumeros(numeros);

            Console.WriteLine("Es mayor de edad: " + EsMayorDeEdad(20));

            MostrarCaracter('J');

            string[] nombres = { "Ana", "Luis", "Pedro" };
            Console.WriteLine("Primer nombre: " + PrimerNombre(nombres));

            Console.WriteLine("Numero fijo: " + NumeroFijo());

            Persona p = CrearPersona("Carlos", 22);
            Console.WriteLine(p.Nombre + " = " + p.Edad);

            Mensaje();
        }

        // 1. funcion sin retorno y con parametro string
        public static void SaludarNombre(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }

        // 2. funcion con retorno double
        public static double AreaCuadrado(double lado)
        {
            return lado * lado;
        }

        // 3. funcion con dos parametros enteros
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        // 4. funcion que recibe un arreglo de enteros
        public static void MostrarNumeros(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }

        // 5. funcion que retorna un booleano
        public static bool EsMayorDeEdad(int edad)
        {
            return edad >= 18;
        }

        // 6. funcion que recibe un caracter
        public static void MostrarCaracter(char letra)
        {
            Console.WriteLine("Caracter: " + letra);
        }

        // 7. funcion con arreglo de strings
        public static string PrimerNombre(string[] nombres)
        {
            return nombres[0];
        }

        // 8. funcion sin parametros y con retorno
        public static int NumeroFijo()
        {
            return 10;
        }

        // 9. funcion que retorna una clase
        public static Persona CrearPersona(string nombre, int edad)
        {
            return new Persona(nombre, edad);
        }

        // 10. funcion sin parametros y sin retorno
        public static void Mensaje()
        {
            Console.WriteLine("Fin del programa");
        }
    }

    // Clase Persona
    public class Persona
    {
        public string Nombre;
        public int Edad;

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}



    





        
    
    
}   
