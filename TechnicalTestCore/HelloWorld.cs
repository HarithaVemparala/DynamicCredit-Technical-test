namespace TechnicalTestCore
{
    using System;

    internal class HelloWorld
    {
        public static void SayHelloToTheWorld(string[] args)
        {
            string str = "";

            if (args == null || args.Length == 0)
                args = new string[] { "Hello ", "World!" };

            if (args != null && args.Length > 0)
            {
                foreach (string item in args)
                {
                    str += item;
                }
            }
            Console.WriteLine((str));


        }
    }
}
