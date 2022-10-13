namespace week2
{
    partial class frmEventReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventReport));
            this.btnDisplayReport = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tbEventReport = new System.Windows.Forms.TextBox();
            this.printEventReport = new System.Drawing.Printing.PrintDocument();
            this.prevPrintEventReport = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnDisplayReport
            // 
            this.btnDisplayReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayReport.Location = new System.Drawing.Point(398, 386);
            this.btnDisplayReport.Name = "btnDisplayReport";
            this.btnDisplayReport.Size = new System.Drawing.Size(167, 43);
            this.btnDisplayReport.TabIndex = 58;
            this.btnDisplayReport.Text = "Print Report";
            this.btnDisplayReport.UseVisualStyleBackColor = true;
            this.btnDisplayReport.Click += new System.EventHandler(this.btnDisplayReport_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Location = new System.Drawing.Point(220, 386);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(156, 43);
            this.btnPrintReport.TabIndex = 57;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Visible = false;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(630, 386);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(124, 43);
            this.btnReturn.TabIndex = 56;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tbEventReport
            // 
            this.tbEventReport.Location = new System.Drawing.Point(29, 22);
            this.tbEventReport.Multiline = true;
            this.tbEventReport.Name = "tbEventReport";
            this.tbEventReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEventReport.Size = new System.Drawing.Size(743, 344);
            this.tbEventReport.TabIndex = 55;
            // 
            // printEventReport
            // 
            this.printEventReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printEventReport_PrintPage);
            // 
            // prevPrintEventReport
            // 
            this.prevPrintEventReport.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prevPrintEventReport.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prevPrintEventReport.ClientSize = new System.Drawing.Size(400, 300);
            this.prevPrintEventReport.Document = this.printEventReport;
            this.prevPrintEventReport.Enabled = true;
            this.prevPrintEventReport.Icon = ((System.Drawing.Icon)(resources.GetObject("prevPrintEventReport.Icon")));
            this.prevPrintEventReport.Name = "prevPrintEventReport";
            this.prevPrintEventReport.Visible = false;
            // 
            // frmEventReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplayReport);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbEventReport);
            this.Name = "frmEventReport";
            this.Text = "Event Report";
            this.Load += new System.EventHandler(this.frmEventReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayReport;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox tbEventReport;
        private System.Drawing.Printing.PrintDocument printEventReport;
        private System.Windows.Forms.PrintPreviewDialog prevPrintEventReport;
    }
}