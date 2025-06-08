// Importa funcionalidades matemáticas como PI y Pow.
using System;

// La clase Circulo hereda de la clase abstracta Figura.
public class Circulo : Figura
{
    // Propiedad pública que representa el radio del círculo.
    public double Radio { get; set; }

    // Constructor que inicializa el valor del radio.
    public Circulo(double radio)
    {
        Radio = radio;
    }

    // Implementación del método CalcularArea heredado de Figura.
    // Usa la fórmula del área de un círculo: π * radio^2.
    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
        // Math.PI representa el valor de π.
        // Math.Pow(Radio, 2) eleva el radio al cuadrado.
    }

    // Implementación del método CalcularPerimetro heredado de Figura.
    // Usa la fórmula del perímetro (circunferencia) de un círculo: 2 * π * radio.
    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Radio;
    }
}
