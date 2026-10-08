Console.WriteLine("Type in 3 sides of a triangle:");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());

Console.WriteLine($"P = {a + b + c}");
double p = (a + b + c) / 2;
Console.WriteLine($"S = {Math.Sqrt(p * (p - a) * (p - b) * (p - c))}");