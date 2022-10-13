namespace week2
{
    partial class ChallengeMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChallengeMaintenance));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteChallenge = new System.Windows.Forms.Button();
            this.btnUpdateChallenge = new System.Windows.Forms.Button();
            this.btnAddChallenge = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.btnMarkChallengeFinished = new System.Windows.Forms.Button();
            this.btnMarkChallengeCompleted = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.tbEventId = new System.Windows.Forms.TextBox();
            this.tbChallengeName = new System.Windows.Forms.TextBox();
            this.tbChallengeId = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventID = new System.Windows.Forms.Label();
            this.lblArenName = new System.Windows.Forms.Label();
            this.lblChallegneId = new System.Windows.Forms.Label();
            this.tbCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lbChallenge = new System.Windows.Forms.ListBox();
            this.pnAddChallenge = new System.Windows.Forms.Panel();
            this.addStartTime = new System.Windows.Forms.DateTimePicker();
            this.addEventName = new System.Windows.Forms.ComboBox();
            this.addEventID = new System.Windows.Forms.ComboBox();
            this.addCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddSaveChallenge = new System.Windows.Forms.Button();
            this.addStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addChallengeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbStartTime = new System.Windows.Forms.DateTimePicker();
            this.pnUpChallenge = new System.Windows.Forms.Panel();
            this.tbUpStatus = new System.Windows.Forms.TextBox();
            this.tbUpChallengeID = new System.Windows.Forms.TextBox();
            this.tbUpEventName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpSaveChanges = new System.Windows.Forms.Button();
            this.tbUpStartTime = new System.Windows.Forms.DateTimePicker();
            this.tbUpCapacity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUpChallengeName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnAddChallenge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCapacity)).BeginInit();
            this.pnUpChallenge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUpCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(734, 415);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(161, 41);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteChallenge
            // 
            this.btnDeleteChallenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteChallenge.Location = new System.Drawing.Point(712, 356);
            this.btnDeleteChallenge.Name = "btnDeleteChallenge";
            this.btnDeleteChallenge.Size = new System.Drawing.Size(183, 41);
            this.btnDeleteChallenge.TabIndex = 10;
            this.btnDeleteChallenge.Text = "Delete Challenge";
            this.btnDeleteChallenge.UseVisualStyleBackColor = true;
            this.btnDeleteChallenge.Click += new System.EventHandler(this.btnDeleteChallenge_Click);
            // 
            // btnUpdateChallenge
            // 
            this.btnUpdateChallenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateChallenge.Location = new System.Drawing.Point(507, 356);
            this.btnUpdateChallenge.Name = "btnUpdateChallenge";
            this.btnUpdateChallenge.Size = new System.Drawing.Size(199, 41);
            this.btnUpdateChallenge.TabIndex = 9;
            this.btnUpdateChallenge.Text = "Update Challenge";
            this.btnUpdateChallenge.UseVisualStyleBackColor = true;
            this.btnUpdateChallenge.Click += new System.EventHandler(this.btnUpdateChallenge_Click);
            // 
            // btnAddChallenge
            // 
            this.btnAddChallenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChallenge.Location = new System.Drawing.Point(276, 356);
            this.btnAddChallenge.Name = "btnAddChallenge";
            this.btnAddChallenge.Size = new System.Drawing.Size(211, 41);
            this.btnAddChallenge.TabIndex = 8;
            this.btnAddChallenge.Text = "Add Challenge";
            this.btnAddChallenge.UseVisualStyleBackColor = true;
            this.btnAddChallenge.Click += new System.EventHandler(this.btnAddChallenge_Click);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(147, 356);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(103, 41);
            this.next.TabIndex = 7;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // prev
            // 
            this.prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev.Location = new System.Drawing.Point(26, 356);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(103, 41);
            this.prev.TabIndex = 6;
            this.prev.Text = "Previous";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // btnMarkChallengeFinished
            // 
            this.btnMarkChallengeFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkChallengeFinished.Location = new System.Drawing.Point(26, 415);
            this.btnMarkChallengeFinished.Name = "btnMarkChallengeFinished";
            this.btnMarkChallengeFinished.Size = new System.Drawing.Size(303, 41);
            this.btnMarkChallengeFinished.TabIndex = 12;
            this.btnMarkChallengeFinished.Text = "Mark Challenge as Finished";
            this.btnMarkChallengeFinished.UseVisualStyleBackColor = true;
            this.btnMarkChallengeFinished.Click += new System.EventHandler(this.btnMarkChallengeFinished_Click);
            // 
            // btnMarkChallengeCompleted
            // 
            this.btnMarkChallengeCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkChallengeCompleted.Location = new System.Drawing.Point(364, 415);
            this.btnMarkChallengeCompleted.Name = "btnMarkChallengeCompleted";
            this.btnMarkChallengeCompleted.Size = new System.Drawing.Size(294, 41);
            this.btnMarkChallengeCompleted.TabIndex = 13;
            this.btnMarkChallengeCompleted.Text = "Mark Challenge as Complete";
            this.btnMarkChallengeCompleted.UseVisualStyleBackColor = true;
            this.btnMarkChallengeCompleted.Click += new System.EventHandler(this.btnMarkChallengeCompleted_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.Enabled = false;
            this.tbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatus.Location = new System.Drawing.Point(542, 237);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(139, 28);
            this.tbStatus.TabIndex = 36;
            // 
            // tbEventName
            // 
            this.tbEventName.Enabled = false;
            this.tbEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEventName.Location = new System.Drawing.Point(542, 159);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(204, 28);
            this.tbEventName.TabIndex = 35;
            // 
            // tbEventId
            // 
            this.tbEventId.Enabled = false;
            this.tbEventId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEventId.Location = new System.Drawing.Point(542, 124);
            this.tbEventId.Name = "tbEventId";
            this.tbEventId.Size = new System.Drawing.Size(77, 28);
            this.tbEventId.TabIndex = 34;
            // 
            // tbChallengeName
            // 
            this.tbChallengeName.Enabled = false;
            this.tbChallengeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChallengeName.Location = new System.Drawing.Point(542, 86);
            this.tbChallengeName.Name = "tbChallengeName";
            this.tbChallengeName.Size = new System.Drawing.Size(203, 28);
            this.tbChallengeName.TabIndex = 33;
            // 
            // tbChallengeId
            // 
            this.tbChallengeId.Enabled = false;
            this.tbChallengeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChallengeId.Location = new System.Drawing.Point(542, 47);
            this.tbChallengeId.Name = "tbChallengeId";
            this.tbChallengeId.Size = new System.Drawing.Size(77, 28);
            this.tbChallengeId.TabIndex = 32;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(449, 240);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 25);
            this.lblStatus.TabIndex = 31;
            this.lblStatus.Text = "Status:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(414, 202);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(108, 25);
            this.lblStartTime.TabIndex = 30;
            this.lblStartTime.Text = "Start Time:";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(404, 164);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(119, 25);
            this.lblEventName.TabIndex = 29;
            this.lblEventName.Text = "Event Name";
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventID.Location = new System.Drawing.Point(436, 126);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(87, 25);
            this.lblEventID.TabIndex = 28;
            this.lblEventID.Text = "EventID:";
            // 
            // lblArenName
            // 
            this.lblArenName.AutoSize = true;
            this.lblArenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenName.Location = new System.Drawing.Point(359, 88);
            this.lblArenName.Name = "lblArenName";
            this.lblArenName.Size = new System.Drawing.Size(164, 25);
            this.lblArenName.TabIndex = 27;
            this.lblArenName.Text = "Challenge Name:";
            // 
            // lblChallegneId
            // 
            this.lblChallegneId.AutoSize = true;
            this.lblChallegneId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChallegneId.Location = new System.Drawing.Point(392, 50);
            this.lblChallegneId.Name = "lblChallegneId";
            this.lblChallegneId.Size = new System.Drawing.Size(131, 25);
            this.lblChallegneId.TabIndex = 26;
            this.lblChallegneId.Text = "Challenge ID:";
            // 
            // tbCapacity
            // 
            this.tbCapacity.Enabled = false;
            this.tbCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCapacity.Location = new System.Drawing.Point(542, 280);
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(96, 28);
            this.tbCapacity.TabIndex = 39;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(434, 283);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(89, 25);
            this.lblCapacity.TabIndex = 38;
            this.lblCapacity.Text = "Capacity";
            // 
            // lbChallenge
            // 
            this.lbChallenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChallenge.FormattingEnabled = true;
            this.lbChallenge.ItemHeight = 22;
            this.lbChallenge.Location = new System.Drawing.Point(26, 23);
            this.lbChallenge.Name = "lbChallenge";
            this.lbChallenge.Size = new System.Drawing.Size(327, 290);
            this.lbChallenge.TabIndex = 40;
            // 
            // pnAddChallenge
            // 
            this.pnAddChallenge.BackColor = System.Drawing.Color.Gainsboro;
            this.pnAddChallenge.Controls.Add(this.addStartTime);
            this.pnAddChallenge.Controls.Add(this.addEventName);
            this.pnAddChallenge.Controls.Add(this.addEventID);
            this.pnAddChallenge.Controls.Add(this.addCapacity);
            this.pnAddChallenge.Controls.Add(this.btnAddCancel);
            this.pnAddChallenge.Controls.Add(this.btnAddSaveChallenge);
            this.pnAddChallenge.Controls.Add(this.addStatus);
            this.pnAddChallenge.Controls.Add(this.label1);
            this.pnAddChallenge.Controls.Add(this.addChallengeName);
            this.pnAddChallenge.Controls.Add(this.label2);
            this.pnAddChallenge.Controls.Add(this.label3);
            this.pnAddChallenge.Controls.Add(this.label4);
            this.pnAddChallenge.Controls.Add(this.label5);
            this.pnAddChallenge.Controls.Add(this.label6);
            this.pnAddChallenge.Location = new System.Drawing.Point(49, 500);
            this.pnAddChallenge.Name = "pnAddChallenge";
            this.pnAddChallenge.Size = new System.Drawing.Size(883, 377);
            this.pnAddChallenge.TabIndex = 41;
            this.pnAddChallenge.Visible = false;
            // 
            // addStartTime
            // 
            this.addStartTime.CustomFormat = "hh:mm:tt";
            this.addStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.addStartTime.Location = new System.Drawing.Point(233, 185);
            this.addStartTime.Name = "addStartTime";
            this.addStartTime.Size = new System.Drawing.Size(145, 28);
            this.addStartTime.TabIndex = 75;
            // 
            // addEventName
            // 
            this.addEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventName.FormattingEnabled = true;
            this.addEventName.Location = new System.Drawing.Point(233, 146);
            this.addEventName.Name = "addEventName";
            this.addEventName.Size = new System.Drawing.Size(332, 30);
            this.addEventName.TabIndex = 74;
            // 
            // addEventID
            // 
            this.addEventID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventID.FormattingEnabled = true;
            this.addEventID.Location = new System.Drawing.Point(233, 104);
            this.addEventID.Name = "addEventID";
            this.addEventID.Size = new System.Drawing.Size(121, 30);
            this.addEventID.TabIndex = 73;
            this.addEventID.SelectedIndexChanged += new System.EventHandler(this.addEventID_SelectedIndexChanged);
            // 
            // addCapacity
            // 
            this.addCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCapacity.Location = new System.Drawing.Point(233, 259);
            this.addCapacity.Name = "addCapacity";
            this.addCapacity.Size = new System.Drawing.Size(74, 28);
            this.addCapacity.TabIndex = 72;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancel.Location = new System.Drawing.Point(326, 327);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(124, 35);
            this.btnAddCancel.TabIndex = 71;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAddSaveChallenge
            // 
            this.btnAddSaveChallenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSaveChallenge.Location = new System.Drawing.Point(97, 327);
            this.btnAddSaveChallenge.Name = "btnAddSaveChallenge";
            this.btnAddSaveChallenge.Size = new System.Drawing.Size(207, 35);
            this.btnAddSaveChallenge.TabIndex = 70;
            this.btnAddSaveChallenge.Text = "Save Challenge";
            this.btnAddSaveChallenge.UseVisualStyleBackColor = true;
            this.btnAddSaveChallenge.Click += new System.EventHandler(this.btnAddSaveChallenge_Click);
            // 
            // addStatus
            // 
            this.addStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStatus.FormattingEnabled = true;
            this.addStatus.Items.AddRange(new object[] {
            "Confirmed",
            "Pending"});
            this.addStatus.Location = new System.Drawing.Point(233, 223);
            this.addStatus.Name = "addStatus";
            this.addStatus.Size = new System.Drawing.Size(121, 30);
            this.addStatus.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Capacity:";
            // 
            // addChallengeName
            // 
            this.addChallengeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addChallengeName.Location = new System.Drawing.Point(233, 69);
            this.addChallengeName.Name = "addChallengeName";
            this.addChallengeName.Size = new System.Drawing.Size(203, 28);
            this.addChallengeName.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "Start Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 61;
            this.label4.Text = "Event Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "EventID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 59;
            this.label6.Text = "Challenge Name:";
            // 
            // tbStartTime
            // 
            this.tbStartTime.Enabled = false;
            this.tbStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tbStartTime.Location = new System.Drawing.Point(542, 199);
            this.tbStartTime.Name = "tbStartTime";
            this.tbStartTime.Size = new System.Drawing.Size(147, 28);
            this.tbStartTime.TabIndex = 42;
            // 
            // pnUpChallenge
            // 
            this.pnUpChallenge.BackColor = System.Drawing.Color.Gainsboro;
            this.pnUpChallenge.Controls.Add(this.tbUpStatus);
            this.pnUpChallenge.Controls.Add(this.tbUpChallengeID);
            this.pnUpChallenge.Controls.Add(this.tbUpEventName);
            this.pnUpChallenge.Controls.Add(this.button1);
            this.pnUpChallenge.Controls.Add(this.btnUpSaveChanges);
            this.pnUpChallenge.Controls.Add(this.tbUpStartTime);
            this.pnUpChallenge.Controls.Add(this.tbUpCapacity);
            this.pnUpChallenge.Controls.Add(this.label7);
            this.pnUpChallenge.Controls.Add(this.tbUpChallengeName);
            this.pnUpChallenge.Controls.Add(this.label8);
            this.pnUpChallenge.Controls.Add(this.label9);
            this.pnUpChallenge.Controls.Add(this.label10);
            this.pnUpChallenge.Controls.Add(this.label11);
            this.pnUpChallenge.Controls.Add(this.label12);
            this.pnUpChallenge.Location = new System.Drawing.Point(844, 35);
            this.pnUpChallenge.Name = "pnUpChallenge";
            this.pnUpChallenge.Size = new System.Drawing.Size(880, 374);
            this.pnUpChallenge.TabIndex = 43;
            this.pnUpChallenge.Visible = false;
            // 
            // tbUpStatus
            // 
            this.tbUpStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpStatus.Location = new System.Drawing.Point(233, 197);
            this.tbUpStatus.Name = "tbUpStatus";
            this.tbUpStatus.ReadOnly = true;
            this.tbUpStatus.Size = new System.Drawing.Size(222, 28);
            this.tbUpStatus.TabIndex = 92;
            // 
            // tbUpChallengeID
            // 
            this.tbUpChallengeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpChallengeID.Location = new System.Drawing.Point(233, 35);
            this.tbUpChallengeID.Name = "tbUpChallengeID";
            this.tbUpChallengeID.ReadOnly = true;
            this.tbUpChallengeID.Size = new System.Drawing.Size(61, 28);
            this.tbUpChallengeID.TabIndex = 91;
            // 
            // tbUpEventName
            // 
            this.tbUpEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpEventName.Location = new System.Drawing.Point(233, 119);
            this.tbUpEventName.Name = "tbUpEventName";
            this.tbUpEventName.ReadOnly = true;
            this.tbUpEventName.Size = new System.Drawing.Size(347, 28);
            this.tbUpEventName.TabIndex = 90;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(316, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 35);
            this.button1.TabIndex = 89;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpSaveChanges
            // 
            this.btnUpSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpSaveChanges.Location = new System.Drawing.Point(87, 312);
            this.btnUpSaveChanges.Name = "btnUpSaveChanges";
            this.btnUpSaveChanges.Size = new System.Drawing.Size(207, 35);
            this.btnUpSaveChanges.TabIndex = 88;
            this.btnUpSaveChanges.Text = "Save Changes";
            this.btnUpSaveChanges.UseVisualStyleBackColor = true;
            this.btnUpSaveChanges.Click += new System.EventHandler(this.btnUpSaveChanges_Click);
            // 
            // tbUpStartTime
            // 
            this.tbUpStartTime.CustomFormat = "hh:mm:tt";
            this.tbUpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tbUpStartTime.Location = new System.Drawing.Point(235, 160);
            this.tbUpStartTime.Name = "tbUpStartTime";
            this.tbUpStartTime.Size = new System.Drawing.Size(133, 28);
            this.tbUpStartTime.TabIndex = 87;
            // 
            // tbUpCapacity
            // 
            this.tbUpCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpCapacity.Location = new System.Drawing.Point(235, 234);
            this.tbUpCapacity.Name = "tbUpCapacity";
            this.tbUpCapacity.Size = new System.Drawing.Size(74, 28);
            this.tbUpCapacity.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 82;
            this.label7.Text = "Capacity:";
            // 
            // tbUpChallengeName
            // 
            this.tbUpChallengeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpChallengeName.Location = new System.Drawing.Point(235, 76);
            this.tbUpChallengeName.Name = "tbUpChallengeName";
            this.tbUpChallengeName.Size = new System.Drawing.Size(203, 28);
            this.tbUpChallengeName.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(139, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 80;
            this.label8.Text = "Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(104, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 25);
            this.label9.TabIndex = 79;
            this.label9.Text = "Start Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(94, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 25);
            this.label10.TabIndex = 78;
            this.label10.Text = "Event Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(79, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 25);
            this.label11.TabIndex = 77;
            this.label11.Text = "Challenge ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(49, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 25);
            this.label12.TabIndex = 76;
            this.label12.Text = "Challenge Name:";
            // 
            // ChallengeMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1422, 877);
            this.Controls.Add(this.pnUpChallenge);
            this.Controls.Add(this.tbStartTime);
            this.Controls.Add(this.pnAddChallenge);
            this.Controls.Add(this.lbChallenge);
            this.Controls.Add(this.tbCapacity);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbEventName);
            this.Controls.Add(this.tbEventId);
            this.Controls.Add(this.tbChallengeName);
            this.Controls.Add(this.tbChallengeId);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.lblEventID);
            this.Controls.Add(this.lblArenName);
            this.Controls.Add(this.lblChallegneId);
            this.Controls.Add(this.btnMarkChallengeCompleted);
            this.Controls.Add(this.btnMarkChallengeFinished);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteChallenge);
            this.Controls.Add(this.btnUpdateChallenge);
            this.Controls.Add(this.btnAddChallenge);
            this.Controls.Add(this.next);
            this.Controls.Add(this.prev);
            this.Name = "ChallengeMaintenance";
            this.Text = "Challenge Maintenance";
            this.Load += new System.EventHandler(this.ChallengeMaintenance_Load);
            this.pnAddChallenge.ResumeLayout(false);
            this.pnAddChallenge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCapacity)).EndInit();
            this.pnUpChallenge.ResumeLayout(false);
            this.pnUpChallenge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUpCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteChallenge;
        private System.Windows.Forms.Button btnUpdateChallenge;
        private System.Windows.Forms.Button btnAddChallenge;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button btnMarkChallengeFinished;
        private System.Windows.Forms.Button btnMarkChallengeCompleted;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.TextBox tbEventId;
        private System.Windows.Forms.TextBox tbChallengeName;
        private System.Windows.Forms.TextBox tbChallengeId;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.Label lblArenName;
        private System.Windows.Forms.Label lblChallegneId;
        private System.Windows.Forms.TextBox tbCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.ListBox lbChallenge;
        private System.Windows.Forms.Panel pnAddChallenge;
        private System.Windows.Forms.NumericUpDown addCapacity;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddSaveChallenge;
        private System.Windows.Forms.ComboBox addStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addChallengeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addEventName;
        private System.Windows.Forms.ComboBox addEventID;
        private System.Windows.Forms.DateTimePicker addStartTime;
        private System.Windows.Forms.DateTimePicker tbStartTime;
        private System.Windows.Forms.Panel pnUpChallenge;
        private System.Windows.Forms.TextBox tbUpStatus;
        private System.Windows.Forms.TextBox tbUpChallengeID;
        private System.Windows.Forms.TextBox tbUpEventName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpSaveChanges;
        private System.Windows.Forms.DateTimePicker tbUpStartTime;
        private System.Windows.Forms.NumericUpDown tbUpCapacity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUpChallengeName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}