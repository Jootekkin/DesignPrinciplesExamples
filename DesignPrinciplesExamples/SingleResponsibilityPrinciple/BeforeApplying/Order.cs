using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesExamples.SingleResponsibilityPrinciple.BeforeApplying
{
    internal class Order
    {
        public void CalculatePrice()
        {
            //Code to calculate the price
        }

        public void PrintOrder()
        {
            //code to print details of order
        }

        public void SaveOrder()
        {
            //code to save order to database
        }
    }
}
