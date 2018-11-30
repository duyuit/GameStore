namespace SteamMini
{
    partial class Profile
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RechargeButton = new System.Windows.Forms.Button();
            this.RechargeTextBox = new System.Windows.Forms.TextBox();
            this.SoDuText = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditQuote = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listGame = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(100, 60);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 447);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.RechargeButton);
            this.panel3.Controls.Add(this.RechargeTextBox);
            this.panel3.Controls.Add(this.SoDuText);
            this.panel3.Controls.Add(this.avatar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.EditQuote);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.UserName);
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 214);
            this.panel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(152, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Recharge:";
            // 
            // RechargeButton
            // 
            this.RechargeButton.Location = new System.Drawing.Point(465, 145);
            this.RechargeButton.Name = "RechargeButton";
            this.RechargeButton.Size = new System.Drawing.Size(75, 23);
            this.RechargeButton.TabIndex = 11;
            this.RechargeButton.Text = "Submit";
            this.RechargeButton.UseVisualStyleBackColor = true;
            this.RechargeButton.Click += new System.EventHandler(this.RechargeButton_Click);
            // 
            // RechargeTextBox
            // 
            this.RechargeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RechargeTextBox.Location = new System.Drawing.Point(256, 146);
            this.RechargeTextBox.Name = "RechargeTextBox";
            this.RechargeTextBox.Size = new System.Drawing.Size(183, 20);
            this.RechargeTextBox.TabIndex = 10;
            this.RechargeTextBox.TextChanged += new System.EventHandler(this.RechargeTextBox_TextChanged);
            this.RechargeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RechargeTextBox_KeyPress);
            this.RechargeTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RechargeTextBox_KeyUp);
            // 
            // SoDuText
            // 
            this.SoDuText.AutoSize = true;
            this.SoDuText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoDuText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SoDuText.Location = new System.Drawing.Point(153, 66);
            this.SoDuText.Name = "SoDuText";
            this.SoDuText.Size = new System.Drawing.Size(78, 24);
            this.SoDuText.TabIndex = 9;
            this.SoDuText.Text = "Money: ";
            // 
            // avatar
            // 
            this.avatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.avatar.Location = new System.Drawing.Point(11, 3);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(134, 132);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(153, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quote:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(3, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "ALL PURCHASED GAMES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(152, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "\"We are Developer\"";
            // 
            // EditQuote
            // 
            this.EditQuote.AutoSize = true;
            this.EditQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditQuote.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EditQuote.Location = new System.Drawing.Point(11, 150);
            this.EditQuote.Name = "EditQuote";
            this.EditQuote.Size = new System.Drawing.Size(68, 16);
            this.EditQuote.TabIndex = 5;
            this.EditQuote.Text = "Edit quote";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(152, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Level 13";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.SystemColors.Control;
            this.UserName.Location = new System.Drawing.Point(151, 7);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(141, 25);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "DUYKKXM92";
            this.UserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listGame);
            this.panel2.Location = new System.Drawing.Point(6, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 224);
            this.panel2.TabIndex = 9;
            // 
            // listGame
            // 
            this.listGame.AutoArrange = false;
            this.listGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listGame.ForeColor = System.Drawing.SystemColors.Control;
            this.listGame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listGame.Location = new System.Drawing.Point(-6, 3);
            this.listGame.MultiSelect = false;
            this.listGame.Name = "listGame";
            this.listGame.Size = new System.Drawing.Size(794, 224);
            this.listGame.TabIndex = 7;
            this.listGame.UseCompatibleStateImageBehavior = false;
            this.listGame.View = System.Windows.Forms.View.List;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EditQuote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listGame;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SoDuText;
        private System.Windows.Forms.TextBox RechargeTextBox;
        private System.Windows.Forms.Button RechargeButton;
        private System.Windows.Forms.Label label1;
    }
}