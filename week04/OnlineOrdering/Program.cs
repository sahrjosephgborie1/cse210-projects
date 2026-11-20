using System;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    { 
        // new customer from USA
        Address CustomerFromUsaAddress = new Address("Salt Lake street", "Salt Lake City", "Provo Utah", "USA");
        Customer customerusa = new Customer("Patrick Mbayoh",  CustomerFromUsaAddress);
        // product string name, int productId, int price, int quantity
        Product productusa = new Product("Rice", 111, 5.0m, 2);
        Product product2 = new Product("Fish", 212, 5.0m, 2);
        // orders
        Order orderuusa = new Order(customerusa);
        // add product (customer from usa)
        orderuusa.AddProduct(productusa);
        orderuusa.AddProduct(product2);

        // second order outside USA
        Address freetownAddress = new Address("Rokel", "Freetown", "None", "Sierra Leone");
        Customer freetownCustomer = new Customer("Sahr Joseph Gborie", freetownAddress);
        Order freetownOrder = new Order(freetownCustomer);
        freetownOrder.AddProduct(new Product("Spoon", 223, 5.0m, 2));
        freetownOrder.AddProduct(new Product("Cake", 255, 5.0m, 2));

        // adding orders in a list
        List<Order> orders = new List<Order>() {orderuusa, freetownOrder};
        int orderNumber = 1;

        Console.WriteLine("Online Ordering");
        Console.WriteLine();

        // display packing label, shipping label, total price.
        foreach (Order order in orders)
        {
            Console.WriteLine($"ORDER {orderNumber}");
            Console.WriteLine("Packing Label");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("Shipping label:");
            Console.WriteLine(order.GetShippingLabel());
            // total
            Console.WriteLine($"Total (USD, including shipping): ${order.GetTotalPrice().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            orderNumber++;

        }       



    }
}