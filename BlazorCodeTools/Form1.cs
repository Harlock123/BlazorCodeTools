using DocumentFormat.OpenXml.Office.CustomUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using TAIGridControl2;

using System.Data.Sql;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Drawing.Text;

namespace BlazorCodeTools
{
    public partial class Form1 : Form
    {
        private List<Field> TheFields = new List<Field>();

        public Form1()
        {
            InitializeComponent();

            fcSharedClass.Language = FastColoredTextBoxNS.Language.CSharp;
            fcController.Language = FastColoredTextBoxNS.Language.CSharp;
            fcUICode.Language = FastColoredTextBoxNS.Language.HTML;
            SQLStatement.Language = FastColoredTextBoxNS.Language.SQL;
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            TAIGFields.PopulateGridWithData(txtConnectionString.Text, SQLStatement.Text);

            string SQLQuerySchema = "sp_describe_first_result_set N'" + SQLStatement.Text.Replace("'", "''") + "'";

            TaigQuerySchema.PopulateGridWithData(txtConnectionString.Text, SQLQuerySchema);

            ParseIntoTheFieldsList();
            ParseIntoTheFieldsGrid();
        }

        private void ParseIntoTheFieldsGrid()
        {
            taigFieldDataTypes.Rows = 0;

            taigFieldDataTypes.Cols = 2;
            taigFieldDataTypes.set_HeaderLabel(0, "Field Name");
            taigFieldDataTypes.set_HeaderLabel(1, "Field Type");

            for (int i = 0; i < TAIGFields.Cols; i++)
            {
                TAIGridControl.TaiGridColContentTypes ii = TAIGFields.GetColumnType(i);

                string FieldTypeName = TAIGFields.get_HeaderLabel(i);
                switch (ii)
                {
                    case TAIGridControl.TaiGridColContentTypes._String:
                        FieldTypeName += "|String";
                        break;
                    case TAIGridControl.TaiGridColContentTypes._Date:
                        FieldTypeName += "|Date";
                        break;
                    case TAIGridControl.TaiGridColContentTypes._WholeNumber:
                        FieldTypeName += "|WholeNumber";
                        break;
                    case TAIGridControl.TaiGridColContentTypes._FloatingPointNumber:
                        FieldTypeName += "|FloatingPointNumber";
                        break;
                    default:
                        FieldTypeName += "|Bool";
                        break;
                }

                taigFieldDataTypes.AddRowToGrid(FieldTypeName, "|");
            }
        }

        private void ParseIntoTheFieldsList()
        {
            TheFields = new List<Field>();

            for (int i = 0; i < TaigQuerySchema.Rows; i++)
            {
                Field nf = new Field();

                var nullable = TaigQuerySchema.get_item(i, "is_nullable");
                if (nullable.ToUpper() == "TRUE")
                    nf.AllowNulls = true;
                else
                    nf.AllowNulls = false;

                nf.FieldName = TaigQuerySchema.get_item(i, "name");

                nf.FieldNameConverted = nf.FieldName.Replace(" ", "_");

                nf.FieldType = TaigQuerySchema.get_item(i, "system_type_name").Split("(".ToCharArray())[0].ToUpper(); // rather convoluted but effective

                var isID = TaigQuerySchema.get_item(i, "is_identity_column");

                if (isID.ToUpper() == "TRUE")
                    nf.IsIdentity = true;
                else
                    nf.IsIdentity = false;

                nf.MaxLength = int.Parse(TaigQuerySchema.get_item(i, "max_length"));
                nf.Precision = int.Parse(TaigQuerySchema.get_item(i, "precision"));
                nf.Scale = int.Parse(TaigQuerySchema.get_item(i, "scale"));

                TheFields.Add(nf);

            }
        }

        private void HandleFieldTypeCellDoubleClick(object sender, int RowClicked, int ColumnClicked)
        {
            if (ColumnClicked == 1)
            {
                string CurVal = taigFieldDataTypes.get_item(RowClicked, ColumnClicked);

                switch (CurVal)
                {
                    case "String":
                        CurVal = "Date";
                        break;
                    case "Date":
                        CurVal = "WholeNumber";
                        break;
                    case "WholeNumber":
                        CurVal = "FloatingPointNumber";
                        break;
                    case "FloatingPointNumber":
                        CurVal = "String";
                        break;
                    default:
                        CurVal = "String";
                        break;
                }

                taigFieldDataTypes.set_item(RowClicked, ColumnClicked, CurVal);
            }
        }

