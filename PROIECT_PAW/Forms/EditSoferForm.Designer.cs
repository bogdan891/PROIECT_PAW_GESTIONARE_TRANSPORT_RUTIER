namespace PROIECT_PAW.Forms
{
    partial class EditSoferForm
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
            this.textBoxEditNume = new System.Windows.Forms.TextBox();
            this.textBoxEditPrenume = new System.Windows.Forms.TextBox();
            this.numericEditSalariul = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerEditAng = new System.Windows.Forms.DateTimePicker();
            this.butonSaveEditSofer = new System.Windows.Forms.Button();
            this.butonCancelEditSofer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditSalariul)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(48, 21);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(35, 13);
            this.labelNume.TabIndex = 1;
            this.labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Location = new System.Drawing.Point(35, 52);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(49, 13);
            this.labelPrenume.TabIndex = 2;
            this.labelPrenume.Text = "Prenume";
            // 
            // labelSalariul
            // 
            this.labelSalariul.AutoSize = true;
            this.labelSalariul.Location = new System.Drawing.Point(43, 79);
            this.labelSalariul.Name = "labelSalariul";
            this.labelSalariul.Size = new System.Drawing.Size(41, 13);
            this.labelSalariul.TabIndex = 3;
            this.labelSalariul.Text = "Salariul";
            // 
            // labelDataAng
            // 
            this.labelDataAng.AutoSize = true;
            this.labelDataAng.Location = new System.Drawing.Point(12, 107);
            this.labelDataAng.Name = "labelDataAng";
            this.labelDataAng.Size = new System.Drawing.Size(72, 13);
            this.labelDataAng.TabIndex = 4;
            this.labelDataAng.Text = "Data angajării";
            // 
            // textBoxEditNume
            // 
            this.textBoxEditNume.Location = new System.Drawing.Point(95, 18);
            this.textBoxEditNume.Name = "textBoxEditNume";
            this.textBoxEditNume.Size = new System.Drawing.Size(229, 20);
            this.textBoxEditNume.TabIndex = 12;
            // 
            // textBoxEditPrenume
            // 
            this.textBoxEditPrenume.Location = new System.Drawing.Point(95, 45);
            this.textBoxEditPrenume.Name = "textBoxEditPrenume";
            this.textBoxEditPrenume.Size = new System.Drawing.Size(229, 20);
            this.textBoxEditPrenume.TabIndex = 13;
            // 
            // numericEditSalariul
            // 
            this.numericEditSalariul.Location = new System.Drawing.Point(95, 77);
            this.numericEditSalariul.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericEditSalariul.Name = "numericEditSalariul";
            this.numericEditSalariul.Size = new System.Drawing.Size(120, 20);
            this.numericEditSalariul.TabIndex = 14;
            // 
            // dateTimePickerEditAng
            // 
            this.dateTimePickerEditAng.Location = new System.Drawing.Point(95, 105);
            this.dateTimePickerEditAng.Name = "dateTimePickerEditAng";
            this.dateTimePickerEditAng.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEditAng.TabIndex = 15;
            // 
            // butonSaveEditSofer
            // 
            this.butonSaveEditSofer.Location = new System.Drawing.Point(51, 156);
            this.butonSaveEditSofer.Name = "butonSaveEditSofer";
            this.butonSaveEditSofer.Size = new System.Drawing.Size(105, 49);
            this.butonSaveEditSofer.TabIndex = 16;
            this.butonSaveEditSofer.Text = "Salvare";
            this.butonSaveEditSofer.UseVisualStyleBackColor = true;
            this.butonSaveEditSofer.Click += new System.EventHandler(this.butonSaveEditSofer_Click);
            // 
            // butonCancelEditSofer
            // 
            this.butonCancelEditSofer.Location = new System.Drawing.Point(199, 156);
            this.butonCancelEditSofer.Name = "butonCancelEditSofer";
            this.butonCancelEditSofer.Size = new System.Drawing.Size(105, 49);
            this.butonCancelEditSofer.TabIndex = 17;
            this.butonCancelEditSofer.Text = "Anulare";
            this.butonCancelEditSofer.UseVisualStyleBackColor = true;
            this.butonCancelEditSofer.Click += new System.EventHandler(this.butonCancelEditSofer_Click);
            // 
            // EditSoferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 235);
            this.Controls.Add(this.butonCancelEditSofer);
            this.Controls.Add(this.butonSaveEditSofer);
            this.Controls.Add(this.dateTimePickerEditAng);
            this.Controls.Add(this.numericEditSalariul);
            this.Controls.Add(this.textBoxEditPrenume);
            this.Controls.Add(this.textBoxEditNume);
            this.Controls.Add(this.labelDataAng);
            this.Controls.Add(this.labelSalariul);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelNume);
            this.Name = "EditSoferForm";
            this.Text = "Editează un șofer";
            ((System.ComponentModel.ISupportInitialize)(this.numericEditSalariul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.Label labelSalariul;
        private System.Windows.Forms.Label labelDataAng;
        private System.Windows.Forms.TextBox textBoxEditNume;
        private System.Windows.Forms.TextBox textBoxEditPrenume;
        private System.Windows.Forms.NumericUpDown numericEditSalariul;
        private System.Windows.Forms.DateTimePicker dateTimePickerEditAng;
        private System.Windows.Forms.Button butonSaveEditSofer;
        private System.Windows.Forms.Button butonCancelEditSofer;
    }
}