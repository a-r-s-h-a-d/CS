//declare the array

string[] cars = {"Volvo","BMW","Ford","Mazda"};

//print using foreach
foreach (string item in cars)
{
    Console.WriteLine(item);
}

//print using for-loop
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}

string[] cars2 = {"Volvo","BMW","Ford","Mazda"};
//sort the array
Array.Sort(cars2);
foreach (string i in cars2)
{
  Console.WriteLine(i);
}