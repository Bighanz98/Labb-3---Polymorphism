namespace Labb_3___Polymorphism;
class Program
{
    static void Main(string[] args)
    {
        Geometry geometry = new Geometry("Color"); //Skapar objekt för alla klasser.

        Rectangle rectangle = new Rectangle("Grön",6, 4);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Rektangel");
        Console.ResetColor();
        Console.WriteLine("Area: " + rectangle.Area() + " cm , Färg : " + rectangle._color);


        Square square = new Square("Blå", 8);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nKvadrat");
        Console.ResetColor();
        Console.WriteLine("Area: " + square.Area() + " cm , Färg : " + square._color);


        Circle circle = new Circle("Red",3.14, 10);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nCirkel");
        Console.ResetColor();
        Console.WriteLine("Area: " + circle.Area() + " cm , Färg : " + circle._color);


        Console.ReadKey();

    }
}
