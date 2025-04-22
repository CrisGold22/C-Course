using System;
using System.Transactions;

namespace PrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aqui se indican los diferentes tipos de variables
            int numeroEntero = 10; // Variable de tipo entero
            double numeroDecimal = 20.5; // Variable de tipo decimal
            string texto = "Hola, mundo!"; // Variable de tipo cadena
            bool esVerdadero = true; // Variable de tipo booleano
            char letra = 'A'; // Variable de tipo caracter

            // Concatenacion de cadenas
            texto += " Mi nombre es CrisGold";
            Console.WriteLine(texto);

            // Ejemplo basico de casteo de un string a un entero
            string numeroCadena = "123";
            int numero = int.Parse(numeroCadena);  // La funcion Parse() convierte un string a un entero
            Console.WriteLine("El numero es: " + numero);

            //Ahora con el caso inverso
            int numeroEntero2 = 456;
            numeroCadena = numeroEntero2.ToString(); // La funcion ToString() convierte un entero a un string
            Console.WriteLine("El numero es: " + numeroCadena);

        }
    }
}