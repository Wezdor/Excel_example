using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_project
{
    public partial class UserInterface : DevExpress.XtraEditors.XtraForm
    {
        private ExcelExample _example;
        private ExcelExample.ExcelExampleOperationHandler _exampleHandler;
        private ExcelExample.ExcelExampleAsyncHandler _asyncHandler;

        private string _topLeftCellReference = "A1";
        private string _bottomRightCellReference = "A12";

        public UserInterface()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Ready!";
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            _example = new ExcelExample();
            _exampleHandler = null;
            _asyncHandler = null;
        }

        // Color picker input event
        private void colorPickEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Color selectedColour = (sender as ColorPickEdit).Color;
            _example.CustomColor = selectedColour;
        }

        // Date edit input event
        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = (sender as DateEdit).DateTime;
            _example.Date = selectedDate;
        }

        //******************
        // Button clicks events
        private void topLeftCellSelect_Click(object sender, EventArgs e)
        {
            // Create a new text input box prompt for the bottom right cell, with the default value "A12"
            var inputResult = TextInputBoxPrompt("top left", "A1");
            // If user clicks "Cancel", result is null -> do not change value
            string inputResultString = inputResult == null ? topLeftCellSelect.Text : inputResult.ToString();
            // Set button name to input value
            topLeftCellSelect.Text = inputResultString;
            _topLeftCellReference = inputResultString;
        }

        private void bottomRightCellSelect_Click(object sender, EventArgs e)
        {
            // Create a new text input box prompt for the bottom right cell, with the default value "A12"
            var inputResult = TextInputBoxPrompt("bottom right", "A12");
            // If user clicks "Cancel", result is null -> do not change value
            string inputResultString = inputResult == null ? bottomRightCellSelect.Text : inputResult.ToString();
            // Set button name to input value
            bottomRightCellSelect.Text = inputResultString;
            _bottomRightCellReference = inputResultString;
        }

        private void dateCellSelect_Click(object sender, EventArgs e)
        {
            // Create a new text input box prompt for the bottom right cell, with the default value "A12"
            var inputResult = TextInputBoxPrompt("date", "D1");
            // If user clicks "Cancel", result is null -> do not change value
            string inputResultString = inputResult == null ? dateCellSelect.Text : inputResult.ToString();
            // Set button name to input value
            dateCellSelect.Text = inputResultString;
            _example.DateCellReference = inputResultString;
        }
        //******************


        // Define an input box, with text field, that is validated for cell reference only
        private object TextInputBoxPrompt(string captionPartial, string defaultInput)
        {
            // Create new input box
            XtraInputBoxArgs args = new XtraInputBoxArgs();
            // Set input box properties
            args.Caption = "Change " + captionPartial + " cell";
            args.Prompt = "Enter a new cell value";
            args.DefaultResponse = defaultInput;
            // Select "OK" button as default
            args.DefaultButtonIndex = 0;
            // Create new text input field
            TextEdit editor = new TextEdit();
            // Turn on input validating
            editor.Validating += CellSelect_Validating;
            // Display Error on invalid value
            editor.InvalidValue += CellSelect_InvalidValue;
            args.Editor = editor;
            // Display the input box (text input)
            return XtraInputBox.Show(args);
        }

        // Validate user input according to a regex pattern
        private void CellSelect_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^[a-zA-Z]{1,2}[0-9]{1,2}$";
            Regex rg = new Regex(pattern);
            string textInput = (sender as TextEdit).EditValue.ToString();

            if(rg.IsMatch(textInput) == false)
            {
                e.Cancel = true;
            }
        }

        // Display error on incorrect input
        private void CellSelect_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "Must be a valid cell value (eg A1)!";
        }



        // Convert top left corner and bottom right corner to range
        // eg. A1, A12 -> A1:A12
        private string ConvertCellsToCellRangeReference()
        {
            return _topLeftCellReference + ":" + _bottomRightCellReference;
        }


        // "Execute" button click
        private async void executeButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Applying settings...";
            _example.RangeReference = ConvertCellsToCellRangeReference();
            _exampleHandler += _example.PopulateCells;
            _exampleHandler += _example.ApplyCustomStyle;
            _exampleHandler += _example.CreateChart;
            _exampleHandler += _example.SaveDateTimeToCell;

            try
            {
                _example.RunExample(_exampleHandler);
            }
            catch (Exception err)
            {
                XtraMessageBox.Show("An Error occured! \n" + err.Message);
                toolStripStatusLabel1.Text = "Operation failed!";
                return;
            }

            _asyncHandler += _example.SaveWorkbookAsync;
            _asyncHandler += _example.ExportWorkbookToPDFAsync;

            try
            {
                toolStripStatusLabel1.Text = "Saving and exporting files...";
                await _example.SaveExampleAsync(_asyncHandler);
                toolStripStatusLabel1.Text = "Operation finished!";
            }
            catch (System.IO.IOException err)
            {
                XtraMessageBox.Show("An error occured! \n" + err.Message);
                toolStripStatusLabel1.Text = "Operation failed!";
                return;
            }
            catch(Exception err)
            {
                XtraMessageBox.Show("An error occured! Please stop clicking the \"Execute\" button so quickly! \n" + err.Message);
                toolStripStatusLabel1.Text = "Operation failed!";
                return;
            }
        }
    }
}