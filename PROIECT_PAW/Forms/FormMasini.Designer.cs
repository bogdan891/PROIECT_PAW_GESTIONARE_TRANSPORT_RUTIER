namespace PROIECT_PAW.Forms
{
    partial class FormMasini
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMasini));
            this.butonAddMasina = new System.Windows.Forms.Button();
            this.butonEditMasina = new System.Windows.Forms.Button();
            this.butonDeleteMasina = new System.Windows.Forms.Button();
            this.dataGridViewMasini = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.butonMain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butonAddMasina
            // 
            this.butonAddMasina.Location = new System.Drawing.Point(446, 154);
            this.butonAddMasina.Name = "butonAddMasina";
            this.butonAddMasina.Size = new System.Drawing.Size(131, 53);
            this.butonAddMasina.TabIndex = 2;
            this.butonAddMasina.Text = "Adaugă o mașină";
            this.butonAddMasina.UseVisualStyleBackColor = true;
            this.butonAddMasina.Click += new System.EventHandler(this.butonAddMasina_Click);
            // 
            // butonEditMasina
            // 
            this.butonEditMasina.Location = new System.Drawing.Point(446, 231);
            this.butonEditMasina.Name = "butonEditMasina";
            this.butonEditMasina.Size = new System.Drawing.Size(131, 53);
            this.butonEditMasina.TabIndex = 3;
            this.butonEditMasina.Text = "Editează o mașină";
            this.butonEditMasina.UseVisualStyleBackColor = true;
            this.butonEditMasina.Click += new System.EventHandler(this.butonEditMasina_Click);
            // 
            // butonDeleteMasina
            // 
            this.butonDeleteMasina.Location = new System.Drawing.Point(446, 305);
            this.butonDeleteMasina.Name = "butonDeleteMasina";
            this.butonDeleteMasina.Size = new System.Drawing.Size(131, 53);
            this.butonDeleteMasina.TabIndex = 4;
            this.butonDeleteMasina.Text = "Șterge o mașină";
            this.butonDeleteMasina.UseVisualStyleBackColor = true;
            this.butonDeleteMasina.Click += new System.EventHandler(this.butonDeleteMasina_Click);
            // 
            // dataGridViewMasini
            // 
            this.dataGridViewMasini.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMasini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMasini.Location = new System.Drawing.Point(12, 154);
            this.dataGridViewMasini.Name = "dataGridViewMasini";
            this.dataGridViewMasini.Size = new System.Drawing.Size(411, 204);
            this.dataGridViewMasini.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gestionarea mașinilor \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butonMain
            // 
            this.butonMain.Location = new System.Drawing.Point(263, 88);
            this.butonMain.Name = "butonMain";
            this.butonMain.Size = new System.Drawing.Size(160, 46);
            this.butonMain.TabIndex = 7;
            this.butonMain.Text = "Pagina principală";
            this.butonMain.UseVisualStyleBackColor = true;
            this.butonMain.Click += new System.EventHandler(this.butonMain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormMasini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 372);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butonMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMasini);
            this.Controls.Add(this.butonDeleteMasina);
            this.Controls.Add(this.butonEditMasina);
            this.Controls.Add(this.butonAddMasina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMasini";
            this.Text = "Masini";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butonAddMasina;
        private System.Windows.Forms.Button butonEditMasina;
        private System.Windows.Forms.Button butonDeleteMasina;
        private System.Windows.Forms.DataGridView dataGridViewMasini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butonMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}