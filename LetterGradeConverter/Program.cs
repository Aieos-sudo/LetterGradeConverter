using System;

namespace LetterGradeConverter
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* == equality
             * != not equals
             * > greater than
             * < less than
             * >= greater than equal to
             * <= less than equal to
             */


            string confirmation;
            Console.WriteLine("Letter Grade Converter \n");
            do
            {
                Console.Write("Enter numerical grade: ");
                string grade = Console.ReadLine();
                string letter = letterGrade(grade);
                Console.WriteLine("Letter Grade: " + letter);
                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                confirmation = Console.ReadLine();

            }
            while (confirmation.ToLower() == "y");
            Console.WriteLine("Bye!");
        }
        public static string letterGrade(string grade)
        {
            int intgrade = Int32.Parse(grade);
            if (intgrade > 87)
            {
                return "A";
            }
            else if (intgrade < 88 && intgrade > 79)
            {
                return "B";
            }
            else if (intgrade < 80 && intgrade > 66)
            {
                return "C";
            }
            else if (intgrade < 67 && intgrade > 59)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
