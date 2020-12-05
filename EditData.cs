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


namespace AeroMaterialHandlingDatabaseApplication
{
    public partial class fEditPage : Form
    {

        //private List<System.Object> _OutlookSelectedItems = null;
        //private Outlook.Explorer _OutlookActiveExplorer = null;
        //private System.Timers.Timer _SelectionTimer = null;
        //private Int32 iTimerCount = 0;
        public fEditPage()
        {
            InitializeComponent();
            this.AcceptButton = btTagAdd;
            gbDragDrop.AllowDrop = true;

        }
        void _SelectionTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //_SelectionTimer.Stop();

            //// Try to restore the selected items
            //OutlookRestoreSelection();
            
            //if (_OutlookActiveExplorer.Selection.Count == _OutlookSelectedItems.Count)
            //{
            //    _OutlookSelectedItems.Clear();
            //}
            //else
            //{                
            //    iTimerCount++;
            //    if (iTimerCount < 50)
            //        _SelectionTimer.Start();
            //}
        }
        private void OutlookDragDrop()
        {            
            //Outlook.Application oOutlook = new Outlook.Application();
            //if (!oOutlook.Version.StartsWith("14"))
            //{                
            //    return;
            //}

            //Outlook.Explorer oExplorer = oOutlook.ActiveExplorer();
            //Outlook.Folder oFolder = (Outlook.Folder)oExplorer.CurrentFolder;

            //// Save all the selected items
            //_OutlookSelectedItems = new List<System.Object>();
            //for (int i = 1; i <= oExplorer.Selection.Count; i++)
            //{
            //    _OutlookSelectedItems.Add(oExplorer.Selection[i]);
            //}

            
            //oExplorer.CurrentFolder = oOutlook.GetNamespace("MAPI").GetDefaultFolder(Outlook.OlDefaultFolders.olFolderOutbox);
            //oExplorer.CurrentFolder = oFolder;

            
            //_OutlookActiveExplorer = oExplorer;
            //iTimerCount = 0;
            //_SelectionTimer.Start();

        }
        private void OutlookRestoreSelection()
        {
            //Try to reselect all the items we have in the selection list
            //_OutlookActiveExplorer.ClearSelection();
            //if (_OutlookSelectedItems.Count > 0)
            //{
            //    for (int i = 0; i < _OutlookSelectedItems.Count; i++)
            //    {
            //        try
            //        {
            //            _OutlookActiveExplorer.AddToSelection(_OutlookSelectedItems[i]);
            //        }
            //        catch
            //        {
            //        }
            //    }
            //}
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
            clbTagList.Items.Add(tbEditAddTags);

            //Establishing a connection to the database to enter new entry data.
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb");
            OleDbCommand cmd = new OleDbCommand("select AMH_Entries.entryTitle, AMH_Entries.entryDescShort, AMH_Entries.entryDescLong, AMH_Tags.tagName, AMH_Attachments.attachmentFile " +
                                                "from(AMH_Tags inner join(AMH_Entries inner join AMH_Tag_Entry on AMH_Entries.entryID = AMH_Tag_Entry.entryID) on AMH_Tags.tagID = AMH_Tag_Entry.tagID) " +
                                                "inner join(AMH_Attachments inner join AMH_Attachment_Entry on AMH_Attachments.attachmentID = AMH_Attachment_Entry.attachmentID) " +
                                                "on AMH_Entries.entryID = AMH_Attachment_Entry.entryID where entryTitle = @entryTitle", con);  
            
            cmd.Parameters.AddWithValue("@entryTitle", tbEditTitle.Text.ToLower());
            cmd.Parameters.AddWithValue("@entryDescShort", tbEditShortDesc.Text.ToLower());
            cmd.Parameters.AddWithValue("@entryDescLong", tbEditLongDesc.Text.ToLower());
            cmd.Parameters.AddWithValue("@tagName", clbTagList.Text.ToLower());

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
                    clbTagList.Items.Clear();
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmd = new OleDbCommand("insert into AMH_Entries(entryTitle,entryDescShort,entryDescLong) values(@entryTitle,@entryDescShort,@entryDescLong)", con);              
                    cmd.Parameters.AddWithValue("@entryTitle", tbEditTitle.Text);
                    cmd.Parameters.AddWithValue("@entryDescShort", tbEditShortDesc.Text);
                    cmd.Parameters.AddWithValue("@entryDescLong", tbEditLongDesc.Text);

                    con.Close();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    //string[] tagholder = new string[0];
                    //for (int x = 0; x <= clbTagList.Items.Count; x++)
                    //{
                    //    tagholder[x] = clbTagList.Items[x].ToString();
                    //}
                    foreach (string item in clbTagList.Items)
                    {

                        using (OleDbCommand cmd2 = new OleDbCommand("insert into AMH_Tags (tagName) values (@tagName)", con))
                        {
                            cmd2.Parameters.AddWithValue("@tagName", item);
                            cmd2.ExecuteNonQuery();
                        }

                    }


                    //cmd = new OleDbCommand("insert into AMH_Tags(tagName) values (@tagName)", con);
                    //int y = 0;
                    //we tried
                    //while (y < clbTagList.Items.Count)
                    //{
                    //    cmd.Parameters.AddWithValue("@tagName", clbTagList.Text.Equals(clbTagList.Items[y].ToString()));

                    //    y++;
                    //}                   
                    //cmd.Parameters.AddWithValue("@tagName", clbTagList.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Entry saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbEditAddTags.Clear();
                    tbEditLongDesc.Clear();
                    tbEditShortDesc.Clear();
                    tbEditTitle.Clear();
                    clbTagList.Items.Clear();                    
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error inserting records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void btClear_Click(object sender, EventArgs e)
        {
            tbEditAddTags.Clear();
            tbEditLongDesc.Clear();
            tbEditShortDesc.Clear();
            tbEditTitle.Clear();
            clbTagList.Items.Clear();
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
            while (clbTagList.SelectedItems.Count > 0)
            {
                clbTagList.Items.Remove(clbTagList.SelectedItems[0]);
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
            clbTagList.Items.Add(currentTag);

            tbEditAddTags.Clear(); ;
            tbEditAddTags.Focus();

            
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

        private void tbEditAddTags_Enter(object sender, EventArgs e)
        {
            //Establishing a connection to the database to enter new tag data.
            //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb");
            //OleDbCommand cmd = new OleDbCommand("select * from AMH_Tags where tagName=@tagName", con);
            //cmd.Parameters.AddWithValue("@tagName", tbEditAddTags.Text.ToLower());
            //con.Open();
            //OleDbDataReader dr = cmd.ExecuteReader();
            //attempts to either add tag to entry or to entry and database
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
            //        MessageBox.Show("Tag(s) added to database.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        clbTagList.Items.Add(tbEditAddTags.Text);
            //        tbEditAddTags.Clear();
            //        tbEditAddTags.Focus();
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error Adding Tag.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_DragDrop(object sender, DragEventArgs e)
        {
            //tbDragDrop.Lines = e.Data.GetFormats();
            //OutlookDragDrop();

        }

        private void gbDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void gbDragDrop_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }        
    }
}
