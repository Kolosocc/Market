using System;
using System.Collections.Generic;

public abstract class Product
{
    public string Name { get; set; }
    public virtual double Price { get; set; }

    public abstract string GetInformation();
}

public class Toy : Product
{
    public string  Material { get; set; }

    public override string GetInformation()
    {
        return $"Игрушка: {Name}, Материал: {Material}, Цена: {Price}";
    }
}

public class Meat : Product
{
    public double Weight { get; set; } 

    public override string GetInformation()
    {
        return $"Мясо: {Name}, Вес: {Weight}кг, Цена: {Price}";
    }
}

public class Drink : Product
{
    public double Volume { get; set; } 

    public override string GetInformation()
    {
        return $"Напиток: {Name}, Объем: {Volume} л, Цена: {Price}";
    }
}

public class Electronics : Product
{
    public int Voltage { get; set; } 

    public override string GetInformation()
    {
        return $"Электроника: {Name}, Вольтаж: {Voltage}, Цена: {Price}";
    }
}

public class Clothing : Product
{
    public string Size { get; set; } 

    public override string GetInformation()
    {
        return $"Одежда: {Name}, Размер: {Size}, Цена: {Price}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product> {
            new Toy { Name = "Машинка", Price = 999.99, Material = "plastic" },
            new Meat { Name = "Говядина", Price = 350.00, Weight = 125 },
            new Drink { Name = "Сок", Price = 50.00, Volume = 1.0 },
            new Electronics { Name = "Телевизор", Price = 29999.99 , Voltage = 220 },
            new Clothing { Name = "Футболка", Price = 1499.99, Size = "L" }
        };


        double discountRate = 0.1 ;

        foreach (var product in products)
        {
            double discountedPrice = product.Price * (1 - discountRate);
            Console.WriteLine($"{product.GetInformation()}, Цена со скидкой: {Math.Round(discountedPrice, 2)}\n");
        }

        Console.ReadKey();
    }
}
