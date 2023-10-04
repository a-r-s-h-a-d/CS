//math operators

int x=5;
int y=10;
double z=10.5;

int max=Math.Max(x,y);
int min=Math.Min(x,y);
double sqrt=Math.Sqrt(9);
double abs=Math.Abs(z);
double round=Math.Round(z);

Console.WriteLine($"Maximum({x},{y}) ==>{max}");
Console.WriteLine($"Minimum({x},{y}) ==>{min}");
Console.WriteLine($"Square Root({x}) ==>{sqrt}");
Console.WriteLine($"Absolute({x}) ==>{abs}");
Console.WriteLine($"Round({z}) ==>{round}");