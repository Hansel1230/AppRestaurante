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
    public partial class FrmOrdenes : Form
    {
        public static FrmOrdenes Instancia { get; } = new FrmOrdenes();

        private FrmOrdenes()
        {
            InitializeComponent();
        }
         

        private void FrmOrdenes_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            FrmOrdenesRealizadas.Instancia.Show();
        }
    }
}
