using System;
using System.Globalization;
using Enum_____ExercicioFixação3.Entities;
using Enum_____ExercicioFixação3.Entities.StatusOrder;

namespace Enum_____ExercicioFixação3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Order order = new Order();
            
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string Name = Console.ReadLine();

            Console.Write("Email: ");
            string Email = Console.ReadLine();

            Console.Write("Birth date(DD/MM/YYYY): ");
            DateTime Date = DateTime.Parse(Console.ReadLine());

            

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(Name, Email, Date);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int QuantOrderItems = int.Parse(Console.ReadLine());

            for(int i = 1; i <= QuantOrderItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                String NameProduct = Console.ReadLine();

                Console.Write("Product price: ");
                double PriceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(NameProduct, PriceProduct);

                Console.Write("Quantity: ");
                int Quantity = int.Parse(Console.ReadLine());

      

                OrdemItem ordemItem = new OrdemItem(Quantity, PriceProduct, product);
                
                order.AddItem(ordemItem);
            }

            Console.WriteLine("\n" + order);
        }
    }
}
