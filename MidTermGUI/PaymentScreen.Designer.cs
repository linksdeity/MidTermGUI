namespace MidTermGUI
{
    partial class PaymentScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aPayWithCardRadioButton = new System.Windows.Forms.RadioButton();
            this.aPayWithRupeesRadioButton = new System.Windows.Forms.RadioButton();
            this.aPayWithCheckRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aChangeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.aPayWithRupeesButton = new System.Windows.Forms.Button();
            this.aPayWithCheckButton = new System.Windows.Forms.Button();
            this.aPayWithCardButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.aCreditCarNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.aExpirationDateCheckBox = new System.Windows.Forms.MaskedTextBox();
            this.aSecurityCodeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.aRupeePayTextBox = new System.Windows.Forms.MaskedTextBox();
            this.aCheckNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.aRoutingNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.aCheckoutTotalLabel = new System.Windows.Forms.Label();
            this.aCheckOutGrandTotalLabel = new System.Windows.Forms.Label();
            this.aCheckOutTaxLabel = new System.Windows.Forms.Label();
            this.aRupeePanel = new System.Windows.Forms.Panel();
            this.aCardPanel = new System.Windows.Forms.Panel();
            this.aCheckPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.aRupeePanel.SuspendLayout();
            this.aCardPanel.SuspendLayout();
            this.aCheckPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TAX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "GRAND TOTAL";
            // 
            // aPayWithCardRadioButton
            // 
            this.aPayWithCardRadioButton.AutoSize = true;
            this.aPayWithCardRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPayWithCardRadioButton.Location = new System.Drawing.Point(19, 330);
            this.aPayWithCardRadioButton.Name = "aPayWithCardRadioButton";
            this.aPayWithCardRadioButton.Size = new System.Drawing.Size(59, 17);
            this.aPayWithCardRadioButton.TabIndex = 3;
            this.aPayWithCardRadioButton.Text = "CARD";
            this.aPayWithCardRadioButton.UseVisualStyleBackColor = true;
            this.aPayWithCardRadioButton.CheckedChanged += new System.EventHandler(this.aPayWithCardRadioButton_CheckedChanged);
            // 
            // aPayWithRupeesRadioButton
            // 
            this.aPayWithRupeesRadioButton.AutoSize = true;
            this.aPayWithRupeesRadioButton.Checked = true;
            this.aPayWithRupeesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPayWithRupeesRadioButton.Location = new System.Drawing.Point(15, 145);
            this.aPayWithRupeesRadioButton.Name = "aPayWithRupeesRadioButton";
            this.aPayWithRupeesRadioButton.Size = new System.Drawing.Size(75, 17);
            this.aPayWithRupeesRadioButton.TabIndex = 4;
            this.aPayWithRupeesRadioButton.TabStop = true;
            this.aPayWithRupeesRadioButton.Text = "RUPEES";
            this.aPayWithRupeesRadioButton.UseVisualStyleBackColor = true;
            this.aPayWithRupeesRadioButton.CheckedChanged += new System.EventHandler(this.aPayWithRupeesRadioButton_CheckedChanged);
            // 
            // aPayWithCheckRadioButton
            // 
            this.aPayWithCheckRadioButton.AutoSize = true;
            this.aPayWithCheckRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPayWithCheckRadioButton.Location = new System.Drawing.Point(19, 561);
            this.aPayWithCheckRadioButton.Name = "aPayWithCheckRadioButton";
            this.aPayWithCheckRadioButton.Size = new System.Drawing.Size(66, 17);
            this.aPayWithCheckRadioButton.TabIndex = 5;
            this.aPayWithCheckRadioButton.Text = "CHECK";
            this.aPayWithCheckRadioButton.UseVisualStyleBackColor = true;
            this.aPayWithCheckRadioButton.CheckedChanged += new System.EventHandler(this.aPayWithCheckRadioButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount of Rupees being payed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "You will receive:";
            // 
            // aChangeLabel
            // 
            this.aChangeLabel.AutoSize = true;
            this.aChangeLabel.Location = new System.Drawing.Point(115, 115);
            this.aChangeLabel.Name = "aChangeLabel";
            this.aChangeLabel.Size = new System.Drawing.Size(13, 13);
            this.aChangeLabel.TabIndex = 9;
            this.aChangeLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rupees in change";
            // 
            // aPayWithRupeesButton
            // 
            this.aPayWithRupeesButton.Location = new System.Drawing.Point(366, 60);
            this.aPayWithRupeesButton.Name = "aPayWithRupeesButton";
            this.aPayWithRupeesButton.Size = new System.Drawing.Size(217, 43);
            this.aPayWithRupeesButton.TabIndex = 11;
            this.aPayWithRupeesButton.Text = "PAY WITH RUPEES";
            this.aPayWithRupeesButton.UseVisualStyleBackColor = true;
            this.aPayWithRupeesButton.Click += new System.EventHandler(this.aPayWithRupeesButton_Click);
            // 
            // aPayWithCheckButton
            // 
            this.aPayWithCheckButton.Location = new System.Drawing.Point(366, 54);
            this.aPayWithCheckButton.Name = "aPayWithCheckButton";
            this.aPayWithCheckButton.Size = new System.Drawing.Size(217, 42);
            this.aPayWithCheckButton.TabIndex = 12;
            this.aPayWithCheckButton.Text = "PAY WITH CHECK";
            this.aPayWithCheckButton.UseVisualStyleBackColor = true;
            this.aPayWithCheckButton.Click += new System.EventHandler(this.aPayWithCheckButton_Click);
            // 
            // aPayWithCardButton
            // 
            this.aPayWithCardButton.Location = new System.Drawing.Point(366, 51);
            this.aPayWithCardButton.Name = "aPayWithCardButton";
            this.aPayWithCardButton.Size = new System.Drawing.Size(217, 42);
            this.aPayWithCardButton.TabIndex = 13;
            this.aPayWithCardButton.Text = "PAY WITH CARD";
            this.aPayWithCardButton.UseVisualStyleBackColor = true;
            this.aPayWithCardButton.Click += new System.EventHandler(this.aPayWithCardButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(39, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Card number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Expiration Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Security / CVV:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Check Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Routing Number:";
            // 
            // aCreditCarNumberTextBox
            // 
            this.aCreditCarNumberTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.aCreditCarNumberTextBox.Location = new System.Drawing.Point(149, 19);
            this.aCreditCarNumberTextBox.Mask = "9999-9999-9999-9999";
            this.aCreditCarNumberTextBox.Name = "aCreditCarNumberTextBox";
            this.aCreditCarNumberTextBox.PromptChar = '#';
            this.aCreditCarNumberTextBox.Size = new System.Drawing.Size(184, 20);
            this.aCreditCarNumberTextBox.TabIndex = 28;
            // 
            // aExpirationDateCheckBox
            // 
            this.aExpirationDateCheckBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.aExpirationDateCheckBox.Location = new System.Drawing.Point(149, 63);
            this.aExpirationDateCheckBox.Mask = "99/9999";
            this.aExpirationDateCheckBox.Name = "aExpirationDateCheckBox";
            this.aExpirationDateCheckBox.PromptChar = '#';
            this.aExpirationDateCheckBox.Size = new System.Drawing.Size(71, 20);
            this.aExpirationDateCheckBox.TabIndex = 33;
            // 
            // aSecurityCodeTextBox
            // 
            this.aSecurityCodeTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.aSecurityCodeTextBox.Location = new System.Drawing.Point(149, 106);
            this.aSecurityCodeTextBox.Mask = "999";
            this.aSecurityCodeTextBox.Name = "aSecurityCodeTextBox";
            this.aSecurityCodeTextBox.PromptChar = '#';
            this.aSecurityCodeTextBox.Size = new System.Drawing.Size(58, 20);
            this.aSecurityCodeTextBox.TabIndex = 34;
            // 
            // aRupeePayTextBox
            // 
            this.aRupeePayTextBox.HidePromptOnLeave = true;
            this.aRupeePayTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.aRupeePayTextBox.Location = new System.Drawing.Point(190, 72);
            this.aRupeePayTextBox.Mask = "999999999";
            this.aRupeePayTextBox.Name = "aRupeePayTextBox";
            this.aRupeePayTextBox.PromptChar = ' ';
            this.aRupeePayTextBox.Size = new System.Drawing.Size(80, 20);
            this.aRupeePayTextBox.TabIndex = 35;
            this.aRupeePayTextBox.TextChanged += new System.EventHandler(this.getChange);
            // 
            // aCheckNumberTextBox
            // 
            this.aCheckNumberTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.aCheckNumberTextBox.Location = new System.Drawing.Point(141, 47);
            this.aCheckNumberTextBox.Mask = "999999999";
            this.aCheckNumberTextBox.Name = "aCheckNumberTextBox";
            this.aCheckNumberTextBox.PromptChar = '#';
            this.aCheckNumberTextBox.Size = new System.Drawing.Size(83, 20);
            this.aCheckNumberTextBox.TabIndex = 36;
            // 
            // aRoutingNumberTextBox
            // 
            this.aRoutingNumberTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.aRoutingNumberTextBox.Location = new System.Drawing.Point(141, 89);
            this.aRoutingNumberTextBox.Mask = "999999999";
            this.aRoutingNumberTextBox.Name = "aRoutingNumberTextBox";
            this.aRoutingNumberTextBox.PromptChar = '#';
            this.aRoutingNumberTextBox.Size = new System.Drawing.Size(83, 20);
            this.aRoutingNumberTextBox.TabIndex = 37;
            // 
            // aCheckoutTotalLabel
            // 
            this.aCheckoutTotalLabel.AutoSize = true;
            this.aCheckoutTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aCheckoutTotalLabel.Location = new System.Drawing.Point(136, 8);
            this.aCheckoutTotalLabel.Name = "aCheckoutTotalLabel";
            this.aCheckoutTotalLabel.Size = new System.Drawing.Size(14, 13);
            this.aCheckoutTotalLabel.TabIndex = 38;
            this.aCheckoutTotalLabel.Text = "0";
            // 
            // aCheckOutGrandTotalLabel
            // 
            this.aCheckOutGrandTotalLabel.AutoSize = true;
            this.aCheckOutGrandTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aCheckOutGrandTotalLabel.Location = new System.Drawing.Point(136, 56);
            this.aCheckOutGrandTotalLabel.Name = "aCheckOutGrandTotalLabel";
            this.aCheckOutGrandTotalLabel.Size = new System.Drawing.Size(14, 13);
            this.aCheckOutGrandTotalLabel.TabIndex = 39;
            this.aCheckOutGrandTotalLabel.Text = "0";
            // 
            // aCheckOutTaxLabel
            // 
            this.aCheckOutTaxLabel.AutoSize = true;
            this.aCheckOutTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aCheckOutTaxLabel.Location = new System.Drawing.Point(136, 32);
            this.aCheckOutTaxLabel.Name = "aCheckOutTaxLabel";
            this.aCheckOutTaxLabel.Size = new System.Drawing.Size(14, 13);
            this.aCheckOutTaxLabel.TabIndex = 40;
            this.aCheckOutTaxLabel.Text = "0";
            // 
            // aRupeePanel
            // 
            this.aRupeePanel.Controls.Add(this.aRupeePayTextBox);
            this.aRupeePanel.Controls.Add(this.label6);
            this.aRupeePanel.Controls.Add(this.aChangeLabel);
            this.aRupeePanel.Controls.Add(this.label5);
            this.aRupeePanel.Controls.Add(this.label4);
            this.aRupeePanel.Controls.Add(this.aPayWithRupeesButton);
            this.aRupeePanel.Location = new System.Drawing.Point(108, 72);
            this.aRupeePanel.Name = "aRupeePanel";
            this.aRupeePanel.Size = new System.Drawing.Size(593, 202);
            this.aRupeePanel.TabIndex = 44;
            // 
            // aCardPanel
            // 
            this.aCardPanel.Controls.Add(this.aSecurityCodeTextBox);
            this.aCardPanel.Controls.Add(this.aExpirationDateCheckBox);
            this.aCardPanel.Controls.Add(this.aCreditCarNumberTextBox);
            this.aCardPanel.Controls.Add(this.label9);
            this.aCardPanel.Controls.Add(this.label8);
            this.aCardPanel.Controls.Add(this.label7);
            this.aCardPanel.Controls.Add(this.aPayWithCardButton);
            this.aCardPanel.Enabled = false;
            this.aCardPanel.Location = new System.Drawing.Point(108, 308);
            this.aCardPanel.Name = "aCardPanel";
            this.aCardPanel.Size = new System.Drawing.Size(593, 164);
            this.aCardPanel.TabIndex = 45;
            // 
            // aCheckPanel
            // 
            this.aCheckPanel.Controls.Add(this.aRoutingNumberTextBox);
            this.aCheckPanel.Controls.Add(this.aCheckNumberTextBox);
            this.aCheckPanel.Controls.Add(this.label11);
            this.aCheckPanel.Controls.Add(this.label10);
            this.aCheckPanel.Controls.Add(this.aPayWithCheckButton);
            this.aCheckPanel.Enabled = false;
            this.aCheckPanel.Location = new System.Drawing.Point(108, 509);
            this.aCheckPanel.Name = "aCheckPanel";
            this.aCheckPanel.Size = new System.Drawing.Size(593, 164);
            this.aCheckPanel.TabIndex = 45;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MidTermGUI.Properties.Resources.MaloBanner;
            this.pictureBox3.Location = new System.Drawing.Point(451, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(205, 48);
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MidTermGUI.Properties.Resources.Rupees;
            this.pictureBox1.Location = new System.Drawing.Point(772, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MidTermGUI.Properties.Resources.bank;
            this.pictureBox2.Location = new System.Drawing.Point(727, 330);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(297, 328);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // PaymentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 682);
            this.Controls.Add(this.aCardPanel);
            this.Controls.Add(this.aCheckPanel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.aRupeePanel);
            this.Controls.Add(this.aCheckOutTaxLabel);
            this.Controls.Add(this.aCheckOutGrandTotalLabel);
            this.Controls.Add(this.aCheckoutTotalLabel);
            this.Controls.Add(this.aPayWithCheckRadioButton);
            this.Controls.Add(this.aPayWithRupeesRadioButton);
            this.Controls.Add(this.aPayWithCardRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1061, 721);
            this.MinimumSize = new System.Drawing.Size(1061, 721);
            this.Name = "PaymentScreen";
            this.Text = "PaymentScreen";
            this.Load += new System.EventHandler(this.PaymentScreen_Load);
            this.aRupeePanel.ResumeLayout(false);
            this.aRupeePanel.PerformLayout();
            this.aCardPanel.ResumeLayout(false);
            this.aCardPanel.PerformLayout();
            this.aCheckPanel.ResumeLayout(false);
            this.aCheckPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton aPayWithCardRadioButton;
        private System.Windows.Forms.RadioButton aPayWithRupeesRadioButton;
        private System.Windows.Forms.RadioButton aPayWithCheckRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label aChangeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button aPayWithRupeesButton;
        private System.Windows.Forms.Button aPayWithCheckButton;
        private System.Windows.Forms.Button aPayWithCardButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox aCreditCarNumberTextBox;
        private System.Windows.Forms.MaskedTextBox aExpirationDateCheckBox;
        private System.Windows.Forms.MaskedTextBox aSecurityCodeTextBox;
        private System.Windows.Forms.MaskedTextBox aRupeePayTextBox;
        private System.Windows.Forms.MaskedTextBox aCheckNumberTextBox;
        private System.Windows.Forms.MaskedTextBox aRoutingNumberTextBox;
        private System.Windows.Forms.Label aCheckoutTotalLabel;
        private System.Windows.Forms.Label aCheckOutGrandTotalLabel;
        private System.Windows.Forms.Label aCheckOutTaxLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel aRupeePanel;
        private System.Windows.Forms.Panel aCardPanel;
        private System.Windows.Forms.Panel aCheckPanel;
    }
}