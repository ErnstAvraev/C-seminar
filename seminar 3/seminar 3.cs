Console.WriteLine("Input coordinate x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinate y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("First quarter");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Second quarter");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Third quarter");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("forth quarter");
}
else 
{
    Console.WriteLine("Can't identify quarter");
}