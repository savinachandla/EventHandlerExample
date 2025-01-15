using System;

public class Order
{
    public delegate void OrderPlacedEventHandler(object sender, OrderPlacedEventArgs e);

    public event OrderPlacedEventHandler OrderPlaced;

    public void PlaceOrder(string orderId, string customerName, double orderAmount)
    {
        Console.WriteLine($"Order Placed: {orderId} by {customerName} for amount {orderAmount}");
        OnOrderPlaced(orderId, customerName, orderAmount);
    }

    protected virtual void OnOrderPlaced(string orderId, string customerName, double orderAmount)
    {
        OrderPlaced?.Invoke(this, new OrderPlacedEventArgs(orderId, customerName, orderAmount));
    }
}
