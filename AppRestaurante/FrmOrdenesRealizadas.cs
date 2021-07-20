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
        public static int determinante { get; set; }
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

        private void FrmOrdenesRealizadas_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            FomMesas.Instancia.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
            //System.Windows.Forms.Application.Exit();
            //Application.Exit(FomMesas.Instancia);
        }

        private void LboxOrdenes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public  void actualizarLboxOrdenes(string nombre, string entrada, string platoFuerte, string bebida, string postre)
        {
            switch (determinante)
            {
                case 1:
                    agregaLbox("Mesa 1", nombre, entrada, platoFuerte, bebida, postre);
                    break;
                case 2:
                    agregaLbox("Mesa 2", nombre, entrada, platoFuerte, bebida, postre);
                    break;
                case 3:
                    agregaLbox("Mesa 3", nombre, entrada, platoFuerte, bebida, postre);
                    break;
                case 4:
                    agregaLbox("Mesa 4", nombre, entrada, platoFuerte, bebida, postre);
                    break;
                case 5:
                    agregaLbox("Mesa 5", nombre, entrada, platoFuerte, bebida, postre);
                    break;
                case 6:
                    agregaLbox("Mesa 6", nombre, entrada, platoFuerte, bebida, postre);
                    break;
                case 7:
                    agregaLbox("Mesa 7", nombre, entrada, platoFuerte, bebida, postre);
                    break;
                case 8:
                    agregaLbox("Mesa 8",nombre,entrada,platoFuerte,bebida,postre);
                    break;
            }
        }
        public void agregaLbox(string mesa,string nombre, string entrada, string platoFuerte, string bebida, string postre)
        {
            string item = nombre + ": " + entrada + ", " + platoFuerte + ", " + bebida + ", " + postre;
            LboxOrdenes.Items.Add("");
            LboxOrdenes.Items.Add(mesa);
            LboxOrdenes.Items.Add(item);
        }
    }
}
