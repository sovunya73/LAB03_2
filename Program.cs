Console.WriteLine("Type in 3 sides of a triangle:");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());

Console.WriteLine($"P = {a + b + c}");
Console.WriteLine($"S = {Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c)):F2}");