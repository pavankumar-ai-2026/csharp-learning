using System;

//for(int i=0;i<=5; i++)
//{
//    Console.WriteLine("pavan");
//}

//int i = 1;

//while (i <= 5)
//{
//    Console.WriteLine(i);
//    i++;
//}

//int i = 10;

//do
//{
//    Console.WriteLine(i);
//}
//while (i < 5);

//string[] Emplpoyees =
//{
//    "pavan",
//    "Raja",
//    "Uday"
//};

//foreach (string employee in Emplpoyees)
//{
//    Console.WriteLine(employee);
//}

//for(int i = 1; i <= 10; i++)
//{
//    if (i == 5)
//        break;
//    Console.WriteLine(i);
//}

//for (int i = 1; i <= 10; i++)
//{
//    if (i == 3)
//        continue;
//    Console.WriteLine(i);
//}

//for(int i=1;i<=3; i++)
//{
//    for(int j = 1; j <= 2; j++)
//    {
//        Console.WriteLine($"i={i},j={j}");
//    }
//}

//Console.Write("Enter No of Employees");
//int noofemp = Convert.ToInt32(Console.ReadLine());

//for (int i=1;i<= noofemp; i++)
//{
//    Console.Write("Enter Employtee name");
//    string name = Console.ReadLine();
//    Console.Write("Enter Attendence");
//    double attendence = Convert.ToDouble(Console.ReadLine());
//    Console.Write("present/absent");
//    string pre = Console.ReadLine();
//    Console.WriteLine("Employee Attendence");
//    Console.WriteLine($"{name} - {pre}");
//}

//for(int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}


Console.WriteLine(" How many Documents you have :");
int num = Convert.ToInt32(Console.ReadLine());

List<string> names = new List<string>();
for (int i = 0; i < num; i++)
{
    Console.Write("Enter Document Name: ");
    string? dcname = Console.ReadLine();
    names.Add(dcname!);
}

Console.WriteLine();
Console.WriteLine("Documents");
int count = 1;
foreach (var nam in names)
{
    Console.WriteLine($"{count} . {nam}");
    count++;
}