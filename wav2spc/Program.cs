using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace wav2spc
{
    class Program
    {
        static void Main()
        {
            string[] args = System.Environment.GetCommandLineArgs();
            if (!File.Exists(args[1]))
            {
                Console.WriteLine("File does not exist.");
                Console.ReadKey();
                return;
            }
            string filePath = args[1];
            string fileExtension = Path.GetExtension(filePath);
            if (fileExtension.ToLower() != ".wav")
            {
                Console.WriteLine(fileExtension.ToLower()+" is an invalid format.");
                Console.ReadKey();
                return;
            }
            string newFilePath = Path.ChangeExtension(filePath,"spc");
            File.WriteAllBytes(newFilePath, Properties.Resources.BruhSPC);
            Console.WriteLine(Path.GetFileName(newFilePath)+" successfully created.");
            Console.ReadKey();
        }
    }
}
