public class Product {
    public double price;
    public string name;
    public int quantity;

    public Product(double price, string name, int quantity) {
        this.price = price;
        this.name = name;
        this.quantity = quantity;
    }
    public void updatePrice(double percentage) {
        this.price = price * (1 + percentage / 100);
    }

    public double total () {
        return price * quantity;
    }

    public override string ToString() {
        return "Product: " + name + " Price: " + price + " Quantity: " + quantity;
    }
}