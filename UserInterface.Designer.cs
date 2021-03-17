
namespace Example_project
{
    partial class UserInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bottomRightCellSelect = new DevExpress.XtraEditors.SimpleButton();
            this.colorPickEdit1 = new DevExpress.XtraEditors.ColorPickEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateCellSelect = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.topLeftCellSelect = new DevExpress.XtraEditors.SimpleButton();
            this.executeButton = new DevExpress.XtraEditors.SimpleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomRightCellSelect
            // 
            this.bottomRightCellSelect.Location = new System.Drawing.Point(6, 152);
            this.bottomRightCellSelect.Name = "bottomRightCellSelect";
            this.bottomRightCellSelect.Size = new System.Drawing.Size(167, 52);
            this.bottomRightCellSelect.TabIndex = 0;
            this.bottomRightCellSelect.Text = "A12";
            this.bottomRightCellSelect.Click += new System.EventHandler(this.bottomRightCellSelect_Click);
            // 
            // colorPickEdit1
            // 
            this.colorPickEdit1.EditValue = System.Drawing.Color.Empty;
            this.colorPickEdit1.Location = new System.Drawing.Point(6, 26);
            this.colorPickEdit1.Name = "colorPickEdit1";
            this.colorPickEdit1.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.colorPickEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorPickEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.colorPickEdit1.Size = new System.Drawing.Size(167, 26);
            this.colorPickEdit1.TabIndex = 1;
            this.colorPickEdit1.EditValueChanged += new System.EventHandler(this.colorPickEdit1_EditValueChanged);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(6, 55);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(158, 26);
            this.dateEdit1.TabIndex = 2;
            this.dateEdit1.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateCellSelect);
            this.groupBox1.Controls.Add(this.dateEdit1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(197, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 179);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date Cell Selection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date Selection";
            // 
            // dateCellSelect
            // 
            this.dateCellSelect.Location = new System.Drawing.Point(6, 121);
            this.dateCellSelect.Name = "dateCellSelect";
            this.dateCellSelect.Size = new System.Drawing.Size(158, 52);
            this.dateCellSelect.TabIndex = 10;
            this.dateCellSelect.Text = "D1";
            this.dateCellSelect.Click += new System.EventHandler(this.dateCellSelect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colorPickEdit1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 62);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cell Colour Picker";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.topLeftCellSelect);
            this.groupBox3.Controls.Add(this.bottomRightCellSelect);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 210);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cell Range Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bottom Right Cell";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Top Left Cell";
            // 
            // topLeftCellSelect
            // 
            this.topLeftCellSelect.Location = new System.Drawing.Point(6, 56);
            this.topLeftCellSelect.Name = "topLeftCellSelect";
            this.topLeftCellSelect.Size = new System.Drawing.Size(167, 52);
            this.topLeftCellSelect.TabIndex = 1;
            this.topLeftCellSelect.Text = "A1";
            this.topLeftCellSelect.Click += new System.EventHandler(this.topLeftCellSelect_Click);
            // 
            // executeButton
            // 
            this.executeButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.executeButton.Appearance.Options.UseFont = true;
            this.executeButton.Location = new System.Drawing.Point(203, 223);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(158, 77);
            this.executeButton.TabIndex = 10;
            this.executeButton.Text = "Execute";
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 321);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(378, 32);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 25);
            this.toolStripStatusLabel1.Text = "Loading...";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 353);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(380, 400);
            this.MinimumSize = new System.Drawing.Size(380, 400);
            this.Name = "UserInterface";
            this.Text = "Excel Example";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bottomRightCellSelect;
        private DevExpress.XtraEditors.ColorPickEdit colorPickEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton dateCellSelect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton topLeftCellSelect;
        private DevExpress.XtraEditors.SimpleButton executeButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}