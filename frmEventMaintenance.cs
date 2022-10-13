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
    public partial class EventForm : Form
    {
        private dataModule DM;
        private mainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmArena;
        public EventForm(dataModule dm, mainForm mn)
        {
            InitializeComponent();
            DM = dm;   
            frmMenu = mn;

            pnAddEvent.Visible = false;
            pnAddEvent.Top = 12;
            pnAddEvent.Left = 12;

            pnUpEvent.Left = 12;
            pnUpEvent.Top = 12;
            pnUpEvent.Visible = false;

            this.Width = 900;
            this.Height = 500;

            
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsEsport, "Event"];
            cmArena = (CurrencyManager)this.BindingContext[DM.dsEsport, "Arena"];
            BindingControl();

        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }

        // binding controls textfiled with listbox items
        private void BindingControl()
        {
           

           


            tbEventId.DataBindings.Add("Text", DM.dsEsport, "Event.EventID");
            tbArenId.DataBindings.Add("Text", DM.dsEsport, "Event.ArenaID");
            tbEventName.DataBindings.Add("Text", DM.dsEsport, "Event.EventName");
            tbStatus.DataBindings.Add("Text", DM.dsEsport, "Event.Status");
            tbCapacity.DataBindings.Add("Text", DM.dsEsport, "Event.Capacity");
            tbEventDate.DataBindings.Add("Text", DM.dsEsport, "Event.EventDate");
            tbArenaName.DataBindings.Add("Text", DM.dsEsport, "Arena.ArenaName");
            lbEventMaintenance.DataSource = DM.dsEsport;
            lbEventMaintenance.DisplayMember = "Event.EventName";
            lbEventMaintenance.ValueMember = "Event.EventName";

            
           
        }
        // performs navigation up and down in Listbox when Previous  button is clicked.
        private void prev_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }
        // performs navigation up and down in Listbox when next  button is clicked.
        private void next_Click(object sender, EventArgs e)
        {
            if(currencyManager.Position < currencyManager.Count)
            {
                ++currencyManager.Position;
            }
        }

        private void pnBtnAddCancel_Click(object sender, EventArgs e)
        {
            showControls();
            pnAddEvent.Visible = false;
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            pnAddEvent.Visible = true;
            loadComboBox();
            hideControls();
        }
        //disable button on the form visble,
        //according to to add, update panel visibility
        private void hideControls()
        {
            next.Enabled = false;
            prev.Enabled = false;
            btnAddEvent.Enabled = false;
            btnDeleteEvent.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateEvent.Enabled=false;


        }

        //Enable button on the form visble,
        //according to to add, update panel visibility
        private void showControls()
        {
            next.Enabled = true;
            prev.Enabled = true;
            btnAddEvent.Enabled = true;
            btnDeleteEvent.Enabled = true;
            btnReturn.Enabled = true;
            btnUpdateEvent.Enabled = true;


        }
        //add new Event record
        //create  Variable of DataRow type.
        //store user input in varibale and add it t0 dataTable.
        private void pnBtnAddSaveArena_Click(object sender, EventArgs e)
        {
            DataRow newEventRow = DM.dtEvent.NewRow();

            if (pnAddEventName.Text=="" || pnAddCapacity==null || pncbAddStatus.Text==""|| cbAddArenaID.Text == "")
            {
                MessageBox.Show("A mandatory field is empty");
            }
            else
            {
                try
                {
                    newEventRow["EventName"] = pnAddEventName.Text;
                    newEventRow["ArenaID"] = cbAddArenaID.Text;
                    //newEventRow["ArenaName"] = cbAddArenaName.Text;
                    newEventRow["Status"] = pncbAddStatus.Text;
                    newEventRow["Capacity"] = pnAddCapacity.Text;
                    newEventRow["EventDate"] = pnAddEventDate.Text;

                    DM.dtEvent.Rows.Add(newEventRow);
                    DM.updateEvent();

                    MessageBox.Show("Event added successfully");
                    showControls();
                    pnAddEvent.Visible = false;
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("capacity should be number value");
                }
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        //fetch list of input from other table for combobox
        public void loadComboBox()
        {
            cbAddArenaID.DataSource = DM.dsEsport;
            cbAddArenaID.DisplayMember = "Arena.ArenaID";
            cbAddArenaID.ValueMember = "Arena.ArenaID";

            cbAddArenaName.DataSource = DM.dsEsport;
            cbAddArenaName.DisplayMember = "Arena.ArenaName";
            cbAddArenaName.ValueMember = "Arena.ArenaName";

        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
           



        }

        private void btnUpCancel_Click(object sender, EventArgs e)
        {
            showControls();
            pnUpEvent.Visible=false;
        }
        //fetch postiton of selected item in list box and store it in DataRow variable
        //checks input validation and display appropriate message.
        //record is upated if valid date entered.
        private void btnSaveArena_Click(object sender, EventArgs e)
        {
            DataRow updateEventRow = DM.dtEvent.Rows[currencyManager.Position];
            
            

            if (pnUpEventName.Text == "" || pnUpCapacity == null || pnUpStatus.Text == "")
            {
                MessageBox.Show("A mandatory field is empty");
            }
            else
            {
                try
                {
                    updateEventRow["EventName"] = pnUpEventName.Text;
                    updateEventRow["ArenaID"] = Convert.ToInt32(pnUpArenaID.Text);
                    //newEventRow["ArenaName"] = cbAddArenaName.Text;
                    updateEventRow["Status"] = pnUpStatus.Text;
                    updateEventRow["Capacity"] = pnUpCapacity.Text;
                    updateEventRow["EventDate"] = pnUpEventDate.Text;

                    currencyManager.EndCurrentEdit();
                    
                    DM.updateEvent();

                    MessageBox.Show("Event updated successfully");
                    showControls();
                    pnUpEvent.Visible = false;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("capacity should be number value");
                }
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            showControls();
            pnUpEvent.Visible = false;
        }
        //Pass the values of selected record in list box to Update Panel textboxes.
        private void btnUpdateEvent_Click_1(object sender, EventArgs e)
        {
            
            hideControls();
            pnUpEvent.Visible = true;

            pnUpEventID.Text = tbEventId.Text;
            pnUpEventName.Text = tbEventName.Text;
            pnUpArenaID.Text = tbArenId.Text;
            pnUpArenaName.Text = tbArenaName.Text;
            pnUpStatus.Text = tbStatus.Text;
            pnUpCapacity = tbCapacity;
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        // obtain row position as per listbox item selected
        // fetching and storing if child records exist
        // deletes record corresponding to list box item selected
        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            DataRow deleteEventRow = DM.dtEvent.Rows[currencyManager.Position];
            DataRow[] eventChallengeRow = DM.dtChallenge.Select("EventID=" + tbEventId.Text);
            if (eventChallengeRow.Length != 0)
            {
                MessageBox.Show("You may only delete Events that has no challenges");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                         MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEventRow.Delete();
                    DM.updateEvent();
                    MessageBox.Show("Event deleted successfully");
                }
            }
        }
    }
}
