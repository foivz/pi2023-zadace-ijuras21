using Sabbatical_Manager.Models;
using Sabbatical_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sabbatical_Manager {
    public partial class FrmEmployer : Form {
        public FrmEmployer() {
            InitializeComponent();
        }

        public void PrikazPodataka() {

        }
        private void FrmEmployer_Load(object sender, EventArgs e) {
            PrikaziZahtjeve();
        }
        private void PrikaziZahtjeve() {
            List<Zahtjev> zahtjevi = RepozitorijDjelatnika.DohvatiZahtjeve();
            dgvZahtjev.DataSource = zahtjevi;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void FrmEmployer_Load_1(object sender, EventArgs e) {
            PrikaziZahtjeve();
        }

        private void btnRequest_Click(object sender, EventArgs e) {
            FrmKreiranjeZahtjeva frmKreiranjeZahtjeva = new FrmKreiranjeZahtjeva();
            Hide();
            frmKreiranjeZahtjeva.ShowDialog();
            Close();
        }

        private void btnUredi_Click(object sender, EventArgs e) {
            FrmKreiranjeZahtjeva frmKreiranjeZahtjeva = new FrmKreiranjeZahtjeva();
            int id = (int)dgvZahtjev.SelectedCells[0].OwningRow.Cells["Id"].Value;
            frmKreiranjeZahtjeva.Editing(id);
            Hide();
            frmKreiranjeZahtjeva.ShowDialog();
            Close();


        }
    }
}
