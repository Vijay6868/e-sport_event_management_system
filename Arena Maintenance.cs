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

namespace week2
{
    public partial class ArenaForm : Form
    {
        private dataModule DM;
        private mainForm frmMenu;
        private CurrencyManager currencyManager;

        
        
        public ArenaForm(dataModule dm ,mainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            bindControls();
            this.Width = 900;
            this.Height = 500;
            pnlAddArena.Left = 12;
            pnlAddArena.Top = 12;

            pnUpdateArena.Left = 12;
            pnUpdateArena.Top = 12;

        }

        private void city_Click(object sender, EventArgs e)
        {

        }

        private void Arena_Maintenance_Load(object sender, EventArgs e)
        {

        }
        // binding controls textfiled with listbox items
        public void bindControls()
        {
            tbArenId.DataBindings.Add("Text", DM.dsEsport, "Arena.ArenaId");
            tbArenaName.DataBindings.Add("Text", DM.dsEsport, "Arena.ArenaName");
            tbStreetAddress.DataBindings.Add("Text", DM.dsEsport, "Arena.StreetAddress");
            tbSuburb.DataBindings.Add("Text", DM.dsEsport, "Arena.Suburb");
            tbCity.DataBindings.Add("Text", DM.dsEsport, "Arena.City");
            tbPhoneNumber.DataBindings.Add("Text", DM.dsEsport, "Arena.PhoneNumber");
            lbMaintenance.DataSource = DM.dsEsport;
            lbMaintenance.DisplayMember = "Arena.ArenaName";
            lbMaintenance.ValueMember = "Arena.ArenaName";

            currencyManager = (CurrencyManager)this.BindingContext[DM.dsEsport, "Arena"];
            pnlAddArena.Visible = false;

        }
        // performs navigation up and down in Listbox when previous  button are clicked.
        private void prev_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }
        // performs navigation up and down in Listbox when next  button are clicked.
        private void next_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count-1)
            {
                ++currencyManager.Position;
            }
        }

        private void ret_Click(object sender, EventArgs e)
        {
            Close();
        }
        //display Panel Add Arena 
        private void add_Click(object sender, EventArgs e)
        {
            hideControls();
            pnlAddArena.Visible = true;
            
        }
        // obtain row position as per listbox item selected
        // fetching and storing if child records exist
        // deletes record corresponding to list box item selected
        private void delete_Click(object sender, EventArgs e)
        {
            DataRow deleteArenaRow = DM.dtArena.Rows[currencyManager.Position];
            DataRow[] eventRow = DM.dtEvent.Select("ArenaID=" + tbArenId.Text);
            if(eventRow.Length != 0)
            {
                MessageBox.Show("This Arena has scheduled events, cannot delete this Arena !!");
            }
            else
            {
               if(MessageBox.Show("Are you sure about deleting this Arena???","warning",
                                        MessageBoxButtons.OKCancel) == DialogResult.OK){
                    deleteArenaRow.Delete();
                    DM.updateArena();
                }
            }
            
        }
        //add new Arena record
        //create  Variable of DataRow type.
        //store user input in varibale and add it to dataTable.
        private void btnSaveArena_Click(object sender, EventArgs e)
        {
            tbArenId.Text = null;
            DataRow newArenaRow = DM.dtArena.NewRow();

            if (tbAddArenaName.Text == null || tbAddStreetAddress.Text == null || tbAddSuburb.Text ==""  || tbAddCity.Text == "" || tbAddPhoneNumber.Text == "")
            {
                MessageBox.Show("one or more field is empty !! you must enter all the fields");
            }
            else
            {
                newArenaRow["ArenaName"] = tbAddArenaName.Text;
                newArenaRow["StreetAddress"] = tbAddStreetAddress.Text;
                newArenaRow["Suburb"] = tbAddSuburb.Text;
                newArenaRow["City"] = tbAddCity.Text;
                newArenaRow["PhoneNumber"] = tbAddPhoneNumber.Text;
                DM.dtArena.Rows.Add(newArenaRow);



                MessageBox.Show("Arena added successfully !!!");
                DM.updateArena();
                pnlAddArena.Visible = false;
                showControls();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           showControls();
            pnlAddArena.Visible = false;

        }

        //Pass the values of selected record in list box to Update Panel textboxes.
        

        private void btnUpdateArena_Click(object sender, EventArgs e)
        {
            pnUpdateArena.Visible = true;
            hideControls();

            pnUpArenaName.Text=tbArenaName.Text;
            pnUpStreetAdress.Text=tbStreetAddress.Text;
            pnUpSuburb.Text=tbSuburb.Text;
            pnUpcbCity.Text=tbCity.Text;
            pnUpPhoneNumber.Text=tbPhoneNumber.Text;
        }

        //make buttons visible on the form,
        //according to add, update panel visibility
        private void showControls()
        {
            lbMaintenance.Visible = true;
            btnAddArena.Visible = true;
            btnDeleteArena.Visible = true;
            btnNext.Visible = true;
            btnPrevious.Visible = true;
            btnUpdateArena.Visible = true;
            btnReturn.Visible = true;
        }
        private void hideControls()
        {
            lbMaintenance.Visible = false;
            btnAddArena.Visible = false;
            btnDeleteArena.Visible = false;
            btnNext.Visible = false;
            btnPrevious.Visible = false;
            btnUpdateArena.Visible = false;
            btnReturn.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnUpdateArena.Visible = false;
            showControls();
        }
        
        //fetch postiton of selected item in list box and store it in DataRow variable
        //checks input validation and display appropriate message.
        //record is upated if valid date entered.

        private void pnBtnUpArena_Click(object sender, EventArgs e)
        {
            DataRow updateArenaRow = DM.dtArena.Rows[currencyManager.Position];
            if (tbArenaName.Text == null || tbStreetAddress.Text == null || tbSuburb.Text == null || tbCity == null || tbPhoneNumber == null)
            {
                MessageBox.Show("one or more field is empty !! you must enter all the fields");
            }
            else
            {
                updateArenaRow["ArenaName"] = pnUpArenaName.Text;
                updateArenaRow["StreetAddress"] = pnUpStreetAdress.Text;
                updateArenaRow["Suburb"] = pnUpSuburb.Text;
                updateArenaRow["City"] = pnUpcbCity.Text;
                updateArenaRow["PhoneNumber"] = pnUpPhoneNumber.Text;

                
                currencyManager.EndCurrentEdit();
                DM.updateArena();
                MessageBox.Show("Arena updated successfully !!");

                pnUpdateArena.Visible = false;
                showControls();
            }
        }

        private void pnlAddArena_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
