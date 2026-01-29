using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una palabra o frase:");
        string texto = Console.ReadLine();

        if (EsPalindroma(texto))
        {
            Console.WriteLine("La cadena ES Palíndroma");
        }
        else
        {
            Console.WriteLine("La cadena NO es Palíndroma");
        }
    }

    static bool EsPalindroma(string texto)
    {
        // Pasar todo a minúsculas
        texto = texto.ToLower();

        int inicio = 0;
        int fin = texto.Length - 1;

        while (inicio < fin)
        {
            if (texto[inicio] != texto[fin])
            {
                return false;
            }
            inicio++;
            fin--;
        }

        return true;
    }
}