// See https://aka.ms/new-console-template for more information
using System;
using System.Text;


namespace FailReading
{
    class Program
    {
        public static void Main(string[] args)
        {

            //簡易的なファイルの読み込み
            StreamReader sr = new StreamReader(@"C:\WordFile\gitword.txt", Encoding.UTF8);

            string str = sr.ReadToEnd();

            sr.Close();

            Console.WriteLine(str);

            Console.ReadKey();

        }
    }
}