using System;
using System.IO;

namespace Activity12
{
    class Act12
    {
        static void Main(string[] args)
        {
            //read text from file
            string file = File.ReadAllText("act12input.txt");
            //StreamReader file;
            //file = File.OpenText("act12input.txt");
            //string file = file.ReadToEnd();

            //set up variables for counts
            int wordCount = 0;
            int lastChar = 0;

            //sort through array and count words ending with e or t and account for certain puntuation
            while (lastChar < file.Length - 1)
            {
                if ((file[lastChar] == ',' || file[lastChar] == ' ' || file[lastChar] == '!') && (file[lastChar - 1] == 't' || file[lastChar - 1] == 'e'))
                {
                    wordCount++;
                }

                lastChar++;
            }

            //print results
            Console.WriteLine("There are " + wordCount + " words ending in t or e.");
        }
    }
}
