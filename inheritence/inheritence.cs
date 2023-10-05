class Vehicle
{
    public string brand="ford";
    public void honk()
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car:Vehicle
{
    public string modelName="mustang";
}

class Program
{
    static void Main(){
        Car myCar=new Car();

        myCar.honk();
        Console.WriteLine(myCar.brand+"\n"+myCar.modelName);
    }
}

//sealed-->we could block another class from inheriting.

/*

sealed class Vehicle
{
    public string brand="ford";
    public void honk()
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

*/