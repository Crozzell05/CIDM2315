namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
            // ==============================
            // Q1: Prime Check
            // ==============================
            Console.WriteLine("Q1: Prime Number Check");
            Console.Write("Enter a number N: ");
            int n1 = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (n1 <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= n1 - 1; i++)
                {
                    if (n1 % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
                Console.WriteLine($"{n1} is prime");
            else
                Console.WriteLine($"{n1} is non-prime");

            Console.WriteLine(); // blank line


            // ==============================
            // Q2: Square Pattern
            // ==============================
            Console.WriteLine("Q2: Square Pattern");
            Console.Write("Enter an integer N: ");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(); // blank line


            // ==============================
            // Q3: Diagonal Square Pattern
            // ==============================
            Console.WriteLine("Q3: Diagonal Square Pattern");
            Console.Write("Enter an integer N: ");
            int n3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n3; i++)
            {
                for (int j = 0; j < n3; j++)
                {
                    if (i >= j) // diagonal condition
                        Console.Write("* ");
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }

        }
    }
    

