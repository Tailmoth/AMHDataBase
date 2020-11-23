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

            //QUERIES

            string amhDatabase = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Aero_Material_Handling.accdb";
            string entries = "insert into AMH_Entries (entryTitle,entryDescShort,entryDescLong) values ('" + this.tbEditTitle.Text + "','" + this.tbEditShortDesc.Text + "','" + this.tbEditLongDesc.Text + "')";
            OleDbConnection con = new OleDbConnection(amhDatabase);
            OleDbCommand cmd = new OleDbCommand(entries, con);
            OleDbDataReader dbr;
            try
            {

                for (int i = 0; i <= lbEditTagView.Items.Count; i++)
                {
                    //loop through the list box and add to database
                }
                

                con.Open();
                dbr = cmd.ExecuteReader();

                MessageBox.Show("Entry saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (dbr.Read())
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error saving entry.", "Error");
            }

            

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            
            tbEditAddTags.Clear();
            tbEditLongDesc.Clear();
            tbEditShortDesc.Clear();
            tbEditTitle.Clear();
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

            tbEditAddTags.Clear(); ;
            tbEditAddTags.Focus();

            string amhDatabase = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Aero_Material_Handling.accdb";
            string tags = "insert into AMH_Tags (tagName) values ('" + this.tbEditAddTags.Text + "')";
            OleDbConnection con = new OleDbConnection(amhDatabase);
            OleDbCommand cmd = new OleDbCommand(tags, con);
            OleDbDataReader dbr;
            try
            {
                con.Open();
                dbr = cmd.ExecuteReader();
                MessageBox.Show("Tag saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (dbr.Read())
                {
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error saving Tag.", "Error");
            }

        }

        private void btEditDeleteTag_Click(object sender, EventArgs e)
        {
            lbEditTagView.Items.RemoveAt(lbEditTagView.SelectedIndex);
        }

        private void btEditAdd_Click(object sender, EventArgs e)
        {

        }

        private void btEditAddImage_Click(object sender, EventArgs e)
        {
            string amhDatabase = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Aero_Material_Handling.accdb";
            string attachment = "insert into AMH_Attachments (attachmentFile) values ('" + this.pbRegister.Image + "')";
            OleDbConnection con = new OleDbConnection(amhDatabase);
            OleDbCommand cmd = new OleDbCommand(attachment, con);
            OleDbDataReader dbr;
            try
            {
                con.Open();
                dbr = cmd.ExecuteReader();
                MessageBox.Show("Attachment saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (dbr.Read())
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error saving Attachment.", "Error");
            }
        }
    }
}
