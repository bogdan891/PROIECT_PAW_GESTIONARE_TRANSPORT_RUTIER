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
    public partial class FormMasini : Form
    {
        public FormMasini()
        {
            InitializeComponent();

            //Setup DataGridView
            dataGridViewMasini.DataSource = DatabaseManager.GetAllMasini();
            dataGridViewMasini.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMasini.MultiSelect = false;
            dataGridViewMasini.AutoGenerateColumns = true;
            dataGridViewMasini.AllowUserToDeleteRows = false;
            dataGridViewMasini.ReadOnly = true;
            dataGridViewMasini.Columns["Id"].Visible = false; 
            dataGridViewMasini.Columns["DetaliiMasina"].Visible = false;
        }

        private void butonAddMasina_Click(object sender, EventArgs e)
        {
            var addForm = new AddMasinaForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                dataGridViewMasini.Refresh();
                dataGridViewMasini.DataSource = DatabaseManager.GetAllMasini();
            }
        }

        private void butonEditMasina_Click(object sender, EventArgs e)
        {
            var editVar = (Models.Masina)dataGridViewMasini.SelectedRows[0].DataBoundItem;
            if (editVar != null)
            {
                var editForm = new EditMasinaForm(editVar);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    dataGridViewMasini.Refresh();
                    dataGridViewMasini.DataSource = DatabaseManager.GetAllMasini();
                }
            }
            else
            {
                MessageBox.Show("Selectează o rută pentru editare!");
            }
        }

        private void butonDeleteMasina_Click(object sender, EventArgs e)
        {
            if(dataGridViewMasini.SelectedRows.Count == 1)
            {
                var deleteVar = (Models.Masina)dataGridViewMasini.SelectedRows[0].DataBoundItem;
                if (deleteVar != null)
                {
                    var confirm = MessageBox.Show(
                        "Vrei să ștergi această mașină?",
                        "Confirmă ștergerea!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if(confirm == DialogResult.Yes)
                    {
                        var id = (Guid)dataGridViewMasini.SelectedRows[0].Cells["Id"].Value;
                        DatabaseManager.DeleteMasina(id);
                        dataGridViewMasini.Refresh();
                        dataGridViewMasini.DataSource = DatabaseManager.GetAllMasini();
                    }
                }
                else
                {
                    MessageBox.Show("Selectează o mașină pentru ștergere!");
                }
            }
        }

        private void butonMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
