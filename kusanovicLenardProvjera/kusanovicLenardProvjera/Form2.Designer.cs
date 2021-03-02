namespace kusanovicLenardProvjera
{
    partial class Form2
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
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.txtBoxOIB = new System.Windows.Forms.TextBox();
            this.txtBoxDatum = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblOIB = new System.Windows.Forms.Label();
            this.lblDatumRodenja = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Location = new System.Drawing.Point(365, 31);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(247, 20);
            this.txtBoxIme.TabIndex = 0;
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Location = new System.Drawing.Point(365, 103);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(247, 20);
            this.txtBoxPrezime.TabIndex = 1;
            // 
            // txtBoxOIB
            // 
            this.txtBoxOIB.Location = new System.Drawing.Point(365, 179);
            this.txtBoxOIB.Name = "txtBoxOIB";
            this.txtBoxOIB.Size = new System.Drawing.Size(247, 20);
            this.txtBoxOIB.TabIndex = 2;
            this.txtBoxOIB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtBoxDatum
            // 
            this.txtBoxDatum.Location = new System.Drawing.Point(365, 253);
            this.txtBoxDatum.Name = "txtBoxDatum";
            this.txtBoxDatum.Size = new System.Drawing.Size(247, 20);
            this.txtBoxDatum.TabIndex = 3;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(150, 31);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 4;
            this.lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(150, 106);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 5;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Location = new System.Drawing.Point(150, 182);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(25, 13);
            this.lblOIB.TabIndex = 6;
            this.lblOIB.Text = "OIB";
            // 
            // lblDatumRodenja
            // 
            this.lblDatumRodenja.AutoSize = true;
            this.lblDatumRodenja.Location = new System.Drawing.Point(150, 256);
            this.lblDatumRodenja.Name = "lblDatumRodenja";
            this.lblDatumRodenja.Size = new System.Drawing.Size(82, 13);
            this.lblDatumRodenja.TabIndex = 7;
            this.lblDatumRodenja.Text = "Datum Rođenja";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(153, 345);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(537, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblDatumRodenja);
            this.Controls.Add(this.lblOIB);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtBoxDatum);
            this.Controls.Add(this.txtBoxOIB);
            this.Controls.Add(this.txtBoxPrezime);
            this.Controls.Add(this.txtBoxIme);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.TextBox txtBoxOIB;
        private System.Windows.Forms.TextBox txtBoxDatum;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.Label lblDatumRodenja;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}