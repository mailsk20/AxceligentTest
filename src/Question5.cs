using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxceligentTest
{
    public class Question5
    { 
        public async Task<(int, int)> SomeCalculation(long longValue, int no, bool isBool)
        {
            int averageSalary = 0;
            int numberOfEmployee = 0;

            // Do somthing here....

            var result = await Task.FromResult((averageSalary, numberOfEmployee));
            return result;
        }
    }
}
