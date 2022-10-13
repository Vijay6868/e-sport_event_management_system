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
    public partial class mainForm : Form
    {
        private dataModule DM;
        private ArenaForm frmArena;
        private CompetitorForm frmCompetitor;
        private EventForm frmEvent;
        private EnterForm frmEnter;
        private ChallengeMaintenance frmChallenge;
        private frmEventReport eventReport;
        private frmCompetitorReport competitorReport;
        private LoginPage frmLogin;


        // loads login and Mainform page at the startup of the Application
        //Login page hides the Mainform, correct username and passowrd, Login pages closes.
        //Mainform is visible
        public mainForm()
        {
            InitializeComponent();
            frmLogin = new LoginPage();
            frmLogin.ShowDialog();
            panel2.Visible = false;
           
        }

        // create new object of Arena form class if frmArena instance is null.
        // frmArena is visible to user.
        private void button1_Click(object sender, EventArgs e)
        {
            if (frmArena == null)
            {
                frmArena = new ArenaForm(DM, this);
            }
            frmArena.ShowDialog();
        }
        // create new object of Competitor forn class if frmCompetitor instance is null.
        // frmCompetitor is visible to user.
        private void button4_Click(object sender, EventArgs e)
        {
            if (frmCompetitor == null)
            {
                frmCompetitor = new CompetitorForm(DM, this);

            }
            frmCompetitor.ShowDialog();
        }
        // create new object of event frmEventReport class if eventReport instance is null.
        // eventReport is visible to user
        private void button6_Click(object sender, EventArgs e)
        {
            if (eventReport == null)
            {
                eventReport = new frmEventReport(DM, this);
            }
            eventReport.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
        }

        // create new object of EventForm class if frmEvent instance is null.
        // frmEvent is visible to user
        private void eventM_Click(object sender, EventArgs e)
        {
           if (frmEvent == null)
            {
                frmEvent = new EventForm(DM, this);
            }
            frmEvent.ShowDialog();
        }
        // create new object of ChallengeMaintenance forn class if frmChallenge instance is null.
        // frmChallenge is visible to user
        private void challenge_Click(object sender, EventArgs e)
        {
            if (frmChallenge== null)
            {
                frmChallenge = new ChallengeMaintenance(DM, this);
            }
            frmChallenge.ShowDialog();
        }
        // create new object of EnterForm class if frmEnter instance is null.
        // frmCompetitor is visible to user
        private void compTo_Click(object sender, EventArgs e)
        {
            if (frmEnter == null)
            {
                frmEnter = new EnterForm(DM, this);
            }
            frmEnter.ShowDialog();
        }
        
        private void mainForm_Load(object sender, EventArgs e)
        {
            DM = new dataModule();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCompetitorReport_Click(object sender, EventArgs e)
        {
            if(competitorReport == null)
            {
                competitorReport = new frmCompetitorReport(DM, this);
            }
            competitorReport.ShowDialog();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }
    }
}
