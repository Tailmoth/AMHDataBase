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

            //Establishing a connection to the database to enter new entry data.
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb");
            OleDbCommand cmd = new OleDbCommand("select * from AMH_Entries where entryTitle=@entryTitle", con);
            cmd.Parameters.AddWithValue("@entryTitle", tbEditTitle.Text.ToLower());
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();

            try
            {


                if (dr.HasRows)
                {
                    MessageBox.Show("Record(s) already exists in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    tbEditAddTags.Clear();
                    tbEditLongDesc.Clear();
                    tbEditShortDesc.Clear();
                    tbEditTitle.Clear();
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
                    tbEditTitle.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inserting records.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            lbEditTagView.Items.RemoveAt(lbEditTagView.SelectedIndex);


        }

        private void btEditAdd_Click(object sender, EventArgs e)
        {
           

        }

        private void btTagAdd_Click(object sender, EventArgs e)
        {

            string currentTag = tbEditAddTags.Text;
            lbEditTagView.Items.Add(currentTag);

            tbEditAddTags.Clear(); ;
            tbEditAddTags.Focus();

            //Establishing a connection to the database to enter new tag data.
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb");
            OleDbCommand cmd = new OleDbCommand("select * from AMH_Tags where tagName=@tagName", con);
            cmd.Parameters.AddWithValue("@tagName", tbEditAddTags.Text.ToLower());
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();

            try
            {


                if (dr.HasRows)
                {
                    MessageBox.Show("Tag already exists in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    tbEditAddTags.Clear();
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmd = new OleDbCommand("insert into AMH_Tags(tagName) values(@tagName)", con);
                    cmd.Parameters.AddWithValue("@tagName", tbEditAddTags.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Tag saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbEditAddTags.Clear();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inserting records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEditAddImage_Click(object sender, EventArgs e)
        {
            //Establishing a connection to the database to enter new attachment data
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb");
            OleDbCommand cmd = new OleDbCommand("select * from AMH_Attachments where attachmentFile=@attachmentFile", con);
            cmd.Parameters.AddWithValue("@attachmentFile", pbRegister.Image);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();


            try
            {


                if (dr.HasRows)
                {
                    MessageBox.Show("Attachment already exists in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();

                }
                else
                {
                    con.Close();
                    con.Open();
                    cmd = new OleDbCommand("insert into AMH_Attachments(attachmentFile) values(@attachmentFile)", con);
                    cmd.Parameters.AddWithValue("@attachmentFile", pbRegister);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Attachment saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inserting records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        

        
    }
}
