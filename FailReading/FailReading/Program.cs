// See https://aka.ms/new-console-template for more information
using System;
using System.Text;


namespace FailReading
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*string filePath = "gitword.txt";

            using (StreamReader sr = new StreamReader(filePath))
            {
                Console.WriteLine("ReadToEnd: "+ allText);

                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine("ReadLine: " + line);
                }
            }
            */

            StreamReader sr = new StreamReader(@"C:\WordFile\gitword.txt", Encoding.UTF8);

            string str = sr.ReadToEnd();

            sr.Close();

            Console.WriteLine(str);

            Console.ReadKey();

        }
    }
}