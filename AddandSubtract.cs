using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalCalc
{
    public class AddandSubtract
    {
        public async Task<double> Add(double num1,double num2)
        {
            await Task.Delay(100);
            return num1+num2;
        }
        public async Task<double> Subtract(double num1, double num2)
        {
            await Task.Delay(100);
            return num1 - num2;
        }

    }
}
