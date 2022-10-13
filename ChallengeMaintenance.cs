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
    public partial class ChallengeMaintenance : Form
    {
        dataModule DM;
        mainForm frmMenu;
        CurrencyManager currencyManager;
        CurrencyManager cmEvent;

        public ChallengeMaintenance(dataModule dm,mainForm mn)
        {
            InitializeComponent();
            frmMenu = mn;
            DM = dm;
            BindingControl();
            pnAddChallenge.Left = 19;
            pnAddChallenge.Top = 19;

            pnAddChallenge.Visible = false;
            pnUpChallenge.Visible = false;

            pnUpChallenge.Left = 19;
            pnUpChallenge.Top = 19;

            this.Width = 900;
            this.Height = 500;

            cmEvent = (CurrencyManager)this.BindingContext[DM.dsEsport, "Event"];
        }

        private void ChallengeMaintenance_Load(object sender, EventArgs e)
        {

        }
        // binding controls textfiled with listbox items
        private void BindingControl()
        {
            lbChallenge.DataSource= DM.dsEsport;
            lbChallenge.DisplayMember = "Challenge.ChallengeName";
            lbChallenge.ValueMember = "Challenge.ChallengeName";

            tbChallengeId.DataBindings.Add("Text", DM.dsEsport, "Challenge.ChallengeID");
            tbChallengeName.DataBindings.Add("Text", DM.dsEsport, "Challenge.ChallengeName");
            tbEventId.DataBindings.Add("Text", DM.dsEsport, "Challenge.EventID");
            tbStartTime.DataBindings.Add("Text", DM.dsEsport, "Challenge.StartTime");
            tbStatus.DataBindings.Add("Text", DM.dsEsport, "Challenge.Status");
            tbCapacity.DataBindings.Add("Text", DM.dsEsport, "Challenge.Capacity");
            tbEventName.DataBindings.Add("Text", DM.dsEsport, "Event.EventName");
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsEsport, "Challenge"];

        }
        // performs navigation up and down in Listbox when Previous button is clicked.
        private void prev_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }
        // performs navigation up and down in Listbox when Previous button is clicked.
        private void next_Click(object sender, EventArgs e)
        {
            if(currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        //Pass the values of selected record in list box to Update Panel textboxes.
        private void loadEvents()
        {
            addEventName.DataSource = DM.dsEsport;
            addEventName.DisplayMember = "Event.EventName";
            addEventName.ValueMember = "Event.EventName";
            
            addEventID.DataSource = DM.dsEsport;
            addEventID.DisplayMember = "Event.EventID";
            addEventID.ValueMember = "Event.EventID";

           
        }

        private void btnAddChallenge_Click(object sender, EventArgs e)
        {
            pnAddChallenge.Visible = true;
            hideControls();

            loadEvents();
            
        }

        //add new Challenge record
        //create  Variable of DataRow type.
        //store user input in varibale and add it t0 dataTable.
        private void btnAddSaveChallenge_Click(object sender, EventArgs e)
        {
            tbChallengeId.Text = null;
            DataRow addChallenge = DM.dtChallenge.NewRow();
            if(addChallengeName.Text=="" || addStatus.Text=="" || addCapacity.Text == null || addStartTime.Text == null)
            {
                MessageBox.Show("one or more fields are empty, fill all the fields");
            }
            else
            {
                addChallenge["ChallengeName"] = addChallengeName.Text;
                addChallenge["EventID"] = addEventID.Text;
                addChallenge["StartTime"]=addStartTime.Text;
                addChallenge["Status"] = addStatus.Text;
                addChallenge["Capacity"]=addCapacity.Text;

                DM.dtChallenge.Rows.Add(addChallenge);

                MessageBox.Show("Challenge added successfully");
                DM.updateChallenge();
                pnAddChallenge.Visible = false;
                showControls();
            }
        }

        //change status of Challenge to "Finished

        private void btnMarkChallengeFinished_Click(object sender, EventArgs e)
        {
            DataRow markFinshedRow = DM.dtChallenge.Rows[currencyManager.Position];
            markFinshedRow["Status"] = "Finished";
            currencyManager.EndCurrentEdit();
            DM.updateChallenge();
        }
        //Pass the values of selected record in list box to Update Panel textboxes.

        private void btnUpdateChallenge_Click(object sender, EventArgs e)
        {
            tbUpChallengeID.Text = tbChallengeId.Text;
            tbUpChallengeName.Text=tbChallengeName.Text;
            tbUpStartTime.Text = tbStartTime.Text;
            tbUpStatus.Text = tbStatus.Text;
            tbUpCapacity.Text=tbCapacity.Text;
            tbUpEventName.Text=tbEventName.Text;

            hideControls();
            pnUpChallenge.Visible = true;

        }
        //fetch postiton of selected item in list box and store it in DataRow variable
        //checks input validation and display appropriate message.
        //record is upated if valid date entered.
        private void btnUpSaveChanges_Click(object sender, EventArgs e)
        {
            hideControls();
            pnUpChallenge.Visible = true;
          DataRow updateChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            if (tbUpChallengeName.Text == "" || tbUpStatus.Text == "" || tbUpCapacity.Text == "" || tbUpStartTime.Text == null)
            {
                MessageBox.Show("one or more fields are empty, fill all the fields");
            }
            else
            {
                try {
                    updateChallengeRow["ChallengeName"] = tbUpChallengeName.Text;
                    updateChallengeRow["Status"] = tbUpStatus.Text;
                    updateChallengeRow["Capacity"] = tbUpCapacity.Text;
                    updateChallengeRow["StartTime"] = tbUpStartTime.Text;
                    currencyManager.EndCurrentEdit();
                    DM.updateChallenge();
                    MessageBox.Show("Challenge updated successfully");
                    showControls();
                    pnUpChallenge.Visible=false;
                  }
                catch (FormatException ex)
                {
                    MessageBox.Show("Capacity should be a number");
                }
               }
        }
        //disable button on the form visble,
        //according to to add, update panel visibility
        private void hideControls()
        {
            btnAddChallenge.Enabled = false;
            prev.Enabled = false;
            next.Enabled = false;
            btnUpdateChallenge.Enabled = false;
            btnReturn.Enabled = false;
            btnMarkChallengeCompleted.Enabled = false;
            btnMarkChallengeFinished.Enabled = false;
            tbStartTime.Visible=false;
            btnDeleteChallenge.Enabled = false;
        }
        //Enable button on the form visble,
        //according to to add, update panel visibility
        private void showControls()
        {
            btnAddChallenge.Enabled = true;
            prev.Enabled = true;
            next.Enabled = true;
            btnUpdateChallenge.Enabled = true;
            btnReturn.Enabled = true;
            btnMarkChallengeCompleted.Enabled = true;
            btnMarkChallengeFinished.Enabled = true;
            tbStartTime.Visible=true;
            btnDeleteChallenge.Enabled=true;
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {   
            showControls();
            pnAddChallenge.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnUpChallenge.Visible = false;
            showControls();
        }

        // obtain row position as per listbox item selected
        // fetching and storing if child records exist
        // deletes record corresponding to list box item selected
        private void btnDeleteChallenge_Click(object sender, EventArgs e)
        {
            DataRow deleteChallengeRow = DM.dtChallenge.Rows[currencyManager.Position];
            DataRow[] entryRow = DM.dtEnter.Select("ChallengeID=" + tbChallengeId.Text);
           

            if(entryRow.Length !=0)
            {
                MessageBox.Show("Cannot delete change active in Event or in Entry");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                         MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteChallengeRow.Delete();
                    DM.updateChallenge();
                }

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //change status of Challenge to "Complete"
        private void btnMarkChallengeCompleted_Click(object sender, EventArgs e)
        {
            DataRow markCompleteRow = DM.dtChallenge.Rows[currencyManager.Position];
            markCompleteRow["Status"] = "Complete";
            currencyManager.EndCurrentEdit();
            DM.updateChallenge();
        }

        private void addEventID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
    
}
