using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.DRYPrinciple
{
    public class DryPrinciple
    {

        #region beforeApply
        public void processSalary() {
        double salary = 3000;
        double bonus = 2000;
        double taxes = 1000;
        double total = salary + bonus - taxes; // outPut 3000  + 2000 - 1000 = 4000
            Console.WriteLine($"Total = {total}");

            //Use it again and make new process
            salary = 5000;
            bonus = 1500;
            taxes = 1000;
            total = salary + bonus - taxes; // outPut 5000 + 1500 - 1000 = 5500
            Console.WriteLine($"Total = {total}");
        }
        #endregion


        #region afterApply

        public static double calculateSalary(double salary, double bonus, double taxes ) {

        return salary + bonus - taxes;

        }

        public double empSalary1 = calculateSalary(5000, 2000, 1500); //outPut 5500

        //Use Code again 
        public double empSalary2 = calculateSalary(6000, 2000, 1800); //outPut 6200

        #endregion
    }
}
