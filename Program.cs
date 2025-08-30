namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        //Given Values
        double X = 2.5;
        double Y = 3.3;

        //Equation: Z = 4*X*X + 3*Y
        double Z = 4 * X * X + 3 * Y;

        //Print result using formatted string
        Console.WriteLine($"For X = {X} and Y = {Y}");
        Console.WriteLine($"The value of Z is {Z:F2}");
    }
       
}
