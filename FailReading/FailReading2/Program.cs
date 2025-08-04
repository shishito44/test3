// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FailReading2
{
    class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    string? readPath;
                    string defPath = "C:/WordFile/";//使わない場合は空白にする
                    string? filePath;
                    do
                    {
                        Console.WriteLine("ファイル名を入力してください");
                        readPath = Console.ReadLine();
                        filePath = defPath + readPath;
                    } while (readPath == string.Empty);

                    using StreamReader sr = new StreamReader(filePath);
                    string? line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    break;

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
}