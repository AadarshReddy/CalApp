// See https://aka.ms/new-console-template for more information
using CalApp;

Console.WriteLine("Calculator App");
Calc calc = new Calc();
Console.WriteLine("Addition");
calc.Add(12, 45);
Console.WriteLine("Subraction");
calc.Sub(12, 45);
Console.WriteLine("Multiplication");
calc.Mul(12, 45);
Console.WriteLine("Division");
calc.Div(12, 45);
