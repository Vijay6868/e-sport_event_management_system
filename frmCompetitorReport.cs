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
    public partial class frmCompetitorReport : Form
    {
       private dataModule DM;
        private mainForm frmMenu;
        private int amountsofReportsPrinted, pagesAmountExpected;
        private DataRow[] reportsForPrint;
        public frmCompetitorReport(dataModule dm, mainForm mn)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mn;
        }

        private void frmCompetitorReport_Load(object sender, EventArgs e)
        {

        }

        private void printCompetitorReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);

            DataRow drCompetitor = reportsForPrint[amountsofReportsPrinted];

            CurrencyManager cmEvent;
            CurrencyManager cmCompetitor;
            CurrencyManager cmChallenge;
            CurrencyManager cmArena;

        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            amountsofReportsPrinted = 0;
            string strSort = "CompetitorID";
            reportsForPrint = DM.dsEsport.Tables["COMPETITOR"].Select(strSort);
            pagesAmountExpected = reportsForPrint.Length;
            prevPrintCompetitorReport.Show();
                
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

            string report = "";

            cmEvent = (CurrencyManager)this.BindingContext[DM.dsEsport, "EVENT"];
            cmChallenge = (CurrencyManager)this.BindingContext[DM.dsEsport,"CHALLENGE"];
            cmCompetitor = (CurrencyManager)this.BindingContext[DM.dsEsport, "COMPETITOR"];

            tbCompetitorReport.Text ="\r\n";

            foreach (DataRow drCompEntry in DM.dtCompetitor.Rows)
            {
                report += "\r\n\r\n";
                int aComeptitorID = Convert.ToInt32(drCompEntry["CompetitorID"].ToString());
                cmCompetitor.Position = DM.competitorView.Find(aComeptitorID);
                DataRow drCompetitor = DM.dtCompetitor.Rows[cmCompetitor.Position];
                report += String.Format("{0,-20}","CompetitorID:")+String.Format("{0,-20}",drCompetitor["CompetitorID"])+"\r\n";
                report += String.Format("{0,-20}", "UserName:") + string.Format("{0,-20}",drCompetitor["Username"]) + "\r\n";
                report += String.Format("{0,-20}","Name:")+string.Format("{0,-20}",drCompetitor["FirstName"]+" "+ drCompetitor["LastName"]) + "\r\n";
                report += String.Format("{0,-20}","Date of Birth:") + string.Format("{0,-20}",drCompetitor["DateOfBirth"]) + "\r\n";
                report += String.Format("{0,-20}","Email") + string.Format("{0,-20}",drCompetitor["EmailAddress"])+"\r\n";

             

                

                DataRow[] drEntries = drCompEntry.GetChildRows(DM.dtCompetitor.ChildRelations["COMPETITOR_ENTRY"]);
                
                if(drEntries.Length > 0)
                {
                    tbCompetitorReport.Text += report;
                    string compReport = "";
                    int count = 0;
                    foreach (DataRow drEntry in drEntries){

                       

                        int aChallengeID = Convert.ToInt32(drEntry["ChallengeID"].ToString());
                        cmChallenge.Position = DM.challengeView.Find(aChallengeID);
                        DataRow drChallenge = DM.dtChallenge.Rows[cmChallenge.Position];


                        if (count == 0)
                        {
                            compReport += String.Format("{0,-20}", "ChallengeID")+ String.Format("{0,-20}", "Challenge Name")+ String.Format("{0,-20}", "Start Time")+"\r\n";
                            //compReport += String.Format("{-0,20}","ChallengeID") + String.Format("{-0,20}", "Challenge Name") + String.Format("{-0,20}","Start Time") ;
                            count++;
                        }
                        compReport += String.Format("{0,-20}",drChallenge["ChallengeID"]) + string.Format("{0,-20}",drChallenge["ChallengeName"]) + string.Format("{0,-20}",drChallenge["StartTime"]) + "\r\n";
                       
                        
                    }
                    count = 0;
                    tbCompetitorReport.Text += "\r\n\r\n";
                    tbCompetitorReport.Text += compReport;
                    report = "";
                    compReport = "";
                }
                else
                {
                    report += "\r\n"+">> This Competitor has no challenges !!!\r\n\r\n";
                }
            }
        }
    }
}