        private void btnGeneralDataObject_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            string CLASSNAME = "{CLASSNAMEHERE}";

            string PROJNAME = "{Project}";

            if (txtClassName.Text.Trim() != "")
            {
                CLASSNAME = txtClassName.Text;
            }

            if (txtProjectName.Text.Trim() != "")
            {
                PROJNAME = txtProjectName.Text;
            }

            sb.Append("using System;\nusing System.ComponentModel.DataAnnotations;\n\nnamespace " + PROJNAME + ".Shared\n");
            sb.Append("{\n\n");

            string tab = "\t";

            sb.Append(tab + "public class " + CLASSNAME + " \n{\n\n");

            tab = "\t\t";

            foreach(Field f in TheFields)
            {
                string fname = f.FieldName;
                string ftype = f.FieldType;
                string flen = f.MaxLength.ToString();
                string anno = "";
                bool nullable = f.AllowNulls;

                switch (ftype.ToUpper())
                {
                    case "VARCHAR":
                    case "CHAR":
                    case "NVARCHAR":
                    case "NCHAR":
                    case "TEXT":
                    case "NTEXT":
                    case "UNIQUEIDENTIFIER":
                    case "SQL_VARIANT":
                    case "XML":
                        ftype = "String";
                        anno = flen;
                        break;
                    case "DATE":
                    case "TIME":
                    case "DATETIME2":
                    case "DATETIME":
                    case "TIMESTAMP":
                    case "SMALLDATETIME":
                        ftype = "DateTime";
                        break;
                    case "INT":
                    case "TINYINT":
                    case "SMALLINT":
                        ftype = "int";
                        break;
                    case "BIGINT":
                        ftype = "long";
                        break;
                    case "DECIMAL":
                    case "NUMERIC":
                    case "MONEY":
                    case "SMALLMONEY":
                    case "REAL":
                    case "FLOAT":
                        ftype = "double";
                        break;
                    case "BIT":
                        ftype = "bool";
                        break;
                    default:
                        ftype = "String";
                        anno = flen;
                        break;
                }

                if (!nullable)
                {
                    sb.Append(tab + "[Required]\n");
                }

                if (anno != "")
                {
                    sb.Append(tab + "[StringLength(" + anno + ", ErrorMessage=\"The {0} value cannot exceed {1} characters. \" )]\n");
                }

                sb.Append(tab + "public " + ftype + " " + fname + " {get; set;}");
                if (!nullable)
                {
                    if (ftype == "string")
                        sb.Append(" = \"\";\n\n");
                    else if (ftype == "long")
                        sb.Append(" = 0;\n\n");
                    else if (ftype == "int")
                        sb.Append(" = 0;\n\n");
                    else if (ftype == "double")
                        sb.Append(" = 0.0;\n\n");
                    else if (ftype == "bool")
                        sb.Append(" = false;\n\n");
                    else if (ftype == "DateTime")
                        sb.Append(" = DateTime.MinValue();\n\n");
                    else
                        sb.Append(" = \"\";\n\n");
                }
                else
                {
                    sb.Append("\n\n");
                }

                //sb.Append(tab + "public " + CLASSNAME + " ()\n" + tab + "{\n\n" + tab + "}\n\n");

                //sb.Append("}\n");
                //fcSharedClass.Text = sb.ToString();



            }

            sb.Append(tab + "public " + CLASSNAME + " ()\n" + tab + "{\n\n" + tab + "}\n\n");

            tab = "\t";

            sb.Append(tab + "}\n");

            sb.Append("}\n");

            fcSharedClass.Text = sb.ToString();
        }

