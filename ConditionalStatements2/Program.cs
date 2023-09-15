// See https://aka.ms/new-console-template for more information
Console.WriteLine("#3");
Console.WriteLine("Choose a number?");

int n = Convert.ToInt32(Console.ReadLine());

if (n >= 0)
{
    Console.WriteLine("Positive");
}
else
{
    Console.WriteLine("Negative");
}
