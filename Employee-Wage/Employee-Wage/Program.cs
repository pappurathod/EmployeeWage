// See https://aka.ms/new-console-template for more information

//UC7-Calculate_Employee_Wage_Using _Method

namespace EmployeeWage
    {
        public class EmployeeWageComputation
        {
            private float EmpWagePerHour = 20;
            public int FullTime_WorkingHrs_PerDay = 8;
            public int PartTime_WorkingHrs_PerDay = 4;
            public int Max_Working_Hrs = 100;
            public int Max_Day = 20;
            public const int Is_Full_Time = 1;
            public const int Is_Part_Time = 2;
            public const int Is_Absent = 0;
            float EmpDailyWage = 0;
            public float TotalWage = 0;

            public EmployeeWageComputation(int EmpWagePerHour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHours_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
            {
                this.EmpWagePerHour = EmpWagePerHour;
                //this.FullTime_WorkingHours_PerDay = FullTime_WorkingHours_PerDay;
                this.FullTime_WorkingHrs_PerDay = FullTime_WorkingHrs_PerDay;
                this.PartTime_WorkingHrs_PerDay = PartTime_WorkingHours_PerDay;
                this.Max_Working_Hrs = MAX_WORKING_HRS;
                this.Max_Day = MAX_WORKING_DAYS;
            }
            private int IsEmployeePresent()
            {
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                return empcheck;

            }
            public void CalculateWage()
            {
                int DayNumber = 1;
                int EmpWorkingHrs = 0;
                int TotalWorkingHrs = 0;
                while (DayNumber <= Max_Day && TotalWorkingHrs <= Max_Working_Hrs)
                {
                    switch (IsEmployeePresent())
                    {
                        case Is_Full_Time:
                            Console.WriteLine("Employee is FullTime present");
                            EmpWorkingHrs = 8;
                            break;
                        case Is_Part_Time:
                            Console.WriteLine("Employee is Part Time present");
                            EmpWorkingHrs = 4;
                            break;
                        case Is_Absent:
                            Console.WriteLine("Employee is absent");
                            EmpWorkingHrs = 0;
                            break;


                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    EmpDailyWage = EmpWorkingHrs * EmpWagePerHour;
                    TotalWage += EmpDailyWage;
                    DayNumber++;
                    TotalWorkingHrs += EmpWorkingHrs;
                    // Console.WriteLine("Day : " + Total_Working_Days + ", EmpHRS :" + emphr);
                }
                //int TotalEmpWage = (Emp_per_rate * emphr
                Console.WriteLine("total Working Days : " + (DayNumber - 1) + "\nTotal working Hours : " + (TotalWorkingHrs) + "\nTotal Emp Wage : " + TotalWage);
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Emp Wage Computation Program");
                EmployeeWageComputation employeewagecomputation = new EmployeeWageComputation(20, 8, 4, 100, 200);
                employeewagecomputation.CalculateWage();


            }
        }
    }
   