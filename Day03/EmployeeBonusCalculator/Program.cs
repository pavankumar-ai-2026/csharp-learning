//using System;

//Console.WriteLine("============================");
//Console.WriteLine("  Employee Bomnus Calculator");
//Console.WriteLine("============================");



//Console.Write("Employee Name");
//string? name = Console.ReadLine();

//Console.Write("Salary");
//decimal salary = Convert.ToDecimal(Console.ReadLine());

//Console.WriteLine("Years of experience");
//int experience = Convert.ToInt32(Console.ReadLine());

//decimal bonus = 0;

//if(experience >= 10)
//{
//    bonus = salary * 0.20m;
//}
//else if(experience >= 5)
//{
//    bonus = salary * 0.10m;
//}
//else
//{
//    bonus = salary * 0.5m;
//}

//Console.WriteLine();
//Console.WriteLine("==============Result=========");


//Console.WriteLine($"Name : {name}");
//Console.WriteLine($"Salary : {salary:C}");
//Console.WriteLine($"Bonus : {bonus :C}");

//Console.WriteLine("==============End=========");





//using System;

//Console.Write("Department");
//string? department = Console.ReadLine();

//string message = department.ToLower() switch
//{
//    "hr" => "Hyman resource",
//    "it" => "information technology",
//    "finance" => "Finance department",
//    _=> "unknown department"
//};

//Console.WriteLine(message);