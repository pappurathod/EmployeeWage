// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage Computation program");

//UC5-Calculate_Employee_Wage_For_Month

namespace EmployeeWage
{
    class program
    {

        public const int IsFullTime = 1;
        public const int IsPartTime = 2;
        public const int Emp_per_rate = 20;
        public const int Num_Of_Working_Days = 20;

        static void Main(String[] args)
        {
            int emphr = 0;
            int empwage = 0;
            int totalEmpWage = 0;

            for (int day = 0; day < Num_Of_Working_Days; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IsFullTime:
                        Console.WriteLine("Employee is FullTime present");
                        emphr = 8;
                        break;
                    case IsPartTime:
                        Console.WriteLine("Employee is Part Time present");
                        emphr = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is absent");
                        emphr = 0;
                        break;
                }
                empwage = (Emp_per_rate * emphr);
                totalEmpWage += empwage;
                Console.WriteLine("Daily Emp wage : " + empwage);
            }
            Console.WriteLine("total Emp wage : " + totalEmpWage);
        }
    }
}
