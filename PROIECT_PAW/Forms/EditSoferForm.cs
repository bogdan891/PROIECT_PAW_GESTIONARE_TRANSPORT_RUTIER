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
    public partial class EditSoferForm : Form
    {
        private Sofer editSofer;

        public EditSoferForm(Sofer sofer)
        {
            InitializeComponent();
            this.Text = "Editare șofer";
            editSofer = sofer;

            textBoxEditNume.Text = sofer.Nume;
            textBoxEditPrenume.Text = sofer.Prenume;   
            numericEditSalariul.Value = (decimal)sofer.Salariul;
            dateTimePickerEditAng.Value = (DateTime)sofer.DataAngajarii;
        }

        private void butonSaveEditSofer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEditNume.Text))
            {
                MessageBox.Show("Introduceți numele șoferului!", "Eroare!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBoxEditPrenume.Text))
            {
                MessageBox.Show("Introduceți prenumele șoferului!", "Eroare!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericEditSalariul.Value <= 0)
            {
                MessageBox.Show("Introduceți un salariu valid!", "Eroare!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            editSofer.Nume = textBoxEditNume.Text;
            editSofer.Prenume = textBoxEditPrenume.Text;
            editSofer.Salariul = (double)numericEditSalariul.Value;
            editSofer.DataAngajarii = (DateTime)dateTimePickerEditAng.Value;

            DatabaseManager.UpdateSofer(editSofer);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void butonCancelEditSofer_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
