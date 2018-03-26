namespace TechnicalTestCore
{
    using System.Collections.Generic;
    using TechnicalTestUtilities;

    internal class Minimum
    {
        public static int MinimumElementIn(List<int> intlist)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass

            int expectedMinimum = 0, k = 0;

            // This can be done in both the ways

            //foreach (int i in intlist)
            //{
            //    if (k == 0)
            //        expectedMinimum = i;

            //    if (expectedMinimum > i)
            //    {
            //        expectedMinimum = i;
            //    }
            //    k++;
            //}


            for (int i = 0; i < intlist.Count; i++)
            {
                if (i == 0)
                    expectedMinimum = intlist[i];

                if (expectedMinimum > intlist[i])
                {
                    expectedMinimum = intlist[i];
                }
            }
            return expectedMinimum;
        }
    }
}
