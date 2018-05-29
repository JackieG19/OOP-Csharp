// Ensure that the System namespace is in scope
using System;
using System.Globalization;
using System.IO;

namespace EDXMod3
{
    class Program
    {
        public static void Main(string[] args)
        {
        // Creates StreamReader object called "streamReaderObject"
        //Assigns its value to null
        StreamReader streamReaderObject = null;

        try
        {
            //Assigns "streamReaderObject" to read for a text file name "file1"
            streamReaderObject = new StreamReader("file1.txt");

            //Reads all characters from the current position to the end of the stream
            //Stores in String variable "contents"

            String contents = streamReaderObject.ReadToEnd();

            // Closes StreamReader
            streamReaderObject.Close();

            //Writes the amount of text elements in the text file to the Console
            Console.WriteLine("The file has {0} text elements.", new StringInfo(contents).LengthInTextElements);
        }

        //Code to handle any errors
        catch (FileNotFoundException)
            {
                //Informs user there is no file created
                Console.WriteLine("The file cannot be found.");
            }

        //Invoking the Dispose Method in a finally block
        //Note that code in finally block will always execute

        finally
            {
                //Check if object is not null
                if (streamReaderObject != null)
                //Calls upon the dispose method
                //Releases all resources used by the TextReader object
                streamReaderObject.Dispose();
            }    
        }
    }
}
