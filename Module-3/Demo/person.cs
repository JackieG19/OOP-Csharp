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
            // creating a new steamreader using a file name that would be passed in from the application
            sr = StreamReader(fileName);

            try
            {
                // open the text file using a stream reader
                using (sr)
                {
                    String line = sr.ReadToEnd; // Read the stream to a string...
                    Console.WriteLine(line); // ...and write the string to the console
                }
            }
            // if an expection occurs...
            catch (Expection e) // catch that expection
            {
                // write out informational message to the console window
                Console.WriteLine("This file can not be read:");
                Console.WriteLine(e.Message);
            }

            finally
            {
                sr.Close(); // close the steamreader...
                sr = null; //...and ste it to null
            }
        }

        public bool WrireDetails(string fileName) // metod that takes a file names
        {
            bool result = false; // return a result of successfully written the file out or not
            outputFile = new StreamWrite(fileNmae); // represent it as a new string steamreader object

            // Create a string array with the lines to text that output different property value
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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual voild Dispose(bool disaposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    if(sr != null)
                    {
                        sr.Close();
                    }

                    if(outputFile != null)
                    {
                        outputFile.Close();
                    }
                }
            }

            disposed = true;
        }
    }
}


