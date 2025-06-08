// La clase Cuadrado también hereda de la clase abstracta Figura.
public class Cuadrado : Figura
{
    // Propiedad pública que representa el lado del cuadrado.
    public double Lado { get; set; }

    // Constructor que inicializa el valor del lado.
    public Cuadrado(double lado)
    {
        Lado = lado;
    }

    // Implementación del método CalcularArea heredado de Figura.
    // Fórmula del área de un cuadrado: lado * lado.
    public override double CalcularArea()
    {
        return Lado * Lado;
    }

    // Implementación del método CalcularPerimetro heredado de Figura.
    // Fórmula del perímetro de un cuadrado: 4 * lado.
    public override double CalcularPerimetro()
    {
        return 4 * Lado;
    }
}
