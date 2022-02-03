using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlog
{
    public class AddNumbers
    {
        private readonly NlogPractice nLog=new NlogPractice();
        public int Sum(int firstNumber,int secondNumber)
        {
            //Checking value equal to 0
            if(firstNumber==0 || secondNumber==0)
            {
                nLog.LogDebug("Debug Unsuccessful:Sum()");
                nLog.LogError("Expecting null value");
                nLog.LogWarn("firstnumber or secondnumber should not equal to 0");
            }
            int result=secondNumber+firstNumber;
            nLog.LogDebug("Debug Successful:Sum()");
            nLog.LogInfo("Sum Method passed result:" + result);
            return result;
        }
    }
}
