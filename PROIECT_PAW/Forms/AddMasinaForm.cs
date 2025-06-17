using PROIECT_PAW.Database;
using PROIECT_PAW.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PAW.Forms
{
    public partial class AddMasinaForm : Form
    {
        public AddMasinaForm()
        {
            InitializeComponent();
        }

        private void butonSaveAddMasina_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxAddNrInmatr.Text))
            {
                MessageBox.Show("Introduceți numărul de înamtriculare!", "Introduceți maxim 9 caractere!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBoxAddMarca.Text))
            {
                MessageBox.Show("Introduceți marca!", "Eroare!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericAddAnFabr.Value < 1900)
            {
                MessageBox.Show("Introduceți un an de fabricație valid!", "Eroare!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericAddCapacitate.Value <= 0)
            {
                MessageBox.Show("Introduceți o capacitate validă!", "Eroare!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var masinaNoua = new Masina
            {
                Id = Guid.NewGuid(),
                NrInmatriculare = textBoxAddNrInmatr.Text,
                Marca = textBoxAddMarca.Text,
                AnFabricatie = (int)numericAddAnFabr.Value,
                Capacitate = (int)numericAddCapacitate.Value
            };

            DatabaseManager.AddMasina(masinaNoua);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void butonCancelAddMasina_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