        private void HandleGenerateUIClick(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            string CLASSNAME = "{CLASSNAMEHERE}";

            if (txtClassName.Text.Trim() != "")
            {
                CLASSNAME = txtClassName.Text;
            }

            string tab = "\t";

            sb.Append("<RadzenGrid TItem=\"" + CLASSNAME + "\" Data=\"@My" + CLASSNAME + "s\" AllowPaging=\"true\" \n");
            sb.Append(tab + tab + tab + tab + "PageSize=\"10\" PageNumbersCount=\"4\" > \n\n");
            sb.Append(tab + " <Columns >\n\n");
            
            for (int i = 0; i < taigFieldDataTypes.Rows; i++)
            {
                string fname = taigFieldDataTypes.get_item(i, 0);
                string ftype = taigFieldDataTypes.get_item(i, 1);

                switch (ftype.ToUpper())
                {
                    case "STRING":

                        sb.Append(tab + tab + "<RadzenGridColumn TItem=\"" + CLASSNAME + "\" Title=\"" + fname + "\" Property=\"" + fname + "\"></RadzenGridColumn>\n\n ");

                        ftype = "String";
                        break;
                    case "DATE":
                        sb.Append(tab + tab + "<RadzenGridColumn TItem=\"" + CLASSNAME + "\" Title=\"" + fname + "\" Property=\"" + fname + "\">\n"); // "</RadzenGridColumn>\n\n ");
                        //           < Template Context = "data" >
                        //               @(data.DueDate.ToShortDateString())
                        //           </ Template >

                        sb.Append(tab + tab + tab + "<Template Context=\"data\" >\n");
                        sb.Append(tab + tab + tab + tab + "@(data." + fname + ".ToShortDateString())\n");
                        sb.Append(tab + tab + tab + "</Template>\n");
                        sb.Append(tab + tab + "</RadzenGridColumn>\n\n ");


                        ftype = "DateTime";
                        break;
                    case "WHOLENUMBER":
                    case "FLOATINGPOINTNUMBER":
                        sb.Append(tab + tab + "<RadzenGridColumn TItem=\"" + CLASSNAME + "\" Title=\"" + fname + "\" Property=\"" + fname + "\"></RadzenGridColumn>\n\n ");


                        ftype = "long";
                        break;
                    default:
                        ftype = "String";
                        break;
                }
            }

            sb.Append(tab + " </Columns >\n\n");
            sb.Append("</RadzenGrid >\n");

            fcUICode.Text = sb.ToString();
        }

        private void btnShowTablesViews_Click(object sender, EventArgs e)
        {
            frmTablesViews frm = new frmTablesViews(txtConnectionString.Text);
            frm.ShowDialog();

            if (frm.SELECTEDTABLE!="")
            {
                SQLStatement.Text = "SELECT TOP 100 * from " + frm.SELECTEDTABLE;
            }

            txtClassName.Text = frm.SELECTEDTABLE;

        }

        private void btnGenerateController_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            string stab = "";
            string tab = stab;

            string CLASSNAME = "{CLASSNAMEHERE}";

            string PROJNAME = "{Project}";

            if (txtClassName.Text.Trim() != "")
            {
                CLASSNAME = txtClassName.Text;
            }

            if (txtProjectName.Text.Trim() != "")
            {
                PROJNAME = txtProjectName.Text;
            }

            if (chkFullController.Checked)
            {
                sb.Append("using System;\n" +
                          "using System.Collections.Generic;\n" +
                          "using System.Linq;\n" +
                          "using System.Threading.Tasks;\n" +
                          "using Microsoft.AspNetCore.Http;\n" +
                          "using Microsoft.AspNetCore.Mvc;\n\n" +
                          "using System.Data.Sql;\n\n" +
                          "using System.Data.SqlClient;\n\n");

                          // using System.Data.Sql;
                          // using System.Data.SqlClient;


                sb.Append("using " + PROJNAME + ".Shared;\n\n");

                sb.Append("namespace " + PROJNAME + ".Server.Controllers\n" +
                          "{\n\n");

                stab = "\t"; //Begin indenting one level
                tab = stab;

            }

            // LIST GETTER

            sb.Append(tab + "[Route(\"api/[controller]\")]\n");
            sb.Append(tab + "[ApiController]\n");
            sb.Append(tab + "public class " + CLASSNAME + "sController : ControllerBase\n" +
                      tab + "{\n\n");

            tab = stab + "\t";

            sb.Append(tab + "[HttpGet]\n");
            sb.Append(tab + "public IEnumerable<" + CLASSNAME + "> Get()\n");
            sb.Append(tab + "{\n\n");

            tab = stab + "\t\t";

            sb.Append(tab + "List<" + CLASSNAME + "> My" + CLASSNAME + "s = new List<" + CLASSNAME + ">();\n\n");

