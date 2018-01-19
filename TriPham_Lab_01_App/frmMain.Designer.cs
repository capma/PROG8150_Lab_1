namespace TriPham_Lab_01_App
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblParis = new System.Windows.Forms.Label();
            this.lblLondon = new System.Windows.Forms.Label();
            this.lblStPetersburg = new System.Windows.Forms.Label();
            this.lblPrague = new System.Windows.Forms.Label();
            this.txtCityInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblParis
            // 
            this.lblParis.AutoEllipsis = true;
            this.lblParis.BackColor = System.Drawing.Color.Transparent;
            this.lblParis.Location = new System.Drawing.Point(854, 77);
            this.lblParis.Name = "lblParis";
            this.lblParis.Size = new System.Drawing.Size(56, 29);
            this.lblParis.TabIndex = 0;
            this.lblParis.MouseLeave += new System.EventHandler(this.lblParis_MouseLeave);
            this.lblParis.MouseHover += new System.EventHandler(this.lblParis_MouseHover);
            // 
            // lblLondon
            // 
            this.lblLondon.AutoEllipsis = true;
            this.lblLondon.BackColor = System.Drawing.Color.Transparent;
            this.lblLondon.Location = new System.Drawing.Point(701, 117);
            this.lblLondon.Name = "lblLondon";
            this.lblLondon.Size = new System.Drawing.Size(57, 28);
            this.lblLondon.TabIndex = 2;
            this.lblLondon.MouseLeave += new System.EventHandler(this.lblLondon_MouseLeave);
            this.lblLondon.MouseHover += new System.EventHandler(this.lblLondon_MouseHover);
            // 
            // lblStPetersburg
            // 
            this.lblStPetersburg.AutoEllipsis = true;
            this.lblStPetersburg.BackColor = System.Drawing.Color.Transparent;
            this.lblStPetersburg.Location = new System.Drawing.Point(982, 65);
            this.lblStPetersburg.Name = "lblStPetersburg";
            this.lblStPetersburg.Size = new System.Drawing.Size(83, 32);
            this.lblStPetersburg.TabIndex = 2;
            this.lblStPetersburg.MouseLeave += new System.EventHandler(this.lblStPetersburg_MouseLeave);
            this.lblStPetersburg.MouseHover += new System.EventHandler(this.lblStPetersburg_MouseHover);
            // 
            // lblPrague
            // 
            this.lblPrague.AutoEllipsis = true;
            this.lblPrague.BackColor = System.Drawing.Color.Transparent;
            this.lblPrague.Location = new System.Drawing.Point(982, 221);
            this.lblPrague.Name = "lblPrague";
            this.lblPrague.Size = new System.Drawing.Size(59, 30);
            this.lblPrague.TabIndex = 2;
            this.lblPrague.MouseLeave += new System.EventHandler(this.lblPrague_MouseLeave);
            this.lblPrague.MouseHover += new System.EventHandler(this.lblPrague_MouseHover);
            // 
            // txtCityInfo
            // 
            this.txtCityInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCityInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCityInfo.ForeColor = System.Drawing.Color.Yellow;
            this.txtCityInfo.Location = new System.Drawing.Point(12, 12);
            this.txtCityInfo.Name = "txtCityInfo";
            this.txtCityInfo.Size = new System.Drawing.Size(385, 227);
            this.txtCityInfo.TabIndex = 3;
            this.txtCityInfo.Text = resources.GetString("txtCityInfo.Text");
            this.txtCityInfo.Visible = false;
            this.txtCityInfo.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.txtCityInfo_ContentsResized);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TriPham_Lab_01_App.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 698);
            this.Controls.Add(this.txtCityInfo);
            this.Controls.Add(this.lblPrague);
            this.Controls.Add(this.lblStPetersburg);
            this.Controls.Add(this.lblLondon);
            this.Controls.Add(this.lblParis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblParis;
        private System.Windows.Forms.Label lblLondon;
        private System.Windows.Forms.Label lblStPetersburg;
        private System.Windows.Forms.Label lblPrague;
        private System.Windows.Forms.RichTextBox txtCityInfo;
    }
}

