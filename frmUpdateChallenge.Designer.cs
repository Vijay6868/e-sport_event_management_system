namespace week2
{
    partial class frmUpdateChallenge
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.tbChallengId = new System.Windows.Forms.TextBox();
            this.tbChallengeName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblChallengeID = new System.Windows.Forms.Label();
            this.lblArenName = new System.Windows.Forms.Label();
            this.timePickerUpdateChallenge = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(218, 221);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(74, 28);
            this.numericUpDown1.TabIndex = 72;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(331, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 35);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(102, 301);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(207, 35);
            this.btnSaveChanges.TabIndex = 70;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(218, 179);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(178, 30);
            this.cbStatus.TabIndex = 69;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(117, 224);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(95, 25);
            this.lblCapacity.TabIndex = 68;
            this.lblCapacity.Text = "Capacity:";
            // 
            // tbEventName
            // 
            this.tbEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEventName.Location = new System.Drawing.Point(218, 99);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(216, 28);
            this.tbEventName.TabIndex = 66;
            // 
            // tbChallengId
            // 
            this.tbChallengId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChallengId.Location = new System.Drawing.Point(218, 19);
            this.tbChallengId.Name = "tbChallengId";
            this.tbChallengId.Size = new System.Drawing.Size(77, 28);
            this.tbChallengId.TabIndex = 65;
            // 
            // tbChallengeName
            // 
            this.tbChallengeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChallengeName.Location = new System.Drawing.Point(218, 59);
            this.tbChallengeName.Name = "tbChallengeName";
            this.tbChallengeName.Size = new System.Drawing.Size(237, 28);
            this.tbChallengeName.TabIndex = 64;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(138, 183);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 25);
            this.lblStatus.TabIndex = 63;
            this.lblStatus.Text = "Status:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(103, 142);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(109, 25);
            this.lblCity.TabIndex = 62;
            this.lblCity.Text = "Start TIme:";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(93, 101);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(119, 25);
            this.lblEventName.TabIndex = 61;
            this.lblEventName.Text = "Event Name";
            // 
            // lblChallengeID
            // 
            this.lblChallengeID.AutoSize = true;
            this.lblChallengeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChallengeID.Location = new System.Drawing.Point(86, 19);
            this.lblChallengeID.Name = "lblChallengeID";
            this.lblChallengeID.Size = new System.Drawing.Size(126, 25);
            this.lblChallengeID.TabIndex = 60;
            this.lblChallengeID.Text = "ChallegneID:";
            // 
            // lblArenName
            // 
            this.lblArenName.AutoSize = true;
            this.lblArenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenName.Location = new System.Drawing.Point(48, 60);
            this.lblArenName.Name = "lblArenName";
            this.lblArenName.Size = new System.Drawing.Size(164, 25);
            this.lblArenName.TabIndex = 59;
            this.lblArenName.Text = "Challenge Name:";
            // 
            // timePickerUpdateChallenge
            // 
            this.timePickerUpdateChallenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePickerUpdateChallenge.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerUpdateChallenge.Location = new System.Drawing.Point(218, 139);
            this.timePickerUpdateChallenge.Name = "timePickerUpdateChallenge";
            this.timePickerUpdateChallenge.Size = new System.Drawing.Size(139, 28);
            this.timePickerUpdateChallenge.TabIndex = 73;
            // 
            // frmUpdateChallenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 380);
            this.Controls.Add(this.timePickerUpdateChallenge);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.tbEventName);
            this.Controls.Add(this.tbChallengId);
            this.Controls.Add(this.tbChallengeName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.lblChallengeID);
            this.Controls.Add(this.lblArenName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateChallenge";
            this.Text = "frmUpdateChallenge";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.TextBox tbChallengId;
        private System.Windows.Forms.TextBox tbChallengeName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblChallengeID;
        private System.Windows.Forms.Label lblArenName;
        private System.Windows.Forms.DateTimePicker timePickerUpdateChallenge;
    }
}