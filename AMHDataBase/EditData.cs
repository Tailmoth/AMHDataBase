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
        //connect to database
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Aero_Material_Handling.accdb");
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataTable dt;
        string sql;


        public fEditPage()
        {
           
            InitializeComponent();
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //may need to change this?
            clbTagList.Items.Add(tbEditAddTags);

            //Establishing a connection to the database to enter new entry data.
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb");
            OleDbCommand cmd = new OleDbCommand("select * from AMH_Entries where entryTitle=@entryTitle", con);
            cmd.Parameters.AddWithValue("@entryTitle", tbEditTitle.Text.ToLower());
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            //Attempt to save entry to database.
            try
            {


                if (dr.HasRows)
                {
                    MessageBox.Show("Record(s) already exists in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    //Edit Tags changes here
                    //tbEditAddTags.Clear();
                    //change to fit Checklistbox
                    clbTagList.Items.Clear();
                    tbEditLongDesc.Clear();
                    tbEditShortDesc.Clear();
                    tbEditTitle.Clear();
                    //Please add in the change here to associate multiple tags with this 
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmd = new OleDbCommand("insert into AMH_Entries(entryTitle,entryDescShort,entryDescLong) values(@entryTitle,@entryDescShort,@entryDescLong)", con);
                    cmd.Parameters.AddWithValue("@entryTitle", tbEditTitle.Text);
                    cmd.Parameters.AddWithValue("@entryDescShort", tbEditShortDesc.Text);
                    cmd.Parameters.AddWithValue("@entryDescLong", tbEditLongDesc.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbEditAddTags.Clear();
                    tbEditLongDesc.Clear();
                    tbEditShortDesc.Clear();
                    clbTagList.Items.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inserting records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btTagAdd_Click(object sender, EventArgs e)
        {

            //Establishing a connection to the database to enter new tag data.
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb");
            OleDbCommand cmd = new OleDbCommand("select * from AMH_Tags where tagName=@tagName", con);
            cmd.Parameters.AddWithValue("@tagName", tbEditAddTags.Text.ToLower());
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            //attempts to either add tag to entry or to entry and database
            try
            {
                
                if(dr.HasRows)
                {
                    clbTagList.Items.Add(tbEditAddTags.Text);
                    tbEditAddTags.Clear();
                    tbEditAddTags.Focus();
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmd = new OleDbCommand("insert into AMH_Tags(tagName) values(@tagName)", con);
                    cmd.Parameters.AddWithValue("@tagName", tbEditAddTags.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Tag added to database.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clbTagList.Items.Add(tbEditAddTags.Text);
                    tbEditAddTags.Clear();
                    tbEditAddTags.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Adding Tag.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        ////Added this to for enter? 
        //private void tbEditAddTags_Enter(object sender, EventArgs e)
        //{
        //    //Establishing a connection to the database to enter new tag data.
        //    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb");
        //    OleDbCommand cmd = new OleDbCommand("select * from AMH_Tags where tagName=@tagName", con);
        //    cmd.Parameters.AddWithValue("@tagName", tbEditAddTags.Text.ToLower());
        //    con.Open();
        //    OleDbDataReader dr = cmd.ExecuteReader();
        //    //attempts to either add tag to entry or to entry and database
        //    try
        //    {

        //        if (dr.HasRows)
        //        {
        //            clbTagList.Items.Add(tbEditAddTags.Text);
        //            tbEditAddTags.Clear();
        //            tbEditAddTags.Focus();
        //        }
        //        else
        //        {
        //            con.Close();
        //            con.Open();
        //            cmd = new OleDbCommand("insert into AMH_Tags(tagName) values(@tagName)", con);
        //            cmd.Parameters.AddWithValue("@tagName", tbEditAddTags.Text);
        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //            MessageBox.Show("Tag added to database.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            clbTagList.Items.Add(tbEditAddTags.Text);
        //            tbEditAddTags.Clear();
        //            tbEditAddTags.Focus();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Error Adding Tag.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}

        private void btClear_Click(object sender, EventArgs e)
        {
            //added to clear check list
            clbTagList.Items.Clear();
            //
            tbEditAddTags.Clear();
            tbEditLongDesc.Clear();
            tbEditShortDesc.Clear();
            clbTagList.Items.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btEditAddImage_Click(object sender, EventArgs e)
        {
          //prompt user to find image and add to database.
        }

 
    }
}
