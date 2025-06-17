using PROIECT_PAW.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PAW
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void butonRute_Click(object sender, EventArgs e)
        {
            var formRute = new FormRute();
            formRute.ShowDialog();
        }

        private void butonMasini_Click(object sender, EventArgs e)
        {
            var formMasini = new FormMasini();
            formMasini.ShowDialog();
        }

        private void butonSoferi_Click(object sender, EventArgs e)
        {
            var formSoferi = new FormSoferi();
            formSoferi.ShowDialog();
        }
    }
}
