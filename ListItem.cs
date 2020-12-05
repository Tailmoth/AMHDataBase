using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AeroMaterialHandlingDatabaseApplication
{
    public partial class ListItem : UserControl
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb");


        public ListItem()
        {
            InitializeComponent();
        }


        //Create variables for the ListItem
        public string _title;
        public string _tags;
        public string _shortDesc;
        public Image _logo;


        //Populate the text boxes with data from the data base

        public string Title
        {         
            get { return _title; }
            set { _title = value; lblTitleListItem.Text = value; }//change value to a place withing the database
        }

        public string Tags
        {
            get { return _tags; }
            set { _tags = value; lblTagsListItem.Text = value; }//change value to a place withing the database
        }

        public string shortDesc
        {
            get { return _shortDesc; }
            set { _shortDesc = value; tbShortDescListItem.Text = value; }//change value to a place withing the database
        }

        public Image Logo
        {
            get { return _logo; }
            set { _logo = value; pbPictureListItem.Image = value; }
        }

        private void ListItem_Load(object sender, EventArgs e)
        {

        }

        private void lblTitleListItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
