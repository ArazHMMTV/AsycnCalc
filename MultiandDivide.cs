using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalCalc
{
    public class MultiandDivide
    {
        public async Task<double> Multi(double num1,double num2)
        {
            await Task.Delay(100);
            return num1*num2;
        }


        public async Task<double> Divide(double num1 , double num2)
        {
            await Task.Delay(100);
            if (num2==0)
            {
                throw new DivideByZeroException("0-a bolmek olmaz!");
            }
            return num1 / num2;
        }
    }
}
