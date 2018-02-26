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
            List<SuperBowl> superBowls = new List<SuperBowl>();
            SuperBowl aSuperBowl;
            const string SUPERFILEPATH = @"C:\schooldata\semester3\AdvancedProgramming\Project-2\Project2\super-bowl-project\super-bowl-project\Super_Bowl_Project.csv";
            const char DELIM = ',';
            string[] arrayOfFields;
            string filePath;

            welcome(out filePath); //out filePath

            try
            {
                FileStream superbowlFile = new FileStream(SUPERFILEPATH, FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader(superbowlFile);

                FileStream outFile = new FileStream(filePath, FileMode.Create, FileAccess.Write); // create new file
                StreamWriter writer = new StreamWriter(outFile);

                while (!read.EndOfStream)
                {                                                                      //each array element holds a field for a row/record from the .csv file
                    arrayOfFields = read.ReadLine().Split(DELIM); // split the fields
                    aSuperBowl = new SuperBowl(arrayOfFields[0], arrayOfFields[1], arrayOfFields[2], arrayOfFields[3], arrayOfFields[4],
                                               arrayOfFields[5], arrayOfFields[6], arrayOfFields[7], arrayOfFields[8], arrayOfFields[9],
                                               arrayOfFields[10], arrayOfFields[11], arrayOfFields[12], arrayOfFields[13], arrayOfFields[14]);
                                                        // each field corresponds to a property within the SuperBowl class respectively
                    // Console.WriteLine(aSuperBowl);
                    superBowls.Add(aSuperBowl);



                    writer.WriteLine(aSuperBowl.Date + DELIM + aSuperBowl.SuperBowlNum + DELIM + aSuperBowl.Winner);

                }
                writer.Close();
                outFile.Close();
                read.Close();
                superbowlFile.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public static void welcome(out string filePath) // gets the desired file path //
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
            Console.WriteLine("\nPlease enter in the desired file path, include the file name after the last backslash: ");
            filePath = Console.ReadLine();

        }
    }
}
