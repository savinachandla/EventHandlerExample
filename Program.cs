using System;

class Program
{
    static void Main()
    {
        Order order = new Order();
        Customer customer = new Customer();

        order.OrderPlaced += customer.OnOrderPlaced;

        order.PlaceOrder("ORDER123", "John Test", 251.75);
    }
}
