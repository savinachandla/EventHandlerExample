using System;

public class Customer
{
    public void OnOrderPlaced(object sender, OrderPlacedEventArgs e)
    {
        Console.WriteLine($"Order Confirmation: Order {e.OrderId} placed by {e.CustomerName} with amount {e.OrderAmount:C}. Thank you for your purchase!");
    }
}
