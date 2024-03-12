// See https://aka.ms/new-console-template for more information


using firstCode;

Console.WriteLine("Welcome to Calculator");
Console.WriteLine("Please enter a first value");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter a second value");
int b = int.Parse(Console.ReadLine());

Calculator c = new Calculator();
c.Add(a,b);

Console.WriteLine("One line added for demo purpose");

Console.ReadLine(); 