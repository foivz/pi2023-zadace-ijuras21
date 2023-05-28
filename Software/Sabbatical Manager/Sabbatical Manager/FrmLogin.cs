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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sabbatical_Manager {
    public partial class FrmLogin : Form {

        public static Djelatnik LogiraniDjelatnik { get; set; } // username: djelatnik pass:test

        public FrmLogin() {
            InitializeComponent();
        }
 
        private void btnLogin_Click(object sender, EventArgs e) {
            if (txtUsername.Text == "") {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtPassword.Text == "") {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else {
                LogiraniDjelatnik = RepozitorijDjelatnika.DohvatiDjelatnika(txtUsername.Text);
                if (LogiraniDjelatnik != null && LogiraniDjelatnik.Password == txtPassword.Text) {
                    FrmEmployer frmEmployer = new FrmEmployer();
                    Hide();
                    frmEmployer.ShowDialog();
                    Close();
                } else {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

            }
        }
    }
}
