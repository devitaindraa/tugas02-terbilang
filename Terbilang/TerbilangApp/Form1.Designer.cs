namespace TerbilangApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.lstTerbilang = new System.Windows.Forms.ListBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Terbilang";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNominal
            // 
            this.txtNominal.Location = new System.Drawing.Point(111, 74);
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.Size = new System.Drawing.Size(347, 26);
            this.txtNominal.TabIndex = 2;
            // 
            // lstTerbilang
            // 
            this.lstTerbilang.FormattingEnabled = true;
            this.lstTerbilang.ItemHeight = 20;
            this.lstTerbilang.Location = new System.Drawing.Point(111, 130);
            this.lstTerbilang.Name = "lstTerbilang";
            this.lstTerbilang.Size = new System.Drawing.Size(523, 64);
            this.lstTerbilang.TabIndex = 3;
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(505, 74);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(129, 36);
            this.btnCek.TabIndex = 4;
            this.btnCek.Text = "Cek Terbilang";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 213);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.lstTerbilang);
            this.Controls.Add(this.txtNominal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNominal;
        private System.Windows.Forms.ListBox lstTerbilang;
        private System.Windows.Forms.Button btnCek;
    }
}

