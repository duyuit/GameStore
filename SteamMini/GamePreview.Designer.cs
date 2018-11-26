namespace SteamMini
{
    partial class GamePreview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.RatingText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Location = new System.Drawing.Point(272, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(85, 25);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "lbName";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbPrice.Location = new System.Drawing.Point(272, 148);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(78, 25);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "lbPrice";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SteamMini.Properties.Resources._1024px_Gold_Star_svg;
            this.pictureBox1.Location = new System.Drawing.Point(907, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // picBox
            // 
            this.picBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Margin = new System.Windows.Forms.Padding(6);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(272, 173);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // RatingText
            // 
            this.RatingText.AutoSize = true;
            this.RatingText.BackColor = System.Drawing.Color.Silver;
            this.RatingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingText.Location = new System.Drawing.Point(941, 75);
            this.RatingText.Name = "RatingText";
            this.RatingText.Size = new System.Drawing.Size(31, 20);
            this.RatingText.TabIndex = 4;
            this.RatingText.Text = "4.5";
            // 
            // GamePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.RatingText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.picBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GamePreview";
            this.Size = new System.Drawing.Size(1010, 173);
            this.MouseEnter += new System.EventHandler(this.GamePreview_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.GamePreview_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label RatingText;
    }
}
