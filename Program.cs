using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        string[,] employees = new string[3,4];

        do
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("1. Enter Employee Data:");
            Console.WriteLine("2. Sort Employee Data by Start Date");
            Console.WriteLine("3. Display Employee Data");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your Choice (1-4):");
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                for(int i=0; i<3; i++)
                {
                    Console.WriteLine("Enter Data for Employee{0}", i + 1);
                    Console.WriteLine("Emplyee Name:");
                    employees[i, 0] = Console.ReadLine();
                    Console.WriteLine("Department:");
                    employees[i, 1] = Console.ReadLine();
                    Console.WriteLine("Salary:");
                    employees[i, 2] = Console.ReadLine();
                    Console.WriteLine("Start date (DD/MM/YYYY): ");
                    employees[i, 3] = Console.ReadLine();
                }
                Console.WriteLine("Employee Date Entered Successfully!\n");
                break;

                case 2:
                for(int i=0; i<3; i++)
        {
            for(int j=i+1; j<3; j++)
            {
                DateTime date1 = DateTime.Parse(employees[i,3]);
                DateTime date2 = DateTime.Parse(employees[j,3]);
                if(date1 > date2)
                {
                    string tempName = employees[i,0];
                    string tempDept = employees[i,1];
                    string tempSalary = employees[i,2];
                    string tempDate = employees[i,3];

                    employees[i,0] = employees[j,0];
                    employees[i,1] = employees[j,1];
                    employees[i,2] = employees[j,2];
                    employees[i,3] = employees[j,3];

                    employees[j,0] = tempName;
                    employees[j,1] = tempDept;
                    employees[j,2] = tempSalary;
                    employees[j,3] = tempDate;
                } 
            }
        }
        Console.WriteLine("Employee Data Sorted by start Date!\n");
        break;

        case 3:
        Console.WriteLine("Employee Data:");
        Console.WriteLine("Name Department Salary StartDate");
        for(int i=0; i<3; i++)
        {
            Console.WriteLine("{0} {1} {2} {3}", employees[i,0], employees[i,1], employees[i,2], employees[i,3]);
        } 
        break;

        case 4:
        Console.WriteLine("Exiting Program...");
        break;

        default:
        Console.WriteLine("Invalid Choice! Please Choose A Valid Option.\n");
        break;
            }

        }while(choice!=4);
    }
}