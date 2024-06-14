namespace instagov_prototype
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.billComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.citizenComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.definitionComboBox = new System.Windows.Forms.ComboBox();
            this.assetComboBox = new System.Windows.Forms.ComboBox();
            this.disputeComboBox = new System.Windows.Forms.ComboBox();
            this.organizationComboBox = new System.Windows.Forms.ComboBox();
            this.contractComboBox = new System.Windows.Forms.ComboBox();
            this.subtypeMetaSelector = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.genesisBox = new System.Windows.Forms.CheckBox();
            this.genesisChainName = new System.Windows.Forms.TextBox();
            this.genesisInputLabel = new System.Windows.Forms.Label();
            this.genesisThresholdValue = new System.Windows.Forms.NumericUpDown();
            this.genesisThresholdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesisThresholdValue)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "make transaction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MAKE",
            "CHANGE",
            "VOTE",
            "CANCEL"});
            this.comboBox1.Location = new System.Drawing.Point(334, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "legal object";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "CITIZEN",
            "BILL",
            "ASSET",
            "DISPUTE",
            "ORGANIZATION",
            "CONTRACT"});
            this.comboBox2.Location = new System.Drawing.Point(334, 233);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "legal action";
            // 
            // billComboBox
            // 
            this.billComboBox.FormattingEnabled = true;
            this.billComboBox.Items.AddRange(new object[] {
            "MAY",
            "MUST",
            "MUSTNOT",
            "ADMINISTRATIVE",
            "DEFINITION"});
            this.billComboBox.Location = new System.Drawing.Point(334, 276);
            this.billComboBox.Name = "billComboBox";
            this.billComboBox.Size = new System.Drawing.Size(121, 21);
            this.billComboBox.TabIndex = 6;
            this.billComboBox.Visible = false;
            this.billComboBox.SelectedIndexChanged += new System.EventHandler(this.billComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "legal type";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(476, 233);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(285, 117);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(476, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 20);
            this.textBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(186, 330);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "votes attached";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "description";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "originator ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "target ID";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(502, 393);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(35, 13);
            this.status.TabIndex = 18;
            this.status.Text = "status";
            // 
            // citizenComboBox
            // 
            this.citizenComboBox.FormattingEnabled = true;
            this.citizenComboBox.Items.AddRange(new object[] {
            "CITIZEN",
            "PRISONER",
            "POLICE",
            "OFFICIAL"});
            this.citizenComboBox.Location = new System.Drawing.Point(320, 284);
            this.citizenComboBox.Name = "citizenComboBox";
            this.citizenComboBox.Size = new System.Drawing.Size(121, 21);
            this.citizenComboBox.TabIndex = 19;
            this.citizenComboBox.Visible = false;
            this.citizenComboBox.SelectedIndexChanged += new System.EventHandler(this.citizenComboBox_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 277);
            this.dateTimePicker1.MinDate = new System.DateTime(2024, 6, 10, 20, 17, 54, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.Value = new System.DateTime(2024, 6, 10, 20, 17, 54, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "vote by";
            // 
            // definitionComboBox
            // 
            this.definitionComboBox.FormattingEnabled = true;
            this.definitionComboBox.Items.AddRange(new object[] {
            "VERB",
            "NOUN",
            "DESCRIPTOR",
            "SPECIFIER"});
            this.definitionComboBox.Location = new System.Drawing.Point(334, 292);
            this.definitionComboBox.Name = "definitionComboBox";
            this.definitionComboBox.Size = new System.Drawing.Size(121, 21);
            this.definitionComboBox.TabIndex = 22;
            this.definitionComboBox.Visible = false;
            this.definitionComboBox.SelectedIndexChanged += new System.EventHandler(this.definitionComboBox_SelectedIndexChanged);
            // 
            // assetComboBox
            // 
            this.assetComboBox.FormattingEnabled = true;
            this.assetComboBox.Items.AddRange(new object[] {
            "PERSONAL",
            "COMMUNAL",
            "LICENSE"});
            this.assetComboBox.Location = new System.Drawing.Point(320, 302);
            this.assetComboBox.Name = "assetComboBox";
            this.assetComboBox.Size = new System.Drawing.Size(121, 21);
            this.assetComboBox.TabIndex = 23;
            this.assetComboBox.Visible = false;
            // 
            // disputeComboBox
            // 
            this.disputeComboBox.FormattingEnabled = true;
            this.disputeComboBox.Items.AddRange(new object[] {
            "CIVIL",
            "CRIMINAL",
            "CONTRACT"});
            this.disputeComboBox.Location = new System.Drawing.Point(334, 311);
            this.disputeComboBox.Name = "disputeComboBox";
            this.disputeComboBox.Size = new System.Drawing.Size(121, 21);
            this.disputeComboBox.TabIndex = 24;
            this.disputeComboBox.Visible = false;
            this.disputeComboBox.SelectedIndexChanged += new System.EventHandler(this.disputeComboBox_SelectedIndexChanged);
            // 
            // organizationComboBox
            // 
            this.organizationComboBox.FormattingEnabled = true;
            this.organizationComboBox.Items.AddRange(new object[] {
            "GOVERNMENT",
            "SOLEOWNER",
            "CORPORATION",
            "NONPROFIT"});
            this.organizationComboBox.Location = new System.Drawing.Point(334, 330);
            this.organizationComboBox.Name = "organizationComboBox";
            this.organizationComboBox.Size = new System.Drawing.Size(121, 21);
            this.organizationComboBox.TabIndex = 25;
            this.organizationComboBox.Visible = false;
            this.organizationComboBox.SelectedIndexChanged += new System.EventHandler(this.organizationComboBox_SelectedIndexChanged);
            // 
            // contractComboBox
            // 
            this.contractComboBox.FormattingEnabled = true;
            this.contractComboBox.Items.AddRange(new object[] {
            "CIVIL",
            "LABOR",
            "LOANS",
            "SALES",
            "ALETORY"});
            this.contractComboBox.Location = new System.Drawing.Point(320, 319);
            this.contractComboBox.Name = "contractComboBox";
            this.contractComboBox.Size = new System.Drawing.Size(121, 21);
            this.contractComboBox.TabIndex = 26;
            this.contractComboBox.Visible = false;
            this.contractComboBox.SelectedIndexChanged += new System.EventHandler(this.contractComboBox_SelectedIndexChanged);
            // 
            // subtypeMetaSelector
            // 
            this.subtypeMetaSelector.AutoSize = true;
            this.subtypeMetaSelector.Location = new System.Drawing.Point(334, 357);
            this.subtypeMetaSelector.Name = "subtypeMetaSelector";
            this.subtypeMetaSelector.Size = new System.Drawing.Size(0, 13);
            this.subtypeMetaSelector.TabIndex = 27;
            this.subtypeMetaSelector.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "vote on bills";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(425, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "view your profile";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(540, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "view passed laws";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(675, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 23);
            this.button5.TabIndex = 31;
            this.button5.Text = "view block headers";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // genesisBox
            // 
            this.genesisBox.AutoSize = true;
            this.genesisBox.Location = new System.Drawing.Point(23, 54);
            this.genesisBox.Name = "genesisBox";
            this.genesisBox.Size = new System.Drawing.Size(88, 17);
            this.genesisBox.TabIndex = 32;
            this.genesisBox.Text = "genesisNode";
            this.genesisBox.UseVisualStyleBackColor = true;
            this.genesisBox.CheckedChanged += new System.EventHandler(this.genesisBox_CheckedChanged);
            // 
            // genesisChainName
            // 
            this.genesisChainName.Location = new System.Drawing.Point(23, 90);
            this.genesisChainName.Name = "genesisChainName";
            this.genesisChainName.Size = new System.Drawing.Size(100, 20);
            this.genesisChainName.TabIndex = 33;
            this.genesisChainName.Visible = false;
            // 
            // genesisInputLabel
            // 
            this.genesisInputLabel.AutoSize = true;
            this.genesisInputLabel.Location = new System.Drawing.Point(20, 74);
            this.genesisInputLabel.Name = "genesisInputLabel";
            this.genesisInputLabel.Size = new System.Drawing.Size(296, 13);
            this.genesisInputLabel.TabIndex = 34;
            this.genesisInputLabel.Text = "name for your new separate blockchain, also initial blockhash";
            this.genesisInputLabel.Visible = false;
            // 
            // genesisThresholdValue
            // 
            this.genesisThresholdValue.DecimalPlaces = 2;
            this.genesisThresholdValue.Location = new System.Drawing.Point(26, 133);
            this.genesisThresholdValue.Name = "genesisThresholdValue";
            this.genesisThresholdValue.Size = new System.Drawing.Size(62, 20);
            this.genesisThresholdValue.TabIndex = 36;
            this.genesisThresholdValue.Visible = false;
            // 
            // genesisThresholdLabel
            // 
            this.genesisThresholdLabel.AutoSize = true;
            this.genesisThresholdLabel.Location = new System.Drawing.Point(23, 117);
            this.genesisThresholdLabel.Name = "genesisThresholdLabel";
            this.genesisThresholdLabel.Size = new System.Drawing.Size(521, 13);
            this.genesisThresholdLabel.TabIndex = 37;
            this.genesisThresholdLabel.Text = "vote passed threshold setting (CANNOT BE CHANGED; MUST CREATE NEW BLOCKCHAIN TO C" +
    "HANGE)";
            this.genesisThresholdLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.genesisThresholdLabel);
            this.Controls.Add(this.genesisThresholdValue);
            this.Controls.Add(this.genesisInputLabel);
            this.Controls.Add(this.genesisChainName);
            this.Controls.Add(this.genesisBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.subtypeMetaSelector);
            this.Controls.Add(this.contractComboBox);
            this.Controls.Add(this.organizationComboBox);
            this.Controls.Add(this.disputeComboBox);
            this.Controls.Add(this.assetComboBox);
            this.Controls.Add(this.definitionComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.citizenComboBox);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.billComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genesisThresholdValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox billComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ComboBox citizenComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox definitionComboBox;
        private System.Windows.Forms.ComboBox assetComboBox;
        private System.Windows.Forms.ComboBox disputeComboBox;
        private System.Windows.Forms.ComboBox organizationComboBox;
        private System.Windows.Forms.ComboBox contractComboBox;
        private System.Windows.Forms.Label subtypeMetaSelector;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox genesisBox;
        private System.Windows.Forms.TextBox genesisChainName;
        private System.Windows.Forms.Label genesisInputLabel;
        private System.Windows.Forms.NumericUpDown genesisThresholdValue;
        private System.Windows.Forms.Label genesisThresholdLabel;
    }
}

