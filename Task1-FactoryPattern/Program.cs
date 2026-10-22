// Student: Abdulrahman Nabil Shehata Mohamed
// ID: 42310194
// Factory Pattern - Task 1
using System;

abstract class Toy
{
    protected string name;
    protected float price;

    public abstract void PrepareParts();
    public abstract void CombineParts();
    public abstract void AssembleParts();
    public abstract void ApplyLabel();
    public abstract void ShowProduct();
}

class Car : Toy
{
    private static int count = 0;

    public Car()
    {
        name = "Car";
        price = 150;
        count++;
    }

    public override void PrepareParts()
        => Console.WriteLine("Car: preparing parts");
    public override void CombineParts()
        => Console.WriteLine("Car: combining parts");
    public override void AssembleParts()
        => Console.WriteLine("Car: assembling parts");
    public override void ApplyLabel()
        => Console.WriteLine("Car: applying label");
    public override void ShowProduct()
        => Console.WriteLine($"{name} | {price} LE | count: {count}");
}

class Bike : Toy
{
    private static int count = 0;

    public Bike()
    {
        name = "Bike";
        price = 100; // Illustrative price; original unavailable.
        count++;
    }

    public override void PrepareParts()
        => Console.WriteLine("Bike: preparing parts");
    public override void CombineParts()
        => Console.WriteLine("Bike: combining parts");
    public override void AssembleParts()
        => Console.WriteLine("Bike: assembling parts");
    public override void ApplyLabel()
        => Console.WriteLine("Bike: applying label");
    public override void ShowProduct()
        => Console.WriteLine($"{name} | {price} LE | count: {count}");
}

class Plane : Toy
{
    private static int count = 0;

    public Plane()
    {
        name = "Plane";
        price = 200; // Illustrative price; original unavailable.
        count++;
    }

    public override void PrepareParts()
        => Console.WriteLine("Plane: preparing parts");
    public override void CombineParts()
        => Console.WriteLine("Plane: combining parts");
    public override void AssembleParts()
        => Console.WriteLine("Plane: assembling parts");
    public override void ApplyLabel()
        => Console.WriteLine("Plane: applying label");
    public override void ShowProduct()
        => Console.WriteLine($"{name} | {price} LE | count: {count}");
}

class Train : Toy
{
    private static int count = 0;

    public Train()
    {
        name = "Train";
        price = 180;
        count++;
    }

    public override void PrepareParts()
        => Console.WriteLine("Train: preparing parts");
    public override void CombineParts()
        => Console.WriteLine("Train: combining parts");
    public override void AssembleParts()
        => Console.WriteLine("Train: assembling parts");
    public override void ApplyLabel()
        => Console.WriteLine("Train: applying label");
    public override void ShowProduct()
        => Console.WriteLine($"{name} | {price} LE | count: {count}");
}

static class ToyFactory
{
    public static Toy CreateToy(int type)
    {
        Toy toy;
        switch (type)
        {
            case 1: toy = new Car(); break;
            case 2: toy = new Bike(); break;
            case 3: toy = new Plane(); break;
            case 4: toy = new Train(); break;
            default:
                throw new ArgumentException("Unknown toy type");
        }

        toy.PrepareParts();
        toy.CombineParts();
        toy.AssembleParts();
        toy.ApplyLabel();
        return toy;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Toy type (1=Car, 2=Bike, 3=Plane, 4=Train): ");
        int type = int.Parse(Console.ReadLine()!);

        Toy toy = ToyFactory.CreateToy(type);
        toy.ShowProduct();

        Toy another = ToyFactory.CreateToy(type);
        another.ShowProduct();
    }
}
