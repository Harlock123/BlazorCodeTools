namespace BlazorCodeTools
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Drawing.StringFormat stringFormat4 = new System.Drawing.StringFormat();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Drawing.StringFormat stringFormat5 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat6 = new System.Drawing.StringFormat();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MoreGrids = new System.Windows.Forms.SplitContainer();
            this.TaigQuerySchema = new TAIGridControl2.TAIGridControl();
            this.TheGrids = new System.Windows.Forms.SplitContainer();
            this.TAIGFields = new TAIGridControl2.TAIGridControl();
            this.taigFieldDataTypes = new TAIGridControl2.TAIGridControl();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.btnShowTablesViews = new System.Windows.Forms.Button();
            this.btnFetch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SQLStatement = new FastColoredTextBoxNS.FastColoredTextBox();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGeneralDataObject = new System.Windows.Forms.Button();
            this.fcSharedClass = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGenerateUI = new System.Windows.Forms.Button();
            this.fcUICode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chkDoSQL = new System.Windows.Forms.CheckBox();
            this.chkFullController = new System.Windows.Forms.CheckBox();
            this.btnGenerateController = new System.Windows.Forms.Button();
            this.fcController = new FastColoredTextBoxNS.FastColoredTextBox();
            this.btnPresetDBs = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoreGrids)).BeginInit();
            this.MoreGrids.Panel1.SuspendLayout();
            this.MoreGrids.Panel2.SuspendLayout();
            this.MoreGrids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TheGrids)).BeginInit();
            this.TheGrids.Panel1.SuspendLayout();
            this.TheGrids.Panel2.SuspendLayout();
            this.TheGrids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SQLStatement)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcSharedClass)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcUICode)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcController)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1190, 530);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.btnPresetDBs);
            this.tabPage1.Controls.Add(this.MoreGrids);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtProjectName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtClassName);
            this.tabPage1.Controls.Add(this.btnShowTablesViews);
            this.tabPage1.Controls.Add(this.btnFetch);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.SQLStatement);
            this.tabPage1.Controls.Add(this.txtConnectionString);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1182, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setup";
            // 
            // MoreGrids
            // 
            this.MoreGrids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoreGrids.Location = new System.Drawing.Point(7, 161);
            this.MoreGrids.Name = "MoreGrids";
            this.MoreGrids.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MoreGrids.Panel1
            // 
            this.MoreGrids.Panel1.Controls.Add(this.TaigQuerySchema);
            // 
            // MoreGrids.Panel2
            // 
            this.MoreGrids.Panel2.Controls.Add(this.TheGrids);
            this.MoreGrids.Size = new System.Drawing.Size(1169, 337);
            this.MoreGrids.SplitterDistance = 168;
            this.MoreGrids.TabIndex = 14;
            // 
            // TaigQuerySchema
            // 
            this.TaigQuerySchema.AlternateColoration = false;
            this.TaigQuerySchema.AlternateColorationAltColor = System.Drawing.Color.MediumSpringGreen;
            this.TaigQuerySchema.AlternateColorationBaseColor = System.Drawing.Color.AntiqueWhite;
            this.TaigQuerySchema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaigQuerySchema.AutoSizeCellsToContents = true;
            this.TaigQuerySchema.BorderColor = System.Drawing.Color.Black;
            this.TaigQuerySchema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaigQuerySchema.CellOutlines = true;
            this.TaigQuerySchema.ColBackColorEdit = System.Drawing.Color.Yellow;
            this.TaigQuerySchema.Cols = 0;
            this.TaigQuerySchema.DefaultBackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.TaigQuerySchema.DefaultCellFont = new System.Drawing.Font("Arial", 9F);
            this.TaigQuerySchema.DefaultForegroundColor = System.Drawing.Color.Black;
            this.TaigQuerySchema.Delimiter = ",";
            this.TaigQuerySchema.ExcelAlternateColoration = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.TaigQuerySchema.ExcelAutoFitColumn = true;
            this.TaigQuerySchema.ExcelAutoFitRow = true;
            this.TaigQuerySchema.ExcelFilename = "";
            this.TaigQuerySchema.ExcelIncludeColumnHeaders = true;
            this.TaigQuerySchema.ExcelKeepAlive = true;
            this.TaigQuerySchema.ExcelMatchGridColorScheme = true;
            this.TaigQuerySchema.ExcelMaximized = true;
            this.TaigQuerySchema.ExcelMaxRowsPerSheet = 30000;
            this.TaigQuerySchema.ExcelOutlineCells = true;
            this.TaigQuerySchema.ExcelPageOrientation = 1;
            this.TaigQuerySchema.ExcelShowBorders = false;
            this.TaigQuerySchema.ExcelUseAlternateRowColor = true;
            this.TaigQuerySchema.ExcelWorksheetName = "Grid Output";
            this.TaigQuerySchema.GridEditMode = TAIGridControl2.TAIGridControl.GridEditModes.KeyReturn;
            this.TaigQuerySchema.GridHeaderBackColor = System.Drawing.Color.LightBlue;
            this.TaigQuerySchema.GridHeaderFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.TaigQuerySchema.GridHeaderForeColor = System.Drawing.Color.Black;
            this.TaigQuerySchema.GridHeaderHeight = 17;
            stringFormat4.Alignment = System.Drawing.StringAlignment.Near;
            stringFormat4.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat4.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat4.Trimming = System.Drawing.StringTrimming.Character;
            this.TaigQuerySchema.GridHeaderStringFormat = stringFormat4;
            this.TaigQuerySchema.GridheaderVisible = true;
            this.TaigQuerySchema.Location = new System.Drawing.Point(6, 3);
            this.TaigQuerySchema.Name = "TaigQuerySchema";
            this.TaigQuerySchema.PageSettings = null;
            this.TaigQuerySchema.PaginationSize = 0;
            this.TaigQuerySchema.Rows = 0;
            this.TaigQuerySchema.ScrollInterval = 5;
            this.TaigQuerySchema.SelectedColBackColor = System.Drawing.Color.MediumSlateBlue;
            this.TaigQuerySchema.SelectedColForeColor = System.Drawing.Color.LightGray;
            this.TaigQuerySchema.SelectedColumn = -1;
            this.TaigQuerySchema.SelectedRow = -1;
            this.TaigQuerySchema.SelectedRowBackColor = System.Drawing.Color.Blue;
            this.TaigQuerySchema.SelectedRowForeColor = System.Drawing.Color.White;
            this.TaigQuerySchema.SelectedRows = ((System.Collections.ArrayList)(resources.GetObject("TaigQuerySchema.SelectedRows")));
            this.TaigQuerySchema.Size = new System.Drawing.Size(1160, 162);
            this.TaigQuerySchema.TabIndex = 13;
            this.TaigQuerySchema.TitleBackColor = System.Drawing.Color.Blue;
            this.TaigQuerySchema.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaigQuerySchema.TitleForeColor = System.Drawing.Color.White;
            this.TaigQuerySchema.TitleText = "The Query\'s Schema";
            this.TaigQuerySchema.TitleVisible = true;
            this.TaigQuerySchema.XMLDataSetName = "Grid_Output";
            this.TaigQuerySchema.XMLFileName = "";
            this.TaigQuerySchema.XMLIncludeSchema = false;
            this.TaigQuerySchema.XMLNameSpace = "TAI_Grid_Ouptut";
            this.TaigQuerySchema.XMLTableName = "Table";
            this.TaigQuerySchema.Load += new System.EventHandler(this.TaigQuerySchema_Load);
            // 
            // TheGrids
            // 
            this.TheGrids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TheGrids.Location = new System.Drawing.Point(6, 3);
            this.TheGrids.Name = "TheGrids";
            // 
            // TheGrids.Panel1
            // 
            this.TheGrids.Panel1.Controls.Add(this.TAIGFields);
            // 
            // TheGrids.Panel2
            // 
            this.TheGrids.Panel2.Controls.Add(this.taigFieldDataTypes);
            this.TheGrids.Size = new System.Drawing.Size(1160, 162);
            this.TheGrids.SplitterDistance = 739;
            this.TheGrids.TabIndex = 12;
            // 
            // TAIGFields
            // 
            this.TAIGFields.AlternateColoration = false;
            this.TAIGFields.AlternateColorationAltColor = System.Drawing.Color.MediumSpringGreen;
            this.TAIGFields.AlternateColorationBaseColor = System.Drawing.Color.AntiqueWhite;
            this.TAIGFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TAIGFields.BorderColor = System.Drawing.Color.Black;
            this.TAIGFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TAIGFields.CellOutlines = true;
            this.TAIGFields.ColBackColorEdit = System.Drawing.Color.Yellow;
            this.TAIGFields.Cols = 0;
            this.TAIGFields.DefaultBackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.TAIGFields.DefaultCellFont = new System.Drawing.Font("Arial", 9F);
            this.TAIGFields.DefaultForegroundColor = System.Drawing.Color.Black;
            this.TAIGFields.Delimiter = ",";
            this.TAIGFields.ExcelAlternateColoration = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.TAIGFields.ExcelAutoFitColumn = true;
            this.TAIGFields.ExcelAutoFitRow = true;
            this.TAIGFields.ExcelFilename = "";
            this.TAIGFields.ExcelIncludeColumnHeaders = true;
            this.TAIGFields.ExcelKeepAlive = true;
            this.TAIGFields.ExcelMatchGridColorScheme = true;
            this.TAIGFields.ExcelMaximized = true;
            this.TAIGFields.ExcelMaxRowsPerSheet = 30000;
            this.TAIGFields.ExcelOutlineCells = true;
            this.TAIGFields.ExcelPageOrientation = 1;
            this.TAIGFields.ExcelShowBorders = false;
            this.TAIGFields.ExcelUseAlternateRowColor = true;
            this.TAIGFields.ExcelWorksheetName = "Grid Output";
            this.TAIGFields.GridEditMode = TAIGridControl2.TAIGridControl.GridEditModes.KeyReturn;
            this.TAIGFields.GridHeaderBackColor = System.Drawing.Color.LightBlue;
            this.TAIGFields.GridHeaderFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.TAIGFields.GridHeaderForeColor = System.Drawing.Color.Black;
            this.TAIGFields.GridHeaderHeight = 16;
            stringFormat5.Alignment = System.Drawing.StringAlignment.Near;
            stringFormat5.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat5.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat5.Trimming = System.Drawing.StringTrimming.Character;
            this.TAIGFields.GridHeaderStringFormat = stringFormat5;
            this.TAIGFields.GridheaderVisible = true;
            this.TAIGFields.Location = new System.Drawing.Point(0, 3);
            this.TAIGFields.Name = "TAIGFields";
            this.TAIGFields.OmitNulls = true;
            this.TAIGFields.PageSettings = null;
            this.TAIGFields.PaginationSize = 0;
            this.TAIGFields.Rows = 0;
            this.TAIGFields.ScrollInterval = 5;
            this.TAIGFields.SelectedColBackColor = System.Drawing.Color.MediumSlateBlue;
            this.TAIGFields.SelectedColForeColor = System.Drawing.Color.LightGray;
            this.TAIGFields.SelectedColumn = -1;
            this.TAIGFields.SelectedRow = -1;
            this.TAIGFields.SelectedRowBackColor = System.Drawing.Color.Blue;
            this.TAIGFields.SelectedRowForeColor = System.Drawing.Color.White;
            this.TAIGFields.SelectedRows = ((System.Collections.ArrayList)(resources.GetObject("TAIGFields.SelectedRows")));
            this.TAIGFields.Size = new System.Drawing.Size(736, 156);
            this.TAIGFields.TabIndex = 0;
            this.TAIGFields.TitleBackColor = System.Drawing.Color.Blue;
            this.TAIGFields.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAIGFields.TitleForeColor = System.Drawing.Color.White;
            this.TAIGFields.TitleText = "SQL Results";
            this.TAIGFields.TitleVisible = true;
            this.TAIGFields.XMLDataSetName = "Grid_Output";
            this.TAIGFields.XMLFileName = "";
            this.TAIGFields.XMLIncludeSchema = false;
            this.TAIGFields.XMLNameSpace = "TAI_Grid_Ouptut";
            this.TAIGFields.XMLTableName = "Table";
            // 
            // taigFieldDataTypes
            // 
            this.taigFieldDataTypes.AlternateColoration = false;
            this.taigFieldDataTypes.AlternateColorationAltColor = System.Drawing.Color.MediumSpringGreen;
            this.taigFieldDataTypes.AlternateColorationBaseColor = System.Drawing.Color.AntiqueWhite;
            this.taigFieldDataTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taigFieldDataTypes.AutoSizeCellsToContents = true;
            this.taigFieldDataTypes.BorderColor = System.Drawing.Color.Black;
            this.taigFieldDataTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taigFieldDataTypes.CellOutlines = true;
            this.taigFieldDataTypes.ColBackColorEdit = System.Drawing.Color.Yellow;
            this.taigFieldDataTypes.Cols = 0;
            this.taigFieldDataTypes.DefaultBackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.taigFieldDataTypes.DefaultCellFont = new System.Drawing.Font("Arial", 9F);
            this.taigFieldDataTypes.DefaultForegroundColor = System.Drawing.Color.Black;
            this.taigFieldDataTypes.Delimiter = ",";
            this.taigFieldDataTypes.ExcelAlternateColoration = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.taigFieldDataTypes.ExcelAutoFitColumn = true;
            this.taigFieldDataTypes.ExcelAutoFitRow = true;
            this.taigFieldDataTypes.ExcelFilename = "";
            this.taigFieldDataTypes.ExcelIncludeColumnHeaders = true;
            this.taigFieldDataTypes.ExcelKeepAlive = true;
            this.taigFieldDataTypes.ExcelMatchGridColorScheme = true;
            this.taigFieldDataTypes.ExcelMaximized = true;
            this.taigFieldDataTypes.ExcelMaxRowsPerSheet = 30000;
            this.taigFieldDataTypes.ExcelOutlineCells = true;
            this.taigFieldDataTypes.ExcelPageOrientation = 1;
            this.taigFieldDataTypes.ExcelShowBorders = false;
            this.taigFieldDataTypes.ExcelUseAlternateRowColor = true;
            this.taigFieldDataTypes.ExcelWorksheetName = "Grid Output";
            this.taigFieldDataTypes.GridEditMode = TAIGridControl2.TAIGridControl.GridEditModes.KeyReturn;
            this.taigFieldDataTypes.GridHeaderBackColor = System.Drawing.Color.LightBlue;
            this.taigFieldDataTypes.GridHeaderFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.taigFieldDataTypes.GridHeaderForeColor = System.Drawing.Color.Black;
            this.taigFieldDataTypes.GridHeaderHeight = 17;
            stringFormat6.Alignment = System.Drawing.StringAlignment.Near;
            stringFormat6.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat6.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat6.Trimming = System.Drawing.StringTrimming.Character;
            this.taigFieldDataTypes.GridHeaderStringFormat = stringFormat6;
            this.taigFieldDataTypes.GridheaderVisible = true;
            this.taigFieldDataTypes.Location = new System.Drawing.Point(4, 4);
            this.taigFieldDataTypes.Name = "taigFieldDataTypes";
            this.taigFieldDataTypes.PageSettings = null;
            this.taigFieldDataTypes.PaginationSize = 0;
            this.taigFieldDataTypes.Rows = 0;
            this.taigFieldDataTypes.ScrollInterval = 5;
            this.taigFieldDataTypes.SelectedColBackColor = System.Drawing.Color.MediumSlateBlue;
            this.taigFieldDataTypes.SelectedColForeColor = System.Drawing.Color.LightGray;
            this.taigFieldDataTypes.SelectedColumn = -1;
            this.taigFieldDataTypes.SelectedRow = -1;
            this.taigFieldDataTypes.SelectedRowBackColor = System.Drawing.Color.Blue;
            this.taigFieldDataTypes.SelectedRowForeColor = System.Drawing.Color.White;
            this.taigFieldDataTypes.SelectedRows = ((System.Collections.ArrayList)(resources.GetObject("taigFieldDataTypes.SelectedRows")));
            this.taigFieldDataTypes.Size = new System.Drawing.Size(410, 155);
            this.taigFieldDataTypes.TabIndex = 0;
            this.taigFieldDataTypes.TitleBackColor = System.Drawing.Color.Blue;
            this.taigFieldDataTypes.TitleFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taigFieldDataTypes.TitleForeColor = System.Drawing.Color.White;
            this.taigFieldDataTypes.TitleText = "Field Data Types";
            this.taigFieldDataTypes.TitleVisible = true;
            this.taigFieldDataTypes.XMLDataSetName = "Grid_Output";
            this.taigFieldDataTypes.XMLFileName = "";
            this.taigFieldDataTypes.XMLIncludeSchema = false;
            this.taigFieldDataTypes.XMLNameSpace = "TAI_Grid_Ouptut";
            this.taigFieldDataTypes.XMLTableName = "Table";
            this.taigFieldDataTypes.CellDoubleClicked += new TAIGridControl2.TAIGridControl.CellDoubleClickedEventHandler(this.HandleFieldTypeCellDoubleClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Project Name";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectName.Location = new System.Drawing.Point(654, 39);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(118, 20);
            this.txtProjectName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Class Name";
            // 
            // txtClassName
            // 
            this.txtClassName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassName.Location = new System.Drawing.Point(842, 39);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(2);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(118, 20);
            this.txtClassName.TabIndex = 8;
            // 
            // btnShowTablesViews
            // 
            this.btnShowTablesViews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowTablesViews.Location = new System.Drawing.Point(964, 38);
            this.btnShowTablesViews.Name = "btnShowTablesViews";
            this.btnShowTablesViews.Size = new System.Drawing.Size(105, 23);
            this.btnShowTablesViews.TabIndex = 7;
            this.btnShowTablesViews.Text = "List Tables/Views";
            this.btnShowTablesViews.UseVisualStyleBackColor = true;
            this.btnShowTablesViews.Click += new System.EventHandler(this.btnShowTablesViews_Click);
            // 
            // btnFetch
            // 
            this.btnFetch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFetch.Location = new System.Drawing.Point(1075, 38);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(105, 23);
            this.btnFetch.TabIndex = 5;
            this.btnFetch.Text = "Fetch Results";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SQL Statement";
            // 
            // SQLStatement
            // 
            this.SQLStatement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQLStatement.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.SQLStatement.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.SQLStatement.BackBrush = null;
            this.SQLStatement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SQLStatement.CharHeight = 14;
            this.SQLStatement.CharWidth = 8;
            this.SQLStatement.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SQLStatement.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SQLStatement.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.SQLStatement.IsReplaceMode = false;
            this.SQLStatement.Location = new System.Drawing.Point(3, 64);
            this.SQLStatement.Name = "SQLStatement";
            this.SQLStatement.Paddings = new System.Windows.Forms.Padding(0);
            this.SQLStatement.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.SQLStatement.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("SQLStatement.ServiceColors")));
            this.SQLStatement.Size = new System.Drawing.Size(1176, 91);
            this.SQLStatement.TabIndex = 2;
            this.SQLStatement.Text = "Select * from TableName Group By  x Order By y";
            this.SQLStatement.WordWrap = true;
            this.SQLStatement.Zoom = 100;
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnectionString.Location = new System.Drawing.Point(108, 6);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(961, 20);
            this.txtConnectionString.TabIndex = 1;
            this.txtConnectionString.Text = "SERVER=luisbhds.database.windows.net;user id=harlock123;password=LaserMaster#1;in" +
    "itial catalog=LUISBHDS_TEST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.btnGeneralDataObject);
            this.tabPage2.Controls.Add(this.fcSharedClass);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1182, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Code Generation";
            // 
            // btnGeneralDataObject
            // 
            this.btnGeneralDataObject.Location = new System.Drawing.Point(7, 4);
            this.btnGeneralDataObject.Name = "btnGeneralDataObject";
            this.btnGeneralDataObject.Size = new System.Drawing.Size(119, 23);
            this.btnGeneralDataObject.TabIndex = 1;
            this.btnGeneralDataObject.Text = "Generate Object";
            this.btnGeneralDataObject.UseVisualStyleBackColor = true;
            this.btnGeneralDataObject.Click += new System.EventHandler(this.btnGeneralDataObject_Click);
            // 
            // fcSharedClass
            // 
            this.fcSharedClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fcSharedClass.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fcSharedClass.AutoScrollMinSize = new System.Drawing.Size(145, 23);
            this.fcSharedClass.BackBrush = null;
            this.fcSharedClass.CharHeight = 23;
            this.fcSharedClass.CharWidth = 13;
            this.fcSharedClass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fcSharedClass.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fcSharedClass.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.fcSharedClass.IsReplaceMode = false;
            this.fcSharedClass.Location = new System.Drawing.Point(7, 28);
            this.fcSharedClass.Name = "fcSharedClass";
            this.fcSharedClass.Paddings = new System.Windows.Forms.Padding(0);
            this.fcSharedClass.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fcSharedClass.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fcSharedClass.ServiceColors")));
            this.fcSharedClass.Size = new System.Drawing.Size(1169, 470);
            this.fcSharedClass.TabIndex = 0;
            this.fcSharedClass.Text = "SharedClass";
            this.fcSharedClass.Zoom = 100;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage3.Controls.Add(this.btnGenerateUI);
            this.tabPage3.Controls.Add(this.fcUICode);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1182, 504);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "UI Generation";
            // 
            // btnGenerateUI
            // 
            this.btnGenerateUI.Location = new System.Drawing.Point(6, 4);
            this.btnGenerateUI.Name = "btnGenerateUI";
            this.btnGenerateUI.Size = new System.Drawing.Size(149, 23);
            this.btnGenerateUI.TabIndex = 2;
            this.btnGenerateUI.Text = "Generate UI";
            this.btnGenerateUI.UseVisualStyleBackColor = true;
            this.btnGenerateUI.Click += new System.EventHandler(this.HandleGenerateUIClick);
            // 
            // fcUICode
            // 
            this.fcUICode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fcUICode.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fcUICode.AutoScrollMinSize = new System.Drawing.Size(93, 23);
            this.fcUICode.BackBrush = null;
            this.fcUICode.CharHeight = 23;
            this.fcUICode.CharWidth = 13;
            this.fcUICode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fcUICode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fcUICode.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.fcUICode.IsReplaceMode = false;
            this.fcUICode.Location = new System.Drawing.Point(6, 30);
            this.fcUICode.Name = "fcUICode";
            this.fcUICode.Paddings = new System.Windows.Forms.Padding(0);
            this.fcUICode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fcUICode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fcUICode.ServiceColors")));
            this.fcUICode.Size = new System.Drawing.Size(1173, 469);
            this.fcUICode.TabIndex = 1;
            this.fcUICode.Text = "UI Code";
            this.fcUICode.Zoom = 100;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage4.Controls.Add(this.chkDoSQL);
            this.tabPage4.Controls.Add(this.chkFullController);
            this.tabPage4.Controls.Add(this.btnGenerateController);
            this.tabPage4.Controls.Add(this.fcController);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1182, 504);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Controller Generation";
            // 
            // chkDoSQL
            // 
            this.chkDoSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDoSQL.AutoSize = true;
            this.chkDoSQL.Checked = true;
            this.chkDoSQL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDoSQL.Location = new System.Drawing.Point(995, 6);
            this.chkDoSQL.Name = "chkDoSQL";
            this.chkDoSQL.Size = new System.Drawing.Size(89, 17);
            this.chkDoSQL.TabIndex = 5;
            this.chkDoSQL.Text = "Do SQL Stuff";
            this.chkDoSQL.UseVisualStyleBackColor = true;
            // 
            // chkFullController
            // 
            this.chkFullController.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFullController.AutoSize = true;
            this.chkFullController.Checked = true;
            this.chkFullController.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFullController.Location = new System.Drawing.Point(1090, 6);
            this.chkFullController.Name = "chkFullController";
            this.chkFullController.Size = new System.Drawing.Size(89, 17);
            this.chkFullController.TabIndex = 4;
            this.chkFullController.Text = "Full Controller";
            this.chkFullController.UseVisualStyleBackColor = true;
            // 
            // btnGenerateController
            // 
            this.btnGenerateController.Location = new System.Drawing.Point(6, 0);
            this.btnGenerateController.Name = "btnGenerateController";
            this.btnGenerateController.Size = new System.Drawing.Size(149, 23);
            this.btnGenerateController.TabIndex = 3;
            this.btnGenerateController.Text = "Generate Getter Controller";
            this.btnGenerateController.UseVisualStyleBackColor = true;
            this.btnGenerateController.Click += new System.EventHandler(this.btnGenerateController_Click);
            // 
            // fcController
            // 
            this.fcController.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fcController.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fcController.AutoScrollMinSize = new System.Drawing.Size(232, 23);
            this.fcController.BackBrush = null;
            this.fcController.CharHeight = 23;
            this.fcController.CharWidth = 13;
            this.fcController.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fcController.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fcController.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.fcController.IsReplaceMode = false;
            this.fcController.Location = new System.Drawing.Point(6, 28);
            this.fcController.Name = "fcController";
            this.fcController.Paddings = new System.Windows.Forms.Padding(0);
            this.fcController.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fcController.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fcController.ServiceColors")));
            this.fcController.Size = new System.Drawing.Size(1173, 471);
            this.fcController.TabIndex = 1;
            this.fcController.Text = "Controller Code";
            this.fcController.Zoom = 100;
            // 
            // btnPresetDBs
            // 
            this.btnPresetDBs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPresetDBs.Location = new System.Drawing.Point(1074, 4);
            this.btnPresetDBs.Name = "btnPresetDBs";
            this.btnPresetDBs.Size = new System.Drawing.Size(105, 23);
            this.btnPresetDBs.TabIndex = 15;
            this.btnPresetDBs.Text = "Preset DBs";
            this.btnPresetDBs.UseVisualStyleBackColor = true;
            this.btnPresetDBs.Click += new System.EventHandler(this.btnPresetDBs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 538);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.MoreGrids.Panel1.ResumeLayout(false);
            this.MoreGrids.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoreGrids)).EndInit();
            this.MoreGrids.ResumeLayout(false);
            this.TheGrids.Panel1.ResumeLayout(false);
            this.TheGrids.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TheGrids)).EndInit();
            this.TheGrids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SQLStatement)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fcSharedClass)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fcUICode)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcController)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label label1;
        private FastColoredTextBoxNS.FastColoredTextBox SQLStatement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFetch;
        private FastColoredTextBoxNS.FastColoredTextBox fcSharedClass;
        private System.Windows.Forms.TabPage tabPage3;
        private FastColoredTextBoxNS.FastColoredTextBox fcUICode;
        private System.Windows.Forms.TabPage tabPage4;
        private FastColoredTextBoxNS.FastColoredTextBox fcController;
        private System.Windows.Forms.Button btnGeneralDataObject;
        private System.Windows.Forms.Button btnGenerateUI;
        private System.Windows.Forms.Button btnShowTablesViews;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.CheckBox chkFullController;
        private System.Windows.Forms.Button btnGenerateController;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.SplitContainer TheGrids;
        private TAIGridControl2.TAIGridControl TAIGFields;
        private TAIGridControl2.TAIGridControl taigFieldDataTypes;
        private System.Windows.Forms.CheckBox chkDoSQL;
        private TAIGridControl2.TAIGridControl TaigQuerySchema;
        private System.Windows.Forms.SplitContainer MoreGrids;
        private System.Windows.Forms.Button btnPresetDBs;
    }
}

