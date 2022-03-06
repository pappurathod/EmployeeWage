// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage Computation program");
//UC2-Calculate_Daily_Wage
int Present = 1;
int Emp_per_rate = 20;
int emphr = 0;
int empwage = 0;

Random random = new Random();
int Employeestatus = random.Next(0, 2);
if (Employeestatus == Present)
{
    Console.WriteLine("Employee is present");
    emphr = 8;
}
else
{
    Console.WriteLine("Employee is absent");
    emphr = 0;
}
empwage = (Emp_per_rate * emphr);
Console.WriteLine("Daily Wage " + empwage);
