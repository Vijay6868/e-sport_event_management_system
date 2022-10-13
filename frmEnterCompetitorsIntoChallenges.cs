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
    public partial class EnterForm : Form
    {
        private dataModule DM;
        private mainForm frmMenu;
        private CurrencyManager cmCompetitior;
        private CurrencyManager cmChallenge;
        private CurrencyManager cmEntry;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;
        private CurrencyManager cmCic;
        private CurrencyManager cmEvent;
        public EnterForm(dataModule dm, mainForm mn) 
        {
            InitializeComponent();
            DM= dm;
            frmMenu= mn;

            //Binding child and parent records

            cmCompetitior = (CurrencyManager)this.BindingContext[DM.dsEsport, "Competitor"];
            cmChallenge= (CurrencyManager)this.BindingContext[DM.dsEsport, "Challenge"];
            cmEntry = (CurrencyManager)this.BindingContext[DM.dsEsport, "Entry"];
            cmDt = (CurrencyManager)this.BindingContext[dt];

            BindControls();


        }

        private void EnterForm_Load(object sender, EventArgs e)
        {

        }
        //setting datasources for data grid view and combobox
        private void BindControls() {

            cmEvent = (CurrencyManager)this.BindingContext[DM.dsEsport, "Event"];
            //int aEventID

            dgvChallenge.DataSource = DM.dsEsport;
            dgvChallenge.DataMember = "Challenge";

            dgvCompetitor.DataSource = DM.dsEsport;
            dgvCompetitor.DataMember = "Competitor";

            dgvEntry.DataSource = DM.dsEsport;
            dgvEntry.DataMember = "Entry";

            cbStatus.DataBindings.Add("Text", DM.dsEsport, "Challenge.Status");
            tbEventName.DataBindings.Add("Text", DM.dsEsport, "Event.EventName");
        }
        // entering competitor into challege if challenge is scheduled
        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            try
            {
                if (DM.dtChallenge.Rows[cmChallenge.Position]["Status"].ToString() == "Scheduled")
                {
                    DataRow newEntry = DM.dtEnter.NewRow();

                    newEntry["ChallengeID"] = dgvChallenge["ChallengeID", cmChallenge.Position].Value;
                    newEntry["CompetitorID"] = dgvCompetitor["CompetitorID", cmCompetitior.Position].Value;
                    newEntry["Status"] = "Confirmed";

                    DM.dsEsport.Tables["Entry"].Rows.Add(newEntry);
                    DM.updateEntry();
                    MessageBox.Show("Competitor added to Challenge !!");
                }
                else
                {
                    MessageBox.Show("cannot add competitor to Finished or Completed Event");
                }
            }
            catch (ConstraintException)
            {
                MessageBox.Show("This Competitor already added to Challenge");
            }
        }
        // removing competitor from challenge
        private void btnRemoveEntry_Click(object sender, EventArgs e)
        {
            if (DM.dtChallenge.Rows[cmChallenge.Position]["Status"].ToString() == "Pending")
            {
                string challengeID = DM.dtChallenge.Rows[cmChallenge.Position]["ChallengeID"].ToString();
                string competitorID = dgvEntry.Rows[cmEntry.Position].Cells[1].Value.ToString();
                int row = 0;

                for(int i =0; i<DM.dtEnter.Rows.Count; i++)
                {
                    string sID = DM.dtEnter.Rows[i]["ChallengeID"].ToString();
                    string aID = DM.dtEnter.Rows[i]["CompetitorID"].ToString();

                    if(challengeID==sID && competitorID == aID)
                    {
                        row = i;
                    }
                }

                DataRow dr = DM.dsEsport.Tables["Entry"].Rows[row];
                dr.Delete();
                DM.updateEntry();
            }
            else
            {
                MessageBox.Show("Cannot remove competitor if it's not Pending");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
