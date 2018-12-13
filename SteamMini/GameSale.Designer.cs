﻿namespace SteamMini
{
    partial class GameSale
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.GameCollection = new System.Windows.Forms.ComboBox();
            this.GameCollectionLabel = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txbAfter = new System.Windows.Forms.TextBox();
            this.lblAfter = new System.Windows.Forms.Label();
            this.txbPercent = new System.Windows.Forms.TextBox();
            this.lblSale = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblChooseGame = new System.Windows.Forms.Label();
            this.lblChooseSale = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.NumericUpDown();
            this.Hours = new System.Windows.Forms.NumericUpDown();
            this.Mins = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mins)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(312, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 38);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(115, 348);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(144, 38);
            this.btnOK.TabIndex = 39;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // GameCollection
            // 
            this.GameCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameCollection.FormattingEnabled = true;
            this.GameCollection.Location = new System.Drawing.Point(118, 43);
            this.GameCollection.Name = "GameCollection";
            this.GameCollection.Size = new System.Drawing.Size(237, 21);
            this.GameCollection.TabIndex = 38;
            this.GameCollection.SelectedIndexChanged += new System.EventHandler(this.GameCollection_SelectedIndexChanged);
            // 
            // GameCollectionLabel
            // 
            this.GameCollectionLabel.AutoSize = true;
            this.GameCollectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameCollectionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GameCollectionLabel.Location = new System.Drawing.Point(12, 44);
            this.GameCollectionLabel.Name = "GameCollectionLabel";
            this.GameCollectionLabel.Size = new System.Drawing.Size(61, 20);
            this.GameCollectionLabel.TabIndex = 37;
            this.GameCollectionLabel.Text = "Games";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(12, 289);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 33;
            this.lblTime.Text = "Time";
            // 
            // txbAfter
            // 
            this.txbAfter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txbAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAfter.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txbAfter.Location = new System.Drawing.Point(115, 227);
            this.txbAfter.Name = "txbAfter";
            this.txbAfter.ReadOnly = true;
            this.txbAfter.Size = new System.Drawing.Size(363, 26);
            this.txbAfter.TabIndex = 32;
            // 
            // lblAfter
            // 
            this.lblAfter.AutoSize = true;
            this.lblAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfter.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAfter.Location = new System.Drawing.Point(11, 233);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(76, 20);
            this.lblAfter.TabIndex = 31;
            this.lblAfter.Text = "AfterSale";
            // 
            // txbPercent
            // 
            this.txbPercent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txbPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPercent.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txbPercent.Location = new System.Drawing.Point(115, 186);
            this.txbPercent.Name = "txbPercent";
            this.txbPercent.Size = new System.Drawing.Size(363, 26);
            this.txbPercent.TabIndex = 30;
            this.txbPercent.TextChanged += new System.EventHandler(this.txbPercent_TextChanged);
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSale.Location = new System.Drawing.Point(12, 192);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(59, 20);
            this.lblSale.TabIndex = 29;
            this.lblSale.Text = "Sale %";
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.ForeColor = System.Drawing.Color.White;
            this.tbPrice.Location = new System.Drawing.Point(118, 115);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(360, 26);
            this.tbPrice.TabIndex = 28;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrice.Location = new System.Drawing.Point(11, 115);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(101, 20);
            this.lblPrice.TabIndex = 27;
            this.lblPrice.Text = "Current Price";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(118, 81);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(360, 26);
            this.tbName.TabIndex = 25;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(12, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name";
            // 
            // lblChooseGame
            // 
            this.lblChooseGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChooseGame.AutoSize = true;
            this.lblChooseGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseGame.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChooseGame.Location = new System.Drawing.Point(223, 9);
            this.lblChooseGame.Name = "lblChooseGame";
            this.lblChooseGame.Size = new System.Drawing.Size(108, 20);
            this.lblChooseGame.TabIndex = 42;
            this.lblChooseGame.Text = "Choose game";
            this.lblChooseGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblChooseSale
            // 
            this.lblChooseSale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChooseSale.AutoSize = true;
            this.lblChooseSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseSale.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChooseSale.Location = new System.Drawing.Point(223, 157);
            this.lblChooseSale.Name = "lblChooseSale";
            this.lblChooseSale.Size = new System.Drawing.Size(105, 20);
            this.lblChooseSale.TabIndex = 43;
            this.lblChooseSale.Text = "Choose sales";
            this.lblChooseSale.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(186, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(308, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(437, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Minutes";
            // 
            // Days
            // 
            this.Days.Location = new System.Drawing.Point(115, 289);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(65, 20);
            this.Days.TabIndex = 51;
            this.Days.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Hours
            // 
            this.Hours.Location = new System.Drawing.Point(237, 289);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(65, 20);
            this.Hours.TabIndex = 52;
            this.Hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Mins
            // 
            this.Mins.Location = new System.Drawing.Point(366, 289);
            this.Mins.Name = "Mins";
            this.Mins.Size = new System.Drawing.Size(65, 20);
            this.Mins.TabIndex = 53;
            this.Mins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GameSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(545, 417);
            this.Controls.Add(this.Mins);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChooseSale);
            this.Controls.Add(this.lblChooseGame);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.GameCollection);
            this.Controls.Add(this.GameCollectionLabel);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txbAfter);
            this.Controls.Add(this.lblAfter);
            this.Controls.Add(this.txbPercent);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Name = "GameSale";
            this.Text = "GameSale";
            ((System.ComponentModel.ISupportInitialize)(this.Days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox GameCollection;
        private System.Windows.Forms.Label GameCollectionLabel;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txbAfter;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.TextBox txbPercent;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblChooseGame;
        private System.Windows.Forms.Label lblChooseSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Days;
        private System.Windows.Forms.NumericUpDown Hours;
        private System.Windows.Forms.NumericUpDown Mins;
    }
}