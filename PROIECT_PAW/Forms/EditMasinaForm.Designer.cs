namespace PROIECT_PAW.Forms
{
    partial class EditMasinaForm
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
            this.labelEditNrinmatr = new System.Windows.Forms.Label();
            this.labelEditMarca = new System.Windows.Forms.Label();
            this.labelAnFabr = new System.Windows.Forms.Label();
            this.labelCapacitate = new System.Windows.Forms.Label();
            this.textBoxEditNrInmatr = new System.Windows.Forms.TextBox();
            this.textBoxEditMarca = new System.Windows.Forms.TextBox();
            this.numericEditAnFabr = new System.Windows.Forms.NumericUpDown();
            this.numericEditCapacitate = new System.Windows.Forms.NumericUpDown();
            this.butonSaveEditMasina = new System.Windows.Forms.Button();
            this.butonCancelEditMasina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditAnFabr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditCapacitate)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEditNrinmatr
            // 
            this.labelEditNrinmatr.AutoSize = true;
            this.labelEditNrinmatr.Location = new System.Drawing.Point(12, 24);
            this.labelEditNrinmatr.Name = "labelEditNrinmatr";
            this.labelEditNrinmatr.Size = new System.Drawing.Size(117, 13);
            this.labelEditNrinmatr.TabIndex = 0;
            this.labelEditNrinmatr.Text = "Număr de înmatriculare";
            // 
            // labelEditMarca
            // 
            this.labelEditMarca.AutoSize = true;
            this.labelEditMarca.Location = new System.Drawing.Point(92, 54);
            this.labelEditMarca.Name = "labelEditMarca";
            this.labelEditMarca.Size = new System.Drawing.Size(37, 13);
            this.labelEditMarca.TabIndex = 1;
            this.labelEditMarca.Text = "Marca";
            // 
            // labelAnFabr
            // 
            this.labelAnFabr.AutoSize = true;
            this.labelAnFabr.Location = new System.Drawing.Point(63, 85);
            this.labelAnFabr.Name = "labelAnFabr";
            this.labelAnFabr.Size = new System.Drawing.Size(66, 13);
            this.labelAnFabr.TabIndex = 2;
            this.labelAnFabr.Text = "An fabricație";
            // 
            // labelCapacitate
            // 
            this.labelCapacitate.AutoSize = true;
            this.labelCapacitate.Location = new System.Drawing.Point(71, 114);
            this.labelCapacitate.Name = "labelCapacitate";
            this.labelCapacitate.Size = new System.Drawing.Size(58, 13);
            this.labelCapacitate.TabIndex = 3;
            this.labelCapacitate.Text = "Capacitate";
            // 
            // textBoxEditNrInmatr
            // 
            this.textBoxEditNrInmatr.Location = new System.Drawing.Point(135, 24);
            this.textBoxEditNrInmatr.MaxLength = 9;
            this.textBoxEditNrInmatr.Name = "textBoxEditNrInmatr";
            this.textBoxEditNrInmatr.Size = new System.Drawing.Size(170, 20);
            this.textBoxEditNrInmatr.TabIndex = 4;
            // 
            // textBoxEditMarca
            // 
            this.textBoxEditMarca.Location = new System.Drawing.Point(135, 51);
            this.textBoxEditMarca.Name = "textBoxEditMarca";
            this.textBoxEditMarca.Size = new System.Drawing.Size(170, 20);
            this.textBoxEditMarca.TabIndex = 5;
            // 
            // numericEditAnFabr
            // 
            this.numericEditAnFabr.Location = new System.Drawing.Point(135, 78);
            this.numericEditAnFabr.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numericEditAnFabr.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericEditAnFabr.Name = "numericEditAnFabr";
            this.numericEditAnFabr.Size = new System.Drawing.Size(120, 20);
            this.numericEditAnFabr.TabIndex = 6;
            this.numericEditAnFabr.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numericEditCapacitate
            // 
            this.numericEditCapacitate.Location = new System.Drawing.Point(135, 112);
            this.numericEditCapacitate.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericEditCapacitate.Name = "numericEditCapacitate";
            this.numericEditCapacitate.Size = new System.Drawing.Size(120, 20);
            this.numericEditCapacitate.TabIndex = 7;
            // 
            // butonSaveEditMasina
            // 
            this.butonSaveEditMasina.Location = new System.Drawing.Point(54, 157);
            this.butonSaveEditMasina.Name = "butonSaveEditMasina";
            this.butonSaveEditMasina.Size = new System.Drawing.Size(109, 37);
            this.butonSaveEditMasina.TabIndex = 8;
            this.butonSaveEditMasina.Text = "Salvare";
            this.butonSaveEditMasina.UseVisualStyleBackColor = true;
            this.butonSaveEditMasina.Click += new System.EventHandler(this.butonSaveEditMasina_Click);
            // 
            // butonCancelEditMasina
            // 
            this.butonCancelEditMasina.Location = new System.Drawing.Point(228, 157);
            this.butonCancelEditMasina.Name = "butonCancelEditMasina";
            this.butonCancelEditMasina.Size = new System.Drawing.Size(109, 37);
            this.butonCancelEditMasina.TabIndex = 9;
            this.butonCancelEditMasina.Text = "Anulare";
            this.butonCancelEditMasina.UseVisualStyleBackColor = true;
            this.butonCancelEditMasina.Click += new System.EventHandler(this.butonCancelEditMasina_Click);
            // 
            // EditMasinaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 217);
            this.Controls.Add(this.butonCancelEditMasina);
            this.Controls.Add(this.butonSaveEditMasina);
            this.Controls.Add(this.numericEditCapacitate);
            this.Controls.Add(this.numericEditAnFabr);
            this.Controls.Add(this.textBoxEditMarca);
            this.Controls.Add(this.textBoxEditNrInmatr);
            this.Controls.Add(this.labelCapacitate);
            this.Controls.Add(this.labelAnFabr);
            this.Controls.Add(this.labelEditMarca);
            this.Controls.Add(this.labelEditNrinmatr);
            this.Name = "EditMasinaForm";
            this.Text = "Editează o mașină";
            ((System.ComponentModel.ISupportInitialize)(this.numericEditAnFabr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditCapacitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditNrinmatr;
        private System.Windows.Forms.Label labelEditMarca;
        private System.Windows.Forms.Label labelAnFabr;
        private System.Windows.Forms.Label labelCapacitate;
        private System.Windows.Forms.TextBox textBoxEditNrInmatr;
        private System.Windows.Forms.TextBox textBoxEditMarca;
        private System.Windows.Forms.NumericUpDown numericEditAnFabr;
        private System.Windows.Forms.NumericUpDown numericEditCapacitate;
        private System.Windows.Forms.Button butonSaveEditMasina;
        private System.Windows.Forms.Button butonCancelEditMasina;
    }
}