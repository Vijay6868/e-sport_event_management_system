namespace week2
{
    partial class frmCompetitorReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompetitorReport));
            this.tbCompetitorReport = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnDisplayReport = new System.Windows.Forms.Button();
            this.printCompetitorReport = new System.Drawing.Printing.PrintDocument();
            this.prevPrintCompetitorReport = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // tbCompetitorReport
            // 
            this.tbCompetitorReport.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCompetitorReport.Location = new System.Drawing.Point(25, 20);
            this.tbCompetitorReport.Multiline = true;
            this.tbCompetitorReport.Name = "tbCompetitorReport";
            this.tbCompetitorReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCompetitorReport.Size = new System.Drawing.Size(916, 416);
            this.tbCompetitorReport.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(621, 457);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(124, 43);
            this.btnReturn.TabIndex = 52;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Location = new System.Drawing.Point(218, 457);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(149, 43);
            this.btnPrintReport.TabIndex = 53;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Visible = false;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnDisplayReport
            // 
            this.btnDisplayReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayReport.Location = new System.Drawing.Point(389, 457);
            this.btnDisplayReport.Name = "btnDisplayReport";
            this.btnDisplayReport.Size = new System.Drawing.Size(167, 43);
            this.btnDisplayReport.TabIndex = 54;
            this.btnDisplayReport.Text = "Print Report";
            this.btnDisplayReport.UseVisualStyleBackColor = true;
            this.btnDisplayReport.Click += new System.EventHandler(this.btnDisplayReport_Click);
            // 
            // printCompetitorReport
            // 
            this.printCompetitorReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCompetitorReport_PrintPage);
            // 
            // prevPrintCompetitorReport
            // 
            this.prevPrintCompetitorReport.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prevPrintCompetitorReport.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prevPrintCompetitorReport.ClientSize = new System.Drawing.Size(400, 300);
            this.prevPrintCompetitorReport.Document = this.printCompetitorReport;
            this.prevPrintCompetitorReport.Enabled = true;
            this.prevPrintCompetitorReport.Icon = ((System.Drawing.Icon)(resources.GetObject("prevPrintCompetitorReport.Icon")));
            this.prevPrintCompetitorReport.Name = "prevPrintCompetitorReport";
            this.prevPrintCompetitorReport.Visible = false;
            // 
            // frmCompetitorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 539);
            this.Controls.Add(this.btnDisplayReport);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbCompetitorReport);
            this.Name = "frmCompetitorReport";
            this.Text = "Competitor Report";
            this.Load += new System.EventHandler(this.frmCompetitorReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCompetitorReport;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Button btnDisplayReport;
        private System.Drawing.Printing.PrintDocument printCompetitorReport;
        private System.Windows.Forms.PrintPreviewDialog prevPrintCompetitorReport;
    }
}