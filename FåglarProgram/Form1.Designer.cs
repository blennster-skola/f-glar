namespace FåglarProgram
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.tbxNyFågel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Fåglar = new System.Windows.Forms.GroupBox();
            this.btnVisaFåglar = new System.Windows.Forms.Button();
            this.lbxFåglar = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.Fåglar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxNyFågel);
            this.groupBox1.Controls.Add(this.btnLäggTill);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ny fågel";
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(9, 87);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(75, 23);
            this.btnLäggTill.TabIndex = 0;
            this.btnLäggTill.Text = "Lägg Till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            this.btnLäggTill.Click += new System.EventHandler(this.btnLäggTill_Click);
            // 
            // tbxNyFågel
            // 
            this.tbxNyFågel.Location = new System.Drawing.Point(47, 35);
            this.tbxNyFågel.Name = "tbxNyFågel";
            this.tbxNyFågel.Size = new System.Drawing.Size(207, 20);
            this.tbxNyFågel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Namn:";
            // 
            // Fåglar
            // 
            this.Fåglar.Controls.Add(this.lbxFåglar);
            this.Fåglar.Controls.Add(this.btnVisaFåglar);
            this.Fåglar.Location = new System.Drawing.Point(12, 155);
            this.Fåglar.Name = "Fåglar";
            this.Fåglar.Size = new System.Drawing.Size(260, 179);
            this.Fåglar.TabIndex = 1;
            this.Fåglar.TabStop = false;
            this.Fåglar.Text = "Fåglar";
            // 
            // btnVisaFåglar
            // 
            this.btnVisaFåglar.Location = new System.Drawing.Point(6, 146);
            this.btnVisaFåglar.Name = "btnVisaFåglar";
            this.btnVisaFåglar.Size = new System.Drawing.Size(75, 23);
            this.btnVisaFåglar.TabIndex = 0;
            this.btnVisaFåglar.Text = "Visa Fåglar";
            this.btnVisaFåglar.UseVisualStyleBackColor = true;
            this.btnVisaFåglar.Click += new System.EventHandler(this.btnVisaFåglar_Click);
            // 
            // lbxFåglar
            // 
            this.lbxFåglar.FormattingEnabled = true;
            this.lbxFåglar.Location = new System.Drawing.Point(6, 19);
            this.lbxFåglar.Name = "lbxFåglar";
            this.lbxFåglar.Size = new System.Drawing.Size(248, 121);
            this.lbxFåglar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 346);
            this.Controls.Add(this.Fåglar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Fåglar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNyFågel;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.GroupBox Fåglar;
        private System.Windows.Forms.ListBox lbxFåglar;
        private System.Windows.Forms.Button btnVisaFåglar;
    }
}

