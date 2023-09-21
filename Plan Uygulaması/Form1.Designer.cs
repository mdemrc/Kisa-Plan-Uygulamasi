namespace Plan_Uygulaması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgw1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbders = new System.Windows.Forms.ComboBox();
            this.txtkonu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.txttarih = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btntarihguncelle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tarihDüzenlemeKilidiniKaldırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarihiKilitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTrackBar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw1
            // 
            this.dgw1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgw1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw1.EnableHeadersVisualStyles = false;
            this.dgw1.GridColor = System.Drawing.Color.Orchid;
            this.dgw1.Location = new System.Drawing.Point(12, 308);
            this.dgw1.Name = "dgw1";
            this.dgw1.Size = new System.Drawing.Size(982, 311);
            this.dgw1.TabIndex = 0;
            this.dgw1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw1_CellClick);
            this.dgw1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(818, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kısa Dönem Programlayıcı";
            // 
            // cmbders
            // 
            this.cmbders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.cmbders.FormattingEnabled = true;
            this.cmbders.Items.AddRange(new object[] {
            "Matematik",
            "Fizik",
            "Kimya",
            "Biyoloji",
            "Türkçe",
            "Coğrafya",
            "Felsefe",
            "Din",
            "Tarih",
            "Geometri",
            "Genel"});
            this.cmbders.Location = new System.Drawing.Point(125, 152);
            this.cmbders.Name = "cmbders";
            this.cmbders.Size = new System.Drawing.Size(145, 33);
            this.cmbders.TabIndex = 2;
            // 
            // txtkonu
            // 
            this.txtkonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtkonu.Location = new System.Drawing.Point(125, 208);
            this.txtkonu.Name = "txtkonu";
            this.txtkonu.Size = new System.Drawing.Size(728, 31);
            this.txtkonu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(30, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "DERS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(30, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "KONU:";
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnekle.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnekle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnekle.Location = new System.Drawing.Point(125, 245);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(145, 57);
            this.btnekle.TabIndex = 6;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnsil.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnsil.Location = new System.Drawing.Point(276, 245);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(145, 57);
            this.btnsil.TabIndex = 7;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnguncelle.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguncelle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnguncelle.Location = new System.Drawing.Point(427, 245);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(195, 57);
            this.btnguncelle.TabIndex = 8;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(934, 107);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(60, 24);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "label4";
            this.lblid.Visible = false;
            // 
            // txttarih
            // 
            this.txttarih.BackColor = System.Drawing.Color.YellowGreen;
            this.txttarih.Enabled = false;
            this.txttarih.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttarih.Location = new System.Drawing.Point(597, 153);
            this.txttarih.Name = "txttarih";
            this.txttarih.Size = new System.Drawing.Size(128, 29);
            this.txttarih.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(520, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "TARİH:";
            // 
            // btntarihguncelle
            // 
            this.btntarihguncelle.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btntarihguncelle.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.btntarihguncelle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btntarihguncelle.Location = new System.Drawing.Point(728, 154);
            this.btntarihguncelle.Name = "btntarihguncelle";
            this.btntarihguncelle.Size = new System.Drawing.Size(125, 28);
            this.btntarihguncelle.TabIndex = 12;
            this.btntarihguncelle.Text = "GÜNCELLE";
            this.btntarihguncelle.UseVisualStyleBackColor = false;
            this.btntarihguncelle.Click += new System.EventHandler(this.bnttarihguncelle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Cyan;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarihDüzenlemeKilidiniKaldırToolStripMenuItem,
            this.tarihiKilitleToolStripMenuItem,
            this.toolStripMenuItemTrackBar});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 70);
            // 
            // tarihDüzenlemeKilidiniKaldırToolStripMenuItem
            // 
            this.tarihDüzenlemeKilidiniKaldırToolStripMenuItem.Name = "tarihDüzenlemeKilidiniKaldırToolStripMenuItem";
            this.tarihDüzenlemeKilidiniKaldırToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.tarihDüzenlemeKilidiniKaldırToolStripMenuItem.Text = "Tarih Kilidini Kaldır";
            this.tarihDüzenlemeKilidiniKaldırToolStripMenuItem.Click += new System.EventHandler(this.tarihDüzenlemeKilidiniKaldırToolStripMenuItem_Click);
            // 
            // tarihiKilitleToolStripMenuItem
            // 
            this.tarihiKilitleToolStripMenuItem.Name = "tarihiKilitleToolStripMenuItem";
            this.tarihiKilitleToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.tarihiKilitleToolStripMenuItem.Text = "Tarihi Kilitle";
            this.tarihiKilitleToolStripMenuItem.Click += new System.EventHandler(this.tarihiKilitleToolStripMenuItem_Click);
            // 
            // toolStripMenuItemTrackBar
            // 
            this.toolStripMenuItemTrackBar.Name = "toolStripMenuItemTrackBar";
            this.toolStripMenuItemTrackBar.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItemTrackBar.Text = "Arka Plan Rengi Ayarı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1006, 631);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btntarihguncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttarih);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkonu);
            this.Controls.Add(this.cmbders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgw1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kısa Dönem Planlayıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbders;
        private System.Windows.Forms.TextBox txtkonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txttarih;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btntarihguncelle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tarihDüzenlemeKilidiniKaldırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarihiKilitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTrackBar;
    }
}

