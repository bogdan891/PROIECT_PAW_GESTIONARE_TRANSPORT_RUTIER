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
    public partial class AddFormSofer : Form
    {
        public AddFormSofer()
        {
            InitializeComponent();
        }

        private void butonSaveAddSofer_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxAddNume.Text))
            {
                MessageBox.Show("Introduceți numele șoferului!", "Eroare!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBoxAddPrenume.Text))
            {
                MessageBox.Show("Introduceți prenumele șoferului!", "Eroare!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(numericSalariul.Value <= 0)
            {
                MessageBox.Show("Introduceți un salariu valid!", "Eroare!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newSofer = new Sofer
            {
                Id = Guid.NewGuid(),
                Nume = textBoxAddNume.Text,
                Prenume = textBoxAddPrenume.Text,
                Salariul = (double)numericSalariul.Value,
                DataAngajarii = dateTimePickerAng.Value

            };

            DatabaseManager.AddSofer(newSofer);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void butonCancelAddSofer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