            if (chkDoSQL.Checked)
            {
                sb.Append(tab + @"// Hardcoded SQL Populator You will need to replace the " + "\n");
                sb.Append(tab + @"// connection parameters with something more secure " + "\n");
                sb.Append(tab + @"// most certainly. In addition the SQL selection filters and criteria" + "\n");
                sb.Append(tab + @"// will likely need to be adjusted to accomodate actual use cases" + "\n\n");

                // here we will attempt to format the SQL statement if its got linefeeds in it

                string SQL = SQLStatement.Text.Replace("\n", " \" + \n" + tab + "\"").Replace("\r", "");

                sb.Append(tab + "string sql =\"" + SQL + "\";\n\n");
                sb.Append(tab + "SqlConnection cn = new SqlConnection(\"" + txtConnectionString.Text + "\");\n\n");
                sb.Append(tab + "cn.Open();\n\n");
                sb.Append(tab + "SqlCommand cmd = new SqlCommand(sql,cn);\n\n");
                sb.Append(tab + "SqlDataReader r = cmd.ExecuteReader();\n\n");

                sb.Append(tab + "while (r.Read())\n");
                sb.Append(tab + "{\n");

                tab = stab + "\t\t\t";

                sb.Append(tab + @"// Do the read and class stuffage here" + "\n");
                sb.Append(tab + CLASSNAME + " TheClass = new " + CLASSNAME + "();\n\n");

                sb.Append(tab + @"// TODO: Implement the field reader" + "\n");

                // Implement field stuffer here
                
                sb.Append(tab + "Copyfields(r,TheClass);\n\n");

                sb.Append(tab + "My" + CLASSNAME + "s.Add(TheClass);\n\n");

                tab = stab + "\t\t";

                sb.Append(tab + "}\n\n");

                sb.Append(tab + "r.Close();\n");
                sb.Append(tab + "cmd.Cancel();\n");
                sb.Append(tab + "cmd.Dispose();\n");
                sb.Append(tab + "cn.Close();\n");
                sb.Append(tab + "cn.Dispose();\n");

            }
            else
            {
                sb.Append(tab + @"// Populate the list here with something" + "\n\n");
            }

            sb.Append(tab + "return My" + CLASSNAME + "s;\n\n");

            tab = stab + "\t";

            sb.Append(tab + "}\n\n");

            // INSTANCE GETTER
                        
            sb.Append(tab + "[HttpGet(\"{id}\")]\n");
            sb.Append(tab + "public " + CLASSNAME + " Get(long id)\n");
            sb.Append(tab + "{\n\n");

            tab = stab + "\t\t";

            sb.Append(tab + @"// Return a specific instance of " + CLASSNAME + "\n\n");
            sb.Append(tab + "return new " + CLASSNAME + "();\n\n");
            tab = stab + "\t";
            sb.Append(tab + "}\n\n");

            // POSTER

            sb.Append(tab + "[HttpPost]\n");
            sb.Append(tab + "public void Post([FromBody] " + CLASSNAME + " value )\n");
            sb.Append(tab + "{\n\n");

            sb.Append(tab + "}\n\n");

            // PUTTER

            sb.Append(tab + "[HttpPut(\"{id}\")]\n");
            sb.Append(tab + "public void Put(long id, [FromBody] " + CLASSNAME + " value )\n");
            sb.Append(tab + "{\n\n");

            sb.Append(tab + "}\n\n");

            // DELETER

            sb.Append(tab + "[HttpDelete(\"{id}\")]\n");
            sb.Append(tab + "public void Delete(long id )\n");
            sb.Append(tab + "{\n\n");

            sb.Append(tab + "}\n\n");

            // Private stuff

