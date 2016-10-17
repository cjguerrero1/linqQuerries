using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> exampleList = new List<string> { "hello", "my", "hello", "name", "my", "is", "cj" };
            Querries querrie = new Querries();
            querrie.RemoveDuplicates(exampleList);
            Console.ReadKey();
            List<string> classGrades = new List<string> { "50,95,85,67,100", "63,98,78,86,92", "0,82,94,97,85", "100,90,93,80,89" };//89.40625
            querrie.FindClassAverage(classGrades);
            Console.ReadKey();
        }
    }
}
