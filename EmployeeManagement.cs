using System;
using System.Collections.Generic;

class EmployeeManagement
{
    private string[,] employees = new string[10, 4];
    private List<string> employeeList = new List<string>();
    private int employeeCount = 0;
    
    public void EnterEmployeeData()
    {
        if (employeeCount < 10)
        {
            Console.WriteLine("Enter Data for Employee {0}:", employeeCount + 1);
            Console.WriteLine("Employee Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Department:");
            string department = Console.ReadLine();
            Console.WriteLine("Salary:");
            string salary = Console.ReadLine();
            Console.WriteLine("Start date (DD/MM/YYYY): ");
            string startDate = Console.ReadLine();

            string employeeData = $"{name}, {department}, {salary}, {startDate}";
            employeeList.Add(employeeData);

            employeeCount++;
            Console.WriteLine("** Employee Data Entered Successfully! **\n");
        }
        else
        {
            Console.WriteLine("** Maximum number of employees reached! **\n");
        }
    }

    public void SortEmployeeDataByStartDate()
    {
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
    }

    public void DisplayEmployeeData()
    {
        for (int i = 0; i < employeeCount; i++)
        {
            Console.WriteLine("{0} {1} {2} {3}", employees[i, 0], employees[i, 1], employees[i, 2], employees[i, 3]);
        }
        Console.WriteLine();
    }

    public void DisplayEmployeeList()
    {
        foreach (string employee in employeeList)
        {
            string[] employeeData = employee.Split(',');
            string name = employeeData[0].Trim();
            Console.WriteLine(name);
        }
    Console.WriteLine();
    }
}
