using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRestaurante
{
    public sealed partial class FomMesas : Form
    {
        public static FomMesas Instancia { get; } = new FomMesas();
        public int count=0;
        private FomMesas()
        {
            InitializeComponent();
        }
        private void FomMesas_Load(object sender, EventArgs e)
        {
        }
        private void FomMesas_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void BtnMesa1_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            FrmCantidadPersonas.Instancia.Show();
            FrmOrdenesRealizadas.determinante = 1;
        }
        private void BtnMesa2_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            FrmCantidadPersonas.Instancia.Show();
            FrmOrdenesRealizadas.determinante = 2;
        }
        private void BtnMesa3_Click_1(object sender, EventArgs e)
        {
            Instancia.Hide();
            FrmCantidadPersonas.Instancia.Show();
            FrmOrdenesRealizadas.determinante = 3;
        }
        private void BtnMesa4_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            FrmCantidadPersonas.Instancia.Show();
            FrmOrdenesRealizadas.determinante = 4;
        }
        private void BtnMesa5_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            FrmCantidadPersonas.Instancia.Show();
            FrmOrdenesRealizadas.determinante = 5;
        }
        private void BtnMesa6_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            FrmCantidadPersonas.Instancia.Show();
            FrmOrdenesRealizadas.determinante = 6;
        }

        private void BtnMesa7_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            FrmCantidadPersonas.Instancia.Show();
            FrmOrdenesRealizadas.determinante = 7;
        }

        private void btnMesa8_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            FrmCantidadPersonas.Instancia.Show();
            FrmOrdenesRealizadas.determinante = 8;
        }
        
    }
}
