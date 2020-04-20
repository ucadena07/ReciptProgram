using System;

namespace SimulatedOrderReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            string customerName, streetAddress, city, state, zipcode;
            double subTotal, numberOfBlenders, taxTotal, totalDue;
           

            const double BLENDER_PRICE = 39.95;
            const double SALE_TAX = .07;

            Console.Write("Please enter your name: ");
            customerName = Console.ReadLine();

            Console.Write("Please enter your address: ");
            streetAddress = Console.ReadLine();

            Console.Write("City: ");
            city = Console.ReadLine();

            Console.Write("State: ");
            state = Console.ReadLine();

            Console.Write("ZipCode: ");
            zipcode = Console.ReadLine();

            Console.Write("How many blenders would you like to purchase: ");
            numberOfBlenders = Convert.ToDouble(Console.ReadLine());

            subTotal = BLENDER_PRICE * numberOfBlenders;
            taxTotal = subTotal * SALE_TAX;
            totalDue = subTotal + taxTotal;

            Console.WriteLine("\nReceipt for:\n{0}\n{1}\n{2} {3}, {4}", customerName, streetAddress,city, state, zipcode);
            Console.WriteLine("\n{0} blenders ordered @{1} each", numberOfBlenders, BLENDER_PRICE.ToString("c"));

            Console.WriteLine("\nTotal: \t{0}", subTotal.ToString("c"));
            Console.WriteLine("\nTax: \t{0}", taxTotal.ToString("c"));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Due: \t{0}", totalDue.ToString("c"));


        }
    }
}
