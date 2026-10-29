namespace DesktopApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.btnSaxla = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtYol = new System.Windows.Forms.TextBox();
            this.grpFayllar = new System.Windows.Forms.GroupBox();
            this.lstFayllar = new System.Windows.Forms.ListBox();
            this.lblMetn = new System.Windows.Forms.Label();
            this.txtMetn = new System.Windows.Forms.TextBox();
            this.pnlMelumat = new System.Windows.Forms.Panel();
            this.lblMelumat = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpFayllar.SuspendLayout();
            this.pnlMelumat.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // btnYeni
            this.btnYeni.Location = new System.Drawing.Point(11, 11);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(87, 25);
            this.btnYeni.Text = "Yeni fayl";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);

            // btnAc
            this.btnAc.Location = new System.Drawing.Point(108, 11);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(87, 25);
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);

            // btnSaxla
            this.btnSaxla.Location = new System.Drawing.Point(206, 11);
            this.btnSaxla.Name = "btnSaxla";
            this.btnSaxla.Size = new System.Drawing.Size(87, 25);
            this.btnSaxla.Text = "Yadda saxla";
            this.btnSaxla.UseVisualStyleBackColor = true;
            this.btnSaxla.Click += new System.EventHandler(this.btnSaxla_Click);

            // btnSil
            this.btnSil.Location = new System.Drawing.Point(304, 11);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 25);
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // txtYol
            this.txtYol.Location = new System.Drawing.Point(402, 15);
            this.txtYol.Name = "txtYol";
            this.txtYol.ReadOnly = true;
            this.txtYol.Size = new System.Drawing.Size(173, 20);
            this.txtYol.Text = "";

            // grpFayllar
            this.grpFayllar.Controls.Add(this.lstFayllar);
            this.grpFayllar.Location = new System.Drawing.Point(11, 50);
            this.grpFayllar.Name = "grpFayllar";
            this.grpFayllar.Size = new System.Drawing.Size(161, 254);
            this.grpFayllar.TabStop = false;
            this.grpFayllar.Text = "Fayllar";

            // lstFayllar
            this.lstFayllar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFayllar.FormattingEnabled = true;
            this.lstFayllar.Name = "lstFayllar";
            this.lstFayllar.SelectedIndexChanged += new System.EventHandler(this.lstFayllar_SelectedIndexChanged);

            // lblMetn
            this.lblMetn.AutoSize = true;
            this.lblMetn.Location = new System.Drawing.Point(189, 48);
            this.lblMetn.Name = "lblMetn";
            this.lblMetn.Text = "Mətn";

            // txtMetn
            this.txtMetn.Location = new System.Drawing.Point(189, 65);
            this.txtMetn.Multiline = true;
            this.txtMetn.Name = "txtMetn";
            this.txtMetn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMetn.Size = new System.Drawing.Size(386, 239);
            this.txtMetn.Text = "";

            // pnlMelumat
            this.pnlMelumat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMelumat.Controls.Add(this.lblMelumat);
            this.pnlMelumat.Location = new System.Drawing.Point(11, 327);
            this.pnlMelumat.Name = "pnlMelumat";
            this.pnlMelumat.Size = new System.Drawing.Size(564, 30);

            // lblMelumat
            this.lblMelumat.AutoSize = true;
            this.lblMelumat.Location = new System.Drawing.Point(6, 7);
            this.lblMelumat.Name = "lblMelumat";
            this.lblMelumat.Text = "";

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatus });
            this.statusStrip1.Name = "statusStrip1";

            // lblStatus
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "Hazırdır  |  Fayl sayı: 0";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 385);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.btnSaxla);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtYol);
            this.Controls.Add(this.grpFayllar);
            this.Controls.Add(this.lblMetn);
            this.Controls.Add(this.txtMetn);
            this.Controls.Add(this.pnlMelumat);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fayl Meneceri";
            this.grpFayllar.ResumeLayout(false);
            this.pnlMelumat.ResumeLayout(false);
            this.pnlMelumat.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnSaxla;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtYol;
        private System.Windows.Forms.GroupBox grpFayllar;
        private System.Windows.Forms.ListBox lstFayllar;
        private System.Windows.Forms.Label lblMetn;
        private System.Windows.Forms.TextBox txtMetn;
        private System.Windows.Forms.Panel pnlMelumat;
        private System.Windows.Forms.Label lblMelumat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}