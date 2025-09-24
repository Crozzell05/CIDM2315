namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
          // Call Q1_method()
            Q1_method();

            // Call Q2_method()
            Q2_method();

            // Call Q3_method()
            Q3_method();
        }

        // ================= Q1 (2 points) =================
        static int Q1_getMax(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        static void Q1_method()
        {
            Console.WriteLine("Q1: Enter two integers:");
            Console.Write("Enter first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = Q1_getMax(num1, num2);
            Console.WriteLine("The largest number is: " + result);
            Console.WriteLine("-----------------------------------");
        }

        // ================= Q2 (3 points) =================
        static int Q2_getMaxOfFour(int a, int b, int c, int d)
        {
            // Using Q1_getMax to compare
            int max1 = Q1_getMax(a, b);
            int max2 = Q1_getMax(c, d);
            int maxFinal = Q1_getMax(max1, max2);

            return maxFinal;
        }

        static void Q2_method()
        {
            Console.WriteLine("Q2: Enter four integers:");
            Console.Write("Enter first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third integer: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.Write("Enter fourth integer: ");
            int num4 = int.Parse(Console.ReadLine());

            int result = Q2_getMaxOfFour(num1, num2, num3, num4);
            Console.WriteLine("The largest number is: " + result);
            Console.WriteLine("-----------------------------------");
        }

        // ================= Q3 (5 points) =================
        static bool checkAge(int birth_year)
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birth_year;

            if (age >= 18)
                return true;
            else
                return false;
        }

        static void createAccount()
        {
            Console.WriteLine("Q3: Account Creation Process");

            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password1 = Console.ReadLine();

            Console.Write("Re-enter password: ");
            string password2 = Console.ReadLine();

            Console.Write("Enter birth year: ");
            int birthYear = int.Parse(Console.ReadLine());

            if (checkAge(birthYear))
            {
                if (password1 == password2)
                {
                    Console.WriteLine("Account is created successfully");
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Could not create an account");
            }

            Console.WriteLine("-----------------------------------");
        }

        static void Q3_method()
        {
            createAccount();
        }
    }
    
