# Preguntas de teoría 

### 22.) ¿Para qué sirve Try Parse?, escriba un ejemplo de cómo se usa

El try Parse es un metodo que, a diferencia del parse, lanza un booleano indicando si el proceso de conversión fue exitoso, si es un ```int.TryParse``` se va a encargar de convertir la cadena a enteros, en caso de fallar o ingresar un valor no valido, el booleano lanza el mensaje de fallo. 

El ```int.Parse``` lanza excepciones como ```FormatException``` ó ```ArgumentNullException```.

**Ejemplos de uso**

```cs
string entrada = "123";
if (int.TryParse(entrada, out int valor)) {
    Console.WriteLine($"Valor convertido: {valor}");
} else {
    Console.WriteLine("Entrada no válida");
}

```
En este ejemplo se esta convierto una cadena de carácteres en un entero.

toda la información fue sacada de: [Academia Sanroque](https://academiasanroque.com/uso-de-tryparse-en-c-y-trucos-utiles/) [CSharp Cheat sheet](https://csharpcheatsheet.es/tryparse/) y [Microsoft Learn](https://learn.microsoft.com/es-es/dotnet/api/system.single.tryparse?view=net-9.0)


### 15.) ¿Cuál es la salida?

Luego de investigar y modificar el codigo se llega a la conclusion de que el loop es infinito, esto se debe a que al entrar y salir, la valor i vuelve a ser 10, cuando empieza otra vez el ciclo i se rebaja a 9 y vuelve a 10 nunca imprime el resultado.

```cs

namespace pregunta_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i; // i declarada pero no inicializada
            do
            {
                i = 10; // i se inicializa a 10 en cada iteración
            } while (--i); // Infinite loop

            Console.WriteLine(i); // esta linea nunca se ejecutará
        }
    }
}
```
 