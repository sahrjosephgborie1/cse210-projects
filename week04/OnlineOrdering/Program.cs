using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    { 
        // new customer from USA
        Address customerFromUsaAddress = new Address("Salt Lake street", "Salt Lake City", "Provo Utah", "USA");
        Customer customerUsa = new Customer("Patrick Mbayoh", customerFromUsaAddress);
        // product string name, int productId, int price, int quantity
        Product productUsa = new Product("Rice", 111, 5.0m, 2);
        Product product2 = new Product("Fish", 212, 5.0m, 2);
        // orders
        Order orderUsa = new Order(customerUsa);
        // add product (customer from usa)
        orderUsa.AddProduct(productUsa);
        orderUsa.AddProduct(product2);

        // second order outside USA
        Address freetownAddress = new Address("Rokel", "Freetown", "None", "Sierra Leone");
        Customer freetownCustomer = new Customer("Sahr Joseph Gborie", freetownAddress);
        Order freetownOrder = new Order(freetownCustomer);
        freetownOrder.AddProduct(new Product("Spoon", 223, 5.0m, 2));
        freetownOrder.AddProduct(new Product("Cake", 255, 5.0m, 2));

        // adding orders in a list
        List<Order> orders = new List<Order>() { orderUsa, freetownOrder };
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