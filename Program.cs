// Importa el espacio de nombres necesario para usar Console.
using System;

class Program
{
    // Punto de entrada principal del programa.
    static void Main()
    {
        // Se crea una instancia de la clase Circulo con radio 5.
        Circulo miCirculo = new Circulo(5);

        // Se crea una instancia de la clase Cuadrado con lado 4.
        Cuadrado miCuadrado = new Cuadrado(4);

        // Se muestra el área del círculo llamando al método CalcularArea().
        Console.WriteLine("Área del círculo: " + miCirculo.CalcularArea());

        // Se muestra el perímetro del círculo llamando al método CalcularPerimetro().
        Console.WriteLine("Perímetro del círculo: " + miCirculo.CalcularPerimetro());

        // Se muestra el área del cuadrado llamando al método CalcularArea().
        Console.WriteLine("Área del cuadrado: " + miCuadrado.CalcularArea());

        // Se muestra el perímetro del cuadrado llamando al método CalcularPerimetro().
        Console.WriteLine("Perímetro del cuadrado: " + miCuadrado.CalcularPerimetro());
    }
}
