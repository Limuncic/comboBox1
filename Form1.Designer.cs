namespace comboBox1
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
            this.cbDorucak = new System.Windows.Forms.CheckBox();
            this.cbRucak = new System.Windows.Forms.CheckBox();
            this.cbVecera = new System.Windows.Forms.CheckBox();
            this.cbSakriji = new System.Windows.Forms.CheckBox();
            this.tb = new System.Windows.Forms.TextBox();
            this.btPos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDorucak
            // 
            this.cbDorucak.AutoSize = true;
            this.cbDorucak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDorucak.Location = new System.Drawing.Point(144, 110);
            this.cbDorucak.Name = "cbDorucak";
            this.cbDorucak.Size = new System.Drawing.Size(99, 28);
            this.cbDorucak.TabIndex = 0;
            this.cbDorucak.Text = "Dorucak";
            this.cbDorucak.UseVisualStyleBackColor = true;
            this.cbDorucak.CheckedChanged += new System.EventHandler(this.cbDorucak_CheckedChanged);
            // 
            // cbRucak
            // 
            this.cbRucak.AutoSize = true;
            this.cbRucak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbRucak.Location = new System.Drawing.Point(144, 132);
            this.cbRucak.Name = "cbRucak";
            this.cbRucak.Size = new System.Drawing.Size(82, 28);
            this.cbRucak.TabIndex = 1;
            this.cbRucak.Text = "Rucak";
            this.cbRucak.UseVisualStyleBackColor = true;
            this.cbRucak.CheckedChanged += new System.EventHandler(this.cbRucak_CheckedChanged);
            // 
            // cbVecera
            // 
            this.cbVecera.AutoSize = true;
            this.cbVecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbVecera.Location = new System.Drawing.Point(144, 155);
            this.cbVecera.Name = "cbVecera";
            this.cbVecera.Size = new System.Drawing.Size(90, 28);
            this.cbVecera.TabIndex = 2;
            this.cbVecera.Text = "Vecera";
            this.cbVecera.UseVisualStyleBackColor = true;
            this.cbVecera.CheckedChanged += new System.EventHandler(this.cbVecera_CheckedChanged);
            // 
            // cbSakriji
            // 
            this.cbSakriji.AutoSize = true;
            this.cbSakriji.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSakriji.Location = new System.Drawing.Point(284, 210);
            this.cbSakriji.Name = "cbSakriji";
            this.cbSakriji.Size = new System.Drawing.Size(78, 28);
            this.cbSakriji.TabIndex = 3;
            this.cbSakriji.Text = "Sakriji";
            this.cbSakriji.UseVisualStyleBackColor = true;
            this.cbSakriji.CheckedChanged += new System.EventHandler(this.cbSakriji_CheckedChanged);
            // 
            // tb
            // 
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb.Location = new System.Drawing.Point(284, 91);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(106, 92);
            this.tb.TabIndex = 4;
            // 
            // btPos
            // 
            this.btPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btPos.Location = new System.Drawing.Point(144, 206);
            this.btPos.Name = "btPos";
            this.btPos.Size = new System.Drawing.Size(90, 34);
            this.btPos.TabIndex = 5;
            this.btPos.Text = "Pošalji";
            this.btPos.UseVisualStyleBackColor = true;
            this.btPos.Click += new System.EventHandler(this.btPos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 562);
            this.Controls.Add(this.btPos);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.cbSakriji);
            this.Controls.Add(this.cbVecera);
            this.Controls.Add(this.cbRucak);
            this.Controls.Add(this.cbDorucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbDorucak;
        private System.Windows.Forms.CheckBox cbRucak;
        private System.Windows.Forms.CheckBox cbVecera;
        private System.Windows.Forms.CheckBox cbSakriji;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button btPos;
    }
}

