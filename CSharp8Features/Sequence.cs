using System;
using System.Collections.Generic;
using System.Threading;

namespace CSharp8Features
{
    public static class Sequence
    {
        public static IEnumerable<int> GenerateSequence()
        {
            for (var i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
                yield return i;
            }
        }

        public static void PrintSequence()
        {
            foreach (var num in GenerateSequence())
            {
                Console.WriteLine(num);
            }
        }
    }
}