// See https://aka.ms/new-console-template for more information
Console.WriteLine("Review 3");
public class Car
{
    private string model;
    private int year;

    public void SetModel(string modelName)
    {
        model = modelName;
    }

    public string GetModel()
    {
        return model;
    }

    public void SetYear(int carYear)
    {
        year = carYear;
    }

    public int GetYear()
    {
        return year;
    }
}

//Inheritance : Car class inherits from the Vehicle class

public class Vehicle
{
    public string Brand
    {
        get; set;
    }
    public void Start()
    {
        Console.WriteLine("Vehicle Started");
    }
}

public class Car1 : Vehicle
{
    public void Accelerate()
    {
        Console.WriteLine("Car Accelerate");
    }
}

//Polymorphism : Shape Class and its derived classes
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Draw a shape");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw a Circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw a Rectangle");
    }
}

//Abstract : Animal Class and its Derived class
public abstract class Animal
{
    public abstract void sound();
}

public class Dog : Animal
{
    public override void sound()
    {
        Console.WriteLine("Woof");
    }
}

public class Program1
{
    public static void Main(string[] args)
    {
        //Encapsulation Example
        Car car = new Car();
        car.SetModel("ABC");
        car.GetModel();
        car.Equals(car);
        car.GetModel();
        car.Equals(car);


    }
}