using System;

namespace inherit
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello");

            Base baseinstint = new Base();
            Console.WriteLine("the string from field in base" + baseinstint.basestring);
            baseinstint.ripit();
        }
    }

}