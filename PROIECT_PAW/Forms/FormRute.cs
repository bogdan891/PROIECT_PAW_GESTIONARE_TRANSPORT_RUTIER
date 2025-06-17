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
    public partial class FormRute : Form
    {
        public FormRute()
        {
            InitializeComponent();

            //Setup DataGridView
            dataGridViewRuta.DataSource = DatabaseManager.GetAllRute();
            dataGridViewRuta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRuta.MultiSelect = false;
            dataGridViewRuta.AutoGenerateColumns = true;
            dataGridViewRuta.AllowUserToDeleteRows = false;
            dataGridViewRuta.ReadOnly = true;
            dataGridViewRuta.Columns["IdSofer"].Visible = false;
            dataGridViewRuta.Columns["IdMasina"].Visible = false;
            dataGridViewRuta.Columns["Id"].Visible = false;
        }

        private void butonAddRuta_Click(object sender, EventArgs e)
        {
            var addForm = new AddRuteForm();
            addForm.ShowDialog();
            dataGridViewRuta.Refresh();
            dataGridViewRuta.DataSource = DatabaseManager.GetAllRute();

        }

        private void butonEditRuta_Click(object sender, EventArgs e)
        {
            if (dataGridViewRuta.SelectedRows.Count == 1)
            {
                DataRowView drw = dataGridViewRuta.SelectedRows[0].DataBoundItem as DataRowView;
               if(drw != null)
                {
                    var rutaSelectata = new Models.Ruta
                    {
                        Id = (Guid)drw["Id"],
                        CodTraseu = drw["CodTraseu"].ToString(),
                        Plecare= drw["Plecare"].ToString(),
                        Destinatie = drw["Destinatie"].ToString(),
                        Distanta = (double)drw["Distanta"],
                        IdSofer = (Guid)drw["IdSofer"],
                        IdMasina = (Guid)drw["IdMasina"]
                    };

                    var editForm = new EditRutaForm(rutaSelectata);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        dataGridViewRuta.Refresh();
                        dataGridViewRuta.DataSource = DatabaseManager.GetAllRute();
                    }
                }
            } 
            else
            {
                MessageBox.Show("Selectează o rută pentru editare!");
            }
        }

        private void butonDeleteRuta_Click(object sender, EventArgs e)
        {
            if (dataGridViewRuta.SelectedRows.Count == 1)
            {
                DataRowView drw = dataGridViewRuta.SelectedRows[0].DataBoundItem as DataRowView;
                if (drw != null)
                {
                    var rutaSelectata = new Models.Ruta
                    {
                        Id = (Guid)drw["Id"],
                        CodTraseu = drw["CodTraseu"].ToString(),
                        Plecare = drw["Plecare"].ToString(),
                        Destinatie = drw["Destinatie"].ToString(),
                        Distanta = (double)drw["Distanta"],
                        IdSofer = (Guid)drw["IdSofer"],
                        IdMasina = (Guid)drw["IdMasina"]
                    };
                    var confirm = MessageBox.Show(
                        "Vrei să ștergi această rută?",
                        "Confirmă Ștergerea!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        var id = (Guid)dataGridViewRuta.SelectedRows[0].Cells["Id"].Value;
                        DatabaseManager.DeleteRuta(id);
                        dataGridViewRuta.Refresh();
                        dataGridViewRuta.DataSource = DatabaseManager.GetAllRute();
                    }
                }

            }
            else
            {
                MessageBox.Show("Selectează o rută pentru ștergere!");
            }
        }

        private void butonMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
