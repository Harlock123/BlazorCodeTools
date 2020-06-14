using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlazorCodeTools
{
    public partial class frmTablesViews : Form
    {
        private string Connection = "";

        public string SELECTEDTABLE = "";

        public frmTablesViews()
        {
            InitializeComponent();
        }

        public frmTablesViews(string connection)
        {
            InitializeComponent();

            Connection = connection;

            string SQL = "SELECT * FROM INFORMATION_SCHEMA.TABLES ORDER BY TABLE_NAME";

            TAIGTablesViews.PopulateGridWithData(Connection, SQL);
        }

        private void HandleCellDoubleclicked(object sender, int RowClicked, int ColumnClicked)
        {
            SELECTEDTABLE = TAIGTablesViews.get_item(RowClicked, "TABLE_NAME");
            Hide();
        }
    }
}
