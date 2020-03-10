using System;
using System.Threading.Tasks;

namespace CSharp8Features
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Output
            var output = new ConsoleOutput();
            output.PrintMessage("hello");
            ((IOutput)output).PrintException(new Exception());


            //Sequence
            await Sequence.PrintSequence();

            Console.ReadKey();

            var words = new string[]
            {
                // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0

            Console.WriteLine($"The last word is {words[^1]}"); // do
            var quickBrownFox = words[1..4]; // quick brown fox from words[1] to words[3] included (not include words[4]
            var lazyDog = words[^2..^0]; // lazy dog, words[^2] and words[^1]
            var allWords = words[..]; // contains "The" through "dog".
            var firstPhrase = words[..4]; // contains "The" through "fox"
            var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"
            Range phrase = 1..4;
            var text = words[phrase];
        }
    }
}
