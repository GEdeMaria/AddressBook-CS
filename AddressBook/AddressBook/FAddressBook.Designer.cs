namespace AddressBook
{
    partial class FAddressBook
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            spcMain = new SplitContainer();
            tlpContacts = new TableLayoutPanel();
            lbxContacts = new ListBox();
            btnCreateContact = new Button();
            btnDeleteContact = new Button();
            grbContact = new GroupBox();
            tlpData = new TableLayoutPanel();
            lblPhone = new Label();
            txtLine1 = new TextBox();
            txtLine2 = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtCountry = new TextBox();
            lblZip = new Label();
            lblCountry = new Label();
            lblState = new Label();
            lblCity = new Label();
            lblLine2 = new Label();
            lblLine1 = new Label();
            ckbEmailType = new CheckBox();
            cbxPhoneType = new ComboBox();
            lblEmail = new Label();
            lblNotes = new Label();
            lblSuffix = new Label();
            lblLast = new Label();
            lblMiddle = new Label();
            lblFirst = new Label();
            lblPrefix = new Label();
            txtNotes = new TextBox();
            txtPrefix = new TextBox();
            txtFirst = new TextBox();
            txtMiddle = new TextBox();
            txtLast = new TextBox();
            txtSuffix = new TextBox();
            txtZip = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)spcMain).BeginInit();
            spcMain.Panel1.SuspendLayout();
            spcMain.Panel2.SuspendLayout();
            spcMain.SuspendLayout();
            tlpContacts.SuspendLayout();
            grbContact.SuspendLayout();
            tlpData.SuspendLayout();
            SuspendLayout();
            // 
            // spcMain
            // 
            spcMain.Dock = DockStyle.Fill;
            spcMain.Location = new Point(0, 0);
            spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            spcMain.Panel1.Controls.Add(tlpContacts);
            spcMain.Panel1MinSize = 220;
            // 
            // spcMain.Panel2
            // 
            spcMain.Panel2.Controls.Add(grbContact);
            spcMain.Size = new Size(619, 426);
            spcMain.SplitterDistance = 223;
            spcMain.TabIndex = 0;
            // 
            // tlpContacts
            // 
            tlpContacts.ColumnCount = 3;
            tlpContacts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpContacts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpContacts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpContacts.Controls.Add(lbxContacts, 0, 0);
            tlpContacts.Controls.Add(btnCreateContact, 0, 1);
            tlpContacts.Controls.Add(btnDeleteContact, 2, 1);
            tlpContacts.Dock = DockStyle.Fill;
            tlpContacts.Location = new Point(0, 0);
            tlpContacts.Name = "tlpContacts";
            tlpContacts.RowCount = 2;
            tlpContacts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContacts.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpContacts.Size = new Size(223, 426);
            tlpContacts.TabIndex = 0;
            // 
            // lbxContacts
            // 
            tlpContacts.SetColumnSpan(lbxContacts, 3);
            lbxContacts.Dock = DockStyle.Fill;
            lbxContacts.FormattingEnabled = true;
            lbxContacts.ItemHeight = 15;
            lbxContacts.Location = new Point(3, 3);
            lbxContacts.Name = "lbxContacts";
            lbxContacts.Size = new Size(217, 386);
            lbxContacts.TabIndex = 0;
            lbxContacts.SelectedIndexChanged += lbxContacts_SelectedIndexChanged;
            // 
            // btnCreateContact
            // 
            btnCreateContact.Dock = DockStyle.Fill;
            btnCreateContact.Location = new Point(3, 395);
            btnCreateContact.Name = "btnCreateContact";
            btnCreateContact.Size = new Size(68, 28);
            btnCreateContact.TabIndex = 1;
            btnCreateContact.Text = "Create";
            btnCreateContact.UseVisualStyleBackColor = true;
            btnCreateContact.Click += btnCreateContact_Click;
            // 
            // btnDeleteContact
            // 
            btnDeleteContact.Dock = DockStyle.Fill;
            btnDeleteContact.Location = new Point(151, 395);
            btnDeleteContact.Name = "btnDeleteContact";
            btnDeleteContact.Size = new Size(69, 28);
            btnDeleteContact.TabIndex = 3;
            btnDeleteContact.Text = "Delete";
            btnDeleteContact.UseVisualStyleBackColor = true;
            btnDeleteContact.Click += btnDeleteContact_Click;
            // 
            // grbContact
            // 
            grbContact.Controls.Add(tlpData);
            grbContact.Dock = DockStyle.Fill;
            grbContact.Location = new Point(0, 0);
            grbContact.Name = "grbContact";
            grbContact.Size = new Size(392, 426);
            grbContact.TabIndex = 0;
            grbContact.TabStop = false;
            grbContact.Text = "Contact:";
            // 
            // tlpData
            // 
            tlpData.ColumnCount = 5;
            tlpData.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tlpData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpData.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tlpData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpData.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            tlpData.Controls.Add(lblPhone, 0, 7);
            tlpData.Controls.Add(txtLine1, 3, 0);
            tlpData.Controls.Add(txtLine2, 3, 1);
            tlpData.Controls.Add(txtCity, 3, 2);
            tlpData.Controls.Add(txtState, 3, 3);
            tlpData.Controls.Add(txtCountry, 3, 4);
            tlpData.Controls.Add(lblZip, 2, 5);
            tlpData.Controls.Add(lblCountry, 2, 4);
            tlpData.Controls.Add(lblState, 2, 3);
            tlpData.Controls.Add(lblCity, 2, 2);
            tlpData.Controls.Add(lblLine2, 2, 1);
            tlpData.Controls.Add(lblLine1, 2, 0);
            tlpData.Controls.Add(ckbEmailType, 4, 6);
            tlpData.Controls.Add(cbxPhoneType, 4, 7);
            tlpData.Controls.Add(lblEmail, 0, 6);
            tlpData.Controls.Add(lblNotes, 0, 5);
            tlpData.Controls.Add(lblSuffix, 0, 4);
            tlpData.Controls.Add(lblLast, 0, 3);
            tlpData.Controls.Add(lblMiddle, 0, 2);
            tlpData.Controls.Add(lblFirst, 0, 1);
            tlpData.Controls.Add(lblPrefix, 0, 0);
            tlpData.Controls.Add(txtNotes, 1, 5);
            tlpData.Controls.Add(txtPrefix, 1, 0);
            tlpData.Controls.Add(txtFirst, 1, 1);
            tlpData.Controls.Add(txtMiddle, 1, 2);
            tlpData.Controls.Add(txtLast, 1, 3);
            tlpData.Controls.Add(txtSuffix, 1, 4);
            tlpData.Controls.Add(txtZip, 3, 5);
            tlpData.Controls.Add(txtEmail, 1, 6);
            tlpData.Controls.Add(txtPhone, 1, 7);
            tlpData.Dock = DockStyle.Fill;
            tlpData.Location = new Point(3, 19);
            tlpData.Name = "tlpData";
            tlpData.RowCount = 9;
            tlpData.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpData.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpData.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpData.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpData.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpData.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpData.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpData.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpData.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpData.Size = new Size(386, 404);
            tlpData.TabIndex = 30;
            // 
            // lblPhone
            // 
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Location = new Point(3, 210);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(49, 30);
            lblPhone.TabIndex = 26;
            lblPhone.Text = "Phone:";
            lblPhone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtLine1
            // 
            tlpData.SetColumnSpan(txtLine1, 2);
            txtLine1.Dock = DockStyle.Fill;
            txtLine1.Location = new Point(208, 3);
            txtLine1.Name = "txtLine1";
            txtLine1.Size = new Size(175, 23);
            txtLine1.TabIndex = 13;
            txtLine1.TextChanged += txtLine1_TextChanged;
            // 
            // txtLine2
            // 
            tlpData.SetColumnSpan(txtLine2, 2);
            txtLine2.Dock = DockStyle.Fill;
            txtLine2.Location = new Point(208, 33);
            txtLine2.Name = "txtLine2";
            txtLine2.Size = new Size(175, 23);
            txtLine2.TabIndex = 15;
            txtLine2.TextChanged += txtLine2_TextChanged;
            // 
            // txtCity
            // 
            tlpData.SetColumnSpan(txtCity, 2);
            txtCity.Dock = DockStyle.Fill;
            txtCity.Location = new Point(208, 63);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(175, 23);
            txtCity.TabIndex = 17;
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // txtState
            // 
            tlpData.SetColumnSpan(txtState, 2);
            txtState.Dock = DockStyle.Fill;
            txtState.Location = new Point(208, 93);
            txtState.Name = "txtState";
            txtState.Size = new Size(175, 23);
            txtState.TabIndex = 19;
            txtState.TextChanged += txtState_TextChanged;
            // 
            // txtCountry
            // 
            tlpData.SetColumnSpan(txtCountry, 2);
            txtCountry.Dock = DockStyle.Fill;
            txtCountry.Location = new Point(208, 123);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(175, 23);
            txtCountry.TabIndex = 21;
            txtCountry.TextChanged += txtCountry_TextChanged;
            // 
            // lblZip
            // 
            lblZip.Dock = DockStyle.Fill;
            lblZip.Location = new Point(146, 150);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(56, 30);
            lblZip.TabIndex = 22;
            lblZip.Text = "Zip:";
            lblZip.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCountry
            // 
            lblCountry.Dock = DockStyle.Fill;
            lblCountry.Location = new Point(146, 120);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(56, 30);
            lblCountry.TabIndex = 20;
            lblCountry.Text = "Country:";
            lblCountry.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblState
            // 
            lblState.Dock = DockStyle.Fill;
            lblState.Location = new Point(146, 90);
            lblState.Name = "lblState";
            lblState.Size = new Size(56, 30);
            lblState.TabIndex = 18;
            lblState.Text = "State:";
            lblState.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCity
            // 
            lblCity.Dock = DockStyle.Fill;
            lblCity.Location = new Point(146, 60);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(56, 30);
            lblCity.TabIndex = 16;
            lblCity.Text = "City:";
            lblCity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLine2
            // 
            lblLine2.Dock = DockStyle.Fill;
            lblLine2.Location = new Point(146, 30);
            lblLine2.Name = "lblLine2";
            lblLine2.Size = new Size(56, 30);
            lblLine2.TabIndex = 14;
            lblLine2.Text = "Line 2:";
            lblLine2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLine1
            // 
            lblLine1.Dock = DockStyle.Fill;
            lblLine1.Location = new Point(146, 0);
            lblLine1.Name = "lblLine1";
            lblLine1.Size = new Size(56, 30);
            lblLine1.TabIndex = 12;
            lblLine1.Text = "Line 1:";
            lblLine1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ckbEmailType
            // 
            ckbEmailType.Dock = DockStyle.Fill;
            ckbEmailType.Location = new Point(296, 183);
            ckbEmailType.Name = "ckbEmailType";
            ckbEmailType.Size = new Size(87, 24);
            ckbEmailType.TabIndex = 28;
            ckbEmailType.Text = "Personal";
            ckbEmailType.UseVisualStyleBackColor = true;
            ckbEmailType.CheckedChanged += ckbEmailType_CheckedChanged;
            // 
            // cbxPhoneType
            // 
            cbxPhoneType.Dock = DockStyle.Fill;
            cbxPhoneType.FormattingEnabled = true;
            cbxPhoneType.Items.AddRange(new object[] { "Work", "Home", "Cell" });
            cbxPhoneType.Location = new Point(296, 213);
            cbxPhoneType.Name = "cbxPhoneType";
            cbxPhoneType.Size = new Size(87, 23);
            cbxPhoneType.TabIndex = 29;
            cbxPhoneType.Text = "Work";
            cbxPhoneType.SelectedIndexChanged += cbxPhoneType_SelectedIndexChanged;
            // 
            // lblEmail
            // 
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Location = new Point(3, 180);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 30);
            lblEmail.TabIndex = 24;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNotes
            // 
            lblNotes.Dock = DockStyle.Fill;
            lblNotes.Location = new Point(3, 150);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(49, 30);
            lblNotes.TabIndex = 10;
            lblNotes.Text = "Notes:";
            lblNotes.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSuffix
            // 
            lblSuffix.Dock = DockStyle.Fill;
            lblSuffix.Location = new Point(3, 120);
            lblSuffix.Name = "lblSuffix";
            lblSuffix.Size = new Size(49, 30);
            lblSuffix.TabIndex = 8;
            lblSuffix.Text = "Suffix:";
            lblSuffix.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLast
            // 
            lblLast.Dock = DockStyle.Fill;
            lblLast.Location = new Point(3, 90);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(49, 30);
            lblLast.TabIndex = 6;
            lblLast.Text = "Last:";
            lblLast.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMiddle
            // 
            lblMiddle.Dock = DockStyle.Fill;
            lblMiddle.Location = new Point(3, 60);
            lblMiddle.Name = "lblMiddle";
            lblMiddle.Size = new Size(49, 30);
            lblMiddle.TabIndex = 4;
            lblMiddle.Text = "Middle:";
            lblMiddle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFirst
            // 
            lblFirst.Dock = DockStyle.Fill;
            lblFirst.Location = new Point(3, 30);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(49, 30);
            lblFirst.TabIndex = 2;
            lblFirst.Text = "First:";
            lblFirst.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPrefix
            // 
            lblPrefix.Dock = DockStyle.Fill;
            lblPrefix.Location = new Point(3, 0);
            lblPrefix.Name = "lblPrefix";
            lblPrefix.Size = new Size(49, 30);
            lblPrefix.TabIndex = 0;
            lblPrefix.Text = "Prefix:";
            lblPrefix.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNotes
            // 
            txtNotes.Dock = DockStyle.Fill;
            txtNotes.Location = new Point(58, 153);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(82, 23);
            txtNotes.TabIndex = 11;
            txtNotes.TextChanged += txtNotes_TextChanged;
            // 
            // txtPrefix
            // 
            txtPrefix.Dock = DockStyle.Fill;
            txtPrefix.Location = new Point(58, 3);
            txtPrefix.Name = "txtPrefix";
            txtPrefix.Size = new Size(82, 23);
            txtPrefix.TabIndex = 1;
            txtPrefix.TextChanged += txtPrefix_TextChanged;
            // 
            // txtFirst
            // 
            txtFirst.Dock = DockStyle.Fill;
            txtFirst.Location = new Point(58, 33);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(82, 23);
            txtFirst.TabIndex = 3;
            txtFirst.TextChanged += txtFirst_TextChanged;
            // 
            // txtMiddle
            // 
            txtMiddle.Dock = DockStyle.Fill;
            txtMiddle.Location = new Point(58, 63);
            txtMiddle.Name = "txtMiddle";
            txtMiddle.Size = new Size(82, 23);
            txtMiddle.TabIndex = 5;
            txtMiddle.TextChanged += txtMiddle_TextChanged;
            // 
            // txtLast
            // 
            txtLast.Dock = DockStyle.Fill;
            txtLast.Location = new Point(58, 93);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(82, 23);
            txtLast.TabIndex = 7;
            txtLast.TextChanged += txtLast_TextChanged;
            // 
            // txtSuffix
            // 
            txtSuffix.Dock = DockStyle.Fill;
            txtSuffix.Location = new Point(58, 123);
            txtSuffix.Name = "txtSuffix";
            txtSuffix.Size = new Size(82, 23);
            txtSuffix.TabIndex = 9;
            txtSuffix.TextChanged += txtSuffix_TextChanged;
            // 
            // txtZip
            // 
            tlpData.SetColumnSpan(txtZip, 2);
            txtZip.Dock = DockStyle.Fill;
            txtZip.Location = new Point(208, 153);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(175, 23);
            txtZip.TabIndex = 23;
            txtZip.TextChanged += txtZip_TextChanged;
            // 
            // txtEmail
            // 
            tlpData.SetColumnSpan(txtEmail, 3);
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(58, 183);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 23);
            txtEmail.TabIndex = 25;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPhone
            // 
            tlpData.SetColumnSpan(txtPhone, 3);
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(58, 213);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(232, 23);
            txtPhone.TabIndex = 27;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // FAddressBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 426);
            Controls.Add(spcMain);
            MinimumSize = new Size(635, 302);
            Name = "FAddressBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contact List";
            FormClosing += FAddressBook_FormClosing;
            Load += FAddressBook_Load;
            spcMain.Panel1.ResumeLayout(false);
            spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcMain).EndInit();
            spcMain.ResumeLayout(false);
            tlpContacts.ResumeLayout(false);
            grbContact.ResumeLayout(false);
            tlpData.ResumeLayout(false);
            tlpData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer spcMain;
        private TableLayoutPanel tlpContacts;
        private GroupBox grbContact;
        private ListBox lbxContacts;
        private Button btnCreateContact;
        private Button btnDeleteContact;
        private TextBox txtNotes;
        private Label lblNotes;
        private TextBox txtSuffix;
        private Label lblSuffix;
        private TextBox txtLast;
        private Label lblLast;
        private TextBox txtMiddle;
        private Label lblMiddle;
        private TextBox txtFirst;
        private Label lblFirst;
        private TextBox txtPrefix;
        private Label lblPrefix;
        private TextBox txtZip;
        private Label lblZip;
        private TextBox txtCountry;
        private Label lblCountry;
        private TextBox txtState;
        private Label lblState;
        private TextBox txtCity;
        private Label lblCity;
        private TextBox txtLine2;
        private Label lblLine2;
        private TextBox txtLine1;
        private Label lblLine1;
        private TableLayoutPanel tlpData;
        private ComboBox cbxPhoneType;
        private CheckBox ckbEmailType;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}