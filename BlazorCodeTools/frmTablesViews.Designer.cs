namespace BlazorCodeTools
{
    partial class frmTablesViews
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
            System.Drawing.StringFormat stringFormat1 = new System.Drawing.StringFormat();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTablesViews));
            this.TAIGTablesViews = new TAIGridControl2.TAIGridControl();
            this.SuspendLayout();
            // 
            // TAIGTablesViews
            // 
            this.TAIGTablesViews.AlternateColoration = false;
            this.TAIGTablesViews.AlternateColorationAltColor = System.Drawing.Color.MediumSpringGreen;
            this.TAIGTablesViews.AlternateColorationBaseColor = System.Drawing.Color.AntiqueWhite;
            this.TAIGTablesViews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TAIGTablesViews.BorderColor = System.Drawing.Color.Black;
            this.TAIGTablesViews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TAIGTablesViews.CellOutlines = true;
            this.TAIGTablesViews.ColBackColorEdit = System.Drawing.Color.Yellow;
            this.TAIGTablesViews.Cols = 0;
            this.TAIGTablesViews.DefaultBackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.TAIGTablesViews.DefaultCellFont = new System.Drawing.Font("Arial", 9F);
            this.TAIGTablesViews.DefaultForegroundColor = System.Drawing.Color.Black;
            this.TAIGTablesViews.Delimiter = ",";
            this.TAIGTablesViews.ExcelAlternateColoration = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.TAIGTablesViews.ExcelAutoFitColumn = true;
            this.TAIGTablesViews.ExcelAutoFitRow = true;
            this.TAIGTablesViews.ExcelFilename = "";
            this.TAIGTablesViews.ExcelIncludeColumnHeaders = true;
            this.TAIGTablesViews.ExcelKeepAlive = true;
            this.TAIGTablesViews.ExcelMatchGridColorScheme = true;
            this.TAIGTablesViews.ExcelMaximized = true;
            this.TAIGTablesViews.ExcelMaxRowsPerSheet = 30000;
            this.TAIGTablesViews.ExcelOutlineCells = true;
            this.TAIGTablesViews.ExcelPageOrientation = 1;
            this.TAIGTablesViews.ExcelShowBorders = false;
            this.TAIGTablesViews.ExcelUseAlternateRowColor = true;
            this.TAIGTablesViews.ExcelWorksheetName = "Grid Output";
            this.TAIGTablesViews.GridEditMode = TAIGridControl2.TAIGridControl.GridEditModes.KeyReturn;
            this.TAIGTablesViews.GridHeaderBackColor = System.Drawing.Color.LightBlue;
            this.TAIGTablesViews.GridHeaderFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.TAIGTablesViews.GridHeaderForeColor = System.Drawing.Color.Black;
            this.TAIGTablesViews.GridHeaderHeight = 16;
            stringFormat1.Alignment = System.Drawing.StringAlignment.Near;
            stringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat1.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat1.Trimming = System.Drawing.StringTrimming.Character;
            this.TAIGTablesViews.GridHeaderStringFormat = stringFormat1;
            this.TAIGTablesViews.GridheaderVisible = true;
            this.TAIGTablesViews.Location = new System.Drawing.Point(12, 33);
            this.TAIGTablesViews.Name = "TAIGTablesViews";
            this.TAIGTablesViews.OmitNulls = true;
            this.TAIGTablesViews.PageSettings = null;
            this.TAIGTablesViews.PaginationSize = 0;
            this.TAIGTablesViews.Rows = 0;
            this.TAIGTablesViews.ScrollInterval = 5;
            this.TAIGTablesViews.SelectedColBackColor = System.Drawing.Color.MediumSlateBlue;
            this.TAIGTablesViews.SelectedColForeColor = System.Drawing.Color.LightGray;
            this.TAIGTablesViews.SelectedColumn = -1;
            this.TAIGTablesViews.SelectedRow = -1;
            this.TAIGTablesViews.SelectedRowBackColor = System.Drawing.Color.Blue;
            this.TAIGTablesViews.SelectedRowForeColor = System.Drawing.Color.White;
            this.TAIGTablesViews.SelectedRows = ((System.Collections.ArrayList)(resources.GetObject("TAIGTablesViews.SelectedRows")));
            this.TAIGTablesViews.Size = new System.Drawing.Size(767, 554);
            this.TAIGTablesViews.TabIndex = 5;
            this.TAIGTablesViews.TitleBackColor = System.Drawing.Color.Blue;
            this.TAIGTablesViews.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAIGTablesViews.TitleForeColor = System.Drawing.Color.White;
            this.TAIGTablesViews.TitleText = "Tables and Views In selected database";
            this.TAIGTablesViews.TitleVisible = true;
            this.TAIGTablesViews.XMLDataSetName = "Grid_Output";
            this.TAIGTablesViews.XMLFileName = "";
            this.TAIGTablesViews.XMLIncludeSchema = false;
            this.TAIGTablesViews.XMLNameSpace = "TAI_Grid_Ouptut";
            this.TAIGTablesViews.XMLTableName = "Table";
            this.TAIGTablesViews.CellDoubleClicked += new TAIGridControl2.TAIGridControl.CellDoubleClickedEventHandler(this.HandleCellDoubleclicked);
            // 
            // frmTablesViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 599);
            this.Controls.Add(this.TAIGTablesViews);
            this.Name = "frmTablesViews";
            this.Text = "frmTablesViews";
            this.ResumeLayout(false);

        }

        #endregion

        private TAIGridControl2.TAIGridControl TAIGTablesViews;
    }
}