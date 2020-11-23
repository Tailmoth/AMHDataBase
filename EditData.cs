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

        
        public fEditPage()
        {
            InitializeComponent();
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
            
            string amhDatabase = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb";
            string entries = "insert into AMH_Entries (entryTitle,entryDescShort,entryDescLong) values ('" + this.tbEditTitle.Text + "','" + this.tbEditShortDesc.Text + "','" + this.tbEditLongDesc.Text + "')";
            OleDbConnection con = new OleDbConnection(amhDatabase);
            OleDbCommand cmd = new OleDbCommand(entries, con);
            OleDbDataReader dbr;
            try
            {
                con.Open();
                dbr = cmd.ExecuteReader();
                MessageBox.Show("Entry saved.", "Save",MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void pbRegister_Click(object sender, EventArgs e)
        {
            AllowDrop = true;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void fEditPage_Load(object sender, EventArgs e)
        {
            

        }

        private void btEditDeleteTag_Click(object sender, EventArgs e)
        {
          


        }

        private void btEditAdd_Click(object sender, EventArgs e)
        {



        }

        private void btTagAdd_Click(object sender, EventArgs e)
        {
            string amhDatabase = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb";
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

        private void btEditAddImage_Click(object sender, EventArgs e)
        {
            string amhDatabase = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb";
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
