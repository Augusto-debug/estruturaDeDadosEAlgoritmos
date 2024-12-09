// See https://aka.ms/new-console-template for more information
public class Prod {
    double price;
    string name;

    public Prod(double price, string name) {
        this.price = price;
        this.name = name;
    }

    public void updatePrice(double percentage) {
        this.price = price * (1 + percentage / 100);
    }

    public static void Main(string[] args) {
        Prod prod1 = new Prod(100, "Prod1");
        Prod prod2 = new Prod(200, "Prod2");
        Console.WriteLine(prod1.name + " price is " + prod1.price);
        prod1.updatePrice(10);
        Console.WriteLine("The update price of " + prod1.name + " is " + prod1.price);
    }
}