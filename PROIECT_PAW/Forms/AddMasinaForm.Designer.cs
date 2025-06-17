namespace PROIECT_PAW.Forms
{
    partial class AddMasinaForm
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
            this.labelNrInamtriculare = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelAnFabr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddNrInmatr = new System.Windows.Forms.TextBox();
            this.textBoxAddMarca = new System.Windows.Forms.TextBox();
            this.numericAddAnFabr = new System.Windows.Forms.NumericUpDown();
            this.numericAddCapacitate = new System.Windows.Forms.NumericUpDown();
            this.butonSaveAddMasina = new System.Windows.Forms.Button();
            this.butonCancelAddMasina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddAnFabr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddCapacitate)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNrInamtriculare
            // 
            this.labelNrInamtriculare.AutoSize = true;
            this.labelNrInamtriculare.Location = new System.Drawing.Point(12, 18);
            this.labelNrInamtriculare.Name = "labelNrInamtriculare";
            this.labelNrInamtriculare.Size = new System.Drawing.Size(117, 13);
            this.labelNrInamtriculare.TabIndex = 0;
            this.labelNrInamtriculare.Text = "Număr de înmatriculare";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(92, 47);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 1;
            this.labelMarca.Text = "Marca";
            // 
            // labelAnFabr
            // 
            this.labelAnFabr.AutoSize = true;
            this.labelAnFabr.Location = new System.Drawing.Point(62, 74);
            this.labelAnFabr.Name = "labelAnFabr";
            this.labelAnFabr.Size = new System.Drawing.Size(69, 13);
            this.labelAnFabr.TabIndex = 2;
            this.labelAnFabr.Text = "An Fabricație";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Capacitate";
            // 
            // textBoxAddNrInmatr
            // 
            this.textBoxAddNrInmatr.Location = new System.Drawing.Point(135, 18);
            this.textBoxAddNrInmatr.MaxLength = 9;
            this.textBoxAddNrInmatr.Name = "textBoxAddNrInmatr";
            this.textBoxAddNrInmatr.Size = new System.Drawing.Size(199, 20);
            this.textBoxAddNrInmatr.TabIndex = 4;
            // 
            // textBoxAddMarca
            // 
            this.textBoxAddMarca.Location = new System.Drawing.Point(135, 44);
            this.textBoxAddMarca.Name = "textBoxAddMarca";
            this.textBoxAddMarca.Size = new System.Drawing.Size(199, 20);
            this.textBoxAddMarca.TabIndex = 5;
            // 
            // numericAddAnFabr
            // 
            this.numericAddAnFabr.Location = new System.Drawing.Point(135, 72);
            this.numericAddAnFabr.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numericAddAnFabr.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericAddAnFabr.Name = "numericAddAnFabr";
            this.numericAddAnFabr.Size = new System.Drawing.Size(120, 20);
            this.numericAddAnFabr.TabIndex = 6;
            this.numericAddAnFabr.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numericAddCapacitate
            // 
            this.numericAddCapacitate.Location = new System.Drawing.Point(135, 102);
            this.numericAddCapacitate.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericAddCapacitate.Name = "numericAddCapacitate";
            this.numericAddCapacitate.Size = new System.Drawing.Size(120, 20);
            this.numericAddCapacitate.TabIndex = 7;
            // 
            // butonSaveAddMasina
            // 
            this.butonSaveAddMasina.Location = new System.Drawing.Point(65, 142);
            this.butonSaveAddMasina.Name = "butonSaveAddMasina";
            this.butonSaveAddMasina.Size = new System.Drawing.Size(93, 45);
            this.butonSaveAddMasina.TabIndex = 8;
            this.butonSaveAddMasina.Text = "Salvare";
            this.butonSaveAddMasina.UseVisualStyleBackColor = true;
            this.butonSaveAddMasina.Click += new System.EventHandler(this.butonSaveAddMasina_Click);
            // 
            // butonCancelAddMasina
            // 
            this.butonCancelAddMasina.Location = new System.Drawing.Point(221, 142);
            this.butonCancelAddMasina.Name = "butonCancelAddMasina";
            this.butonCancelAddMasina.Size = new System.Drawing.Size(93, 45);
            this.butonCancelAddMasina.TabIndex = 9;
            this.butonCancelAddMasina.Text = "Anulare";
            this.butonCancelAddMasina.UseVisualStyleBackColor = true;
            this.butonCancelAddMasina.Click += new System.EventHandler(this.butonCancelAddMasina_Click);
            // 
            // AddMasinaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 199);
            this.Controls.Add(this.butonCancelAddMasina);
            this.Controls.Add(this.butonSaveAddMasina);
            this.Controls.Add(this.numericAddCapacitate);
            this.Controls.Add(this.numericAddAnFabr);
            this.Controls.Add(this.textBoxAddMarca);
            this.Controls.Add(this.textBoxAddNrInmatr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAnFabr);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelNrInamtriculare);
            this.Name = "AddMasinaForm";
            this.Text = "Adaugă o mașină";
            ((System.ComponentModel.ISupportInitialize)(this.numericAddAnFabr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddCapacitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNrInamtriculare;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelAnFabr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddNrInmatr;
        private System.Windows.Forms.TextBox textBoxAddMarca;
        private System.Windows.Forms.NumericUpDown numericAddAnFabr;
        private System.Windows.Forms.NumericUpDown numericAddCapacitate;
        private System.Windows.Forms.Button butonSaveAddMasina;
        private System.Windows.Forms.Button butonCancelAddMasina;
    }
}