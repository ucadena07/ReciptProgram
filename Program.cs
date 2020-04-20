using System;

namespace SimulatedOrderReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            string customerName, streetAddress, state, zipcode;
            double total, numberOfBlenders, tax, due;
           

            const double blenderPrice = 39.95;
            const double saleTax = .07;

            Console.Write("Please enter your name: ");
            customerName = Console.ReadLine();

            Console.Write("Please enter your address: ");
            streetAddress = Console.ReadLine();

            Console.Write("Please enter the State: ");
            state = Console.ReadLine();

            Console.Write("Please enter the zipcode: ");
            zipcode = Console.ReadLine();

            Console.Write("How many blenders would you like to purchase: ");
            numberOfBlenders = Convert.ToDouble(Console.ReadLine());

            total = blenderPrice * numberOfBlenders;
            tax = total * saleTax;
            due = total + tax;

            Console.WriteLine("\nReceipt for:\n{0}\n{1}\n{2}, {3}", customerName, streetAddress, state, zipcode);
            Console.WriteLine("\n{0} blenders ordered @{1} each", numberOfBlenders, blenderPrice.ToString("c"));

            Console.WriteLine("\nTotal: \t{0}", total.ToString("c"));
            Console.WriteLine("\nTax: \t{0}", tax.ToString("c"));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Due: \t{0}", due.ToString("c"));


        }
    }
}
