namespace Labb_3___Polymorphism;
class Program
{
    static void Main(string[] args)
    {
        //Anton Hansson SUT23

        Geometry geometry = new Geometry("Color"); //Skapar objekt för alla klasser.

        Rectangle rectangle = new Rectangle("Grön",6, 4); //Väljer 6 cm som bas och 4 cm som höjd.
        Console.ForegroundColor = ConsoleColor.Green; //Ändrar färg.
        Console.WriteLine("Rektangel");
        Console.ResetColor();
        Console.WriteLine("Area: " + rectangle.Area() + " cm , Färg : " + rectangle._color); //Kallar på metoden för att skriva ut uträkningen.


        Square square = new Square("Blå", 8); //Kvadratens sida är 8 cm.
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nKvadrat");
        Console.ResetColor();
        Console.WriteLine("Area: " + square.Area() + " cm , Färg : " + square._color);


        Circle circle = new Circle("Röd",3.14, 10); //Pi och radien 10 cm.
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nCirkel");
        Console.ResetColor();
        Console.WriteLine("Area: " + circle.Area() + " cm2 , Färg : " + circle._color);


        Console.ReadKey();

    }
}
