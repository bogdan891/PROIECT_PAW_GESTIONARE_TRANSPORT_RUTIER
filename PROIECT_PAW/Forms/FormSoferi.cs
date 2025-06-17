using PROIECT_PAW.Database;
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
    public partial class FormSoferi : Form
    {
        public FormSoferi()
        {
            InitializeComponent();

            //Setup DataGridView
            dataGridViewSoferi.DataSource = DatabaseManager.GetAllSoferi();
            dataGridViewSoferi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSoferi.MultiSelect = false;
            dataGridViewSoferi.AutoGenerateColumns = true;
            dataGridViewSoferi.AllowUserToDeleteRows = false;
            dataGridViewSoferi.ReadOnly = true;
            dataGridViewSoferi.Columns["Id"].Visible = false;
            dataGridViewSoferi.Columns["NumeComplet"].Visible = false;
        }

        private void butonAddSofer_Click(object sender, EventArgs e)
        {
            var addForm = new AddFormSofer();
            if(addForm.ShowDialog() == DialogResult.OK)
            {
                dataGridViewSoferi.Refresh();
                dataGridViewSoferi.DataSource = DatabaseManager.GetAllSoferi();
            }
        }

        private void butonEditSofer_Click(object sender, EventArgs e)
        {
            if(dataGridViewSoferi.SelectedRows.Count == 1)
            {
                var sofer = (Models.Sofer)dataGridViewSoferi.SelectedRows[0].DataBoundItem;

                if(sofer != null)
                {
                    var editForm = new EditSoferForm(sofer);
                    if(editForm.ShowDialog() == DialogResult.OK)
                    {
                        dataGridViewSoferi.Refresh();
                        dataGridViewSoferi.DataSource = DatabaseManager.GetAllSoferi();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selectează un șofer pentru editare!");
            }
        }

        private void butonDeleteSofer_Click(object sender, EventArgs e)
        {
            if (dataGridViewSoferi.SelectedRows.Count == 1)
            {
                var sofer = (Models.Sofer)dataGridViewSoferi.SelectedRows[0].DataBoundItem;
                if (sofer != null)
                {
                    var confirm = MessageBox.Show(
                        "Vrei să ștergi acest șofer?",
                        "Confirmă Ștergerea!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        var id = (Guid)dataGridViewSoferi.SelectedRows[0].Cells["Id"].Value;
                        DatabaseManager.DeleteSofer(id);
                        dataGridViewSoferi.Refresh();
                        dataGridViewSoferi.DataSource = DatabaseManager.GetAllSoferi();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selectează un șofer pentru ștergere!");
            }
        }

        private void butonMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
