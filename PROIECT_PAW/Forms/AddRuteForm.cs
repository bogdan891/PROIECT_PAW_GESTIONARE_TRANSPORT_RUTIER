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
    public partial class AddRuteForm : Form
    {
        public AddRuteForm()
        {
            InitializeComponent();

            comboBoxMasini.DataSource = DatabaseManager.GetAllMasini();
            comboBoxMasini.DisplayMember = "DetaliiMasina";
            comboBoxMasini.ValueMember = "Id";

            comboBoxSoferi.DataSource = DatabaseManager.GetAllSoferi();
            comboBoxSoferi.DisplayMember = "NumeComplet";
            comboBoxSoferi.ValueMember = "Id";
        }

        private void butonSaveAddRuta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAddCodTraseu.Text))
            {
                MessageBox.Show("Introduceți un cod de traseu!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBoxAddRutaPlecare.Text))
            {
                MessageBox.Show("Introduceți punctul de plecare!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBoxAddRutaDestinatie.Text))
            {
                MessageBox.Show("Introduceți punctul de sosire!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericAddDistanta.Value <= 0)
            {
                MessageBox.Show("Introduceți o distanta pozitiva!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(comboBoxMasini.SelectedItem == null || comboBoxSoferi.SelectedItem == null)
            {
                MessageBox.Show("Selectați o mașină și un șofer!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rutaNoua = new Ruta
            {
                Id = Guid.NewGuid(),
                CodTraseu = textBoxAddCodTraseu.Text,
                Plecare = textBoxAddRutaPlecare.Text,
                Destinatie = textBoxAddRutaDestinatie.Text,
                Distanta = (double)numericAddDistanta.Value,
                IdMasina = ((Masina)comboBoxMasini.SelectedItem).Id,
                IdSofer = ((Sofer)comboBoxSoferi.SelectedItem).Id
            };

            DatabaseManager.AddRuta(rutaNoua);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void butonCancelAddRuta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
