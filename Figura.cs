// Clase base abstracta para representar figuras geométricas en general.
public abstract class Figura
{
    // Método abstracto para calcular el área de una figura.
    // Cada subclase (como Circulo o Cuadrado) debe implementar este método.
    public abstract double CalcularArea();

    // Método abstracto para calcular el perímetro de una figura.
    // También debe ser implementado por las clases hijas.
    public abstract double CalcularPerimetro();
}

