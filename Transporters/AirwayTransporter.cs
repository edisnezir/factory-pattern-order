
public class AirwayTransporter : Transporter
{
    public AirwayTransporter(Order order)
    {
        _order = order;
    }
    
    protected override bool IsSuitableWithOrder(Order order)
    {
        return order.Urgent || (order.Distance >= 1000 && order.Weight <= 100);
    }

    public override void Transport()
    {
        Console.WriteLine($"The order transported by AirwayTransporter");
    }
}