using System;

public class OrderPlacedEventArgs : EventArgs
{
    public string OrderId { get; }
    public string CustomerName { get; }
    public double OrderAmount { get; }

    public OrderPlacedEventArgs(string orderId, string customerName, double orderAmount)
    {
        OrderId = orderId;
        CustomerName = customerName;
        OrderAmount = orderAmount;
    }
}
