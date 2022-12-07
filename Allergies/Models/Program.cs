using System;
using Allergies;

namespace AllergyScore
{
    public class Program
    {
        public static void Main()
        {
            Allergy newAllergyScore = new Allergy();

            Console.WriteLine("Enter a number to find out what you're allergic to:");
            string stringUserInput = Console.ReadLine();
            int userInput = int.Parse(stringUserInput);

            newAllergyScore.findAllergyScore(userInput);
        }

        public static void testMethod()
        {
            Console.WriteLine("Eggs \nTomatoes");
        }
    }
}