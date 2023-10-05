//1.Create a Method

// class MethodExample
// {
//     static void MyMethod()
//     {
//         Console.WriteLine("I Just Got Executed!");
//     }

//     static void Main()
//     {
//         MyMethod();
//     }
// }

//<--------------------------------------------------------------->

//2.Multiple parameters

// class ParameterExample{
//     static void MyMethod(string fname,int age){
//     Console.WriteLine(fname + " is " + age);
// }

// static void Main(){
//     MyMethod(fname:"Arshad",age:22);
//     MyMethod(fname:"Ajmal",age:20);
//     MyMethod(fname:"Afsal",age:21);
//     MyMethod(fname:"Jubair",age:23);
// }
// }

//<------------------------------------------------------------------>

// 3.Default Parameter

// class DefaultParameterExample
// {
//     static void MyMethod(string country="India")
//     {
//         Console.WriteLine(country);
//     }

//     static void Main()
//     {
//         MyMethod("UAE");
//         MyMethod("USA");
//         MyMethod();
//         MyMethod("UK");

//     }
// }

//<------------------------------------------------------------------>


//4.Return Value

// class ReturnValue
// {
//     static int MyMethod(int x,int y){
//         return x+y;
//     }

//     static void Main(){
//         Console.WriteLine(MyMethod(5,10));
//     }
// }


//5.Named Parameter

// class NamedParameterExample
// {
//     static void MyMethod(string country)
//     {
//         Console.WriteLine(country);
//     }

//     static void Main()
//     {
//         MyMethod(country:"INDIA");
//         MyMethod(country:"UAE");
//         MyMethod(country:"USA");
//         MyMethod(country:"UK");
//     }
// }

//6.Method Overloading

// class MethodOverloadingExample
// {
//     static int PlusMethod(int x, int y)
// {
//   return x + y;
// }

// static double PlusMethod(double x, double y)
// {
//   return x + y;
// }

// static void Main(string[] args)
// {
//   int myNum1 = PlusMethod(8, 5);
//   double myNum2 = PlusMethod(4.3, 6.26);
//   Console.WriteLine("Int: " + myNum1);
//   Console.WriteLine("Double: " + myNum2);
// }
// }

