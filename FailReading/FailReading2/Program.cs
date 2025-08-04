// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FailReading2
{
    class Program

    {
        public static void Main(string[] args)
        {
            string filePath = "C:/WordFile/programword.txt";
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }

                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("ファイルが見つかりません。");
            }
            catch (Exception e)
            {
                Console.WriteLine("エラーが発生しました：" + e.Message);
            }
        }
    }
}