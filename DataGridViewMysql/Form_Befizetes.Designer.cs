namespace DataGridViewMysql
{
    partial class Form_Befizetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Befizetes));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Tag_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Tag_neve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Befizetes_napja = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tag azonosítója:";
            // 
            // textBox_Tag_id
            // 
            this.textBox_Tag_id.Location = new System.Drawing.Point(152, 35);
            this.textBox_Tag_id.Name = "textBox_Tag_id";
            this.textBox_Tag_id.ReadOnly = true;
            this.textBox_Tag_id.Size = new System.Drawing.Size(195, 20);
            this.textBox_Tag_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tag neve:";
            // 
            // textBox_Tag_neve
            // 
            this.textBox_Tag_neve.Location = new System.Drawing.Point(152, 73);
            this.textBox_Tag_neve.Name = "textBox_Tag_neve";
            this.textBox_Tag_neve.ReadOnly = true;
            this.textBox_Tag_neve.Size = new System.Drawing.Size(195, 20);
            this.textBox_Tag_neve.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Befizetés napja:";
            // 
            // textBox_Befizetes_napja
            // 
            this.textBox_Befizetes_napja.Location = new System.Drawing.Point(152, 113);
            this.textBox_Befizetes_napja.Name = "textBox_Befizetes_napja";
            this.textBox_Befizetes_napja.ReadOnly = true;
            this.textBox_Befizetes_napja.Size = new System.Drawing.Size(195, 20);
            this.textBox_Befizetes_napja.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(152, 162);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Befizetett összeg:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Befizet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ft";
            // 
            // Form_Befizetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 292);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox_Befizetes_napja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Tag_neve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Tag_id);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Befizetes";
            this.Text = "Tagdíj befizetés";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Befizetes_FormClosed);
            this.Load += new System.EventHandler(this.Form_Befizetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Tag_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Tag_neve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Befizetes_napja;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}