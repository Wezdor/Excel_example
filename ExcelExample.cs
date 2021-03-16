using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;
using System;
using System.Drawing;

namespace Example_project
{
    /// <summary>
    /// This is an example project for SOL-IT
    /// <para>Project requirements:<br/>
    /// * Create/Open an excel file<br/>
    /// * Populate cells with random data<br/>
    /// * Edit the cell style<br/>
    /// * Show graph of cells from previous step<br/>
    /// * Export file to PDF</para>
    /// </summary>
    class ExcelExample
    {
        private Workbook _workbook;
        private Worksheet _worksheet;
        private CellRange _range;
        private string _fileName;

        public delegate void ExcelExampleHandler();

        public ExcelExample()
        {
            _workbook = new Workbook();
            _workbook.Worksheets.Add("Excel sample");
            _worksheet = _workbook.Worksheets["Excel sample"];
            _range = _worksheet.Range["A1:A12"];
            _fileName = "Test";
        }

        public void RunExample(ExcelExampleHandler exampleHandler)
        {
            exampleHandler();
        }

        // Populate the selected range with random data
        public void PopulateCells()
        {
            Random random = new Random();

            for (int i = 0; i < _range.RowCount; i++ )
            {
                for (int j = 0; j < _range.ColumnCount; j++)
                {
                    // Populate the cells with incrementing values with random noise
                    _range[i, j].Value = i + random.Next(-50, 50) / 100;
                }
            }
        }

        // Create a custom style and apply it to the selected Range
        public void ApplyCustomStyle()
        {
            // Add a new style under the "SOL-IT" name to the style collection.
            Style customStyle = _workbook.Styles.Add("SOL-IT");

            // Copy all format settings from the built-in Good style.
            customStyle.CopyFrom(BuiltInStyleId.Good);

            // Specify the style's format characteristics.
            customStyle.BeginUpdate();
            try
            {
                customStyle.Font.Color = Color.DarkGray;
                customStyle.Font.Size = 12;

                // Align the cells to the right.
                customStyle.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Right;

                customStyle.Fill.BackgroundColor = Color.LightBlue;
            }
            finally
            {
                customStyle.EndUpdate();
            }

            _range.Style = customStyle;
        }

        // Create a chart, populate with data from given range, format appearance and add trendline
        public void CreateChart()
        {
            Chart chart = _worksheet.Charts.Add(ChartType.ScatterLineMarkers);
            chart.TopLeftCell = _worksheet.Cells["D1"];
            chart.BottomRightCell = _worksheet.Cells["K14"];
            chart.Series.Add(
                ChartData.FromRange(_range),    // Convert the CellRange data to a ChartData format and use as Y axis data
                new CellValue[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }   // Create X axis data
                );
            // Display the minor gridlines of the category axis.
            chart.PrimaryAxes[0].MinorGridlines.Visible = true;
            // Display the minor gridlines of the value axis.
            chart.PrimaryAxes[1].MinorGridlines.Visible = true;
            // Hide the legend.
            chart.Legend.Visible = false;
            // Display a linear trendline.
            chart.Series[0].Trendlines.Add(ChartTrendlineType.Linear);
        }

        // Save the workbook to file
        public void SaveWorkbook()
        {
            _workbook.SaveDocument($"{_fileName}.xlsx");
        }

        // Export the workbook to a PDF file
        public void ExportWorkbookToPDF()
        {
            _workbook.ExportToPdf($"{_fileName}.pdf");
        }
    }
}
