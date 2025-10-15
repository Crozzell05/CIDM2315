namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
          // ===== Q1 & Q2 =====

            // Create two Customer objects
            Customer customer1 = new Customer(110, "Alice", 28);
            Customer customer2 = new Customer(111, "Bob", 30);

            Console.WriteLine("---- Original Customer Information ----");
            customer1.PrintCusInfo();
            customer2.PrintCusInfo();

            // Update customer IDs
            customer1.ChangeID(220);
            customer2.ChangeID(221);

            Console.WriteLine("\n---- Updated Customer Information ----");
            customer1.PrintCusInfo();
            customer2.PrintCusInfo();

            // Compare their ages
            Console.WriteLine("\n---- Comparing Ages ----");
            customer1.CompareAge(customer2);

            Console.WriteLine("\nProgram execution completed successfully.");
        }
    }

    class Customer
    {
        private int cus_id;
        public string cus_name;
        public int cus_age;

        // Constructor
        public Customer(int cus_id, string cus_name, int cus_age)
        {
            this.cus_id = cus_id;
            this.cus_name = cus_name;
            this.cus_age = cus_age;
        }

        // Method to change customer ID
        public void ChangeID(int new_id)
        {
            cus_id = new_id;
        }

        // Method to print customer information
        public void PrintCusInfo()
        {
            Console.WriteLine($"Customer ID: {cus_id}, Name: {cus_name}, Age: {cus_age}");
        }

        // Method to compare ages between customers
        public void CompareAge(Customer objCustomer)
        {
            if (this.cus_age > objCustomer.cus_age)
            {
                Console.WriteLine($"{this.cus_name} is older than {objCustomer.cus_name}.");
            }
            else if (this.cus_age < objCustomer.cus_age)
            {
                Console.WriteLine($"{objCustomer.cus_name} is older than {this.cus_name}.");
            }
            else
            {
                Console.WriteLine($"{this.cus_name} and {objCustomer.cus_name} are the same age.");
            }
        }
    }