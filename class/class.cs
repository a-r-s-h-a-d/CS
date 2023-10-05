//class with multiple objects
// class Car
// {
//     string color="red";

//     static void Main()
//     {
//         Car obj1=new Car();
//         Car obj2=new Car();

//         Console.WriteLine(obj1.color);
//         Console.WriteLine(obj2.color);
//     }
// }

//<------------------------------------------------>


//passing values

// class Car
// {
//     string color;
//     int maxSpeed;

//     static void Main(){

//         Car obj=new Car();
//         obj.color="red";
//         obj.maxSpeed=200;

//         Console.WriteLine(obj.color);
//         Console.WriteLine(obj.maxSpeed);

//     }
// }


//<------------------------------------------------>

//constructor


// class Car
// {
//     public string model;

//     public Car()
//     {
//         model="mustang";
//     }

//     static void Main()
//     {
//         Car ford=new Car();
        
//         Console.WriteLine(ford.model);
//     }
// }

//C# Properties (Get and Set)

class Person
{
  private string name; // field
  public string Name   // property
  {
    get { return name; }
    set { name = value; }
    
    
    //Automatic Properties
    // get;
    // set;
  }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Arshad";
    Console.WriteLine(myObj.Name);
  }
}

