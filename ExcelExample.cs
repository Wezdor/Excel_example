using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Charts;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

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
        private Cell _dateCell;
        private string _fileName;
        private Color _customColor;
        private DateTime _date;

        private Random _random = new Random(DateTime.Now.Millisecond);

        public delegate void ExcelExampleOperationHandler();
        public delegate Task ExcelExampleAsyncHandler();

        public ExcelExample()
        {
            _workbook = new Workbook();
            _workbook.Worksheets.Add("Excel sample");
            _worksheet = _workbook.Worksheets["Excel sample"];
            _range = _worksheet.Range["A1:A12"];
            _fileName = "Test";
            _customColor = Color.White;
            _dateCell = _worksheet.Cells["D1"];
            _date = DateTime.Today;
        }

        // Public attributes
        public Color CustomColor
        {
            get { return _customColor; }
            set { _customColor = value; }
        }
        public string RangeReference
        {
            get { return _range.GetReferenceA1(); }
            set { _range = _worksheet.Range[value]; }
        }
        public string DateCellReference
        {
            get { return _dateCell.GetReferenceA1(); }
            set { _dateCell = _worksheet.Cells[value]; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }


        public void RunExample(ExcelExampleOperationHandler exampleHandler)
        {
            exampleHandler();
        }

        public async Task SaveExampleAsync(ExcelExampleAsyncHandler asyncHandler)
        {
            await asyncHandler();
        }

        // Populate the selected range with random data
        public void PopulateCells()
        {
            for (int i = 0; i < _range.RowCount; i++)
            {
                for (int j = 0; j < _range.ColumnCount; j++)
                {
                    // Populate the cells with incrementing values with random noise
                    _range[i, j].Value = i + j * 10 + (float)_random.Next(-50, 50) / 100.0;
                }
            }
        }

        // Create a custom style and apply it to the selected Range
        public void ApplyCustomStyle()
        {
            string styleName = "SOL-IT";
            
            // Check that style doesn't already exist
            // For the purpose of this example we just append a random int to the style name, because deleting it is not an option
            if (_workbook.Styles.Contains(styleName)) styleName += _random.Next().ToString();
            // Check again, in case we got the same random int twice...
            if (_workbook.Styles.Contains(styleName)) styleName += _random.Next().ToString();
            // Add a new style under the "SOL-IT" name to the style collection.
            Style customStyle = _workbook.Styles.Add(styleName);

            // Copy all format settings from the built-in Good style.
            customStyle.CopyFrom(BuiltInStyleId.Good);

            // Specify the style's format characteristics.
            customStyle.BeginUpdate();
            try
            {
                customStyle.Font.Color = Color.DimGray;
                customStyle.Font.Size = 12;

                // Align the cells to the right.
                customStyle.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Right;

                customStyle.Fill.BackgroundColor = _customColor;
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
            chart.Title.SetValue("Example chart with trendline");
            chart.TopLeftCell = _worksheet.Cells["E1"];
            chart.BottomRightCell = _worksheet.Cells["L14"];
            // Create X- axis data
            CellValue[] xAxisData = Enumerable.Range(1, _range.RowCount).Select(i => (CellValue)i).ToArray();
            // Create Y- axis data
            // Use only the first range column for Y data
            CellValue[] yAxisData = Enumerable.Range(0, _range.RowCount).Select(i => _range[i, 0].Value).ToArray();
            chart.Series.Add(xAxisData, yAxisData);
            // Display the minor gridlines of the category axis.
            chart.PrimaryAxes[0].MinorGridlines.Visible = true;
            // Display the minor gridlines of the value axis.
            chart.PrimaryAxes[1].MinorGridlines.Visible = true;
            // Hide the legend.
            chart.Legend.Visible = false;
            // Display a linear trendline.
            chart.Series[0].Trendlines.Add(ChartTrendlineType.Linear);
        }

        // Save Date to cell
        public void SaveDateTimeToCell()
        {
            _dateCell.Value = _date;
        }

        // Save the workbook to file
        async public Task SaveWorkbookAsync()
        {
            await _workbook.SaveDocumentAsync($"{_fileName}.xlsx");
        }

        // Export the workbook to a PDF file
        async public Task ExportWorkbookToPDFAsync()
        {
            await _workbook.ExportToPdfAsync($"{_fileName}.pdf");
        }
    }
}
