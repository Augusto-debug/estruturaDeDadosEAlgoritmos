class Product:
    def __init__(self, name, price, quantity):
        self.name = name
        self.price = price
        self.quantity = quantity

    def __str__(self):
        return f"{self.name}, ${self.price:.2f}, {self.quantity}"

    def total(self):
        return self.price * self.quantity
    
    def update_price(self, price):
        self.price = self.price * (1 + price / 100) 

p1 = Product("Laptop", 1000, 5)
p2 = Product("headphone", 200, 2)
total1 = p1.total()
total2 = p2.total()
print(total1)
print(total2)
p1.update_price(10)
p2.update_price(20)
print(p1)
print(p2)