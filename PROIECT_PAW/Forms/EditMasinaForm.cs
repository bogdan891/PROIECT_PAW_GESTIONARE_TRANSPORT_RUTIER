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
    public partial class EditMasinaForm : Form
    {
        private Models.Masina masinaEdit;
        public EditMasinaForm(Models.Masina masina)
        {
            InitializeComponent();
            this.Text = "Editează o mașină!";
            masinaEdit = masina;
            textBoxEditNrInmatr.Text = masina.NrInmatriculare;
            textBoxEditMarca.Text = masina.Marca;
            numericEditAnFabr.Value = masina.AnFabricatie;
            numericEditCapacitate.Value = masina.Capacitate;
        }

        private void butonSaveEditMasina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEditNrInmatr.Text))
            {
                MessageBox.Show("Introduceți numărul de înamtriculare!", "Introduceți maxim 9 caractere!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBoxEditMarca.Text))
            {
                MessageBox.Show("Introduceți marca!", "Eroare!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericEditAnFabr.Value < 1900)
            {
                MessageBox.Show("Introduceți un an de fabricație valid!", "Eroare!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericEditCapacitate.Value <= 0)
            {
                MessageBox.Show("Introduceți o capacitate validă!", "Eroare!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            masinaEdit.NrInmatriculare = textBoxEditNrInmatr.Text;
            masinaEdit.Marca = textBoxEditMarca.Text;
            masinaEdit.AnFabricatie = (int)numericEditAnFabr.Value;
            masinaEdit.Capacitate = (int)numericEditCapacitate.Value;

            DatabaseManager.UpdateMasina(masinaEdit);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void butonCancelEditMasina_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
