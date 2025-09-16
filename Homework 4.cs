namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
         // === Q1 ===
            Console.WriteLine("=== Question 1 ===");
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int largest = Q1_method(num1, num2);
            Console.WriteLine($"The larger number between {num1} and {num2} is: {largest}\n");

            // === Q2 ===
            Console.WriteLine("=== Question 2 ===");
            Console.Write("Enter a number N (triangle size): ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a shape (left or right): ");
            string shape = Console.ReadLine();

            Q2_method(N, shape);
        }

        // Q1_method: Takes two numbers and returns the largest one
        static int Q1_method(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        // Q2_method: Takes an integer N and a shape (left or right) and prints a triangle
        static void Q2_method(int N, string shape)
        {
            Console.WriteLine($"N = {N}, Shape = {shape}");

            if (shape.ToLower() == "left")
            {
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else if (shape.ToLower() == "right")
            {
                for (int i = 1; i <= N; i++)
                {
                    // print spaces first
                    for (int j = 1; j <= N - i; j++)
                    {
                        Console.Write(" ");
                    }
                    // print stars
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid shape. Please enter 'left' or 'right'.");
            }
        }
    }

