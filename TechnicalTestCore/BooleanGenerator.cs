namespace TechnicalTestCore
{
    internal class BooleanGenerator
    {
        public static bool GetBoolean() {

            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass

            bool result = false;
            
                int Dynamic = 12;
                int Credit = 18;

                if (Dynamic > 10)
                    if (Credit < 20)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                return result;
        }
    }
}
