namespace MidTermGUI
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
            this.components = new System.ComponentModel.Container();
            this.aTitleLabel = new System.Windows.Forms.Label();
            this.aSubTitalLabel = new System.Windows.Forms.Label();
            this.aCheckoutButton = new System.Windows.Forms.Button();
            this.aCategoryListBox = new System.Windows.Forms.ListBox();
            this.aTotalCostLabel = new System.Windows.Forms.Label();
            this.aTaxCostLabel = new System.Windows.Forms.Label();
            this.aGrandTotalLabel = new System.Windows.Forms.Label();
            this.aClearCartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aItemDescriptionLabel = new System.Windows.Forms.Label();
            this.aAddToCartButton = new System.Windows.Forms.Button();
            this.aShoppingCartList = new System.Windows.Forms.ListBox();
            this.aShoppingCartLabel = new System.Windows.Forms.Label();
            this.aCategoryNameLabel = new System.Windows.Forms.Label();
            this.aItemNumeric = new System.Windows.Forms.NumericUpDown();
            this.aLineTotalLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aDeleteButton = new System.Windows.Forms.Button();
            this.aShieldsButton = new System.Windows.Forms.Button();
            this.aPotionsButton = new System.Windows.Forms.Button();
            this.aMasksButton = new System.Windows.Forms.Button();
            this.aConsumablesButton = new System.Windows.Forms.Button();
            this.aSwordsButton = new System.Windows.Forms.Button();
            this.aTitleTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.aMusicButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aMaloPicture = new System.Windows.Forms.PictureBox();
            this.aItemPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aItemNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMaloPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aItemPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // aTitleLabel
            // 
            this.aTitleLabel.AutoSize = true;
            this.aTitleLabel.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTitleLabel.Location = new System.Drawing.Point(211, 14);
            this.aTitleLabel.Name = "aTitleLabel";
            this.aTitleLabel.Size = new System.Drawing.Size(723, 55);
            this.aTitleLabel.TabIndex = 0;
            this.aTitleLabel.Text = "WELCOME TO MALO MART!!";
            // 
            // aSubTitalLabel
            // 
            this.aSubTitalLabel.AutoSize = true;
            this.aSubTitalLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSubTitalLabel.Location = new System.Drawing.Point(483, 76);
            this.aSubTitalLabel.Name = "aSubTitalLabel";
            this.aSubTitalLabel.Size = new System.Drawing.Size(174, 25);
            this.aSubTitalLabel.TabIndex = 1;
            this.aSubTitalLabel.Text = "Hyrule\'s #1 outlet!";
            // 
            // aCheckoutButton
            // 
            this.aCheckoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aCheckoutButton.Location = new System.Drawing.Point(565, 601);
            this.aCheckoutButton.Name = "aCheckoutButton";
            this.aCheckoutButton.Size = new System.Drawing.Size(541, 60);
            this.aCheckoutButton.TabIndex = 3;
            this.aCheckoutButton.Text = "Sell it to meeee!!";
            this.aCheckoutButton.UseVisualStyleBackColor = true;
            this.aCheckoutButton.Click += new System.EventHandler(this.aCheckoutButton_Click);
            // 
            // aCategoryListBox
            // 
            this.aCategoryListBox.FormattingEnabled = true;
            this.aCategoryListBox.Location = new System.Drawing.Point(265, 120);
            this.aCategoryListBox.Name = "aCategoryListBox";
            this.aCategoryListBox.Size = new System.Drawing.Size(244, 69);
            this.aCategoryListBox.TabIndex = 8;
            this.aCategoryListBox.SelectedIndexChanged += new System.EventHandler(this.aCategoryListBox_SelectedIndexChanged);
            // 
            // aTotalCostLabel
            // 
            this.aTotalCostLabel.AutoSize = true;
            this.aTotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTotalCostLabel.Location = new System.Drawing.Point(576, 574);
            this.aTotalCostLabel.Name = "aTotalCostLabel";
            this.aTotalCostLabel.Size = new System.Drawing.Size(14, 13);
            this.aTotalCostLabel.TabIndex = 10;
            this.aTotalCostLabel.Text = "0";
            // 
            // aTaxCostLabel
            // 
            this.aTaxCostLabel.AutoSize = true;
            this.aTaxCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTaxCostLabel.Location = new System.Drawing.Point(726, 575);
            this.aTaxCostLabel.Name = "aTaxCostLabel";
            this.aTaxCostLabel.Size = new System.Drawing.Size(14, 13);
            this.aTaxCostLabel.TabIndex = 11;
            this.aTaxCostLabel.Text = "0";
            // 
            // aGrandTotalLabel
            // 
            this.aGrandTotalLabel.AutoSize = true;
            this.aGrandTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGrandTotalLabel.Location = new System.Drawing.Point(875, 576);
            this.aGrandTotalLabel.Name = "aGrandTotalLabel";
            this.aGrandTotalLabel.Size = new System.Drawing.Size(14, 13);
            this.aGrandTotalLabel.TabIndex = 12;
            this.aGrandTotalLabel.Text = "0";
            // 
            // aClearCartButton
            // 
            this.aClearCartButton.Enabled = false;
            this.aClearCartButton.Location = new System.Drawing.Point(1025, 503);
            this.aClearCartButton.Name = "aClearCartButton";
            this.aClearCartButton.Size = new System.Drawing.Size(66, 27);
            this.aClearCartButton.TabIndex = 14;
            this.aClearCartButton.Text = "Clear Cart";
            this.aClearCartButton.UseVisualStyleBackColor = true;
            this.aClearCartButton.Click += new System.EventHandler(this.aClearCartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(726, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(875, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "GRAND TOTAL:";
            // 
            // aItemDescriptionLabel
            // 
            this.aItemDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aItemDescriptionLabel.Location = new System.Drawing.Point(267, 192);
            this.aItemDescriptionLabel.Name = "aItemDescriptionLabel";
            this.aItemDescriptionLabel.Size = new System.Drawing.Size(242, 199);
            this.aItemDescriptionLabel.TabIndex = 18;
            this.aItemDescriptionLabel.Text = "Select an item to see a description!";
            // 
            // aAddToCartButton
            // 
            this.aAddToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aAddToCartButton.Location = new System.Drawing.Point(325, 624);
            this.aAddToCartButton.Name = "aAddToCartButton";
            this.aAddToCartButton.Size = new System.Drawing.Size(174, 37);
            this.aAddToCartButton.TabIndex = 20;
            this.aAddToCartButton.Text = "Add to cart";
            this.aAddToCartButton.UseVisualStyleBackColor = true;
            this.aAddToCartButton.Click += new System.EventHandler(this.aAddToCartButton_Click);
            // 
            // aShoppingCartList
            // 
            this.aShoppingCartList.FormattingEnabled = true;
            this.aShoppingCartList.Location = new System.Drawing.Point(952, 136);
            this.aShoppingCartList.Name = "aShoppingCartList";
            this.aShoppingCartList.Size = new System.Drawing.Size(118, 342);
            this.aShoppingCartList.TabIndex = 21;
            this.aShoppingCartList.SelectedIndexChanged += new System.EventHandler(this.aShoppingCartList_SelectedIndexChanged);
            // 
            // aShoppingCartLabel
            // 
            this.aShoppingCartLabel.AutoSize = true;
            this.aShoppingCartLabel.Location = new System.Drawing.Point(965, 120);
            this.aShoppingCartLabel.Name = "aShoppingCartLabel";
            this.aShoppingCartLabel.Size = new System.Drawing.Size(77, 13);
            this.aShoppingCartLabel.TabIndex = 22;
            this.aShoppingCartLabel.Text = "Shopping Cart:";
            // 
            // aCategoryNameLabel
            // 
            this.aCategoryNameLabel.AutoSize = true;
            this.aCategoryNameLabel.Location = new System.Drawing.Point(267, 104);
            this.aCategoryNameLabel.Name = "aCategoryNameLabel";
            this.aCategoryNameLabel.Size = new System.Drawing.Size(0, 13);
            this.aCategoryNameLabel.TabIndex = 25;
            // 
            // aItemNumeric
            // 
            this.aItemNumeric.Location = new System.Drawing.Point(279, 634);
            this.aItemNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.aItemNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aItemNumeric.Name = "aItemNumeric";
            this.aItemNumeric.Size = new System.Drawing.Size(40, 20);
            this.aItemNumeric.TabIndex = 26;
            this.aItemNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.aItemNumeric.ValueChanged += new System.EventHandler(this.aItemNumeric_ValueChanged);
            // 
            // aLineTotalLabel
            // 
            this.aLineTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLineTotalLabel.Location = new System.Drawing.Point(385, 664);
            this.aLineTotalLabel.Name = "aLineTotalLabel";
            this.aLineTotalLabel.Size = new System.Drawing.Size(177, 13);
            this.aLineTotalLabel.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 664);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Line Price:";
            // 
            // aDeleteButton
            // 
            this.aDeleteButton.Enabled = false;
            this.aDeleteButton.Location = new System.Drawing.Point(941, 503);
            this.aDeleteButton.Name = "aDeleteButton";
            this.aDeleteButton.Size = new System.Drawing.Size(66, 27);
            this.aDeleteButton.TabIndex = 30;
            this.aDeleteButton.Text = "Delete";
            this.aDeleteButton.UseVisualStyleBackColor = true;
            this.aDeleteButton.Click += new System.EventHandler(this.aDeleteButton_Click);
            // 
            // aShieldsButton
            // 
            this.aShieldsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aShieldsButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aShieldsButton.Location = new System.Drawing.Point(27, 273);
            this.aShieldsButton.Name = "aShieldsButton";
            this.aShieldsButton.Size = new System.Drawing.Size(217, 89);
            this.aShieldsButton.TabIndex = 7;
            this.aShieldsButton.Text = "SHIELDS";
            this.aShieldsButton.UseVisualStyleBackColor = true;
            this.aShieldsButton.Click += new System.EventHandler(this.aShieldsButton_Click);
            // 
            // aPotionsButton
            // 
            this.aPotionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPotionsButton.Location = new System.Drawing.Point(27, 368);
            this.aPotionsButton.Name = "aPotionsButton";
            this.aPotionsButton.Size = new System.Drawing.Size(217, 89);
            this.aPotionsButton.TabIndex = 6;
            this.aPotionsButton.Text = "POTIONS";
            this.aPotionsButton.UseVisualStyleBackColor = true;
            this.aPotionsButton.Click += new System.EventHandler(this.aPotionsButton_Click);
            // 
            // aMasksButton
            // 
            this.aMasksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aMasksButton.Location = new System.Drawing.Point(27, 463);
            this.aMasksButton.Name = "aMasksButton";
            this.aMasksButton.Size = new System.Drawing.Size(217, 82);
            this.aMasksButton.TabIndex = 5;
            this.aMasksButton.Text = "MASKS";
            this.aMasksButton.UseVisualStyleBackColor = true;
            this.aMasksButton.Click += new System.EventHandler(this.aMasksButton_Click);
            // 
            // aConsumablesButton
            // 
            this.aConsumablesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aConsumablesButton.Location = new System.Drawing.Point(27, 551);
            this.aConsumablesButton.Name = "aConsumablesButton";
            this.aConsumablesButton.Size = new System.Drawing.Size(217, 85);
            this.aConsumablesButton.TabIndex = 4;
            this.aConsumablesButton.Text = "CONSUMABLES";
            this.aConsumablesButton.UseVisualStyleBackColor = true;
            this.aConsumablesButton.Click += new System.EventHandler(this.aConsumablesButton_Click);
            // 
            // aSwordsButton
            // 
            this.aSwordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSwordsButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aSwordsButton.Location = new System.Drawing.Point(27, 174);
            this.aSwordsButton.Name = "aSwordsButton";
            this.aSwordsButton.Size = new System.Drawing.Size(217, 93);
            this.aSwordsButton.TabIndex = 2;
            this.aSwordsButton.Text = "SWORDS";
            this.aSwordsButton.UseVisualStyleBackColor = true;
            this.aSwordsButton.Click += new System.EventHandler(this.aSwordsButton_Click);
            // 
            // aTitleTimer
            // 
            this.aTitleTimer.Interval = 500;
            this.aTitleTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MidTermGUI.Properties.Resources.rupee;
            this.pictureBox2.Location = new System.Drawing.Point(651, 556);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // aMusicButton
            // 
            this.aMusicButton.Image = global::MidTermGUI.Properties.Resources.musicmaker;
            this.aMusicButton.Location = new System.Drawing.Point(952, 9);
            this.aMusicButton.Name = "aMusicButton";
            this.aMusicButton.Size = new System.Drawing.Size(154, 89);
            this.aMusicButton.TabIndex = 27;
            this.aMusicButton.UseVisualStyleBackColor = true;
            this.aMusicButton.Click += new System.EventHandler(this.aMusicButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MidTermGUI.Properties.Resources.MaloMartLogo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 159);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // aMaloPicture
            // 
            this.aMaloPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aMaloPicture.Image = global::MidTermGUI.Properties.Resources.malo;
            this.aMaloPicture.Location = new System.Drawing.Point(563, 120);
            this.aMaloPicture.Name = "aMaloPicture";
            this.aMaloPicture.Size = new System.Drawing.Size(350, 410);
            this.aMaloPicture.TabIndex = 23;
            this.aMaloPicture.TabStop = false;
            // 
            // aItemPictureBox
            // 
            this.aItemPictureBox.Image = global::MidTermGUI.Properties.Resources.treasurechest;
            this.aItemPictureBox.Location = new System.Drawing.Point(265, 394);
            this.aItemPictureBox.Name = "aItemPictureBox";
            this.aItemPictureBox.Size = new System.Drawing.Size(244, 218);
            this.aItemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aItemPictureBox.TabIndex = 19;
            this.aItemPictureBox.TabStop = false;
            this.aItemPictureBox.Click += new System.EventHandler(this.aItemPictureBox_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MidTermGUI.Properties.Resources.rupee;
            this.pictureBox3.Location = new System.Drawing.Point(800, 557);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MidTermGUI.Properties.Resources.rupee;
            this.pictureBox4.Location = new System.Drawing.Point(968, 558);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 686);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.aDeleteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aLineTotalLabel);
            this.Controls.Add(this.aMusicButton);
            this.Controls.Add(this.aItemNumeric);
            this.Controls.Add(this.aCategoryNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aMaloPicture);
            this.Controls.Add(this.aShoppingCartLabel);
            this.Controls.Add(this.aShoppingCartList);
            this.Controls.Add(this.aAddToCartButton);
            this.Controls.Add(this.aItemPictureBox);
            this.Controls.Add(this.aItemDescriptionLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aClearCartButton);
            this.Controls.Add(this.aGrandTotalLabel);
            this.Controls.Add(this.aTaxCostLabel);
            this.Controls.Add(this.aTotalCostLabel);
            this.Controls.Add(this.aCategoryListBox);
            this.Controls.Add(this.aShieldsButton);
            this.Controls.Add(this.aPotionsButton);
            this.Controls.Add(this.aMasksButton);
            this.Controls.Add(this.aConsumablesButton);
            this.Controls.Add(this.aCheckoutButton);
            this.Controls.Add(this.aSwordsButton);
            this.Controls.Add(this.aSubTitalLabel);
            this.Controls.Add(this.aTitleLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "MALOMART";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aItemNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMaloPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aItemPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aTitleLabel;
        private System.Windows.Forms.Label aSubTitalLabel;
        private System.Windows.Forms.Button aSwordsButton;
        private System.Windows.Forms.Button aCheckoutButton;
        private System.Windows.Forms.Button aConsumablesButton;
        private System.Windows.Forms.Button aMasksButton;
        private System.Windows.Forms.Button aPotionsButton;
        private System.Windows.Forms.Button aShieldsButton;
        private System.Windows.Forms.ListBox aCategoryListBox;
        private System.Windows.Forms.Label aTotalCostLabel;
        private System.Windows.Forms.Label aTaxCostLabel;
        private System.Windows.Forms.Label aGrandTotalLabel;
        private System.Windows.Forms.Button aClearCartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aItemDescriptionLabel;
        private System.Windows.Forms.PictureBox aItemPictureBox;
        private System.Windows.Forms.Button aAddToCartButton;
        private System.Windows.Forms.ListBox aShoppingCartList;
        private System.Windows.Forms.Label aShoppingCartLabel;
        private System.Windows.Forms.PictureBox aMaloPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label aCategoryNameLabel;
        private System.Windows.Forms.NumericUpDown aItemNumeric;
        private System.Windows.Forms.Button aMusicButton;
        private System.Windows.Forms.Label aLineTotalLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button aDeleteButton;
        private System.Windows.Forms.Timer aTitleTimer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

