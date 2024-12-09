public class Program{
    public static void Main(string[] args) {
        Product prod1 = new(100, "Prod1", 2);
        Product prod2 = new(200, "Prod2", 3);
        Console.WriteLine(prod1);
        prod1.updatePrice(10);
        Console.WriteLine(prod2);
        Console.WriteLine("The total price of " + prod1.name + " is " + prod1.total());
        Console.WriteLine("The update price of " + prod1.name + " is " + prod1.price);
    }
}