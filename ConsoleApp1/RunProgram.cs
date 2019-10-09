//RunProgram
using System;
using System.IO;


namespace ConsoleApp1
{
    class RunProgram
    {
        [STAThread]
        public static void Main()
        {
            //  Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");


            Program.Run();


            //Stop before exiting
            Console.WriteLine("Hello World!");
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            //static void Main(string[] args)
            // {


            //   Console.ReadKey();
            //}

            Console.ReadKey();
        }


        // My conversion Doc to Pdf path
        public static String GetDataDir_Convert()
        {
            return Path.GetFullPath(GetDataDir_Data() + "Viktor/Doc-to-Pdf/");
        }

        private static string GetDataDir_Data()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }

            return Path.Combine(startDirectory, "Data\\");
        }

        public static string GetOutputFilePath(String inputFilePath)
        {
            string extension = Path.GetExtension(inputFilePath);
            string filename = Path.GetFileNameWithoutExtension(inputFilePath);
            return filename + "_out" + extension;
        }
    }
}
///////////////////////////////////////////////

