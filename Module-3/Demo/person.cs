using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ID;


namespace ConsoleApp2
{
    class Person : IDispossible
    {
        public int PersonID { get; set }

        public string FirstName { get; set }

        public string LastName { get; set }

        public int Age { get; set }

        public string Gender { get; set }


        // flag to check if the object has been disposed
        private bool disposed = false;

        StreamReader sr;
        StreamWriter outputFile;

        public void ReadDetails(string fileName)
        {
            sr = StreamReader(fileName);

            try
            {
                // open the text file using a stream reader
                using (sr)
                {
                    // Read the stream to a string, and write the string to the console
                    String line = sr.ReadToEnd;
                    Console.WriteLine(line);
                }
            }

            catch (Expection e)
            {
                Console.WriteLine("This file can not be read:");
                Console.WriteLine(e.Message);
            }

            finally
            {
                sr.Close();
                sr = null;
            }
        }

        public bool WrireDetails(string fileName)
        {
            bool result = false;
            outputFile = new StreamWrite(fileNmae);

            // Create a string array with the lines to text
            string[] lines = { this.PersonID.ToString(), this.FirstName, this.LastName, this.Gender, this.Age.ToString() };

            try
            {
                // write the string array to a new file
                using (outputFile)
                {
                    foreach (string line in lines)
                    outputFile.WriteLine(line);
                }
                result = true;
            }

            catch(Expcetion e)
            {
                Console.WriteLine("This file can not be read:");
                Console.WriteLine(e.Message);
                result = false;
            }

            finally
            {
                outputFile.Close();
                outputFile = null;
            }

            return result;
        }
    }
}


