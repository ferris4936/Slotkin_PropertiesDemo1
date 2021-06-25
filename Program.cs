using System;

namespace Slotkin_PropertiesDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student molly = new Student("Molly Cat", 1234);

            Console.WriteLine("molly's Name: {0}", molly.Name);
            Console.WriteLine("molly's IdNumber: {0}", molly.IdNumber);
            molly.Score1 = 100;
            molly.Score2 = 80;
            Console.WriteLine("molly's Average Score: {0}", molly.GetAverageScore());
            Console.WriteLine("molly's High Score: {0}", molly.HighScore);
        }
    }
}
