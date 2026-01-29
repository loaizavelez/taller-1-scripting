

namespace ejercicio_2
{
    internal class Program
    {
        // Programa que convierte cada palabra de una frase   a minúscula y con inicial mayúscula
        

        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una frase de mínimo 3 palabras:");
            string frase = Console.ReadLine();

            string resultado = ConvertirFrase(frase);

            if (resultado == null )
            {
                Console.WriteLine("La frase debe contener al menos 3 palabras.");
            }
            else
            {
                Console.WriteLine("Frase convertida: " + resultado);
            }
        }

        public static string ConvertirFrase(string frase)
        {
            
            string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            
            if (palabras.Length < 3)
            {
                return null;
            }

            
            for (int i = 0; i < palabras.Length; i++)
            {
                string palabra = palabras[i].ToLower();
                if (palabra.Length > 0)
                {
                    palabras[i] = char.ToUpper(palabra[0]) + palabra.Substring(1);
                }
            }

            
            return string.Join(" ", palabras);
        }
    }
}