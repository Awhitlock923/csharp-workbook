using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace week8_1ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\flash\Desktop\csharp-workbook\week8-1ex\textdoc.txt");

            // string[] lines = System.IO.File.ReadAllLines(@"C:\Users\flash\Desktop\csharp-workbook\week8-1ex\words_alpha.txt");

            // System.IO.File.WriteAllLines(@"C:\Users\flash\Desktop\csharp-workbook\week8-1ex\textdoc.txt", lines);

            // foreach(String line in lines){
            //     Console.WriteLine(line);
            // }

            StreamReader stream = File.OpenText(@"C:\Users\flash\Desktop\csharp-workbook\week8-1ex\textdoc.txt");
            FileStream outStream = File.OpenWrite(@"C:\Users\flash\Desktop\csharp-workbook\week8-1ex\textdoc3.txt");
            StreamWriter s = new StreamWriter(outStream);

            string line = stream.ReadLine();
        //    // if(line.StartsWith("a")){
        //         Console.WriteLine(line);
        //     //}
            while(line != null){
                
                // string line = stream.ReadLine();
                // Console.WriteLine(line);
                s.WriteLine(line);
                line = stream.ReadLine();

            }

            FileStream picReader = File.OpenRead(@"C:\Users\flash\Desktop\csharp-workbook\week8-1ex\logo-aca-white.png");
            FileStream picWriter = File.OpenWrite(@"C:\Users\flash\Desktop\csharp-workbook\week8-1ex\logo-aca-white2.png");
            int b = picReader.ReadByte();
            StreamWriter p = new StreamWriter(picWriter);

            while(b != -1){
                
                // string line = stream.ReadLine();
                // Console.WriteLine(line);
                picWriter.WriteByte((byte)b);
                b = picReader.ReadByte();

            }
            

            outStream.Close();
           // s.Close();
            stream.Close();
        }
    }
}
