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
    public partial class EditRutaForm : Form
    {
        private Ruta editRuta;
        public EditRutaForm()
        {
            InitializeComponent();
        }

        public EditRutaForm(Ruta ruta)
        {
            InitializeComponent();
            this.Text = "Editează o rută";
            editRuta = ruta;

            comboBoxMasini.DataSource = DatabaseManager.GetAllMasini();
            comboBoxMasini.DisplayMember = "DetaliiMasina";
            comboBoxMasini.ValueMember = "Id";

            comboBoxSoferi.DataSource = DatabaseManager.GetAllSoferi();
            comboBoxSoferi.DisplayMember = "NumeComplet";
            comboBoxSoferi.ValueMember = "Id";

            textBoxEditCodTraseu.Text = ruta.CodTraseu;
            textBoxEditPlecare.Text = ruta.Plecare;
            textBoxEditDestinatie.Text = ruta.Destinatie;
            numericEditDistanta.Value = (decimal)ruta.Distanta;
            comboBoxMasini.SelectedValue = ruta.IdMasina;
            comboBoxSoferi.SelectedValue = ruta.IdSofer;
        }

        private void butonSaveEditRuta_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxEditCodTraseu.Text))
            {
                MessageBox.Show("Introduceți un cod de traseu!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBoxEditPlecare.Text))
            {
                MessageBox.Show("Introduceți punctul de plecare!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBoxEditDestinatie.Text))
            {
                MessageBox.Show("Introduceți punctul de sosire!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(numericEditDistanta.Value <= 0)
            {
                MessageBox.Show("Introduceți o distanta pozitiva!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxMasini.SelectedItem == null || comboBoxSoferi.SelectedItem == null)
            {
                MessageBox.Show("Selectați o mașină și un șofer!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            editRuta.CodTraseu = textBoxEditCodTraseu.Text;
            editRuta.Plecare = textBoxEditPlecare.Text;
            editRuta.Destinatie = textBoxEditDestinatie.Text;
            editRuta.Distanta = (double)numericEditDistanta.Value;
            editRuta.IdMasina = ((Masina)comboBoxMasini.SelectedItem).Id;
            editRuta.IdSofer = ((Sofer)comboBoxSoferi.SelectedItem).Id;

            DatabaseManager.UpdateRuta(editRuta);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void butonCancelEditRuta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
