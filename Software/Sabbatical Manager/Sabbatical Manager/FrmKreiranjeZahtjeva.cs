using Sabbatical_Manager.Models;
using Sabbatical_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sabbatical_Manager {
    public partial class FrmKreiranjeZahtjeva : Form {
        public FrmKreiranjeZahtjeva() {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        bool edit = false;
        public void Editing(int id) {
            edit = true;

            Zahtjev zahtjev = RepozitorijDjelatnika.DohvatiZahtjev(id);

            txtObrazlozenje.Text = zahtjev.Obrazloženje;
            cboVrsta.Text = zahtjev.Vrsta;
            dateOdsustva.SelectionStart = zahtjev.DatumOdlaska;
            dateOdsustva.SelectionEnd = zahtjev.DatumOdlaska;
            dateDo.SelectionStart = zahtjev.DoDatuma;
            dateDo.SelectionEnd = zahtjev.DoDatuma;
        }

        private void FrmKreiranjeZahtjeva_Load(object sender, EventArgs e) {
            cboVrsta.Items.Add("Godišnji odmor");
            cboVrsta.Items.Add("Slobodan dan");
            cboVrsta.Items.Add("Stručno usavršavanje");
            cboVrsta.Items.Add("Bolovanje");

        }

        private void button1_Click(object sender, EventArgs e) {
            Zahtjev zahtjev = new Zahtjev {
                Obrazloženje = txtObrazlozenje.Text,
                Vrsta = cboVrsta.Text,
                DatumOdlaska = dateOdsustva.SelectionStart,
                DoDatuma = dateDo.SelectionEnd,
                Status = "Zaprimljen"
            };

            if (!edit) {
                RepozitorijDjelatnika.SpremiZahtjev(zahtjev);
            } else {
                RepozitorijDjelatnika.UrediZahtjev(zahtjev);
            }

            edit = false;

            FrmEmployer frmEmployer = new FrmEmployer();
            Hide();
            frmEmployer.ShowDialog();
            Close();
        }
    }
}
