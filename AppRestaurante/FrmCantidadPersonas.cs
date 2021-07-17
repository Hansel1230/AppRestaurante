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

        private FrmCantidadPersonas()
        {
            InitializeComponent();
        }
         
        private void FrmCantidadPersonas_Load(object sender, EventArgs e)
        {

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
            Instancia.Hide();
            FrmOrdenes.Instancia.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        private void CloseForm()
        {
            Instancia.Hide();
            FomMesas.Instancia.Show();
        }

       
    }
}
