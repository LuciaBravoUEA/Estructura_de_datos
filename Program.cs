//creamos una clase llamado circulo 
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Circulo
{
    //creamos la variable para el radio del circulo
    private double radio;
    //creamos un constructor para el radio
    public Circulo(double radio)
    {
        this.radio = radio;
    }
    // CalcularArea esto representa a una función que devuelve un valor double.
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }
    // CalcularPerimetro devuelve el perímetro a un valor double
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }

}
// creamos una clase para el rectangulo 
public class Rectangulo
{
    // creamos la variable para almacenar la base y la altura
    private double baseRect;
    private double altura;
    // creamos el contructor para la base y la altura
    public Rectangulo(double baseRect, double altura)
    {
        this.baseRect = baseRect;
        this.altura = altura;
    }
    //CalcularArea devuelve el área del rectangulo
    public double CalcularArea()
    {
        return baseRect * altura;
    }
    // CalcularPerimetro del rectangulo
    public double CalcularPerimetro()
    {
        return 2 * (baseRect + altura);
    }

}
// cramos el circulo 
public class Programa
{
    public static void Main(string[] args)
    {
        // Crear un objeto Circulo con radio 8
        Circulo miCirculo = new Circulo(8);
        Console.WriteLine("Círculo:");
        Console.WriteLine("Área: " + miCirculo.CalcularArea());
        Console.WriteLine("Perímetro: " + miCirculo.CalcularPerimetro());

        // Crear un objeto Rectángulo con base 6 y altura 10
        Rectangulo miRectangulo = new Rectangulo(6, 10);
        Console.WriteLine("\nRectángulo:");
        Console.WriteLine("Área: " + miRectangulo.CalcularArea());
        Console.WriteLine("Perímetro: " + miRectangulo.CalcularPerimetro());
    }
}



