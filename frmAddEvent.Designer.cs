namespace week2
{
    partial class frmAddEvent
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
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblArena = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveMeeting = new System.Windows.Forms.Button();
            this.cbArenId = new System.Windows.Forms.ComboBox();
            this.cbArenaName = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.nmCapacity = new System.Windows.Forms.NumericUpDown();
            this.datePickerEventDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nmCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDate.Location = new System.Drawing.Point(26, 195);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(114, 25);
            this.lblEventDate.TabIndex = 82;
            this.lblEventDate.Text = "Event Date:";
            // 
            // lblArena
            // 
            this.lblArena.AutoSize = true;
            this.lblArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArena.Location = new System.Drawing.Point(69, 63);
            this.lblArena.Name = "lblArena";
            this.lblArena.Size = new System.Drawing.Size(71, 25);
            this.lblArena.TabIndex = 78;
            this.lblArena.Text = "Arena:";
            this.lblArena.Click += new System.EventHandler(this.lblArena_Click);
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(45, 151);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(95, 25);
            this.lblCapacity.TabIndex = 76;
            this.lblCapacity.Text = "Capacity:";
            // 
            // tbEventName
            // 
            this.tbEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEventName.Location = new System.Drawing.Point(139, 17);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(204, 28);
            this.tbEventName.TabIndex = 74;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(66, 107);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 25);
            this.lblStatus.TabIndex = 73;
            this.lblStatus.Text = "Status:";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(15, 19);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(125, 25);
            this.lblEventName.TabIndex = 72;
            this.lblEventName.Text = "Event Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(233, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 41);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveMeeting
            // 
            this.btnSaveMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMeeting.Location = new System.Drawing.Point(12, 310);
            this.btnSaveMeeting.Name = "btnSaveMeeting";
            this.btnSaveMeeting.Size = new System.Drawing.Size(199, 41);
            this.btnSaveMeeting.TabIndex = 70;
            this.btnSaveMeeting.Text = "Save Meeting";
            this.btnSaveMeeting.UseVisualStyleBackColor = true;
            // 
            // cbArenId
            // 
            this.cbArenId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArenId.FormattingEnabled = true;
            this.cbArenId.Location = new System.Drawing.Point(139, 62);
            this.cbArenId.Name = "cbArenId";
            this.cbArenId.Size = new System.Drawing.Size(50, 30);
            this.cbArenId.TabIndex = 84;
            // 
            // cbArenaName
            // 
            this.cbArenaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArenaName.FormattingEnabled = true;
            this.cbArenaName.Location = new System.Drawing.Point(195, 62);
            this.cbArenaName.Name = "cbArenaName";
            this.cbArenaName.Size = new System.Drawing.Size(196, 30);
            this.cbArenaName.TabIndex = 85;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(139, 102);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(148, 30);
            this.cbStatus.TabIndex = 86;
            // 
            // nmCapacity
            // 
            this.nmCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCapacity.Location = new System.Drawing.Point(139, 151);
            this.nmCapacity.Name = "nmCapacity";
            this.nmCapacity.Size = new System.Drawing.Size(88, 28);
            this.nmCapacity.TabIndex = 87;
            // 
            // datePickerEventDate
            // 
            this.datePickerEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerEventDate.Location = new System.Drawing.Point(139, 195);
            this.datePickerEventDate.Name = "datePickerEventDate";
            this.datePickerEventDate.Size = new System.Drawing.Size(148, 28);
            this.datePickerEventDate.TabIndex = 88;
            // 
            // frmAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 376);
            this.Controls.Add(this.datePickerEventDate);
            this.Controls.Add(this.nmCapacity);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbArenaName);
            this.Controls.Add(this.cbArenId);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lblArena);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.tbEventName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveMeeting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEvent";
            this.Text = "frmAddEvent";
            this.Load += new System.EventHandler(this.frmAddEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblArena;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveMeeting;
        private System.Windows.Forms.ComboBox cbArenId;
        private System.Windows.Forms.ComboBox cbArenaName;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.NumericUpDown nmCapacity;
        private System.Windows.Forms.DateTimePicker datePickerEventDate;
    }
}