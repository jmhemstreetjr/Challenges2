/// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// Taken from Exercism.io. LogAnalysis was used to teach about Extension methods by manioulating strings. 
/// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;

namespace LogAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Hello World!");
        }
    }
    
    public static class LogAnalysis
    {
        // TODO: define the 'SubstringAfter()' extension method on the `string` type
        /// <summary>
        /// //////////
        /// </summary>
        /// <param name="logLine"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public static string SubstringAfter(this string logLine, string delimiter)
        {
            int index = logLine.IndexOf(delimiter);
            return logLine.Remove(0, index + delimiter.Length);
        }
        // TODO: define the 'SubstringBetween()' extension method on the `string` type
        public static string SubstringBetween(this string logLine, string first, string second)
        {
            int indexFirst = logLine.IndexOf(first);
            int indexSecond = logLine.IndexOf(second);

            if (indexFirst < indexSecond)
            {
                if (indexFirst == 0)
                {
                    return logLine.Remove(indexSecond).Remove(0, 1).Trim();
                }

                return logLine.Remove(indexSecond).Remove(0, indexFirst + first.Length).Trim();
            }
            else if (indexFirst > indexSecond)
            {
                if (indexSecond == 0)
                {
                    return logLine.Remove(indexFirst).Remove(0, 1).Trim();
                }

                return logLine.Remove(indexFirst).Remove(0, indexSecond + second.Length).Trim();
            }
            else
            {
                return "";
            }
        }
        // TODO: define the 'Message()' extension method on the `string` type
        public static string Message(this string logLine)
        {
            int index = logLine.IndexOf(": ");
            return logLine.Remove(0, index + 1).Trim();
        }
        // TODO: define the 'LogLevel()' extension method on the `string` type
        public static string LogLevel(this string logLine)
        {
            return LogAnalysis.SubstringBetween(logLine, "[", "]");
        }
    }
}

