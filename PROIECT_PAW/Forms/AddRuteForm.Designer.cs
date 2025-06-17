namespace PROIECT_PAW.Forms
{
    partial class AddRuteForm
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
            this.labelAddRutaCodTraseu = new System.Windows.Forms.Label();
            this.textBoxAddCodTraseu = new System.Windows.Forms.TextBox();
            this.labelAddRutePlecare = new System.Windows.Forms.Label();
            this.textBoxAddRutaPlecare = new System.Windows.Forms.TextBox();
            this.labelAddFormDestinatie = new System.Windows.Forms.Label();
            this.textBoxAddRutaDestinatie = new System.Windows.Forms.TextBox();
            this.labelAddRutaDistanta = new System.Windows.Forms.Label();
            this.butonSaveAddRuta = new System.Windows.Forms.Button();
            this.butonCancelAddRuta = new System.Windows.Forms.Button();
            this.numericAddDistanta = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMasini = new System.Windows.Forms.ComboBox();
            this.comboBoxSoferi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddDistanta)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddRutaCodTraseu
            // 
            this.labelAddRutaCodTraseu.AutoSize = true;
            this.labelAddRutaCodTraseu.Location = new System.Drawing.Point(17, 20);
            this.labelAddRutaCodTraseu.Name = "labelAddRutaCodTraseu";
            this.labelAddRutaCodTraseu.Size = new System.Drawing.Size(62, 13);
            this.labelAddRutaCodTraseu.TabIndex = 0;
            this.labelAddRutaCodTraseu.Text = "Cod Traseu";
            // 
            // textBoxAddCodTraseu
            // 
            this.textBoxAddCodTraseu.Location = new System.Drawing.Point(91, 20);
            this.textBoxAddCodTraseu.Name = "textBoxAddCodTraseu";
            this.textBoxAddCodTraseu.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddCodTraseu.TabIndex = 1;
            // 
            // labelAddRutePlecare
            // 
            this.labelAddRutePlecare.AutoSize = true;
            this.labelAddRutePlecare.Location = new System.Drawing.Point(33, 47);
            this.labelAddRutePlecare.Name = "labelAddRutePlecare";
            this.labelAddRutePlecare.Size = new System.Drawing.Size(43, 13);
            this.labelAddRutePlecare.TabIndex = 2;
            this.labelAddRutePlecare.Text = "Plecare";
            // 
            // textBoxAddRutaPlecare
            // 
            this.textBoxAddRutaPlecare.Location = new System.Drawing.Point(91, 47);
            this.textBoxAddRutaPlecare.Name = "textBoxAddRutaPlecare";
            this.textBoxAddRutaPlecare.Size = new System.Drawing.Size(303, 20);
            this.textBoxAddRutaPlecare.TabIndex = 3;
            // 
            // labelAddFormDestinatie
            // 
            this.labelAddFormDestinatie.AutoSize = true;
            this.labelAddFormDestinatie.Location = new System.Drawing.Point(25, 72);
            this.labelAddFormDestinatie.Name = "labelAddFormDestinatie";
            this.labelAddFormDestinatie.Size = new System.Drawing.Size(54, 13);
            this.labelAddFormDestinatie.TabIndex = 4;
            this.labelAddFormDestinatie.Text = "Destinatie";
            // 
            // textBoxAddRutaDestinatie
            // 
            this.textBoxAddRutaDestinatie.Location = new System.Drawing.Point(91, 73);
            this.textBoxAddRutaDestinatie.Name = "textBoxAddRutaDestinatie";
            this.textBoxAddRutaDestinatie.Size = new System.Drawing.Size(303, 20);
            this.textBoxAddRutaDestinatie.TabIndex = 5;
            // 
            // labelAddRutaDistanta
            // 
            this.labelAddRutaDistanta.AutoSize = true;
            this.labelAddRutaDistanta.Location = new System.Drawing.Point(15, 105);
            this.labelAddRutaDistanta.Name = "labelAddRutaDistanta";
            this.labelAddRutaDistanta.Size = new System.Drawing.Size(70, 13);
            this.labelAddRutaDistanta.TabIndex = 6;
            this.labelAddRutaDistanta.Text = "DIstanța (km)";
            // 
            // butonSaveAddRuta
            // 
            this.butonSaveAddRuta.Location = new System.Drawing.Point(12, 202);
            this.butonSaveAddRuta.Name = "butonSaveAddRuta";
            this.butonSaveAddRuta.Size = new System.Drawing.Size(105, 49);
            this.butonSaveAddRuta.TabIndex = 8;
            this.butonSaveAddRuta.Text = "Salvare";
            this.butonSaveAddRuta.UseVisualStyleBackColor = true;
            this.butonSaveAddRuta.Click += new System.EventHandler(this.butonSaveAddRuta_Click);
            // 
            // butonCancelAddRuta
            // 
            this.butonCancelAddRuta.Location = new System.Drawing.Point(290, 202);
            this.butonCancelAddRuta.Name = "butonCancelAddRuta";
            this.butonCancelAddRuta.Size = new System.Drawing.Size(105, 49);
            this.butonCancelAddRuta.TabIndex = 9;
            this.butonCancelAddRuta.Text = "Anulare";
            this.butonCancelAddRuta.UseVisualStyleBackColor = true;
            this.butonCancelAddRuta.Click += new System.EventHandler(this.butonCancelAddRuta_Click);
            // 
            // numericAddDistanta
            // 
            this.numericAddDistanta.Location = new System.Drawing.Point(91, 99);
            this.numericAddDistanta.Name = "numericAddDistanta";
            this.numericAddDistanta.Size = new System.Drawing.Size(120, 20);
            this.numericAddDistanta.TabIndex = 10;
            // 
            // comboBoxMasini
            // 
            this.comboBoxMasini.FormattingEnabled = true;
            this.comboBoxMasini.Location = new System.Drawing.Point(91, 125);
            this.comboBoxMasini.Name = "comboBoxMasini";
            this.comboBoxMasini.Size = new System.Drawing.Size(304, 21);
            this.comboBoxMasini.TabIndex = 11;
            // 
            // comboBoxSoferi
            // 
            this.comboBoxSoferi.FormattingEnabled = true;
            this.comboBoxSoferi.Location = new System.Drawing.Point(91, 152);
            this.comboBoxSoferi.Name = "comboBoxSoferi";
            this.comboBoxSoferi.Size = new System.Drawing.Size(304, 21);
            this.comboBoxSoferi.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Masina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sofer";
            // 
            // AddRuteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 266);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSoferi);
            this.Controls.Add(this.comboBoxMasini);
            this.Controls.Add(this.numericAddDistanta);
            this.Controls.Add(this.butonCancelAddRuta);
            this.Controls.Add(this.butonSaveAddRuta);
            this.Controls.Add(this.labelAddRutaDistanta);
            this.Controls.Add(this.textBoxAddRutaDestinatie);
            this.Controls.Add(this.labelAddFormDestinatie);
            this.Controls.Add(this.textBoxAddRutaPlecare);
            this.Controls.Add(this.labelAddRutePlecare);
            this.Controls.Add(this.textBoxAddCodTraseu);
            this.Controls.Add(this.labelAddRutaCodTraseu);
            this.Name = "AddRuteForm";
            this.Text = "Adaugă o rută";
            ((System.ComponentModel.ISupportInitialize)(this.numericAddDistanta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddRutaCodTraseu;
        private System.Windows.Forms.TextBox textBoxAddCodTraseu;
        private System.Windows.Forms.Label labelAddRutePlecare;
        private System.Windows.Forms.TextBox textBoxAddRutaPlecare;
        private System.Windows.Forms.Label labelAddFormDestinatie;
        private System.Windows.Forms.TextBox textBoxAddRutaDestinatie;
        private System.Windows.Forms.Label labelAddRutaDistanta;
        private System.Windows.Forms.Button butonSaveAddRuta;
        private System.Windows.Forms.Button butonCancelAddRuta;
        private System.Windows.Forms.NumericUpDown numericAddDistanta;
        private System.Windows.Forms.ComboBox comboBoxMasini;
        private System.Windows.Forms.ComboBox comboBoxSoferi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}