/* Lea las coordenadas de dos puntos y que muestre la distancia entre los dos puntos.*/

public class Distancia2Puntos
{
    static void Main(string[] args)
    {
        double x1, x2, y1, y2, d;

        Console.Write("Ingrese x1:");
        x1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese x2:");
        x2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese y1:");
        y1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese y2:");
        y2 = double.Parse(Console.ReadLine());

        d = Math.Sqrt(x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);

        Console.Write("La distancia entre el P1=(" + x1 + "," + y1 + ") Y el P2=(" + x2 + "," + y2 + ") Es: " + d);

    }


}
