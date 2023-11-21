using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaExamenFinal
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnBeisbolistas_Click(object sender, EventArgs e)
        {
            frmBeisbolistas frmBeisbolistas = new frmBeisbolistas();
            AbrirFormEnPanel(frmBeisbolistas);

        }

        private void AbrirFormEnPanel(frmBeisbolistas frm)
        {
            if (pnlContenedor.Controls.Count > 0)
                pnlContenedor.Controls.RemoveAt(0);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(frm);
            pnlContenedor.Tag = frm;
            frm.Show();
        }
    }
}
