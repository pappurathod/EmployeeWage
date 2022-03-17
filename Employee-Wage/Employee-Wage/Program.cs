//UC8

using System;
using System.Collections.Generic;

namespace EmployeeWage
{
    public class Company
    {
        public float EmpWagePerHour = 20;
        public int FullTime_WorkingHrs_PerDay = 8;
        public int PartTime_WorkingHrs_PerDay = 4;
        public int MAX_WORKING_HRS = 100;
        public int MAX_WORKING_DAYS = 20;
        public String CompanyName;

        public Company(String CompanyName, int EmpWagePerHour, int FullTime_WorkingHrs_PerDay, int PartTime_WorkingHours_PerDay, int MAX_WORKING_HRS, int MAX_WORKING_DAYS)
        {
            this.CompanyName = CompanyName;
            this.EmpWagePerHour = EmpWagePerHour;
            this.FullTime_WorkingHrs_PerDay = FullTime_WorkingHrs_PerDay;
            this.PartTime_WorkingHrs_PerDay = PartTime_WorkingHours_PerDay;
            this.MAX_WORKING_HRS = MAX_WORKING_HRS;
            this.MAX_WORKING_DAYS = MAX_WORKING_DAYS;
        }
    }
    class EmployeeWageComputation
    {
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        public const int Is_Absent = 0;
        float EmpDailyWage = 0;
        public float TotalWage = 0;
        private Dictionary<String, Company> Companies = new Dictionary<String, Company>();

        private void AddCompany(String CompanyName, int EmpWagePerHour, int FullTime_WorkinkHrs_PerDay, int PartTime_WorkingHours_PerDay, int MAX_WORKINK_HRS, int MAX_WORKING_DAY)
        {
            Company company = new Company(CompanyName.ToLower(), EmpWagePerHour, FullTime_WorkinkHrs_PerDay, PartTime_WorkingHours_PerDay, MAX_WORKINK_HRS, MAX_WORKING_DAY);
            Companies.Add(CompanyName.ToLower(), company);
        }
        private int IsEmployeePresent()
        {
            return new Random().Next(0, 3);            
        }
        public void CalculateWage(string CompanyName)
        {
            int DayNumber = 0;
            int EmpWorkingHrs = 0;
            int TotalWorkingHrs = 0;


            if (!Companies.ContainsKey(CompanyName.ToLower()))
                throw new ArgumentNullException("Company Don't Exist");
            Companies.TryGetValue(CompanyName.ToLower(), out Company company);


            while (DayNumber <= company.MAX_WORKING_DAYS && TotalWorkingHrs <= company.MAX_WORKING_HRS)
            {
                switch (IsEmployeePresent())
                {
                    case Is_Full_Time:
                        //Console.WriteLine("Employee is FullTime present");
                        EmpWorkingHrs = company.FullTime_WorkingHrs_PerDay;
                        break;
                    case Is_Part_Time:
                        //Console.WriteLine("Employee is Part Time present");
                        EmpWorkingHrs = company.PartTime_WorkingHrs_PerDay;
                        break;
                    case Is_Absent:
                        //Console.WriteLine("Employee is absent");
                        EmpWorkingHrs = 0;
                        break;


                    default:
                        Console.WriteLine("Error");
                        break;
                }
                EmpDailyWage = EmpWorkingHrs * company.EmpWagePerHour;
                TotalWage += EmpWorkingHrs;
                DayNumber++;
                TotalWorkingHrs += EmpWorkingHrs;


            }
            Console.WriteLine("\nCompany name : " + CompanyName);
            Console.WriteLine("Total Working Days : " + (DayNumber) + "\nTotal Working Hours : " + TotalWorkingHrs + "\nEmp Daily Wage : " + EmpDailyWage + "\nTotal Employee Wage : " + TotalWage);
            //Console.WriteLine("total Working Days : " + (DayNumber - 1) + "\nTotal working Hours : " + (TotalWorkingHrs) + "\nTotal Emp Wage : " + TotalWage);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Emp Wage Computation Program");
            EmployeeWageComputation employeewagecomputation = new EmployeeWageComputation();
            employeewagecomputation.AddCompany("TATA", 20, 8, 4, 100, 20);
            employeewagecomputation.AddCompany("Mahendra", 30, 8, 4, 100, 20);
            employeewagecomputation.AddCompany("Amazon", 40, 8, 4, 100, 20);
            employeewagecomputation.CalculateWage("Tata");
            employeewagecomputation.CalculateWage("Mahendra");
            employeewagecomputation.CalculateWage("Amazon");


        }
    }
}