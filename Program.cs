List<Order> orders = new() {
    new Order {
        Urgent = false,
        Distance = 100,
        Weight = 50
    },
    new Order {
        Urgent = false,
        Distance = 2000,
        Weight = 4000
    },
    new Order {
        Urgent = false,
        Distance = 1100,
        Weight = 5
    },
    new Order {
        Urgent = true,
        Distance = 1200,
        Weight = 250
    }
};

foreach(var order in orders) {
    Console.WriteLine("----------------------");
    Console.WriteLine(order.ToString());
    Transporter.GetTransporter(order).Transport();
    Thread.Sleep(200);
}