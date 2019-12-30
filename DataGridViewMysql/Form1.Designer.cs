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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Tagok = new System.Windows.Forms.DataGridView();
            this.dataGridView_Befizetesek = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.comboBox_Orszag = new System.Windows.Forms.ComboBox();
            this.numericUpDown_Iranyitoszam = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SzuletesiEv = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tagok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Befizetesek)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Iranyitoszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzuletesiEv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_SzuletesiEv);
            this.groupBox1.Controls.Add(this.numericUpDown_Iranyitoszam);
            this.groupBox1.Controls.Add(this.comboBox_Orszag);
            this.groupBox1.Controls.Add(this.textBox_Nev);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tag adatai";
            // 
            // dataGridView_Tagok
            // 
            this.dataGridView_Tagok.AllowUserToAddRows = false;
            this.dataGridView_Tagok.AllowUserToDeleteRows = false;
            this.dataGridView_Tagok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tagok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Tagok.Location = new System.Drawing.Point(0, 124);
            this.dataGridView_Tagok.Name = "dataGridView_Tagok";
            this.dataGridView_Tagok.ReadOnly = true;
            this.dataGridView_Tagok.Size = new System.Drawing.Size(586, 326);
            this.dataGridView_Tagok.TabIndex = 1;
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
            this.dataGridView_Befizetesek.Size = new System.Drawing.Size(194, 431);
            this.dataGridView_Befizetesek.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_Befizetesek);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(600, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 450);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A tag befizetései";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_Tagok);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 450);
            this.panel1.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ország";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Születési év";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(14, 57);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(237, 20);
            this.textBox_Nev.TabIndex = 4;
            // 
            // comboBox_Orszag
            // 
            this.comboBox_Orszag.FormattingEnabled = true;
            this.comboBox_Orszag.Location = new System.Drawing.Point(282, 56);
            this.comboBox_Orszag.Name = "comboBox_Orszag";
            this.comboBox_Orszag.Size = new System.Drawing.Size(59, 21);
            this.comboBox_Orszag.TabIndex = 5;
            // 
            // numericUpDown_Iranyitoszam
            // 
            this.numericUpDown_Iranyitoszam.Location = new System.Drawing.Point(376, 57);
            this.numericUpDown_Iranyitoszam.Name = "numericUpDown_Iranyitoszam";
            this.numericUpDown_Iranyitoszam.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown_Iranyitoszam.TabIndex = 6;
            // 
            // numericUpDown_SzuletesiEv
            // 
            this.numericUpDown_SzuletesiEv.Location = new System.Drawing.Point(493, 57);
            this.numericUpDown_SzuletesiEv.Name = "numericUpDown_SzuletesiEv";
            this.numericUpDown_SzuletesiEv.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown_SzuletesiEv.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Befizetések";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tagok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Befizetesek)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Iranyitoszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzuletesiEv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_Tagok;
        private System.Windows.Forms.DataGridView dataGridView_Befizetesek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown_SzuletesiEv;
        private System.Windows.Forms.NumericUpDown numericUpDown_Iranyitoszam;
        private System.Windows.Forms.ComboBox comboBox_Orszag;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

