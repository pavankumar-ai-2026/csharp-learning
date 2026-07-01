using System;

class Program
{
    //static decimal TotalSalary(decimal salary, decimal bonus)
    //{
    //    return salary + bonus;
    //}

    //static void Main()
    //{
    //    Console.WriteLine("Enter Employee Name:");
    //    string name = Console.ReadLine();

    //    Console.WriteLine("Enter Salary:");
    //    decimal salary = decimal.Parse(Console.ReadLine());

    //    Console.WriteLine("Enter Bonus:");
    //    decimal bonus = decimal.Parse(Console.ReadLine());

    //    decimal totalSalary = TotalSalary(salary, bonus);

    //    Console.WriteLine($"Employee Name: {name}");
    //    Console.WriteLine($"Total Salary: {totalSalary}");
    //}

    static void Main()
    {
        Console.WriteLine("===================================");
        Console.WriteLine("   Employee Management System");
        Console.WriteLine("===================================");

        Console.WriteLine(" 1.Employee Details");
        Console.WriteLine(" 2.Calculate total Salary");
        Console.WriteLine(" 3.Checking Voting Eligibilty");
        Console.WriteLine(" 4.Exit");

        Console.WriteLine("Enter Your Choice..");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                EmployeeDetails();
                break;
            case 2:
                CalculateTotalsalary();
                break;
            case 3:
                Checkvotingligibility();
                break;
            case 4: 
                Console.WriteLine("Thank you");
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
            
    }

      static void EmployeeDetails()
      {
            Console.WriteLine("Employee ID");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee Name");
            string? name = Console.ReadLine();
            Console.WriteLine("Department");
            string? department = Console.ReadLine();
            Employeedetailsdisplay(empid, name, department);

        }
      static void CalculateTotalsalary()
      {
            Console.WriteLine("Basic Salary");
            decimal salary  = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Bonus");
            decimal bonus = Convert.ToDecimal(Console.ReadLine());
            employeetotalsalary(salary, bonus);
       }
      static void Checkvotingligibility()
      {
            Console.WriteLine("Employee age");
            int age = Convert.ToInt32(Console.ReadLine());
            Checkingvotingeligibility(age);
      }
        static void Checkingvotingeligibility(int age) 
        { 
            if(age >= 18)
            {
                Console.WriteLine("Eligble For Vote");
            }
            else
            {
                Console.WriteLine("Not Eligble For Vote");

            }
        }
        static void employeetotalsalary(decimal salary , decimal bonus)
        {
            Console.WriteLine($"Total salary {salary + bonus}");
        }
        static void Employeedetailsdisplay(double empid, string name , string department)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("  Employee Details");
            Console.WriteLine("===========================");
            Console.WriteLine($"EmpID : {empid}");
            Console.WriteLine($"Empname : {name}");
            Console.WriteLine($"Department : {department}");
        }

    }