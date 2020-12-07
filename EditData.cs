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
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Threading;
using System.IO;
using System.Diagnostics;


namespace AeroMaterialHandlingDatabaseApplication
{
    public partial class fEditPage : Form
    {
        protected bool validData;
        string path;
        protected Image image;
        protected Thread getImageThread;       
        public fEditPage()
        {
            InitializeComponent();
            this.AcceptButton = btTagAdd;
            gbDragDrop.AllowDrop = true;
            pbRegister.AllowDrop = true;
            lbDragDrop.AllowDrop = true;
            this.lbDragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbDragDrop_DragDrop);
            this.lbDragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbDragDrop_DragEnter);
        }
                        
        private bool GetFilename(out string filename, DragEventArgs e)
        {
            //This code reads the file extension of the image being dropped into picture box (pbRegister)
            bool ret = false;
            filename = String.Empty;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array data = ((IDataObject)e.Data).GetData("FileDrop") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        filename = ((string[])data)[0];
                        string ext = Path.GetExtension(filename).ToLower();
                        if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp") || (ext == ".tif"))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
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
            lbTagList.Items.Add(tbEditAddTags);

            //Establishing a connection to the database to enter new entry data.
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb");
            OleDbCommand cmd = new OleDbCommand("select AMH_Entries.entryTitle, AMH_Entries.entryDescShort, AMH_Entries.entryDescLong, AMH_Tags.tagName, AMH_Attachments.attachmentFile " +
                                                "from(AMH_Tags inner join(AMH_Entries inner join AMH_Tag_Entry on AMH_Entries.entryID = AMH_Tag_Entry.entryID) on AMH_Tags.tagID = AMH_Tag_Entry.tagID) " +
                                                "inner join(AMH_Attachments inner join AMH_Attachment_Entry on AMH_Attachments.attachmentID = AMH_Attachment_Entry.attachmentID) " +
                                                "on AMH_Entries.entryID = AMH_Attachment_Entry.entryID where entryTitle = @entryTitle", con);  
            
            cmd.Parameters.AddWithValue("@entryTitle", tbEditTitle.Text.ToLower());
            cmd.Parameters.AddWithValue("@entryDescShort", tbEditShortDesc.Text.ToLower());
            cmd.Parameters.AddWithValue("@entryDescLong", tbEditLongDesc.Text.ToLower());
            cmd.Parameters.AddWithValue("@tagName", lbTagList.Text.ToLower());
            cmd.Parameters.AddWithValue("@attachmentFile", lbDragDrop.Text.ToLower());


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
                    lbTagList.Items.Clear();
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
                    foreach (string item in lbTagList.Items)
                    {
                        cmd = new OleDbCommand("insert into AMH_Tags(tagName) values(@tagName)", con);
                        cmd.Parameters.AddWithValue("@tagName", item);
                        cmd.ExecuteNonQuery();
                    }
                    foreach (string item in lbDragDrop.Items)
                    {
                        cmd = new OleDbCommand("insert into AMH_Attachments(attachmentFile) values(@attachmentFile)", con);
                        cmd.Parameters.AddWithValue("@attachmentFile", item);
                        cmd.ExecuteNonQuery();
                    }
                }              
            }
            catch (Exception)
            {
                MessageBox.Show("Entry saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbEditAddTags.Clear();
                tbEditLongDesc.Clear();
                tbEditShortDesc.Clear();
                tbEditTitle.Clear();
                lbTagList.Items.Clear();
                lbDragDrop.Items.Clear();
            }
            finally
            {
                //MessageBox.Show("Error inserting records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void btClear_Click(object sender, EventArgs e)
        {
            tbEditAddTags.Clear();
            tbEditLongDesc.Clear();
            tbEditShortDesc.Clear();
            tbEditTitle.Clear();
            lbTagList.Items.Clear();
            pbRegister.Image = null;
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
            //Deletes tags from listbox
            while (lbTagList.SelectedItems.Count > 0)
            {
                lbTagList.Items.Remove(lbTagList.SelectedItems[0]);
            }

        }

        private void btEditAdd_Click(object sender, EventArgs e)
        {
           

        }

        private void btTagAdd_Click(object sender, EventArgs e)
        {
            ////Establishing a connection to the database to enter new tag data.
            //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb");
            //OleDbCommand cmd = new OleDbCommand("select * from AMH_Tags where tagName=@tagName", con);
            //cmd.Parameters.AddWithValue("@tagName", tbEditAddTags.Text.ToLower());
            //con.Open();
            //OleDbDataReader dr = cmd.ExecuteReader();
            ////attempts to either add tag to entry or to entry and database
            //try
            //{

            //    if (dr.HasRows)
            //    {
            //        clbTagList.Items.Add(tbEditAddTags.Text);
            //        tbEditAddTags.Clear();
            //        tbEditAddTags.Focus();
            //    }
            //    else
            //    {
            //        con.Close();
            //        con.Open();
            //        cmd = new OleDbCommand("insert into AMH_Tags(tagName) values(@tagName)", con);
            //        cmd.Parameters.AddWithValue("@tagName", tbEditAddTags.Text);
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //        MessageBox.Show("Tag added to database.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        clbTagList.Items.Add(tbEditAddTags.Text);
            //        tbEditAddTags.Clear();
            //        tbEditAddTags.Focus();
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error Adding Tag.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}



            string currentTag = tbEditAddTags.Text;
            lbTagList.Items.Add(currentTag);

            tbEditAddTags.Clear(); 
            tbEditAddTags.Focus();

            
        }

        private void btEditAddImage_Click(object sender, EventArgs e)
        {
            //Establishing a connection to the database to enter new attachment data
            //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb");
            //OleDbCommand cmd = new OleDbCommand("select * from AMH_Attachments where attachmentFile=@attachmentFile", con);
            //cmd.Parameters.AddWithValue("@attachmentFile", pbRegister.Image);
            //con.Open();
            //OleDbDataReader dr = cmd.ExecuteReader();

            //try
            //{


            //    if (dr.HasRows)
            //    {
            //        MessageBox.Show("Attachment already exists in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        con.Close();

            //    }
            //    else
            //    {
            //        con.Close();
            //        con.Open();
            //        cmd = new OleDbCommand("insert into AMH_Attachments(attachmentFile) values(@attachmentFile)", con);
            //        cmd.Parameters.AddWithValue("@attachmentFile", pbRegister.Image);
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //        MessageBox.Show("Attachment saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error inserting records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void tbEditAddTags_Enter(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void gbDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void gbDragDrop_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbRegister_DragEnter(object sender, DragEventArgs e)
        {
            string filename;
            validData = GetFilename(out filename, e);
            if (validData)
            {
                path = filename;
                getImageThread = new Thread(new ThreadStart(LoadImage));
                getImageThread.Start();
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void pbRegister_DragDrop(object sender, DragEventArgs e)
        {
            if (validData)
            {
                while (getImageThread.IsAlive)
                {
                    Application.DoEvents();
                    Thread.Sleep(0);
                }
                pbRegister.Image = image;
            }
        }
        protected void LoadImage()
        {
            image = new Bitmap(path);
        }
              
        private void lbDragDrop_DragDrop(object sender, DragEventArgs e)
        {            
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
                lbDragDrop.Items.Add(Path.GetFileName(s[i]));
        }

        private void lbDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void btEditRemove_Click(object sender, EventArgs e)
        {
            //Deletes item from the drag and drop listbox
            while (lbDragDrop.SelectedItems.Count > 0)
            {
                lbDragDrop.Items.Remove(lbDragDrop.SelectedItems[0]);
            }
        }
    }
}
