namespace PROIECT_PAW
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.butonRute = new System.Windows.Forms.Button();
            this.butonMasini = new System.Windows.Forms.Button();
            this.butonSoferi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestiune Transport\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butonRute
            // 
            this.butonRute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonRute.Location = new System.Drawing.Point(98, 215);
            this.butonRute.Name = "butonRute";
            this.butonRute.Size = new System.Drawing.Size(174, 66);
            this.butonRute.TabIndex = 3;
            this.butonRute.Text = "Rute";
            this.butonRute.UseVisualStyleBackColor = true;
            this.butonRute.Click += new System.EventHandler(this.butonRute_Click);
            // 
            // butonMasini
            // 
            this.butonMasini.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonMasini.Location = new System.Drawing.Point(98, 306);
            this.butonMasini.Name = "butonMasini";
            this.butonMasini.Size = new System.Drawing.Size(174, 66);
            this.butonMasini.TabIndex = 4;
            this.butonMasini.Text = "Mașini";
            this.butonMasini.UseVisualStyleBackColor = true;
            this.butonMasini.Click += new System.EventHandler(this.butonMasini_Click);
            // 
            // butonSoferi
            // 
            this.butonSoferi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonSoferi.Location = new System.Drawing.Point(98, 397);
            this.butonSoferi.Name = "butonSoferi";
            this.butonSoferi.Size = new System.Drawing.Size(174, 66);
            this.butonSoferi.TabIndex = 5;
            this.butonSoferi.Text = "Șoferi";
            this.butonSoferi.UseVisualStyleBackColor = true;
            this.butonSoferi.Click += new System.EventHandler(this.butonSoferi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butonSoferi);
            this.Controls.Add(this.butonMasini);
            this.Controls.Add(this.butonRute);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Pagina Principală";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butonRute;
        private System.Windows.Forms.Button butonMasini;
        private System.Windows.Forms.Button butonSoferi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

