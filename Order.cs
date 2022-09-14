public class Order {
    public int Distance { get; set; }
    public int Weight { get; set; }
    public bool Urgent { get; set; }

    public override string ToString()
    {
        return $"Distance: {Distance}km, Weight: {Weight}kg, Urgent: {(Urgent? "Y": "N")}";
    }
}



