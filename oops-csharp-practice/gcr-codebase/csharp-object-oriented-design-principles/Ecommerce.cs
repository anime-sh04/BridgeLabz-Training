using System;
using System.Collections.Generic;

class Product{
    public string Name;
    public double Price;

    public Product(string name,double price){
        Name = name;
        Price =price;
    }
}

class Order{
    public int OrderId;
    private List<Product> products =new List<Product>();

    public Order(int id){
        OrderId = id;
    }

    public void AddProduct(Product p){
        products.Add(p);
        Console.WriteLine("Product added :"+ p.Name);
    }

    public void ShowOrder(){
        Console.WriteLine("Order ID :" +OrderId);
        double total = 0;
        foreach(Product p in products){
            Console.WriteLine(p.Name +"-" + p.Price);
            total += p.Price;
        }
        Console.WriteLine("Total Bill : " +total);
    }
}

class Customer{
    public string Name;

    public Customer(string name){
        Name = name;
    }

    public void PlaceOrder(Order o){
        Console.WriteLine(Name +" placed order"+ o.OrderId);
        o.ShowOrder();
    }
}

class Ecommerce{
    static void Main(string[] args){
        Customer c1 = new Customer("Animesh");

        Product p1 = new Product("Laptop",50000);
        Product p2 = new Product("Mouse",500);

        Order o1 = new Order(101);

        o1.AddProduct(p1);
        o1.AddProduct(p2);

        c1.PlaceOrder(o1);
    }
}
