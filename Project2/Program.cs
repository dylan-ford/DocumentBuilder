/* Dylan Ford
 * July 21/ 2020
 * A guided user application that will build XML or JSON documents via user input
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DocumentBuilderLibrary;
using DocumentBuilderLibrary.Builder;
using DocumentBuilderLibrary.Director;

namespace Project2
{
    class Program
    {        
        static void Main(string[] args)
        {
            docMenu();
        }

        public static void docMenu()
        {
            string input = "";
            string[] inputArray;
            int modeType = 0;       //1 = xml, 2 = json   
            Director director = new Director();

            Console.WriteLine("Document Builder Console Client");

            do
            {
                inputArray = input.Split(':');

                if (input == "" || input == "help")
                {
                    Console.WriteLine("Usage");
                    Console.WriteLine("\tHelp - Prints Usage(this page)");
                    Console.WriteLine("\tmode:JSON | XML -Sets mode to JSON or XML.Must be set before creating or closing.");
                    Console.WriteLine("\tbranch:name -Creates a new branch, assigning it the passed name.");
                    Console.WriteLine("\tleaf:name:content -Creates a new leaf, assigning the passed name and content.");
                    Console.WriteLine("\tclose - Closes the current branch, as long as it is not the root.");
                    Console.WriteLine("\tprint - Prints the document in its current state to the console.");
                    Console.WriteLine("\texit - Exits the application.");
                }
                else if (input == "mode:xml")                                                       // Creating Docs
                {
                    modeType = 1;
                    director = new Director(new XMLBuilder());
                    //create new XML doc
                }
                else if (input == "mode:json")
                {
                    modeType = 2;
                    //create new JSON doc
                    director = new Director(new JSONBuilder());
                }
                else if (inputArray[0] == "branch" && modeType > 0)                                // Creating Branches
                {
                    //create new xbranch, name = inputArray[1]
                    director._name = inputArray[1];
                    director.BuildBranch();
                }
                else if (inputArray[0] == "leaf" && modeType > 0 && inputArray.Length >= 2)        // Creating Leaves
                {
                    //create new xleaf, name = inputArray[1], content = inputArray[2]
                    director._name = inputArray[1];
                    director._content = inputArray[2];
                    director.BuildLeaf();
                }
                else if (inputArray[0] == "branch" || inputArray[0] == "leaf" && modeType == 0)     // User input verification
                {
                    Console.WriteLine("Error. Mode has not been set. For usage, type 'Help'");
                }
                else if(input == "close")                                                           //MISC features
                {
                    director.CloseBranch();
                }
                else if(input == "print")
                {
                    //prints the doc in its current form
                    director._builder.GetDocument().Print(0);
                }
                else if(input == "exit")
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Invalid input. Type 'help' for a list of commands");
                }

                Console.Write("> ");
                input = Console.ReadLine().ToLower();

            } while (input != "exit");
        }
    }
}
