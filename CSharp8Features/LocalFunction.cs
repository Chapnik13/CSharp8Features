using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Features
{
    public class LocalFunction
    {
        public string MethodWithLocalFunction()
        {
            var firstname = "Hiccuo";
            var lastname = "Mauritius";
            return LocalFunction();

            string LocalFunction() => firstname + " - " + lastname;
        }

        public string MethodWithStaticLocalFunction()
        {
            string first = "Hiccuo";
            string last = "Mauritius";
            return LocalFunction(first, last);
            static string LocalFunction(string firstname, string lastname) => firstname + " - " + lastname;
        }
    }
}
