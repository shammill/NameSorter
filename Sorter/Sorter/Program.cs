using System;
using System.Collections.Generic;
using Sorter.Model;
using System.IO;
using System.Configuration;

using Sorter.Services;

namespace Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("Please add a file as a parameter.");
                Console.ReadKey();
                return;
            }

            // Get Input and Output files. 
            string inputFile = args[0];
            Console.WriteLine("sort-names " + inputFile);
            string textToAppend = ConfigurationManager.AppSettings["TextToAppend"];
            string outputFile = FileHelper.GetOutputFileName(inputFile, textToAppend);

            // Parse and Sort.
            List<Person> people = FileHelper.ParseFileToPersonList(inputFile);
            people = SortingService.SortPeopleByLastName(people);

            // Output and Respond.
            FileHelper.OutputPeopleToFile(outputFile, people);
            Console.WriteLine("Finished: created " + Path.GetFileName(outputFile));
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
