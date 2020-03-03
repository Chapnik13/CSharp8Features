using System;
using System.IO;

namespace CSharp8Features
{
    public interface IOutput
    {
        private static string s_exceptionPrefix = "Exception";

        public static string ExceptionPrefix
        {
            get => s_exceptionPrefix;
            set => s_exceptionPrefix = value;
        }
        void PrintMessage(string message);
        sealed void PrintException(Exception exception)
            => PrintMessage($"{s_exceptionPrefix}: {exception}");
    }
    public class ConsoleOutput : IOutput
    {
        public void PrintMessage(string message)
            => Console.WriteLine(message);
    }

    public class FileOutput : IOutput
    {
        public void PrintMessage(string message)
        {
            if (message.Contains("Hello"))
            {
                using (var streamWriter = new StreamWriter("somefile.txt"))
                {
                    streamWriter.WriteLine(message);
                }
                
            }
        }
    }
}
