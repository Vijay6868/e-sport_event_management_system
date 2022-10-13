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
    public partial class dataModule : Form
    {
        public DataTable dtArena;
        public DataTable dtChallenge;
        public DataTable dtCompetitor;
        public DataTable dtEvent;
        public DataTable dtEnter;
        public DataView arenaView;
        public DataView challengeView;
        public DataView competitorView;
        public DataView eventView;
        public DataView enterView;
        public dataModule()

        {
            InitializeComponent();
            dsEsport.EnforceConstraints = false;

            daArenaMaintenance.Fill(dsEsport);
            daChallengeMaintenance.Fill(dsEsport);
            daCompetitor.Fill(dsEsport);
            daEntry.Fill(dsEsport);
            daEventMaintenance.Fill(dsEsport);

            dtArena = dsEsport.Tables["Arena"];
            dtChallenge = dsEsport.Tables["Challenge"];
            dtCompetitor = dsEsport.Tables["Competitor"];
            dtEnter = dsEsport.Tables["Entry"];
            dtEvent = dsEsport.Tables["Event"];

            dsEsport.EnforceConstraints = true;

            arenaView = new DataView(dtArena);
            arenaView.Sort = "ArenaID";

            challengeView = new DataView(dtChallenge);
            challengeView.Sort = "ChallengeID";

            eventView = new DataView(dtEvent);
            eventView.Sort = "eventID";

            competitorView = new DataView(dtCompetitor);
            competitorView.Sort = "CompetitorID";
            
        }

        private void daArenaMaintenance_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnESport);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and
                // store it in the TreatmentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ArenaID"] = newID;
            }


        }
        private void daChallengeMaintenance_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnESport);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and
                // store it in the TreatmentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ChallengeID"] = newID;
            }


        }
        
        public void updateArena()
        {
            daArenaMaintenance.Update(dtArena);
        }

        private void dataModule_Load(object sender, EventArgs e)
        {

        }
        public void updateEntry()
        {
            daEntry.Update(dtEnter);
        }
        public void updateChallenge()
        {
            daChallengeMaintenance.Update(dtChallenge);
        }
        public void updateCompetitor()
        {
            daCompetitor.Update(dtCompetitor);
        }
        public void updateEvent()
        {
            daEventMaintenance.Update(dtEvent);
        }
        private void daCompetitor_RowUpdated_1(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnESport);

            if (e.StatementType == StatementType.Insert)
            {               
                newID = (int)idCMD.ExecuteScalar();
                e.Row["CompetitorID"] = newID;
            }
        }

        private void daEventMaintenance_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnESport);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["EventID"] = newID;
            }
        }
    }
}
