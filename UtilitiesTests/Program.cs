using System;
using Utilities;

namespace UtilitiesTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringUtilities.ToWords("Marcin Jagieła"));
            Console.WriteLine(StringUtilities.ToWords("The lords of the rings"));

            Console.WriteLine(StringUtilities.ToSentence("the LorDS oF tHE rIngs"));

            Console.WriteLine(StringUtilities.ToCamelCase("the LorDS oF tHE rIngs"));
            
            //And because it is an extension method, we can do like this:
            Console.WriteLine("the LorDS oF tHE rIngs".ToCamelCase());
        }
    }
}
