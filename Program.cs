using System;

namespace Example_project
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelExample example = new ExcelExample();

            Console.WriteLine("Processing document, please wait...");

            // Create a new instance of the delegate and reference the desired functions
            ExcelExample.ExcelExampleHandler exampleHandler = example.PopulateCells;
            exampleHandler += example.ApplyCustomStyle;
            exampleHandler += example.CreateChart;
            exampleHandler += example.SaveWorkbook;
            exampleHandler += example.ExportWorkbookToPDF;

            // Run the functions referenced by the delegate
            example.RunExample(exampleHandler);

            Console.WriteLine("Done!");
        }
    }
}
