using System;

Console.WriteLine("==========================");
Console.WriteLine("  Student Information System");
Console.WriteLine("==========================");

Console.Write("Enter Your Name");
string? name = Console.ReadLine();

Console.Write("Enter Your Age");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Height in CM");
double height = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Percentage");
decimal percentage = Convert.ToDecimal(Console.ReadLine());

Console.Write("Is passed (True/false)");
bool pass = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("==========================");


Console.WriteLine($"name :       {name}");
Console.WriteLine($"Age :       {age}");
Console.WriteLine($"height :       {height} CM");
Console.WriteLine($"Percentage :       {percentage}");
Console.WriteLine($"Pass :       {pass}");

Console.WriteLine("=======================");

