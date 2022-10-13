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
  
    public partial class CompetitorForm : Form

    {
        private dataModule DM;
        private mainForm frmMenu;
        private CurrencyManager currencyManager;
        public CompetitorForm(dataModule dm,mainForm mn)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mn;

            pnAddCompetitor.Left = 12;
            pnAddCompetitor.Top = 12;
            pnAddCompetitor.Visible = false;

            pnUpCompetitor.Left = 12;
            pnUpCompetitor.Top = 12;
            pnUpCompetitor.Visible = false;

            this.Width = 900;
            this.Height = 500;

           
            BindingControl();

        }

        private void frmCompetitorMaintenance_Load(object sender, EventArgs e)
        {

        }
        // binding controls textfiled with listbox items
        private void BindingControl()
        {
            tbCompetitorId.DataBindings.Add("Text",DM.dsEsport, "Competitor.CompetitorID");
            tbUserName.DataBindings.Add("Text", DM.dsEsport, "Competitor.UserName");
            tbFirstName.DataBindings.Add("Text", DM.dsEsport, "Competitor.FirstName");
            tbLastName.DataBindings.Add("Text", DM.dsEsport, "Competitor.LastName");
            tbGender.DataBindings.Add("Text", DM.dsEsport, "Competitor.Gender");
            tbDateOfBirth.DataBindings.Add("Text", DM.dsEsport, "Competitor.DateOfBirth");
            tbEmail.DataBindings.Add("Text", DM.dsEsport, "Competitor.EmailAddress");

            lbCompetitor.DataSource = DM.dsEsport;
            lbCompetitor.DisplayMember = "Competitor.LastName";
            lbCompetitor.ValueMember = "Competitor.LastName";

            currencyManager = (CurrencyManager)this.BindingContext[DM.dsEsport, "Competitor"];
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
            if(currencyManager.Position<currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnAddCompetitor_Click(object sender, EventArgs e)
        {
            pnAddCompetitor.Visible = true;
            hideControls();
        }

        //Disable button on the form visble,
        //according to to add, update panel visibility
        private void hideControls()
        {
            prev.Enabled = false;
            next.Enabled = false;
            btnAddCompetitor.Enabled = false;
            btnUpdateCompetitor.Enabled = false;
            btnDeleteCompetitor.Enabled=false;
            btnReturn.Enabled= false;
        }

        //disable button on the form visble,
        //according to to add, update panel visibility
        private void showControls()
        {
            prev.Enabled = true;
            next.Enabled = true;
            btnAddCompetitor.Enabled = true;
            btnUpdateCompetitor.Enabled = true;
            btnDeleteCompetitor.Enabled = true;
            btnReturn.Enabled = true;
        }

        //add new Competitor record
        //create  Variable of DataRow type.
        //store user input in varibale and add it t0 dataTable.

        private void pnbtnSaveCompetitor_Click(object sender, EventArgs e)
        {
            DataRow addCompetitor = DM.dtCompetitor.NewRow();
            tbCompetitorId.Text = null;

            if(pnAddGender.Text=="" || pnAddDateOfBirth.Text==""|| pnAddEmail.Text==""||pnAddFirstName.Text=="" 
                || pnAddLastName.Text == "" || pnAddUsername.Text == "")
            {
                MessageBox.Show("All fields are Mandatory !!");
            }
            else
            {
                addCompetitor["Username"]= pnAddUsername.Text;
                addCompetitor["FirstName"] = pnAddFirstName.Text;
                addCompetitor["LastName"]= pnAddLastName.Text;
                addCompetitor["Gender"] = pnAddGender.Text;
                addCompetitor["DateOfBirth"] = pnAddDateOfBirth.Text;
                addCompetitor["EmailAddress"] = pnAddEmail.Text;

                DM.dtCompetitor.Rows.Add(addCompetitor);

                DM.updateCompetitor();
                pnAddCompetitor.Visible = false;
                MessageBox.Show("Competitor Added successfully");
            }

        }

        private void pnbtnCancel_Click(object sender, EventArgs e)
        {
            pnAddCompetitor.Visible = false;
            showControls();
        }
        //Pass the values of selected record in list box to Update Panel textboxes.
        private void btnUpdateCompetitor_Click(object sender, EventArgs e)
        {
            
            hideControls();
            pnUpCompetitor.Visible = true;

            pnUpUserName.Text = tbUserName.Text;
            pnUpFirstName.Text = tbFirstName.Text;
            pnUpLastName.Text = tbLastName.Text;
            pnUpGender.Text= tbGender.Text;
            pnUpDateOfBirth.Text= tbDateOfBirth.Text;
            pnUpEmail.Text= tbEmail.Text;


        }


        private void btnUpCancel_Click(object sender, EventArgs e)
        {
            pnUpCompetitor.Visible = false;
            showControls();
        }
        //fetch postiton of selected item in list box and store it in DataRow variable
        //checks input validation and display appropriate message.
        //record is upated if valid date entered.
        private void btnUpSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateCompetitor = DM.dtCompetitor.Rows[currencyManager.Position];
            if (pnUpGender.Text == "" || pnUpDateOfBirth.Text == "" || pnUpEmail.Text == "" || pnUpFirstName.Text == ""
                || pnUpLastName.Text == "" || pnUpUserName.Text == "")
            {
                MessageBox.Show("All fields are Mandatory !!");
            }
            else
            {
                updateCompetitor["UserName"] = pnUpUserName.Text;
                updateCompetitor["LastName"] = pnUpLastName.Text;
                updateCompetitor["FirstName"] = pnUpFirstName.Text;
                updateCompetitor["Gender"] = pnUpGender.Text;
                updateCompetitor["DateOfBirth"] = pnUpDateOfBirth.Text;
                updateCompetitor["EmailAddress"] = pnUpEmail.Text;
                currencyManager.EndCurrentEdit();
                DM.updateCompetitor();

                MessageBox.Show("Competitor details added successfully !!");
                pnUpCompetitor.Visible=false;
                showControls();

            }


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        // obtain row position as per listbox item selected
        // fetching and storing if child records exist
        // deletes record corresponding to list box item selected
        private void btnDeleteCompetitor_Click(object sender, EventArgs e)
        {
            DataRow deleteCompetitorRow = DM.dtCompetitor.Rows[currencyManager.Position];
            DataRow []compChallengeRow = DM.dtEnter.Select("CompetitorID=" + tbCompetitorId.Text);
            //DataRow[] entryRow = DM.dtEnter.Select("CompetitorID=" + tbCompetitorId.Text);

            if(compChallengeRow.Length != 0)
            {
                MessageBox.Show("Cannot delete Competitor, particpating in challenge");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                         MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteCompetitorRow.Delete();
                    DM.updateCompetitor();
                }
            }
        }
    }
}

