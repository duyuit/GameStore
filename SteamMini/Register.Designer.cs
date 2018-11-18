namespace SteamMini
{
    partial class Register
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LOGO = new System.Windows.Forms.PictureBox();
            this.txtRe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtWarningRePass = new System.Windows.Forms.Label();
            this.txtWarningMail = new System.Windows.Forms.Label();
            this.txtWarningPass = new System.Windows.Forms.Label();
            this.txtWarningName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.Control;
            this.txtPass.Location = new System.Drawing.Point(204, 302);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(362, 31);
            this.txtPass.TabIndex = 7;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.Control;
            this.txtID.Location = new System.Drawing.Point(204, 178);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(362, 31);
            this.txtID.TabIndex = 6;
            this.txtID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtID_MouseClick);
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.MouseEnter += new System.EventHandler(this.txtID_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(99, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(71, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Display Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LOGO
            // 
            this.LOGO.InitialImage = global::SteamMini.Properties.Resources.steam_logo;
            this.LOGO.Location = new System.Drawing.Point(204, 36);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(237, 81);
            this.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LOGO.TabIndex = 11;
            this.LOGO.TabStop = false;
            // 
            // txtRe
            // 
            this.txtRe.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtRe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRe.ForeColor = System.Drawing.SystemColors.Control;
            this.txtRe.Location = new System.Drawing.Point(204, 366);
            this.txtRe.Multiline = true;
            this.txtRe.Name = "txtRe";
            this.txtRe.PasswordChar = '*';
            this.txtRe.Size = new System.Drawing.Size(362, 31);
            this.txtRe.TabIndex = 13;
            this.txtRe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(33, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Re-enter password";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.SystemColors.Control;
            this.txtMail.Location = new System.Drawing.Point(204, 239);
            this.txtMail.MaximumSize = new System.Drawing.Size(1001, 1000);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(362, 31);
            this.txtMail.TabIndex = 15;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(129, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(434, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 39);
            this.button2.TabIndex = 17;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(157, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtWarningRePass
            // 
            this.txtWarningRePass.AutoSize = true;
            this.txtWarningRePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarningRePass.ForeColor = System.Drawing.Color.Red;
            this.txtWarningRePass.Location = new System.Drawing.Point(201, 400);
            this.txtWarningRePass.Name = "txtWarningRePass";
            this.txtWarningRePass.Size = new System.Drawing.Size(319, 16);
            this.txtWarningRePass.TabIndex = 18;
            this.txtWarningRePass.Text = "Please enter the same word  in both password fields.";
            this.txtWarningRePass.Visible = false;
            // 
            // txtWarningMail
            // 
            this.txtWarningMail.AutoSize = true;
            this.txtWarningMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarningMail.ForeColor = System.Drawing.Color.Red;
            this.txtWarningMail.Location = new System.Drawing.Point(201, 273);
            this.txtWarningMail.Name = "txtWarningMail";
            this.txtWarningMail.Size = new System.Drawing.Size(351, 16);
            this.txtWarningMail.TabIndex = 19;
            this.txtWarningMail.Text = "Please enter correct Email pattern (Ex:abc12@gmail.com)";
            this.txtWarningMail.Visible = false;
            // 
            // txtWarningPass
            // 
            this.txtWarningPass.AutoSize = true;
            this.txtWarningPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarningPass.ForeColor = System.Drawing.Color.Red;
            this.txtWarningPass.Location = new System.Drawing.Point(201, 336);
            this.txtWarningPass.Name = "txtWarningPass";
            this.txtWarningPass.Size = new System.Drawing.Size(311, 16);
            this.txtWarningPass.TabIndex = 20;
            this.txtWarningPass.Text = "The password must contain at least eight character.";
            this.txtWarningPass.Visible = false;
            this.txtWarningPass.Click += new System.EventHandler(this.txtWarningPass_Click);
            // 
            // txtWarningName
            // 
            this.txtWarningName.AutoSize = true;
            this.txtWarningName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarningName.ForeColor = System.Drawing.Color.Red;
            this.txtWarningName.Location = new System.Drawing.Point(201, 212);
            this.txtWarningName.Name = "txtWarningName";
            this.txtWarningName.Size = new System.Drawing.Size(160, 16);
            this.txtWarningName.TabIndex = 21;
            this.txtWarningName.Text = "Display name is required.";
            this.txtWarningName.Visible = false;
            this.txtWarningName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtWarningName_MouseClick);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(680, 587);
            this.Controls.Add(this.txtWarningName);
            this.Controls.Add(this.txtWarningPass);
            this.Controls.Add(this.txtWarningMail);
            this.Controls.Add(this.txtWarningRePass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LOGO);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LOGO;
        private System.Windows.Forms.TextBox txtRe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtWarningRePass;
        private System.Windows.Forms.Label txtWarningMail;
        private System.Windows.Forms.Label txtWarningPass;
        private System.Windows.Forms.Label txtWarningName;
    }
}