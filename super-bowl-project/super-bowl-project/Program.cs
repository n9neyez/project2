using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace super_bowl_project
{
    class SuperBowlProject
    {
        static void Main(string[] args)
        {
            welcome();
        }

        public static void welcome()
        {
            Console.WriteLine("Welcome, this program is designed to manipulate and summarize data from a corresponding " +
                "Excel spreadsheet (.csv file).");
            Console.WriteLine("The data being used is from past NFL Super Bowls. (I 1967 through LI 2017)");
            Console.WriteLine("\nA text file will be created and this program will write data into that file based on different criteria.");
            Console.WriteLine("Below is the list of criteria that must be displayed: ");
            Console.WriteLine("\nGenerate a list of all Super Bowl Winners" +
                              "\nGenerate a list of the top five attended Super Bowls" +
                              "\nOutput the state that hosted the most Super Bowls" +
                              "\nGenerate a list of players who won MVP more than twice");
            Console.WriteLine("\n\nThese will output a single value: ");
            Console.WriteLine("Which coach lost the most Super Bowls?" +
                              "\nWhich coach won the most Super Bowls?" +
                              "\nWhich team(s) won the most Super Bowls?" +
                              "\nWhich team(s) lost the most Super Bowls?" +
                              "\nWhat is the average attendance of all Super Bowls?");

        }
    }
}
