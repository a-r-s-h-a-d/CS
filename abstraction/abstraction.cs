abstract class Animal
{
    public abstract void animalSound();

    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

class Pig : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The Pig says : wee wee");
    }
}

class Program
{
    static void Main()
    {
        Pig myPig=new Pig();
        myPig.animalSound();
        myPig.sleep();
    }
}