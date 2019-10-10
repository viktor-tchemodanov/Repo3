using Aspose.Words;
using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        private static void Task1_HelloWorldConsole()
        {
            Console.WriteLine("Hello World!");
        }

        private static void Task2_DocToPdf()
        {
           Document doc = new Document(GetDataDir() + "Tech_Article_Viktor.doc");
           doc.Save(GetDataDir() + "Tech_Article_Viktor_out.pdf");
        }

        private static void Task3_HelloWorldAW()
        {
            // TODO Programmatically create a document and insert a paragraph with text Hello World and save to disk.
        }

        [STAThread]
        public static void Main()
        {
            Task1_HelloWorldConsole();
            Task2_DocToPdf();
            Task3_HelloWorldAW();
            // TODO Task4_JoinTwoDocuments();
            // TODO Task5_ReplaceTextOfBookmark();
        
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            Console.ReadKey();
        }

        /// <summary>
        /// This method helps to simplify getting access to the MyProject/Data directory to store 
        /// document intput and output files there.
        /// 
        /// When the program is built, the executable is placed quite deep in the tree structure like this
        /// C:\Users\romeok\Documents\GitHub\Repo3\ConsoleApp1\bin\Debug\netcoreapp3.0
        /// So we retrace a number of steps up to get to the project dir.
        /// </summary>
         private static string GetDataDir()
        {
            DirectoryInfo binDirInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            
            // RK I am not sure why these conditional manipulations are required.
            // Maybe there is a different behavior on Linux etc and they cover for this. 
            string projectDir = null;
            if (binDirInfo != null)
            {
                var projectDirInfo = binDirInfo.Parent;
                if (projectDirInfo != null)
                    projectDir = projectDirInfo.FullName;
            }
            else
            {
                projectDir = binDirInfo.FullName;
            }

            return Path.Combine(projectDir, "Data\\");
        }
    }
}


