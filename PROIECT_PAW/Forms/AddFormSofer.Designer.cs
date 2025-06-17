namespace PROIECT_PAW.Forms
{
    partial class AddFormSofer
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
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelSalariul = new System.Windows.Forms.Label();
            this.labelDataAng = new System.Windows.Forms.Label();
            this.butonSaveAddSofer = new System.Windows.Forms.Button();
            this.butonCancelAddSofer = new System.Windows.Forms.Button();
            this.textBoxAddNume = new System.Windows.Forms.TextBox();
            this.textBoxAddPrenume = new System.Windows.Forms.TextBox();
            this.numericSalariul = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerAng = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalariul)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(49, 26);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(35, 13);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(35, 52);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(49, 13);
            this.labelPrenume.TabIndex = 1;
            this.labelPrenume.Text = "Prenume";
            // 
            // labelSalariul
            // 
            this.labelSalariul.AutoSize = true;
            this.labelSalariul.Location = new System.Drawing.Point(43, 77);
            this.labelSalariul.Name = "labelSalariul";
            this.labelSalariul.Size = new System.Drawing.Size(41, 13);
            this.labelSalariul.TabIndex = 2;
            this.labelSalariul.Text = "Salariul";
            // 
            // labelDataAng
            // 
            this.labelDataAng.AutoSize = true;
            this.labelDataAng.Location = new System.Drawing.Point(12, 101);
            this.labelDataAng.Name = "labelDataAng";
            this.labelDataAng.Size = new System.Drawing.Size(72, 13);
            this.labelDataAng.TabIndex = 3;
            this.labelDataAng.Text = "Data angajării";
            // 
            // butonSaveAddSofer
            // 
            this.butonSaveAddSofer.Location = new System.Drawing.Point(52, 140);
            this.butonSaveAddSofer.Name = "butonSaveAddSofer";
            this.butonSaveAddSofer.Size = new System.Drawing.Size(105, 49);
            this.butonSaveAddSofer.TabIndex = 9;
            this.butonSaveAddSofer.Text = "Salvare";
            this.butonSaveAddSofer.UseVisualStyleBackColor = true;
            this.butonSaveAddSofer.Click += new System.EventHandler(this.butonSaveAddSofer_Click);
            // 
            // butonCancelAddSofer
            // 
            this.butonCancelAddSofer.Location = new System.Drawing.Point(213, 140);
            this.butonCancelAddSofer.Name = "butonCancelAddSofer";
            this.butonCancelAddSofer.Size = new System.Drawing.Size(105, 49);
            this.butonCancelAddSofer.TabIndex = 10;
            this.butonCancelAddSofer.Text = "Anulare";
            this.butonCancelAddSofer.UseVisualStyleBackColor = true;
            this.butonCancelAddSofer.Click += new System.EventHandler(this.butonCancelAddSofer_Click);
            // 
            // textBoxAddNume
            // 
            this.textBoxAddNume.Location = new System.Drawing.Point(99, 19);
            this.textBoxAddNume.Name = "textBoxAddNume";
            this.textBoxAddNume.Size = new System.Drawing.Size(229, 20);
            this.textBoxAddNume.TabIndex = 11;
            // 
            // textBoxAddPrenume
            // 
            this.textBoxAddPrenume.Location = new System.Drawing.Point(99, 45);
            this.textBoxAddPrenume.Name = "textBoxAddPrenume";
            this.textBoxAddPrenume.Size = new System.Drawing.Size(229, 20);
            this.textBoxAddPrenume.TabIndex = 12;
            // 
            // numericSalariul
            // 
            this.numericSalariul.Location = new System.Drawing.Point(99, 75);
            this.numericSalariul.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericSalariul.Name = "numericSalariul";
            this.numericSalariul.Size = new System.Drawing.Size(120, 20);
            this.numericSalariul.TabIndex = 13;
            // 
            // dateTimePickerAng
            // 
            this.dateTimePickerAng.Location = new System.Drawing.Point(99, 101);
            this.dateTimePickerAng.Name = "dateTimePickerAng";
            this.dateTimePickerAng.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAng.TabIndex = 14;
            // 
            // AddFormSofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 215);
            this.Controls.Add(this.dateTimePickerAng);
            this.Controls.Add(this.numericSalariul);
            this.Controls.Add(this.textBoxAddPrenume);
            this.Controls.Add(this.textBoxAddNume);
            this.Controls.Add(this.butonCancelAddSofer);
            this.Controls.Add(this.butonSaveAddSofer);
            this.Controls.Add(this.labelDataAng);
            this.Controls.Add(this.labelSalariul);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelNume);
            this.Name = "AddFormSofer";
            this.Text = "Adaugă un șofer";
            ((System.ComponentModel.ISupportInitialize)(this.numericSalariul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.Label labelSalariul;
        private System.Windows.Forms.Label labelDataAng;
        private System.Windows.Forms.Button butonSaveAddSofer;
        private System.Windows.Forms.Button butonCancelAddSofer;
        private System.Windows.Forms.TextBox textBoxAddNume;
        private System.Windows.Forms.TextBox textBoxAddPrenume;
        private System.Windows.Forms.NumericUpDown numericSalariul;
        private System.Windows.Forms.DateTimePicker dateTimePickerAng;
    }
}