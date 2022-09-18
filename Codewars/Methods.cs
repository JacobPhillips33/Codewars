using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Methods
    {
        #region All Completed Codewars Methods
        #region Codewars: Are arrow functions odd? - Method to remove all even numbers from a List<int>
        public static List<int> Odds(List<int> values)
        {
            values.RemoveAll(x => x % 2 == 0);
            return values;
        }
        #endregion

        #region Codewars: Calculate Average - Method to calculate the average value of an array.
        public static double FindAverage(params double[] array)
        {
            return array.Length == 0 ? 0 : array.Average();
        }
        #endregion

        #region Codewars: Calculate BMI - Method to calculate BMI with inputs of height in meters and weight in kg.
        public static string Bmi(double weight, double height)
        {
            var bmi = weight / (height * height);

            if (bmi <= 18.5) return "Underweight";
            if (bmi <= 25) return "Normal";
            if (bmi <= 30) return "Overweight";
            return "Obese";
        }
        #endregion

        #region Codewars: Grasshopper - Terminal game combat function - Method to adjust health level if player takes damage.
        public static float Combat(float health, float damage)
        {
            return (health >= damage) ? health - damage : 0;
        }
        #endregion

        #region Codewars: Count Odd Numbers below n - Method to return the total number of odd numbers below an inputted number.
        public static ulong OddCount(ulong n)
        {
            return n / 2;
        }
        #endregion

        #region Codewars: Even or Odd - Method to tell you if an inputted number is even or odd.
        public static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
        #endregion

        #region Codewars: Remove String Spaces - Method to remove any empty spaces in a string input.
        public static string NoSpace(string input)
        {
            return input.Replace(" ", "");
        }
        #endregion

        #region Codewars: Sentence Smash - Method to join seperate strings into a single string.
        public static string Smash(params string[] words)
        {
            string smash = string.Join(" ", words);
            return smash;
        }
        #endregion

        #region Codewars: String repeat
        public static string RepeatStr(int n, string s)
        {
            return String.Concat(Enumerable.Repeat(s, n));
        }
        #endregion

        #region Codewars: A Strange Trip to the Market - Method to identify keywords in a string and return true or false if the sentence contains the keywords or not.
        public static bool IsLockNessMonster(string sentence)
        {
            if (sentence.ToLower().Contains("3.50") || sentence.ToLower().Contains("tree fiddy")) return true;
            return false;
        }
        #endregion

        #endregion All Completed Codewars Methods
    }
}
