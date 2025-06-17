namespace PROIECT_PAW.Forms
{
    partial class FormSoferi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSoferi));
            this.butonAddSofer = new System.Windows.Forms.Button();
            this.butonEditSofer = new System.Windows.Forms.Button();
            this.butonDeleteSofer = new System.Windows.Forms.Button();
            this.dataGridViewSoferi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.butonMain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoferi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butonAddSofer
            // 
            this.butonAddSofer.Location = new System.Drawing.Point(442, 163);
            this.butonAddSofer.Name = "butonAddSofer";
            this.butonAddSofer.Size = new System.Drawing.Size(131, 53);
            this.butonAddSofer.TabIndex = 3;
            this.butonAddSofer.Text = "Adaugă un șofer";
            this.butonAddSofer.UseVisualStyleBackColor = true;
            this.butonAddSofer.Click += new System.EventHandler(this.butonAddSofer_Click);
            // 
            // butonEditSofer
            // 
            this.butonEditSofer.Location = new System.Drawing.Point(442, 235);
            this.butonEditSofer.Name = "butonEditSofer";
            this.butonEditSofer.Size = new System.Drawing.Size(131, 53);
            this.butonEditSofer.TabIndex = 4;
            this.butonEditSofer.Text = "Editează un șofer";
            this.butonEditSofer.UseVisualStyleBackColor = true;
            this.butonEditSofer.Click += new System.EventHandler(this.butonEditSofer_Click);
            // 
            // butonDeleteSofer
            // 
            this.butonDeleteSofer.Location = new System.Drawing.Point(442, 309);
            this.butonDeleteSofer.Name = "butonDeleteSofer";
            this.butonDeleteSofer.Size = new System.Drawing.Size(131, 53);
            this.butonDeleteSofer.TabIndex = 5;
            this.butonDeleteSofer.Text = "Șterge un șofer";
            this.butonDeleteSofer.UseVisualStyleBackColor = true;
            this.butonDeleteSofer.Click += new System.EventHandler(this.butonDeleteSofer_Click);
            // 
            // dataGridViewSoferi
            // 
            this.dataGridViewSoferi.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSoferi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoferi.Location = new System.Drawing.Point(12, 163);
            this.dataGridViewSoferi.Name = "dataGridViewSoferi";
            this.dataGridViewSoferi.Size = new System.Drawing.Size(414, 200);
            this.dataGridViewSoferi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gestionarea șoferilor ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butonMain
            // 
            this.butonMain.Location = new System.Drawing.Point(283, 88);
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
            this.pictureBox1.Location = new System.Drawing.Point(96, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormSoferi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 374);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butonMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSoferi);
            this.Controls.Add(this.butonDeleteSofer);
            this.Controls.Add(this.butonEditSofer);
            this.Controls.Add(this.butonAddSofer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSoferi";
            this.Text = "FormSoferi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoferi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butonAddSofer;
        private System.Windows.Forms.Button butonEditSofer;
        private System.Windows.Forms.Button butonDeleteSofer;
        private System.Windows.Forms.DataGridView dataGridViewSoferi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butonMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}