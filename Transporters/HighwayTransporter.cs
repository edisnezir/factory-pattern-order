
public class HighwayTransporter : Transporter
{
    public HighwayTransporter(Order order)
    {
        _order = order;
    }
    
    protected override bool IsSuitableWithOrder(Order order)
    {
        return !order.Urgent && order.Distance < 1000;
    }

    public override void Transport()
    {
        Console.WriteLine($"The order transported by HighwayTransporter");
    }
}