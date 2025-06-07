using System;

class Program
{
    static void Main()
    {
        Circulo miCirculo = new Circulo(5);
        Cuadrado miCuadrado = new Cuadrado(4);

        Console.WriteLine("Área del círculo: " + miCirculo.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + miCirculo.CalcularPerimetro());

        Console.WriteLine("Área del cuadrado: " + miCuadrado.CalcularArea());
        Console.WriteLine("Perímetro del cuadrado: " + miCuadrado.CalcularPerimetro());
    }
}
