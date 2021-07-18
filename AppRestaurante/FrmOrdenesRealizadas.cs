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
    public partial class FrmOrdenesRealizadas : Form
    {
        public static FrmOrdenesRealizadas Instancia { get; } = new FrmOrdenesRealizadas();

        private FrmOrdenesRealizadas()
        {
            InitializeComponent();
        }

        private void FrmOrdenesRealizadas_Load(object sender, EventArgs e)
        {

        }

        private void FrmOrdenesRealizadas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Instancia.Hide();
            FomMesas.Instancia.Show();
        }
    }
}
