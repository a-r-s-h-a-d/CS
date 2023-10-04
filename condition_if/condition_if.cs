//condition

//1.if
if (20>10)
{
    Console.WriteLine("20 is greater than 10");
}

//2.else
int time = 20;
if (time < 18) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}

//3.else if
int time2 = 18;
if (time2 < 10) 
{
  Console.WriteLine("Good morning.");
} 
else if (time2 < 20) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}

//ternary operator
int time3 = 20;
string result = (time3 < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);