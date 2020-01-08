namespace DataGridViewMysql
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_Tagok = new System.Windows.Forms.GroupBox();
            this.textBox_Orszag = new System.Windows.Forms.TextBox();
            this.button_Tag_Delete = new System.Windows.Forms.Button();
            this.button_Tag_Update = new System.Windows.Forms.Button();
            this.button_Tag_Insert = new System.Windows.Forms.Button();
            this.numericUpDown_SzuletesiEv = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Iranyitoszam = new System.Windows.Forms.NumericUpDown();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Tagok = new System.Windows.Forms.DataGridView();
            this.dataGridView_Befizetesek = new System.Windows.Forms.DataGridView();
            this.groupBox_Befizetesek = new System.Windows.Forms.GroupBox();
            this.panel_tagok = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.felvételToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.groupBox_Tagok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzuletesiEv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Iranyitoszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tagok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Befizetesek)).BeginInit();
            this.groupBox_Befizetesek.SuspendLayout();
            this.panel_tagok.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Tagok
            // 
            this.groupBox_Tagok.Controls.Add(this.textBox_Orszag);
            this.groupBox_Tagok.Controls.Add(this.button_Tag_Delete);
            this.groupBox_Tagok.Controls.Add(this.button_Tag_Update);
            this.groupBox_Tagok.Controls.Add(this.button_Tag_Insert);
            this.groupBox_Tagok.Controls.Add(this.numericUpDown_SzuletesiEv);
            this.groupBox_Tagok.Controls.Add(this.numericUpDown_Iranyitoszam);
            this.groupBox_Tagok.Controls.Add(this.textBox_Nev);
            this.groupBox_Tagok.Controls.Add(this.label4);
            this.groupBox_Tagok.Controls.Add(this.label3);
            this.groupBox_Tagok.Controls.Add(this.label2);
            this.groupBox_Tagok.Controls.Add(this.label1);
            this.groupBox_Tagok.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Tagok.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Tagok.Name = "groupBox_Tagok";
            this.groupBox_Tagok.Size = new System.Drawing.Size(586, 133);
            this.groupBox_Tagok.TabIndex = 0;
            this.groupBox_Tagok.TabStop = false;
            this.groupBox_Tagok.Text = "Tag adatai";
            // 
            // textBox_Orszag
            // 
            this.textBox_Orszag.Location = new System.Drawing.Point(282, 44);
            this.textBox_Orszag.Name = "textBox_Orszag";
            this.textBox_Orszag.Size = new System.Drawing.Size(65, 20);
            this.textBox_Orszag.TabIndex = 9;
            this.textBox_Orszag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Tag_Delete
            // 
            this.button_Tag_Delete.Location = new System.Drawing.Point(395, 85);
            this.button_Tag_Delete.Name = "button_Tag_Delete";
            this.button_Tag_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Tag_Delete.TabIndex = 8;
            this.button_Tag_Delete.Text = "Törlés";
            this.button_Tag_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Tag_Update
            // 
            this.button_Tag_Update.Location = new System.Drawing.Point(244, 85);
            this.button_Tag_Update.Name = "button_Tag_Update";
            this.button_Tag_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Tag_Update.TabIndex = 8;
            this.button_Tag_Update.Text = "Módosítás";
            this.button_Tag_Update.UseVisualStyleBackColor = true;
            // 
            // button_Tag_Insert
            // 
            this.button_Tag_Insert.Location = new System.Drawing.Point(93, 85);
            this.button_Tag_Insert.Name = "button_Tag_Insert";
            this.button_Tag_Insert.Size = new System.Drawing.Size(75, 23);
            this.button_Tag_Insert.TabIndex = 8;
            this.button_Tag_Insert.Text = "Rögzítés";
            this.button_Tag_Insert.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_SzuletesiEv
            // 
            this.numericUpDown_SzuletesiEv.Location = new System.Drawing.Point(493, 45);
            this.numericUpDown_SzuletesiEv.Name = "numericUpDown_SzuletesiEv";
            this.numericUpDown_SzuletesiEv.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown_SzuletesiEv.TabIndex = 7;
            this.numericUpDown_SzuletesiEv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDown_Iranyitoszam
            // 
            this.numericUpDown_Iranyitoszam.Location = new System.Drawing.Point(376, 45);
            this.numericUpDown_Iranyitoszam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_Iranyitoszam.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_Iranyitoszam.Name = "numericUpDown_Iranyitoszam";
            this.numericUpDown_Iranyitoszam.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown_Iranyitoszam.TabIndex = 6;
            this.numericUpDown_Iranyitoszam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Iranyitoszam.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(14, 45);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(237, 20);
            this.textBox_Nev.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Születési év";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Irányítószám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ország";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // dataGridView_Tagok
            // 
            this.dataGridView_Tagok.AllowUserToAddRows = false;
            this.dataGridView_Tagok.AllowUserToDeleteRows = false;
            this.dataGridView_Tagok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tagok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Tagok.Location = new System.Drawing.Point(0, 131);
            this.dataGridView_Tagok.Name = "dataGridView_Tagok";
            this.dataGridView_Tagok.ReadOnly = true;
            this.dataGridView_Tagok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Tagok.Size = new System.Drawing.Size(586, 292);
            this.dataGridView_Tagok.TabIndex = 1;
            this.dataGridView_Tagok.SelectionChanged += new System.EventHandler(this.dataGridView_Tagok_SelectionChanged);
            // 
            // dataGridView_Befizetesek
            // 
            this.dataGridView_Befizetesek.AllowUserToAddRows = false;
            this.dataGridView_Befizetesek.AllowUserToDeleteRows = false;
            this.dataGridView_Befizetesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Befizetesek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Befizetesek.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_Befizetesek.Name = "dataGridView_Befizetesek";
            this.dataGridView_Befizetesek.ReadOnly = true;
            this.dataGridView_Befizetesek.Size = new System.Drawing.Size(278, 404);
            this.dataGridView_Befizetesek.TabIndex = 0;
            // 
            // groupBox_Befizetesek
            // 
            this.groupBox_Befizetesek.Controls.Add(this.dataGridView_Befizetesek);
            this.groupBox_Befizetesek.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox_Befizetesek.Location = new System.Drawing.Point(607, 0);
            this.groupBox_Befizetesek.Name = "groupBox_Befizetesek";
            this.groupBox_Befizetesek.Size = new System.Drawing.Size(284, 423);
            this.groupBox_Befizetesek.TabIndex = 0;
            this.groupBox_Befizetesek.TabStop = false;
            this.groupBox_Befizetesek.Text = "A tag befizetései";
            // 
            // panel_tagok
            // 
            this.panel_tagok.Controls.Add(this.dataGridView_Tagok);
            this.panel_tagok.Controls.Add(this.groupBox_Tagok);
            this.panel_tagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_tagok.Location = new System.Drawing.Point(0, 0);
            this.panel_tagok.Name = "panel_tagok";
            this.panel_tagok.Size = new System.Drawing.Size(586, 423);
            this.panel_tagok.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.felvételToolStripMenuItem,
            this.törlésToolStripMenuItem,
            this.módosításToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Tagok";
            // 
            // felvételToolStripMenuItem
            // 
            this.felvételToolStripMenuItem.Name = "felvételToolStripMenuItem";
            this.felvételToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.felvételToolStripMenuItem.Text = "Felvétel";
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem2.Text = "Befizetés";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Controls.Add(this.groupBox_Befizetesek);
            this.panel_Bottom.Controls.Add(this.panel_tagok);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 7);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(891, 423);
            this.panel_Bottom.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 430);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_Bottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Befizetések";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Tagok.ResumeLayout(false);
            this.groupBox_Tagok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzuletesiEv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Iranyitoszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tagok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Befizetesek)).EndInit();
            this.groupBox_Befizetesek.ResumeLayout(false);
            this.panel_tagok.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Tagok;
        private System.Windows.Forms.DataGridView dataGridView_Tagok;
        private System.Windows.Forms.DataGridView dataGridView_Befizetesek;
        private System.Windows.Forms.GroupBox groupBox_Befizetesek;
        private System.Windows.Forms.Panel panel_tagok;
        private System.Windows.Forms.NumericUpDown numericUpDown_SzuletesiEv;
        private System.Windows.Forms.NumericUpDown numericUpDown_Iranyitoszam;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Button button_Tag_Delete;
        private System.Windows.Forms.Button button_Tag_Update;
        private System.Windows.Forms.Button button_Tag_Insert;
        private System.Windows.Forms.ToolStripMenuItem felvételToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_Orszag;
    }
}

