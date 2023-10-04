//1.Variables and its Datatypes
int myNum = 5;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";

Console.WriteLine($"int ==> {myNum}");
Console.WriteLine($"double ==> {myDoubleNum}");
Console.WriteLine($"char ==> {myLetter}");
Console.WriteLine($"bool ==> {myBool}");
Console.WriteLine($"string ==> {myText}");

//2.Constants
const int myConstantNum=15;

/*
myConstantNum=20; ==> Error
*/
Console.WriteLine($"Constant Number ==> {myConstantNum}");

//3.Multiple Variables
int x=10;
int y=20;
int z=30;

Console.WriteLine(x+y+z);