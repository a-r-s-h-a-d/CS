//String
string greeting="Hello";
string greeting2 = "Nice to meet you!";

Console.WriteLine(greeting);
Console.WriteLine(greeting2);

//String length
string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of string : "+txt.Length);

//Upper Case
Console.WriteLine(greeting.ToUpper());
//Lower Case
Console.WriteLine(greeting.ToLower());

//concatenation
string firstName="Muhammed ";
string secondName="Arshad K A";
string fullName=firstName+secondName;

Console.WriteLine(fullName);

//interpolation
string firstName2 = "Muhammed";
string lastName2 = "Arshad K A";
string name = $"My full name is: {firstName2} {lastName2}";
Console.WriteLine(name);

//Access Strings
string hello="Hello";
Console.WriteLine(hello[0]);
Console.WriteLine(hello[1]);
Console.WriteLine(hello[2]);
Console.WriteLine(hello[3]);
Console.WriteLine(hello[4]);

//IndexOf()
string myString1="Hasta la vista, baby";
Console.WriteLine(myString1.IndexOf("t"));

//Substring()
string myString2="Hasta la vista, baby";
Console.WriteLine(myString2.Substring(6));
