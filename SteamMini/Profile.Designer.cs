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
            this.avatar = new System.Windows.Forms.PictureBox();
            this.QuoteLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.QuoteText = new System.Windows.Forms.Label();
            this.Editquote = new System.Windows.Forms.Label();
            this.UserLevel = new System.Windows.Forms.Label();
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
            this.panel3.Controls.Add(this.avatar);
            this.panel3.Controls.Add(this.QuoteLabel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.QuoteText);
            this.panel3.Controls.Add(this.Editquote);
            this.panel3.Controls.Add(this.UserLevel);
            this.panel3.Controls.Add(this.UserName);
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 214);
            this.panel3.TabIndex = 10;
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
            // QuoteLabel
            // 
            this.QuoteLabel.AutoSize = true;
            this.QuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.QuoteLabel.Location = new System.Drawing.Point(153, 95);
            this.QuoteLabel.Name = "QuoteLabel";
            this.QuoteLabel.Size = new System.Drawing.Size(53, 16);
            this.QuoteLabel.TabIndex = 3;
            this.QuoteLabel.Text = "Quote:";
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
            // QuoteText
            // 
            this.QuoteText.AutoSize = true;
            this.QuoteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteText.ForeColor = System.Drawing.SystemColors.Control;
            this.QuoteText.Location = new System.Drawing.Point(152, 111);
            this.QuoteText.Name = "QuoteText";
            this.QuoteText.Size = new System.Drawing.Size(177, 24);
            this.QuoteText.TabIndex = 2;
            this.QuoteText.Text = "\"We are Developer\"";
            // 
            // Editquote
            // 
            this.Editquote.AutoSize = true;
            this.Editquote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editquote.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Editquote.Location = new System.Drawing.Point(726, 119);
            this.Editquote.Name = "Editquote";
            this.Editquote.Size = new System.Drawing.Size(68, 16);
            this.Editquote.TabIndex = 5;
            this.Editquote.Text = "Edit quote";
            this.Editquote.Click += new System.EventHandler(this.label5_Click);
            // 
            // UserLevel
            // 
            this.UserLevel.AutoSize = true;
            this.UserLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLevel.ForeColor = System.Drawing.SystemColors.Control;
            this.UserLevel.Location = new System.Drawing.Point(707, 8);
            this.UserLevel.Name = "UserLevel";
            this.UserLevel.Size = new System.Drawing.Size(80, 24);
            this.UserLevel.TabIndex = 6;
            this.UserLevel.Text = "Level 13";
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
        private System.Windows.Forms.Label QuoteText;
        private System.Windows.Forms.Label QuoteLabel;
        private System.Windows.Forms.Label Editquote;
        private System.Windows.Forms.Label UserLevel;
        private System.Windows.Forms.ListView listGame;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}