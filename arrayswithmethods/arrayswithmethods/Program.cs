using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayswithmethods
{
    class Program
    {
        static void Main(string[] args)
        {

            //declare arrays and variables
            int[] studentScores = new int[5];

            double avgScore;

            //Get user input - get student scores

            studentScores = GetScores();

            //Calculate the average of all student scores
            avgScore = studentScores.Average();

            //display student scores - and the average score

            DisplayScores(avgScore, studentScores);



            Console.ReadKey();

        }//end of main

        public static int[] GetScores()
        {
            //Gets all 5 student scores as user input
            //returns the list when it's done
            //declare a temp array
            int[] tempArray = new int[5];
            //use a for loop to get all 5 scores
            for (int i = 0; i < tempArray.Length; i++)
            {
                Console.WriteLine("Enter score for student # {0}: ", i + 1);
                //validate
                while (int.TryParse(Console.ReadLine(), out tempArray[i]) == false)
                {
                    Console.WriteLine("Invalid score! please re-enter student {0} score:", i + 1);
                }
            }
            //return the list / array of scores
            return tempArray;
        }//end of GetScores method


        //Method displays the scores and the average- accepts on double variable
        //and one integer list as parameters
        public static void DisplayScores(double average, int[] scores)
        {
            Console.WriteLine("The student scores are:");
            //use a loop to display the scores in the list
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
            Console.WriteLine(" The average score is: {0:N2}", average);
        }//end of DisplayScores method


    }//end of class
}//end of namespace
