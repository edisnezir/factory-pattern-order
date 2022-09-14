
public abstract class Transporter : IDisposable
{
    protected Order _order;

    public static Transporter GetTransporter(Order order)
    {
        var instance = GetSuitableInstance(typeof(Transporter).FindSubClasses(), order);
        return instance;
    }

    private static Transporter GetSuitableInstance(IEnumerable<Type> types, Order order)
    {
        foreach (var @class in types)
        {
            try
            {
                var instance = Activator.CreateInstance(@class, new object[] {order}) as Transporter;
                var isSuitable = instance.IsSuitableWithOrder(order);

                if (isSuitable != true)
                {
                    instance.Dispose();
                    continue;
                }

                return instance;
            }
            catch (System.Exception ex)
            {
                continue;
            }
        }

        throw new NotImplementedException("System can not found any transporter for given order." + order);
    }

    public abstract void Transport();
    protected abstract bool IsSuitableWithOrder(Order order);

    public void Dispose()
    {
        // Suppress finalization.
        GC.SuppressFinalize(this);
    }
}
