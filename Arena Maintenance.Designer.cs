namespace week2
{
    partial class ArenaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArenaForm));
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddArena = new System.Windows.Forms.Button();
            this.btnUpdateArena = new System.Windows.Forms.Button();
            this.btnDeleteArena = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.arenaId = new System.Windows.Forms.Label();
            this.aName = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.Label();
            this.suburb = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.pNum = new System.Windows.Forms.Label();
            this.lbMaintenance = new System.Windows.Forms.ListBox();
            this.tbArenId = new System.Windows.Forms.TextBox();
            this.tbArenaName = new System.Windows.Forms.TextBox();
            this.tbStreetAddress = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbSuburb = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.pnlAddArena = new System.Windows.Forms.Panel();
            this.tbAddCity = new System.Windows.Forms.TextBox();
            this.tbAddPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbAddSuburb = new System.Windows.Forms.TextBox();
            this.tbAddStreetAddress = new System.Windows.Forms.TextBox();
            this.tbAddArenaName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveArena = new System.Windows.Forms.Button();
            this.pnUpdateArena = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnBtnUpArena = new System.Windows.Forms.Button();
            this.pnUpcbCity = new System.Windows.Forms.ComboBox();
            this.pnUpPhoneNumber = new System.Windows.Forms.TextBox();
            this.pnUpSuburb = new System.Windows.Forms.TextBox();
            this.pnUpStreetAdress = new System.Windows.Forms.TextBox();
            this.pnUpArenaName = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblStreetAdress = new System.Windows.Forms.Label();
            this.lblArenaName = new System.Windows.Forms.Label();
            this.pnlAddArena.SuspendLayout();
            this.pnUpdateArena.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(36, 338);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(103, 41);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.prev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(157, 338);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(103, 41);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.next_Click);
            // 
            // btnAddArena
            // 
            this.btnAddArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArena.Location = new System.Drawing.Point(285, 338);
            this.btnAddArena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddArena.Name = "btnAddArena";
            this.btnAddArena.Size = new System.Drawing.Size(141, 41);
            this.btnAddArena.TabIndex = 2;
            this.btnAddArena.Text = "Add Arena";
            this.btnAddArena.UseVisualStyleBackColor = true;
            this.btnAddArena.Click += new System.EventHandler(this.add_Click);
            // 
            // btnUpdateArena
            // 
            this.btnUpdateArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateArena.Location = new System.Drawing.Point(443, 338);
            this.btnUpdateArena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateArena.Name = "btnUpdateArena";
            this.btnUpdateArena.Size = new System.Drawing.Size(168, 41);
            this.btnUpdateArena.TabIndex = 3;
            this.btnUpdateArena.Text = "Update Arena";
            this.btnUpdateArena.UseVisualStyleBackColor = true;
            this.btnUpdateArena.Click += new System.EventHandler(this.btnUpdateArena_Click);
            // 
            // btnDeleteArena
            // 
            this.btnDeleteArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteArena.Location = new System.Drawing.Point(627, 338);
            this.btnDeleteArena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteArena.Name = "btnDeleteArena";
            this.btnDeleteArena.Size = new System.Drawing.Size(161, 41);
            this.btnDeleteArena.TabIndex = 4;
            this.btnDeleteArena.Text = "Delete Arena";
            this.btnDeleteArena.UseVisualStyleBackColor = true;
            this.btnDeleteArena.Click += new System.EventHandler(this.delete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(685, 398);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(103, 41);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.ret_Click);
            // 
            // arenaId
            // 
            this.arenaId.AutoSize = true;
            this.arenaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arenaId.Location = new System.Drawing.Point(453, 30);
            this.arenaId.Name = "arenaId";
            this.arenaId.Size = new System.Drawing.Size(95, 25);
            this.arenaId.TabIndex = 6;
            this.arenaId.Text = "Arena ID:";
            // 
            // aName
            // 
            this.aName.AutoSize = true;
            this.aName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aName.Location = new System.Drawing.Point(421, 68);
            this.aName.Name = "aName";
            this.aName.Size = new System.Drawing.Size(128, 25);
            this.aName.TabIndex = 7;
            this.aName.Text = "Arena Name:";
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.street.Location = new System.Drawing.Point(401, 106);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(148, 25);
            this.street.TabIndex = 8;
            this.street.Text = "Street Address:";
            // 
            // suburb
            // 
            this.suburb.AutoSize = true;
            this.suburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suburb.Location = new System.Drawing.Point(467, 144);
            this.suburb.Name = "suburb";
            this.suburb.Size = new System.Drawing.Size(82, 25);
            this.suburb.TabIndex = 9;
            this.suburb.Text = "Suburb:";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(497, 182);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(52, 25);
            this.city.TabIndex = 10;
            this.city.Text = "City:";
            this.city.Click += new System.EventHandler(this.city_Click);
            // 
            // pNum
            // 
            this.pNum.AutoSize = true;
            this.pNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNum.Location = new System.Drawing.Point(400, 220);
            this.pNum.Name = "pNum";
            this.pNum.Size = new System.Drawing.Size(149, 25);
            this.pNum.TabIndex = 11;
            this.pNum.Text = "Phone Number:";
            // 
            // lbMaintenance
            // 
            this.lbMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaintenance.FormattingEnabled = true;
            this.lbMaintenance.ItemHeight = 22;
            this.lbMaintenance.Location = new System.Drawing.Point(36, 14);
            this.lbMaintenance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMaintenance.Name = "lbMaintenance";
            this.lbMaintenance.Size = new System.Drawing.Size(321, 268);
            this.lbMaintenance.TabIndex = 12;
            // 
            // tbArenId
            // 
            this.tbArenId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArenId.Location = new System.Drawing.Point(584, 30);
            this.tbArenId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbArenId.Name = "tbArenId";
            this.tbArenId.ReadOnly = true;
            this.tbArenId.Size = new System.Drawing.Size(77, 28);
            this.tbArenId.TabIndex = 13;
            // 
            // tbArenaName
            // 
            this.tbArenaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArenaName.Location = new System.Drawing.Point(584, 66);
            this.tbArenaName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbArenaName.Name = "tbArenaName";
            this.tbArenaName.ReadOnly = true;
            this.tbArenaName.Size = new System.Drawing.Size(203, 28);
            this.tbArenaName.TabIndex = 14;
            // 
            // tbStreetAddress
            // 
            this.tbStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStreetAddress.Location = new System.Drawing.Point(584, 104);
            this.tbStreetAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStreetAddress.Name = "tbStreetAddress";
            this.tbStreetAddress.ReadOnly = true;
            this.tbStreetAddress.Size = new System.Drawing.Size(285, 28);
            this.tbStreetAddress.TabIndex = 15;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(584, 217);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.ReadOnly = true;
            this.tbPhoneNumber.Size = new System.Drawing.Size(204, 28);
            this.tbPhoneNumber.TabIndex = 24;
            // 
            // tbSuburb
            // 
            this.tbSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuburb.Location = new System.Drawing.Point(583, 140);
            this.tbSuburb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSuburb.Name = "tbSuburb";
            this.tbSuburb.ReadOnly = true;
            this.tbSuburb.Size = new System.Drawing.Size(204, 28);
            this.tbSuburb.TabIndex = 23;
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(583, 176);
            this.tbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCity.Name = "tbCity";
            this.tbCity.ReadOnly = true;
            this.tbCity.Size = new System.Drawing.Size(204, 28);
            this.tbCity.TabIndex = 25;
            // 
            // pnlAddArena
            // 
            this.pnlAddArena.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlAddArena.Controls.Add(this.tbAddCity);
            this.pnlAddArena.Controls.Add(this.tbAddPhoneNumber);
            this.pnlAddArena.Controls.Add(this.tbAddSuburb);
            this.pnlAddArena.Controls.Add(this.tbAddStreetAddress);
            this.pnlAddArena.Controls.Add(this.tbAddArenaName);
            this.pnlAddArena.Controls.Add(this.label1);
            this.pnlAddArena.Controls.Add(this.label2);
            this.pnlAddArena.Controls.Add(this.label3);
            this.pnlAddArena.Controls.Add(this.label4);
            this.pnlAddArena.Controls.Add(this.label5);
            this.pnlAddArena.Controls.Add(this.btnCancel);
            this.pnlAddArena.Controls.Add(this.btnSaveArena);
            this.pnlAddArena.Location = new System.Drawing.Point(12, 441);
            this.pnlAddArena.Name = "pnlAddArena";
            this.pnlAddArena.Size = new System.Drawing.Size(829, 305);
            this.pnlAddArena.TabIndex = 26;
            this.pnlAddArena.Visible = false;
            this.pnlAddArena.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddArena_Paint);
            // 
            // tbAddCity
            // 
            this.tbAddCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddCity.Location = new System.Drawing.Point(191, 121);
            this.tbAddCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddCity.Name = "tbAddCity";
            this.tbAddCity.Size = new System.Drawing.Size(204, 28);
            this.tbAddCity.TabIndex = 61;
            // 
            // tbAddPhoneNumber
            // 
            this.tbAddPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddPhoneNumber.Location = new System.Drawing.Point(191, 165);
            this.tbAddPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddPhoneNumber.Name = "tbAddPhoneNumber";
            this.tbAddPhoneNumber.Size = new System.Drawing.Size(204, 28);
            this.tbAddPhoneNumber.TabIndex = 60;
            // 
            // tbAddSuburb
            // 
            this.tbAddSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddSuburb.Location = new System.Drawing.Point(191, 85);
            this.tbAddSuburb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddSuburb.Name = "tbAddSuburb";
            this.tbAddSuburb.Size = new System.Drawing.Size(204, 28);
            this.tbAddSuburb.TabIndex = 59;
            // 
            // tbAddStreetAddress
            // 
            this.tbAddStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddStreetAddress.Location = new System.Drawing.Point(192, 49);
            this.tbAddStreetAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddStreetAddress.Name = "tbAddStreetAddress";
            this.tbAddStreetAddress.Size = new System.Drawing.Size(285, 28);
            this.tbAddStreetAddress.TabIndex = 58;
            // 
            // tbAddArenaName
            // 
            this.tbAddArenaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddArenaName.Location = new System.Drawing.Point(192, 11);
            this.tbAddArenaName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAddArenaName.Name = "tbAddArenaName";
            this.tbAddArenaName.Size = new System.Drawing.Size(203, 28);
            this.tbAddArenaName.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Suburb:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 53;
            this.label4.Text = "Street Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "Arena Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(318, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 43);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveArena
            // 
            this.btnSaveArena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveArena.Location = new System.Drawing.Point(37, 220);
            this.btnSaveArena.Name = "btnSaveArena";
            this.btnSaveArena.Size = new System.Drawing.Size(212, 43);
            this.btnSaveArena.TabIndex = 50;
            this.btnSaveArena.Text = "Save Arena";
            this.btnSaveArena.UseVisualStyleBackColor = true;
            this.btnSaveArena.Click += new System.EventHandler(this.btnSaveArena_Click);
            // 
            // pnUpdateArena
            // 
            this.pnUpdateArena.BackColor = System.Drawing.Color.Gainsboro;
            this.pnUpdateArena.Controls.Add(this.button1);
            this.pnUpdateArena.Controls.Add(this.pnBtnUpArena);
            this.pnUpdateArena.Controls.Add(this.pnUpcbCity);
            this.pnUpdateArena.Controls.Add(this.pnUpPhoneNumber);
            this.pnUpdateArena.Controls.Add(this.pnUpSuburb);
            this.pnUpdateArena.Controls.Add(this.pnUpStreetAdress);
            this.pnUpdateArena.Controls.Add(this.pnUpArenaName);
            this.pnUpdateArena.Controls.Add(this.lblCity);
            this.pnUpdateArena.Controls.Add(this.lblPhoneNumber);
            this.pnUpdateArena.Controls.Add(this.lblSuburb);
            this.pnUpdateArena.Controls.Add(this.lblStreetAdress);
            this.pnUpdateArena.Controls.Add(this.lblArenaName);
            this.pnUpdateArena.Location = new System.Drawing.Point(867, 30);
            this.pnUpdateArena.Name = "pnUpdateArena";
            this.pnUpdateArena.Size = new System.Drawing.Size(829, 310);
            this.pnUpdateArena.TabIndex = 27;
            this.pnUpdateArena.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(360, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 43);
            this.button1.TabIndex = 53;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnBtnUpArena
            // 
            this.pnBtnUpArena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnBtnUpArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnBtnUpArena.Location = new System.Drawing.Point(76, 242);
            this.pnBtnUpArena.Name = "pnBtnUpArena";
            this.pnBtnUpArena.Size = new System.Drawing.Size(212, 43);
            this.pnBtnUpArena.TabIndex = 52;
            this.pnBtnUpArena.Text = "Save Changes";
            this.pnBtnUpArena.UseVisualStyleBackColor = true;
            this.pnBtnUpArena.Click += new System.EventHandler(this.pnBtnUpArena_Click);
            // 
            // pnUpcbCity
            // 
            this.pnUpcbCity.BackColor = System.Drawing.SystemColors.Window;
            this.pnUpcbCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnUpcbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnUpcbCity.FormattingEnabled = true;
            this.pnUpcbCity.Items.AddRange(new object[] {
            "Auckland",
            "Wellington",
            "Christchurch",
            "Dunedin",
            "Napier",
            "Hamilton",
            "Tauranga"});
            this.pnUpcbCity.Location = new System.Drawing.Point(168, 141);
            this.pnUpcbCity.Name = "pnUpcbCity";
            this.pnUpcbCity.Size = new System.Drawing.Size(218, 33);
            this.pnUpcbCity.TabIndex = 22;
            // 
            // pnUpPhoneNumber
            // 
            this.pnUpPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.pnUpPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnUpPhoneNumber.Location = new System.Drawing.Point(168, 189);
            this.pnUpPhoneNumber.Name = "pnUpPhoneNumber";
            this.pnUpPhoneNumber.Size = new System.Drawing.Size(253, 30);
            this.pnUpPhoneNumber.TabIndex = 21;
            // 
            // pnUpSuburb
            // 
            this.pnUpSuburb.BackColor = System.Drawing.SystemColors.Window;
            this.pnUpSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnUpSuburb.Location = new System.Drawing.Point(168, 98);
            this.pnUpSuburb.Name = "pnUpSuburb";
            this.pnUpSuburb.Size = new System.Drawing.Size(276, 30);
            this.pnUpSuburb.TabIndex = 20;
            // 
            // pnUpStreetAdress
            // 
            this.pnUpStreetAdress.BackColor = System.Drawing.SystemColors.Window;
            this.pnUpStreetAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnUpStreetAdress.Location = new System.Drawing.Point(169, 54);
            this.pnUpStreetAdress.Name = "pnUpStreetAdress";
            this.pnUpStreetAdress.Size = new System.Drawing.Size(353, 30);
            this.pnUpStreetAdress.TabIndex = 19;
            // 
            // pnUpArenaName
            // 
            this.pnUpArenaName.BackColor = System.Drawing.SystemColors.Window;
            this.pnUpArenaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnUpArenaName.Location = new System.Drawing.Point(169, 7);
            this.pnUpArenaName.Name = "pnUpArenaName";
            this.pnUpArenaName.Size = new System.Drawing.Size(275, 30);
            this.pnUpArenaName.TabIndex = 18;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(100, 146);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(53, 25);
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "CIty:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(4, 191);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(149, 25);
            this.lblPhoneNumber.TabIndex = 16;
            this.lblPhoneNumber.Text = "Phone Number:";
            this.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuburb.Location = new System.Drawing.Point(71, 101);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(82, 25);
            this.lblSuburb.TabIndex = 15;
            this.lblSuburb.Text = "Suburb:";
            this.lblSuburb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStreetAdress
            // 
            this.lblStreetAdress.AutoSize = true;
            this.lblStreetAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAdress.Location = new System.Drawing.Point(5, 56);
            this.lblStreetAdress.Name = "lblStreetAdress";
            this.lblStreetAdress.Size = new System.Drawing.Size(148, 25);
            this.lblStreetAdress.TabIndex = 14;
            this.lblStreetAdress.Text = "Street Address:";
            this.lblStreetAdress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArenaName
            // 
            this.lblArenaName.AutoSize = true;
            this.lblArenaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaName.Location = new System.Drawing.Point(25, 11);
            this.lblArenaName.Name = "lblArenaName";
            this.lblArenaName.Size = new System.Drawing.Size(128, 25);
            this.lblArenaName.TabIndex = 13;
            this.lblArenaName.Text = "Arena Name:";
            this.lblArenaName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArenaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1632, 758);
            this.Controls.Add(this.pnlAddArena);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteArena);
            this.Controls.Add(this.btnUpdateArena);
            this.Controls.Add(this.btnAddArena);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.pnUpdateArena);
            this.Controls.Add(this.lbMaintenance);
            this.Controls.Add(this.arenaId);
            this.Controls.Add(this.aName);
            this.Controls.Add(this.street);
            this.Controls.Add(this.suburb);
            this.Controls.Add(this.city);
            this.Controls.Add(this.pNum);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbSuburb);
            this.Controls.Add(this.tbStreetAddress);
            this.Controls.Add(this.tbArenaName);
            this.Controls.Add(this.tbArenId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ArenaForm";
            this.Text = "Arena Maintenance";
            this.Load += new System.EventHandler(this.Arena_Maintenance_Load);
            this.pnlAddArena.ResumeLayout(false);
            this.pnlAddArena.PerformLayout();
            this.pnUpdateArena.ResumeLayout(false);
            this.pnUpdateArena.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddArena;
        private System.Windows.Forms.Button btnUpdateArena;
        private System.Windows.Forms.Button btnDeleteArena;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label arenaId;
        private System.Windows.Forms.Label aName;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Label suburb;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label pNum;
        private System.Windows.Forms.ListBox lbMaintenance;
        private System.Windows.Forms.TextBox tbArenId;
        private System.Windows.Forms.TextBox tbArenaName;
        private System.Windows.Forms.TextBox tbStreetAddress;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbSuburb;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Panel pnlAddArena;
        private System.Windows.Forms.TextBox tbAddCity;
        private System.Windows.Forms.TextBox tbAddPhoneNumber;
        private System.Windows.Forms.TextBox tbAddSuburb;
        private System.Windows.Forms.TextBox tbAddStreetAddress;
        private System.Windows.Forms.TextBox tbAddArenaName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveArena;
        private System.Windows.Forms.Panel pnUpdateArena;
        private System.Windows.Forms.ComboBox pnUpcbCity;
        private System.Windows.Forms.TextBox pnUpPhoneNumber;
        private System.Windows.Forms.TextBox pnUpSuburb;
        private System.Windows.Forms.TextBox pnUpStreetAdress;
        private System.Windows.Forms.TextBox pnUpArenaName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblStreetAdress;
        private System.Windows.Forms.Label lblArenaName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pnBtnUpArena;
    }
}