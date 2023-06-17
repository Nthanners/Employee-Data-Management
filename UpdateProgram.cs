using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        int employeeCount = 0;
        string[,] employees = new string[10, 4];
        List<string> employeeList = new List<string>();

        do
        {
            Console.WriteLine("*******************");
            Console.WriteLine("*     MENU        *");
            Console.WriteLine("*******************");
            Console.WriteLine("1. Enter Employee Data:");
            Console.WriteLine("2. Sort Employee Data by Start Date");
            Console.WriteLine("3. Display Employee Data");
            Console.WriteLine("4. Display Employee List");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your Choice (1-5):");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("** Enter Data for the Employee **\n");
                    if (employeeCount < 10)
                    {
                        Console.WriteLine("Enter Data for Employee {0}:", employeeCount + 1);
                        Console.WriteLine("Employee Name:");
                        employees[employeeCount, 0] = Console.ReadLine();
                        Console.WriteLine("Department:");
                        employees[employeeCount, 1] = Console.ReadLine();
                        Console.WriteLine("Salary:");
                        employees[employeeCount, 2] = Console.ReadLine();
                        Console.WriteLine("Start date (DD/MM/YYYY): ");
                        employees[employeeCount, 3] = Console.ReadLine();
                        employeeCount++;
                        Console.WriteLine("** Employee Data Entered Successfully! **\n");
                    }
                    else
                    {
                        Console.WriteLine("** Maximum number of employees reached! **\n");
                    }
                    break;

                case 2:
                    for (int i = 0; i < employeeCount; i++)
                    {
                        for (int j = i + 1; j < employeeCount; j++)
                        {
                            DateTime date1 = DateTime.Parse(employees[i, 3]);
                            DateTime date2 = DateTime.Parse(employees[j, 3]);
                            if (date1 > date2)
                            {
                                string tempName = employees[i, 0];
                                string tempDept = employees[i, 1];
                                string tempSalary = employees[i, 2];
                                string tempDate = employees[i, 3];

                                employees[i, 0] = employees[j, 0];
                                employees[i, 1] = employees[j, 1];
                                employees[i, 2] = employees[j, 2];
                                employees[i, 3] = employees[j, 3];

                                employees[j, 0] = tempName;
                                employees[j, 1] = tempDept;
                                employees[j, 2] = tempSalary;
                                employees[j, 3] = tempDate;
                            }
                        }
                    }
                    Console.WriteLine("** Employee Data Sorted by Start Date! **\n");
                    break;

                case 3:
                    DisplayEmployeeData(employees, employeeCount);
                    break;

                case 4:
                    DisplayEmployeeList(employeeList);
                    break;

                case 5:
                    Console.WriteLine("Exiting Program...");
                    break;

                default:
                    Console.WriteLine("** Invalid Choice! Please Choose A Valid Option. **\n");
                    break;
            }

        } while (choice != 5);
    }

    static void DisplayEmployeeData(string[,] employees, int count)
    {
        Console.WriteLine("Employee Data:");
        Console.WriteLine("Name Department Salary StartDate");
        for (int i = 0; i < count; i++)
        {
                        Console.WriteLine("{0} {1} {2} {3}", employees[i, 0], employees[i, 1], employees[i, 2], employees[i, 3]);
        }
        Console.WriteLine();
    }
        
    static void DisplayEmployeeList(List<string> employeeList)
    {
        Console.WriteLine("Employee List:");
        foreach (string employee in employeeList)
        {
            Console.WriteLine(employee);
        }
        Console.WriteLine();
    }
    
}