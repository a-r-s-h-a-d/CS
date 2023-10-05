//interface

interface IAnimal
{
    void animalSound();
}

class Pig : IAnimal
{
    
    public void animalSound()
    {
        Console.WriteLine("The pig says : wee wee");
    }
    
}

class InterfaceExample
{
    public static void Main()
    {
        Pig pig=new Pig();
        pig.animalSound();
    }
}

//Multiple Interface

interface IFirstInterface
{
    void myMethod();
}

interface ISecondInterface
{
    void myOtherMethod();
}

class DemoClass : IFirstInterface,ISecondInterface
{
    public void myMethod()
    {
        Console.WriteLine("Some Text...");
    }

    public void myOtherMethod()
    {
        Console.WriteLine("Some Other Text...");
    }
}

class MultipleInterfaceExample
{
    public static void Main()
    {
        DemoClass demoClass=new DemoClass();
        demoClass.myMethod();
        demoClass.myOtherMethod();
    }
}