            sb.Append(tab + "private void Copyfields(SqlDataReader r, " + CLASSNAME + " TheClass)\n");
            sb.Append(tab + "{\n\n");
            tab += "\t";
            string s = "";

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME")
                {
                    s += tab + "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += tab + "{\n";
                    s += tab + "\tTheClass." + f.FieldNameConverted + " = r[\"" + f.FieldName + "\"] + \"\";\n";
                    s += tab + "}\n\n";
                }

                if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT")
                {
                    s += tab + "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += tab + "{\n";
                    s += tab + "\tTheClass." + f.FieldNameConverted + " = Convert.ToInt32(r[\"" + f.FieldName + "\"]);\n";
                    s += tab + "}\n\n";
                }

                if (f.FieldType == "BIGINT")
                {
                    s += tab + "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += tab + "{\n";
                    s += tab + "\tTheClass." + f.FieldNameConverted + " = Convert.ToInt64(r[\"" + f.FieldName + "\"]);\n";
                    s += tab + "}\n\n";
                }

                if (f.FieldType == "DECIMAL" || f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                {
                    s += tab + "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += tab + "{\n";
                    s += tab + "\tTheClass." + f.FieldNameConverted + " = Convert.ToDouble(r[\"" + f.FieldName + "\"]);\n";
                    s += tab + "}\n\n";
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += tab + "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += tab + "{\n";
                    s += tab + "\tTheClass." + f.FieldNameConverted + " = Convert.ToDateTime(r[\"" + f.FieldName + "\"]);\n";
                    s += tab + "}\n\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += tab + "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += tab + "{\n";
                    s += tab + "\tTheClass." + f.FieldNameConverted + " = Convert.ToBoolean(r[\"" + f.FieldName + "\"]);\n";
                    s += tab + "}\n\n";
                }
            }

            tab = stab + "\t";
            s += tab + "}\n\n";

            sb.Append(s);

            tab = stab;

            sb.Append(tab + "}\n\n");

            if (chkFullController.Checked)
            {
                sb.Append("}\n\n");
            }


            fcController.Text = sb.ToString();

        }

        //private string GenerateCopyFieldsMethod()
        //{
        //    string s = "";

        //    s += "public void CopyFields(SqlDataReader r)\n";
        //    s += "{\n";
        //    s += "try\n";
        //    s += "{\n";

        //    foreach (Field f in TheFields)
        //    {
        //        if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
        //            f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
        //            f.FieldType == "SYSNAME")
        //        {
        //            s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
        //            s += "{\n";
        //            s += "_" + f.FieldNameConverted + " = r[\"" + f.FieldName + "\"] + \"\";\n";
        //            s += "}\n";
        //        }

        //        if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT")
        //        {
        //            s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
        //            s += "{\n";
        //            s += "_" + f.FieldNameConverted + " = Convert.ToInt32(r[\"" + f.FieldName + "\"]);\n";
        //            s += "}\n";
        //        }

        //        if (f.FieldType == "BIGINT")
        //        {
        //            s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
        //            s += "{\n";
        //            s += "_" + f.FieldNameConverted + " = Convert.ToInt64(r[\"" + f.FieldName + "\"]);\n";
        //            s += "}\n";
        //        }

        //        if (f.FieldType == "DECIMAL" || f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
        //        {
        //            s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
        //            s += "{\n";
        //            s += "_" + f.FieldNameConverted + " = Convert.ToDouble(r[\"" + f.FieldName + "\"]);\n";
        //            s += "}\n";
        //        }

        //        if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
        //        {
        //            s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
        //            s += "{\n";
        //            s += "_" + f.FieldNameConverted + " = Convert.ToDateTime(r[\"" + f.FieldName + "\"]);\n";
        //            s += "}\n";
        //        }

        //        if (f.FieldType == "BOOL" || f.FieldType == "BIT")
        //        {
        //            s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
        //            s += "{\n";
        //            s += "_" + f.FieldNameConverted + " = Convert.ToBoolean(r[\"" + f.FieldName + "\"]);\n";
        //            s += "}\n";
        //        }
        //    }

        //    s += "}\n";
        //    s += "catch (Exception ex)\n";
        //    s += "{\n";
        //    s += "throw(new Exception(\"" + TableName + ".CopyFields \" +  ex.ToString()));\n";
        //    s += "}\n";
        //    s += "}\n\n";

        //    return s;
        //}

        private void TaigQuerySchema_Load(object sender, EventArgs e)
        {

        }

        private void btnPresetDBs_Click(object sender, EventArgs e)
        {
            frmPresetDBs frm = new frmPresetDBs();

            frm.ShowDialog();

            if (frm.frmOK)
            {
                txtConnectionString.Text = frm.selectedDB;
            }

            frm.Dispose();
            frm = null;
        }
    }
}
