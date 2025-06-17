namespace PROIECT_PAW.Forms
{
    partial class EditRutaForm
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
            this.labelEditCodTraseu = new System.Windows.Forms.Label();
            this.labelEditPlecare = new System.Windows.Forms.Label();
            this.labelEditDestinatie = new System.Windows.Forms.Label();
            this.labelEditDistanta = new System.Windows.Forms.Label();
            this.textBoxEditCodTraseu = new System.Windows.Forms.TextBox();
            this.textBoxEditPlecare = new System.Windows.Forms.TextBox();
            this.textBoxEditDestinatie = new System.Windows.Forms.TextBox();
            this.numericEditDistanta = new System.Windows.Forms.NumericUpDown();
            this.butonSaveEditRuta = new System.Windows.Forms.Button();
            this.butonCancelEditRuta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMasini = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSoferi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditDistanta)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEditCodTraseu
            // 
            this.labelEditCodTraseu.AutoSize = true;
            this.labelEditCodTraseu.Location = new System.Drawing.Point(12, 24);
            this.labelEditCodTraseu.Name = "labelEditCodTraseu";
            this.labelEditCodTraseu.Size = new System.Drawing.Size(62, 13);
            this.labelEditCodTraseu.TabIndex = 0;
            this.labelEditCodTraseu.Text = "Cod Traseu";
            // 
            // labelEditPlecare
            // 
            this.labelEditPlecare.AutoSize = true;
            this.labelEditPlecare.Location = new System.Drawing.Point(31, 54);
            this.labelEditPlecare.Name = "labelEditPlecare";
            this.labelEditPlecare.Size = new System.Drawing.Size(43, 13);
            this.labelEditPlecare.TabIndex = 1;
            this.labelEditPlecare.Text = "Plecare";
            // 
            // labelEditDestinatie
            // 
            this.labelEditDestinatie.AutoSize = true;
            this.labelEditDestinatie.Location = new System.Drawing.Point(20, 85);
            this.labelEditDestinatie.Name = "labelEditDestinatie";
            this.labelEditDestinatie.Size = new System.Drawing.Size(54, 13);
            this.labelEditDestinatie.TabIndex = 2;
            this.labelEditDestinatie.Text = "Destinație";
            // 
            // labelEditDistanta
            // 
            this.labelEditDistanta.AutoSize = true;
            this.labelEditDistanta.Location = new System.Drawing.Point(12, 111);
            this.labelEditDistanta.Name = "labelEditDistanta";
            this.labelEditDistanta.Size = new System.Drawing.Size(69, 13);
            this.labelEditDistanta.TabIndex = 3;
            this.labelEditDistanta.Text = "Distanța (km)";
            // 
            // textBoxEditCodTraseu
            // 
            this.textBoxEditCodTraseu.Location = new System.Drawing.Point(97, 21);
            this.textBoxEditCodTraseu.Name = "textBoxEditCodTraseu";
            this.textBoxEditCodTraseu.Size = new System.Drawing.Size(100, 20);
            this.textBoxEditCodTraseu.TabIndex = 4;
            // 
            // textBoxEditPlecare
            // 
            this.textBoxEditPlecare.Location = new System.Drawing.Point(97, 51);
            this.textBoxEditPlecare.Name = "textBoxEditPlecare";
            this.textBoxEditPlecare.Size = new System.Drawing.Size(305, 20);
            this.textBoxEditPlecare.TabIndex = 5;
            // 
            // textBoxEditDestinatie
            // 
            this.textBoxEditDestinatie.Location = new System.Drawing.Point(98, 78);
            this.textBoxEditDestinatie.Name = "textBoxEditDestinatie";
            this.textBoxEditDestinatie.Size = new System.Drawing.Size(304, 20);
            this.textBoxEditDestinatie.TabIndex = 6;
            // 
            // numericEditDistanta
            // 
            this.numericEditDistanta.Location = new System.Drawing.Point(98, 104);
            this.numericEditDistanta.Name = "numericEditDistanta";
            this.numericEditDistanta.Size = new System.Drawing.Size(120, 20);
            this.numericEditDistanta.TabIndex = 7;
            // 
            // butonSaveEditRuta
            // 
            this.butonSaveEditRuta.Location = new System.Drawing.Point(15, 203);
            this.butonSaveEditRuta.Name = "butonSaveEditRuta";
            this.butonSaveEditRuta.Size = new System.Drawing.Size(112, 56);
            this.butonSaveEditRuta.TabIndex = 8;
            this.butonSaveEditRuta.Text = "Salvare";
            this.butonSaveEditRuta.UseVisualStyleBackColor = true;
            this.butonSaveEditRuta.Click += new System.EventHandler(this.butonSaveEditRuta_Click);
            // 
            // butonCancelEditRuta
            // 
            this.butonCancelEditRuta.Location = new System.Drawing.Point(287, 203);
            this.butonCancelEditRuta.Name = "butonCancelEditRuta";
            this.butonCancelEditRuta.Size = new System.Drawing.Size(115, 56);
            this.butonCancelEditRuta.TabIndex = 9;
            this.butonCancelEditRuta.Text = "Anulare";
            this.butonCancelEditRuta.UseVisualStyleBackColor = true;
            this.butonCancelEditRuta.Click += new System.EventHandler(this.butonCancelEditRuta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Masina";
            // 
            // comboBoxMasini
            // 
            this.comboBoxMasini.FormattingEnabled = true;
            this.comboBoxMasini.Location = new System.Drawing.Point(97, 132);
            this.comboBoxMasini.Name = "comboBoxMasini";
            this.comboBoxMasini.Size = new System.Drawing.Size(304, 21);
            this.comboBoxMasini.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sofer";
            // 
            // comboBoxSoferi
            // 
            this.comboBoxSoferi.FormattingEnabled = true;
            this.comboBoxSoferi.Location = new System.Drawing.Point(98, 165);
            this.comboBoxSoferi.Name = "comboBoxSoferi";
            this.comboBoxSoferi.Size = new System.Drawing.Size(304, 21);
            this.comboBoxSoferi.TabIndex = 17;
            // 
            // EditRutaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 271);
            this.Controls.Add(this.comboBoxSoferi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMasini);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butonCancelEditRuta);
            this.Controls.Add(this.butonSaveEditRuta);
            this.Controls.Add(this.numericEditDistanta);
            this.Controls.Add(this.textBoxEditDestinatie);
            this.Controls.Add(this.textBoxEditPlecare);
            this.Controls.Add(this.textBoxEditCodTraseu);
            this.Controls.Add(this.labelEditDistanta);
            this.Controls.Add(this.labelEditDestinatie);
            this.Controls.Add(this.labelEditPlecare);
            this.Controls.Add(this.labelEditCodTraseu);
            this.Name = "EditRutaForm";
            this.Text = "Editează o rută";
            ((System.ComponentModel.ISupportInitialize)(this.numericEditDistanta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditCodTraseu;
        private System.Windows.Forms.Label labelEditPlecare;
        private System.Windows.Forms.Label labelEditDestinatie;
        private System.Windows.Forms.Label labelEditDistanta;
        private System.Windows.Forms.TextBox textBoxEditCodTraseu;
        private System.Windows.Forms.TextBox textBoxEditPlecare;
        private System.Windows.Forms.TextBox textBoxEditDestinatie;
        private System.Windows.Forms.NumericUpDown numericEditDistanta;
        private System.Windows.Forms.Button butonSaveEditRuta;
        private System.Windows.Forms.Button butonCancelEditRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMasini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSoferi;
    }
}