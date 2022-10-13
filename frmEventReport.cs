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
    public partial class frmEventReport : Form
    {
        private dataModule DM;
        private mainForm frmMenu;
        private int amountofReportPrinted, pagesAmountExpected;
        private DataRow reportForPrint;
        public frmEventReport(dataModule dm, mainForm mn)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mn;
        }

        private void frmEventReport_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            CurrencyManager cmEvent;
            CurrencyManager cmCompetitor;
            CurrencyManager cmChallenge;
            CurrencyManager cmArena;

            string eventText = "";

            cmArena = (CurrencyManager)this.BindingContext[DM.dsEsport, "ARENA"];
            cmEvent = (CurrencyManager)this.BindingContext[DM.dsEsport, "EVENT"];
            cmChallenge = (CurrencyManager)this.BindingContext[DM.dsEsport, "CHALLENGE"];
            cmCompetitor = (CurrencyManager)this.BindingContext[DM.dsEsport, "COMPETITOR"];

            tbEventReport.Text = "";

            foreach (DataRow evReport in DM.dtEvent.Rows)
            {
                int aEventID = Convert.ToInt32(evReport["EventID"].ToString());
                cmEvent.Position = DM.challengeView.Find(aEventID);
                DataRow drEvent = DM.dtEvent.Rows[cmEvent.Position];

                int aArenID = Convert.ToInt32(evReport["ArenaID"]);
                cmArena.Position = DM.arenaView.Find(aArenID);
                DataRow drArena = DM.dtArena.Rows[cmArena.Position];

                eventText += String.Format("{0,-20}","EvenID:")+ String.Format("{0,-20}",drEvent["EventID"]) + "\r\n\r\n";
                eventText += String.Format("{0,-20}", drEvent["EventName"]) + "\r\n";
                eventText += String.Format("{0,-20}", drArena["ArenaName"]) + "\r\n";
                eventText += String.Format("{0,-20}", drArena["StreetAddress"]) + "\r\n";
                eventText += String.Format("{0,-20}", drArena["Suburb"]) + "\r\n";
                eventText += String.Format("{0,-20}", drArena["City"]) + "\r\n\r\n";
                eventText += String.Format("{0,-20}", "Event Date : ") + String.Format("{0,-20}", drEvent["EventDate"]) + "\r\n";

                //eventText += drEvent["ChallengeID"] + "\r\n";


                //int aChallengeID = Convert.ToInt32(evReport[""])


                DataRow[] drChallenges = evReport.GetChildRows(DM.dtEvent.ChildRelations["EVENT_CHALLENGE"]);

                string challengesText = "\r\n";
                int count = 0;

                if (drChallenges.Length > 0)
                {

                    foreach (DataRow drEventChallenge in drChallenges)
                    {

                        int aChallengeID = Convert.ToInt32(drEventChallenge["EventID"].ToString());
                        cmChallenge.Position = DM.challengeView.Find(aChallengeID);
                        DataRow drChallenge = DM.dtChallenge.Rows[cmChallenge.Position];


                        if (count == 0)
                        {
                            challengesText += String.Format("{0,-20}","ID")+String.Format("{0,-20}","Name") + String.Format("{0,-20}","Start Time")+ "\r\n";
                            count++;
                        }
                        //challengesText +
                        challengesText += String.Format("{0,-20}", drChallenge["ChallengeID"]);
                        challengesText += String.Format("{0,-20}", drChallenge["ChallengeName"]);
                        challengesText += String.Format("{0,-20}", drChallenge["StartTime"]);

                        challengesText += "\r\n";

                    }
                    tbEventReport.Text += eventText;
                    tbEventReport.Text += challengesText + "\r\n";
                    challengesText = "\r\n";
                }
                else
                {
                    eventText += "This Event has no challenges\r\n";
                }
                
                eventText = "";
            }
        }

        private void printEventReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);

            //DataRow drEvent = reportForPrint[amountofReportPrinted];

            CurrencyManager cmEvent;
            CurrencyManager cmCompetitor;
            CurrencyManager cmChallenge;
            CurrencyManager cmArena;

            Brush brush = new SolidBrush(Color.Black);
            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;


        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            /*amountofReportPrinted = 0;
            string strSort = "EventID";

            reportForPrint = DM.dsEsport.Tables["EVENT"].Select(strSort);
            prevPrintEventReport.Show();*/

        }
    }
}
