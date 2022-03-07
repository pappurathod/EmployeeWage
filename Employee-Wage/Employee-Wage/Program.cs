// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage Computation program");

//UC4-Employee_Wage_Using_Case_Statement

namespace EmployeeWage
{
    class program
    {

        public const int IsFullTime = 1;
        public const int IsPartTime = 2;
        public const int Emp_per_rate = 20;

       public static void Main(String[] args)
        {
            int emphr = 0;
            int empwage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case IsFullTime:
                    Console.WriteLine("Employee is FullTime present");
                    emphr = 8;
                    //empwage = (Emp_per_rate * emphr);
                    //Console.WriteLine("Daily wage " + empwage);
                    break;
                case IsPartTime:
                    Console.WriteLine("Employee is Part Time present");
                    emphr = 4;
                    //empwage = (Emp_per_rate * emphr);
                    //Console.WriteLine("Daily wage " + empwage);
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    emphr = 0;
                    //empwage = (Emp_per_rate * emphr);
                    //Console.WriteLine("Daily wage " + empwage);
                    break;
            }
            empwage = (Emp_per_rate * emphr);
            Console.WriteLine("Daily wage " + empwage);

        }
    }
}
