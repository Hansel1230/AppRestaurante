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
    public partial class FrmCantidadPersonas : Form
    {
        public static FrmCantidadPersonas Instancia { get; } = new FrmCantidadPersonas();
        public static int Cantidad { get; set; }
        public bool isvalid = true;

        private FrmCantidadPersonas()
        {
            InitializeComponent();
        }
        private void FrmCantidadPersonas_Load(object sender, EventArgs e)
        {
            TxtCantidad.Text ="Ingrese Cantidad:";
            
        }
        private void FrmCantidadPersonas_FormClosed(object sender, FormClosedEventArgs e)
        {
            FomMesas.Instancia.Show();
        }
        private void LblCantidadPersonas_Click(object sender, EventArgs e)
        {

        }
        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            isvalid = true;
            if (string.IsNullOrEmpty(TxtCantidad.Text) || (TxtCantidad.Text == "Ingrese Cantidad:"))
            {              
                MessageBox.Show("Debe ingresar una Cantidad", "Advertencia");
                isvalid = false;
            }
            else if (TxtCantidad.Text !="1"&& TxtCantidad.Text != "2"&& TxtCantidad.Text != "3"&& TxtCantidad.Text != "4")
            {
                MessageBox.Show("Debe ingresar una Cantidad entre 1 y 4 incluyendo a estas", "Advertencia");
                isvalid = false;
            }
            if (isvalid)
            {
                Cantidad = Convert.ToInt32(TxtCantidad.Text);
                Instancia.Hide();
                FrmOrdenes.Instancia.Show();
                TxtCantidad.Text = "1";
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CloseForm();
            TxtCantidad.Text = "1";
        }
        private void FrmCantidadPersonas_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        private void TxtCantidad_Click(object sender, EventArgs e)
        {
            if (TxtCantidad.Text == "Ingrese Cantidad:")
            {
                TxtCantidad.Text = "";
            }
        }
        private void TxtCantidad_Leave(object sender, EventArgs e)
        {
            
        }
        private void TxtCantidad_Enter(object sender, EventArgs e)
        {
            
        }
        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void CloseForm()
        {
            Instancia.Hide();
            FomMesas.Instancia.Show();
        }
    }
}
