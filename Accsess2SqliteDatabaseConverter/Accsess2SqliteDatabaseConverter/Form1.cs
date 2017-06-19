using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accsess2SqliteDatabaseConverter
{
    public partial class Form1 : Form
    {

        AccessConnect AcessDb;
        private delegate void UpdateStatusDelegate();
        private UpdateStatusDelegate updateStatusDelegate = null;
        private Thread workerThread = null;
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btn_select_acces_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;
            of.Filter = "Access database|*.mdb";
            of.Title = "Select Access database...";
            if (of.ShowDialog() == DialogResult.OK)
            {
                txtAccessPath.Text = of.FileName;
                GetTables();
            }
        }
        private void GetTables()
        {
            AcessDb = new AccessConnect(txtAccessPath.Text);
            List<string> tables = AcessDb.GetTableNames();
            foreach (string s in tables)
            {
                checkTableNames.Items.Add(s);
            }
        }

        private void checkTableNames_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
           for(int i=0;i<checkTableNames.Items.Count;i++){

               checkTableNames.SetItemChecked(i, true);
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkTableNames.Items.Count; i++)
            {

                checkTableNames.SetItemChecked(i, false);
            }
        }

        private List<string> GetSelectedTables()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < checkTableNames.Items.Count; i++)
            {
                if (checkTableNames.GetItemChecked(i))
                    result.Add(checkTableNames.Items[i].ToString());
            }
            this.selectedCount = result.Count;
            return result;
        }
        int counter = 0;
        int selectedCount = 0;
        private void UpdateStatus()
        {
            counter++;
            lblstatus.Text = counter.ToString() + "/" + selectedCount.ToString();
            if (counter >= selectedCount)
            {
                MessageBox.Show("Operation completed");
            }
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtAccessPath.Text == string.Empty)
            {
                MessageBox.Show("please select database to convert","error");
                return;
            }
            this.updateStatusDelegate = new UpdateStatusDelegate(this.UpdateStatus);

            //running conversation in a thread to prevent windows from freezing! because of heavy operation
            this.workerThread = new Thread(new ThreadStart(this.Convert));
            this.workerThread.Start();
        }
        private void Convert()
        {

            List<string> selectedTables = GetSelectedTables();
            if (selectedTables.Count == 0)
                return;

            sqliteClass sqliteDb = new sqliteClass();
            for (int i = 0; i < selectedTables.Count; i++)
            {
                string table = selectedTables[i];
                sqliteDb.CreateTable(table);

                DataTable dt = AcessDb.GetTable(table);
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    string word = dt.Rows[j]["word"].ToString();
                    string image = dt.Rows[j]["image"].ToString();
                    sqliteDb.InsertRow(word, image, table);
                }
                //sending operation status to update current status
                this.Invoke(this.updateStatusDelegate);
            }
        }

    }
}
