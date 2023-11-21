using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaExamenFinal
{
    public partial class frmBeisbolistas : Form
    {
        public frmBeisbolistas()
        {
            InitializeComponent();
        }
        public List<string> busqueda = new List<string>() { "Promedio Mayor 0.3 y Pais RD", "Liga Americana" };

        public List<Beisbolista> Beisbol = new List<Beisbolista>();


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EnviarObjetos();

            Beisbol.Add(new Beisbolista
            {
                Nombre = txtNombre.Text,
                Pais = txtPais.Text,
                Liga = txtLiga.Text,
                AB = double.Parse(txtAB.Text),
                H = double.Parse(txtH.Text)
            });

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = Beisbol;
            MessageBox.Show("Agregado correctamebnte");
            Limpiar();

        }

        public void EnviarObjetos()
        {
            Beisbolista beis = new Beisbolista();

            beis.Nombre = txtNombre.Text;
            beis.Pais = txtPais.Text;
            beis.AB = double.Parse(txtAB.Text);
            beis.H = double.Parse(txtH.Text);
        }

        public void Limpiar()
        {
            txtAB.Clear();
            txtH.Clear();
            txtNombre.Clear();
            txtPais.Clear();
            txtLiga.Clear();
        }

        private void frmBeisbolistas_Load(object sender, EventArgs e)
        {
            cboBusqueda.DataSource = busqueda;
        }


        public void BusquedaLiga()
        {
            var BusquedaCadenas = (from c in Beisbol
                                   where c.Liga == "AL"
                                   select c).ToList();

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = BusquedaCadenas;
        }

        public void BusquedaPaisYPromedio()
        {
            var BusquedaCadenas = (from c in Beisbol
                                   where c.Pais == "RD" && (c.H / c.AB) > 0.3
                                   select c).ToList();

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = BusquedaCadenas;
        }

        private void cboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBusqueda.SelectedItem == "Liga Americana")
            {
                BusquedaLiga();
            }
            else
            {
                BusquedaPaisYPromedio();
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                
                e.Handled = true;
            }
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                
                e.Handled = true;
            }
        }

        private void txtLiga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                
                e.Handled = true;
            }
        }

        private void txtH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 2;

            if (txtH.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtAB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            int maxLength = 3;

            if (txtAB.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
