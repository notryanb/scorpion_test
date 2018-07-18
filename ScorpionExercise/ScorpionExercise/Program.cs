using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorpionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }

    /// <summary>
    /// Task:
    ///     Complete the body of this method so it passes all NUnit tests.
    ///     
    /// Objective:
    ///     Take a string and a grouping size then split the string into substrings of that group size.
    ///     
    ///     ex. "This is a string".Chunk(4) => List<string>() { "This", " is ", "a st", "ring" }
    ///     
    /// Help:
    ///     To run tests, use `Ctrl+R, A` or use Test > Run > All Tests
    /// </summary>
    public static class ExtensionMethods
    {
        public static IEnumerable<string> Chunk(this string sourceString, int groupSize)
        {
        
        }
    }
}
