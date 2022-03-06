// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage Computation program");
//UC1Attendance
int Present = 1;
Random random = new Random();
int EmployeeStatus = random.Next(0, 2);
if (EmployeeStatus == Present)
{
    Console.WriteLine("Employee is present");
}
else
{
    Console.WriteLine("Employee is absent");
}