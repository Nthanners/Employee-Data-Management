using System;

class Program
{
    static void Main(string[] args)
    {
        EmployeeManagement employeeManagement = new EmployeeManagement();
        {
            int choice = 0;

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
                        employeeManagement.EnterEmployeeData();
                        break;

                    case 2:
                        employeeManagement.SortEmployeeDataByStartDate();
                        Console.WriteLine("** Employee Data Sorted by Start Date! **\n");
                        break;

                    case 3:
                        Console.WriteLine("Employee Data:");
                        Console.WriteLine("Name Department Salary StartDate");
                        employeeManagement.DisplayEmployeeData();
                        break;

                    case 4:
                        Console.WriteLine("Employee List:");
                        employeeManagement.DisplayEmployeeList();
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
    }
}
