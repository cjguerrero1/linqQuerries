using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    class Querries
    {
        public void RemoveDuplicates(List<string>originalList)
        {
            var newList = originalList.Distinct();
            foreach(string item in newList)
            {
                Console.WriteLine(item);
            }
        }

        public void FindClassAverage(List<string> classGrades)
        {
            List<double> classAverage = new List<double>();
            foreach (string studentGrades in classGrades)
            {
                classAverage.Add(GetStudentAverage(studentGrades));
            }
            var finalAverage = classAverage.Average();
            Console.WriteLine(finalAverage);
        }

        public double GetStudentAverage(string studentGrades)
        {
            var gradesAsInts = studentGrades.Split(',').Select(int.Parse).ToList();
            int lowestGrade = gradesAsInts.Min();
            gradesAsInts.Remove(lowestGrade);
            double studentAverage = gradesAsInts.Average();
            return studentAverage;
            

        }
    }
}
