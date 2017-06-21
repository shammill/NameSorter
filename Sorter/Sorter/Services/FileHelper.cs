using System;
using System.Collections.Generic;
using System.IO;
using Sorter.Model;

namespace Sorter.Services
{
    public static class FileHelper
    {
        public static string GetOutputFileName(string inputFile, string appendText)
        {
            string filePath = Path.GetDirectoryName(inputFile);
            string fileName = Path.GetFileNameWithoutExtension(inputFile);
            string fileExtension = Path.GetExtension(inputFile);
            string outputFile = String.Format("{0}\\{1}-{2}{3}", filePath, fileName, appendText, fileExtension);

            return outputFile;
        }

        public static List<Person> ParseFileToPersonList(string fileName)
        {
            List<Person> people = new List<Person>();
            
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        Person person = ConvertLineToPerson(line);
                        people.Add(person);
                    }
                    catch
                    {
                        Console.WriteLine("Error Parsing Person: " + line);
                    }
                }
            }
            return people;
        }

        public static Person ConvertLineToPerson(string line)
        {
            var firstNameLastName = line.Split(',');
            string firstname = firstNameLastName[1].Trim();
            string lastName = firstNameLastName[0].Trim();
            return new Person(firstname, lastName);
        }


        public static void OutputPeopleToFile(string outputFile, List<Person> people)
        {
            foreach (Person person in people)
            {
                string output = person.OutputName;
                OutputToFile(outputFile, output);
                Console.WriteLine(output);
            }
        }

        public static void OutputToFile(string outputFile, string output)
        {
            using (StreamWriter sw = File.AppendText(outputFile))
            {
                sw.WriteLine(output);
            }
        }

    }
}
