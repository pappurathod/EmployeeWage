// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage Computation program");

//UC6-Calculate_Employee_Wage_Till_Condition

namespace EmployeeWage
{
    class program
    {

        public const int IsFullTime = 1;
        public const int IsPartTime = 2;
        public const int Emp_per_rate = 20;
        public const int Num_Of_Working_Days = 2;
        public const int Max_Hr_Month = 10;

        static void Main(String[] args)
        {
            int emphr = 0;
            int Total_Emp_Hr = 0;
            int Total_Working_Days = 0;
            //int totalEmpWage = 0;

            //for (int day = 0; day < Num_Of_Working_Days; day++)
            while (Total_Emp_Hr <= Max_Hr_Month && Total_Working_Days < Num_Of_Working_Days)
            {
                Total_Working_Days++;
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
                Total_Emp_Hr += emphr;
                Console.WriteLine("Day : " + Total_Working_Days + ", EmpHRS :" + emphr);
            }
            int TotalEmpWage = (Emp_per_rate * emphr);
            Console.WriteLine("total Emp wage : " + TotalEmpWage);
        }
    }
}
