using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AeroMaterialHandlingDatabaseApplication
{
    public partial class fEditPage : Form
    {


        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Aero_Material_Handling.accdb");
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataTable dt;
        string sql;
        public fEditPage()
        {
            InitializeComponent();
        }
        private int login(string sql)
        {
            int maxrow = 0;
            //A try/catch/finally statement is used to ensure the application doesn't crash when login is unsuccessful.
            try
            {
                con.Open();
                cmd = new OleDbCommand();
                da = new OleDbDataAdapter();
                dt = new DataTable();
                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                maxrow = dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return maxrow;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //hello world

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {

            lbEditTagView.Items.Add(tbEditAddTags);

            string title = tbEditTitle.Text;
            string shortDesc = tbEditShortDesc.Text;
            string longDesc = tbEditLongDesc.Text;

            //QUERIES
            
            //
            for(int i = 0; i <= lbEditTagView.Items.Count; i++)
            {
                //INSERT INTO AMH_Tags(tagName) VALUE(lbEditTagView.SetSelected(i))
            }


            //INSERT INTO AMH_Entries(entryTitle, enteredBy, entryDate, entryDetails, entryConfidence, entyrVerify) VALUES(title, ) THIS QUERY NEEDS TO BE FINISHED

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbEditLongDesc.Text = "";
            tbEditShortDesc.Text = "";
            tbEditTitle.Text = "";
            tbEditAddTags.Text = "";
            lbEditTagView.Items.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbRegister_Click(object sender, EventArgs e)
        {

        }

        private void btTagAdd_Click(object sender, EventArgs e)
        {
            string currentTag = tbEditAddTags.Text;
            lbEditTagView.Items.Add(currentTag);

            tbEditAddTags.Text = "";
            tbEditAddTags.Focus();

            
        }

        private void btEditDeleteTag_Click(object sender, EventArgs e)
        {
            lbEditTagView.Items.RemoveAt(lbEditTagView.SelectedIndex);
        }
    }
}
