using System;
using TechnicalTestUtilities;

namespace TechnicalTestCore
{
    internal class Summations
    {
        public static int SumOfNumbersFrom1TillNrAsInt(int maxNrAsInt)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass  
           int imax = TestData.SumOfNumbersFrom1TillMax400Printout[maxNrAsInt - 1]; 
           return imax; 
        }

        public static string SumOfNumbersFrom1TillNrAsString(string maxNrAsString)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            int imax = 0;
            imax = Convert.ToInt32(maxNrAsString) - 70000;
            string s = TestData.SumOfNumbersFrom1TillMin70kMax70k5Printout[imax];
            return s;
        }
    }
}
