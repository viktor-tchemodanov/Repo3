//Program
using Aspose.Words;
using Aspose.Words.Saving;
using System;

namespace ConsoleApp1
{
    class Program
    {
        //conversion
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunProgram.GetDataDir_Convert();

            // Load the document from disk.
            Document doc = new Document(dataDir + "Tech_Article_Viktor.doc");

            dataDir = dataDir + "Tech_Article_Viktor_out.pdf";

            // Save the document in PDF format.
            doc.Save(dataDir);
            // ExEnd:Doc2Pdf
            Console.WriteLine("\nDocument converted to PDF successfully.\nFile saved at " + dataDir);
        }
        public static void DisplayDocTitleInWindowTitlebar()
        {
            // ExStart:DisplayDocTitleInWindowTitlebar
            // The path to the documents directory.
            string dataDir = RunProgram.GetDataDir_Convert();

            // Load the document from disk.
            Document doc = new Document(dataDir + "Tech_Article_Viktor.doc");

            PdfSaveOptions saveOptions = new PdfSaveOptions();
            saveOptions.DisplayDocTitle = true;

            dataDir = dataDir + "Tech_Article_Viktor.pdf";

            // Save the document in PDF format.
            doc.Save(dataDir, saveOptions);
            // ExEnd:DisplayDocTitleInWindowTitlebar
            Console.WriteLine("\nDocument converted to PDF successfully.\nFile saved at " + dataDir);
        }

    }
}