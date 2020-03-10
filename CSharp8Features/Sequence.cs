using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp8Features
{
    public static class Sequence
    {
        public static async IAsyncEnumerable<int> GenerateSequence()
        {
            for (var i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }

        public static async Task PrintSequence()
        {
            await foreach (var num in GenerateSequence())
            {
                Console.WriteLine(num);
            }
        }
    }
}