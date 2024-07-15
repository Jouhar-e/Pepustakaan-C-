namespace Perpustakaan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pustakawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anggotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengembalianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lPustakawan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.pengembalianToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pustakawanToolStripMenuItem,
            this.anggotaToolStripMenuItem,
            this.bukuToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // pustakawanToolStripMenuItem
            // 
            this.pustakawanToolStripMenuItem.Name = "pustakawanToolStripMenuItem";
            this.pustakawanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pustakawanToolStripMenuItem.Text = "Pustakawan";
            this.pustakawanToolStripMenuItem.Click += new System.EventHandler(this.pustakawanToolStripMenuItem_Click);
            // 
            // anggotaToolStripMenuItem
            // 
            this.anggotaToolStripMenuItem.Name = "anggotaToolStripMenuItem";
            this.anggotaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.anggotaToolStripMenuItem.Text = "Anggota";
            this.anggotaToolStripMenuItem.Click += new System.EventHandler(this.anggotaToolStripMenuItem_Click);
            // 
            // bukuToolStripMenuItem
            // 
            this.bukuToolStripMenuItem.Name = "bukuToolStripMenuItem";
            this.bukuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bukuToolStripMenuItem.Text = "Buku";
            this.bukuToolStripMenuItem.Click += new System.EventHandler(this.bukuToolStripMenuItem_Click);
            // 
            // pengembalianToolStripMenuItem
            // 
            this.pengembalianToolStripMenuItem.Name = "pengembalianToolStripMenuItem";
            this.pengembalianToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.pengembalianToolStripMenuItem.Text = "Pengembalian";
            this.pengembalianToolStripMenuItem.Click += new System.EventHandler(this.pengembalianToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            this.laporanToolStripMenuItem.Click += new System.EventHandler(this.laporanToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lPustakawan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(764, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 102);
            this.button1.TabIndex = 2;
            this.button1.Text = "Peminjaman";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lPustakawan
            // 
            this.lPustakawan.AutoSize = true;
            this.lPustakawan.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPustakawan.Location = new System.Drawing.Point(151, 54);
            this.lPustakawan.Name = "lPustakawan";
            this.lPustakawan.Size = new System.Drawing.Size(122, 26);
            this.lPustakawan.TabIndex = 1;
            this.lPustakawan.Text = "Pustakawan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pustakawan :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1014, 463);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Peminjaman";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 608);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pustakawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anggotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengembalianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lPustakawan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}

