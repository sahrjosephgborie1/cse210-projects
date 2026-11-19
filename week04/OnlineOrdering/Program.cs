using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // new customer from USA
        Address CustomerFromUsaAddress = new Address("Salt Lake street", "Salt Lake City", "Provo Utah", "usa");
        Customer customerusa = new Customer("Patrick Mbayoh",  CustomerFromUsaAddress);

        // product string name, int productId, int price, int quantity
        Product productusa = new Product("Rice", 045, 5, 2);

        // orders
        Order orderuusa = new Order(customerusa);
        // add product (customer from usa)
        orderuusa.AddProduct(productusa);

        // display packing label, shipping label, total price.


        string shippingLabel = orderuusa.GetShippingLabel();
        Console.WriteLine($"Shipping Label: {shippingLabel}");
        
        int tp = orderuusa.GetTotalPrice();
        Console.WriteLine($"Total Price: {tp}");


        // // Second Product
        // Product product2Usa = new Product("Rice", 045, 10, 3);
        // orderuusa.AddProduct(product2Usa);

        
         



    }
}