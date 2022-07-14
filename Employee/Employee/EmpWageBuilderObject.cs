using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmpWageBuilderObject
    {
    }
}
public class EmpWageBuilderObject
{

    const int IS_PART_TIME = 1;
    const int IS_FULL_TIME = 2;

    private string company;
    private int empRatePerHrs;
    private int numOfWorkingDays;
    private int maxHrsPerMonth;
    private int totalEmpWage;

    public EmpWageBuilderObject(string company, int empRatePerHrs, int numOfWorkingDays, int maxHrsPerMonth)
    {
        this.company = company;
        this.empRatePerHrs = empRatePerHrs;
        this.numOfWorkingDays = numOfWorkingDays;
        this.maxHrsPerMonth = maxHrsPerMonth;
    }
    public void computeEmpWage()
    {
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;


        while (totalEmpHrs <= this.maxHrsPerMonth && totalWorkingDays < this.numOfWorkingDays)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            totalEmpHrs += empHrs;
            Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs : " + empHrs);
        }
        totalEmpWage = totalEmpHrs * this.empRatePerHrs;
        Console.WriteLine("total Emp Wage for company: " + company + " is: " + totalEmpWage);
    }
    public string toString()
    {
        return "total Emp Wage for company; " + this. company + " is; " + this.totalEmpWage;
        
    }


}

