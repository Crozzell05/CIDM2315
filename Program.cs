namespace Week2;

class Program
{
    static void Main(string[] args)
    {
        // =======================
        // Q1: Letter Grade to GPA
        // =======================
        Console.WriteLine("Q1: Enter a letter grade (A, B, C, D, E, F: )");
        string grade = Console.ReadLine();

        switch (grade.ToUpper())
        {
            case "A":
                Console.WriteLine("GPA Points: 4");
                break;
            case "B":
                Console.WriteLine("GPA Points: 3");
                break;
            case "C":
                Console.WriteLine("GPA Points: 2");
                break;
            case "D":
                Console.WriteLine("GPA Points: 1");
                break;
            case "F":
                Console.WriteLine("GPA Points: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }

        Console.WriteLine(); //break line for readability

        //========================
        //Q2: Find Smallest Number
        //========================
        Console.WriteLine("Q2: Enter three numbers to find the smallest value");

        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = Convert.ToInt16(Console.ReadLine());

        int smallest;

        if (num1 < num3)
        {
            if (num1 < num3)
                smallest = num1;
            else
                smallest = num3;
        }
        else
        {
            if (num2 < num3)
                smallest = num2;
            else
                smallest = num3;
        }

        Console.WriteLine("The smallest value is: " + smallest);

        Console.WriteLine(); //blank line for readability

        //=========================
        // Bonus: Leap Year Checker
        //=========================
        Console.WriteLine("Bonus: Enter a year to check if it is a leap year.");
        int year = Convert.ToInt16(Console.ReadLine());

         if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine(year + " is a Leap Year.");
            }
            else
            {
                Console.WriteLine(year + " is NOT a Leap Year.");
            }
    }
}
