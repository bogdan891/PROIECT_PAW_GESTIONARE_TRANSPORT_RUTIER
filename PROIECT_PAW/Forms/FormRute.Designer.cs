namespace PROIECT_PAW.Forms
{
    partial class FormRute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRute));
            this.butonAddRuta = new System.Windows.Forms.Button();
            this.butonEditRuta = new System.Windows.Forms.Button();
            this.butonDeleteRuta = new System.Windows.Forms.Button();
            this.dataGridViewRuta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.butonMain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butonAddRuta
            // 
            this.butonAddRuta.Location = new System.Drawing.Point(449, 164);
            this.butonAddRuta.Name = "butonAddRuta";
            this.butonAddRuta.Size = new System.Drawing.Size(145, 57);
            this.butonAddRuta.TabIndex = 1;
            this.butonAddRuta.Text = "Adaugă o rută";
            this.butonAddRuta.UseVisualStyleBackColor = true;
            this.butonAddRuta.Click += new System.EventHandler(this.butonAddRuta_Click);
            // 
            // butonEditRuta
            // 
            this.butonEditRuta.Location = new System.Drawing.Point(449, 243);
            this.butonEditRuta.Name = "butonEditRuta";
            this.butonEditRuta.Size = new System.Drawing.Size(147, 57);
            this.butonEditRuta.TabIndex = 2;
            this.butonEditRuta.Text = "Editează o rută";
            this.butonEditRuta.UseVisualStyleBackColor = true;
            this.butonEditRuta.Click += new System.EventHandler(this.butonEditRuta_Click);
            // 
            // butonDeleteRuta
            // 
            this.butonDeleteRuta.Location = new System.Drawing.Point(447, 315);
            this.butonDeleteRuta.Name = "butonDeleteRuta";
            this.butonDeleteRuta.Size = new System.Drawing.Size(148, 57);
            this.butonDeleteRuta.TabIndex = 3;
            this.butonDeleteRuta.Text = "Șterge o rută";
            this.butonDeleteRuta.UseVisualStyleBackColor = true;
            this.butonDeleteRuta.Click += new System.EventHandler(this.butonDeleteRuta_Click);
            // 
            // dataGridViewRuta
            // 
            this.dataGridViewRuta.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRuta.Location = new System.Drawing.Point(12, 164);
            this.dataGridViewRuta.Name = "dataGridViewRuta";
            this.dataGridViewRuta.Size = new System.Drawing.Size(409, 208);
            this.dataGridViewRuta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gestionarea rutelor \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butonMain
            // 
            this.butonMain.Location = new System.Drawing.Point(294, 88);
            this.butonMain.Name = "butonMain";
            this.butonMain.Size = new System.Drawing.Size(160, 46);
            this.butonMain.TabIndex = 8;
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
            this.pictureBox1.Location = new System.Drawing.Point(101, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormRute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 387);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butonMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRuta);
            this.Controls.Add(this.butonDeleteRuta);
            this.Controls.Add(this.butonEditRuta);
            this.Controls.Add(this.butonAddRuta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRute";
            this.Text = "Rute ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butonAddRuta;
        private System.Windows.Forms.Button butonEditRuta;
        private System.Windows.Forms.Button butonDeleteRuta;
        private System.Windows.Forms.DataGridView dataGridViewRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butonMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}