using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinesLayer.CustomControlItem;

namespace AppRestaurante
{
    public partial class FrmOrdenes : Form
    {
        public static FrmOrdenes Instancia { get; } = new FrmOrdenes();    
        private FrmOrdenes()
        {
            InitializeComponent();
        }

        private void FrmOrdenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Instancia.Hide();
            FomMesas.Instancia.Show();        
        }
        private void FrmOrdenes_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        private void FrmOrdenes_Load(object sender, EventArgs e)
        {
            TxtNombre.Text = "Ingrese nombre:";
            LoadCombobox();
            LblInfoCantidad.Text = "";         
        }
        private void TxtNombre_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "Ingrese nombre:")
            {
                TxtNombre.Text = "";
            }
        }
        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "")
            {
                TxtNombre.Text = "Ingrese nombre:";
            }
        }
        private void TxtNombre_Enter(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "Ingrese nombre:")
            {
                TxtNombre.Text = "";
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            selectOpcionCBx();

        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            FrmCantidadPersonas.Instancia.Show();                        
            LblInfoCantidad.Text ="";
        }
        private void TxtNombre_MouseLeave(object sender, EventArgs e)
        {
            
        }
        private void TxtNombre_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //llenar combobox
        private void LoadCombobox()
        {
            ComboBoxItem OpcionPorDefecto = new ComboBoxItem();
            OpcionPorDefecto.Text = "selecione una opcion ";
            OpcionPorDefecto.Value = null;

            //comboboxEntrada

            ComboBoxItem FalafelOpcion = new ComboBoxItem();
            FalafelOpcion.Text = "Falafel";
            FalafelOpcion.Value = 1;

            ComboBoxItem  ChampinonesOpcion = new ComboBoxItem();
            ChampinonesOpcion.Text = "Champiñones Rellenos";
            ChampinonesOpcion.Value = 2;

            ComboBoxItem CanapesOpcion = new ComboBoxItem();
            CanapesOpcion.Text = "Canapes Frios";
            CanapesOpcion.Value = 3;

            ComboBoxItem PanOpcion = new ComboBoxItem();
            PanOpcion.Text = "Pan Amasado";
            PanOpcion.Value = 4;

            ComboBoxItem CebicheOpcion = new ComboBoxItem();
            CebicheOpcion.Text = "Cebiche de Champiñones";
            CebicheOpcion.Value = 5;

            CbxEntrada.Items.Add(OpcionPorDefecto);
            CbxEntrada.Items.Add(FalafelOpcion);
            CbxEntrada.Items.Add(ChampinonesOpcion);
            CbxEntrada.Items.Add(CanapesOpcion);
            CbxEntrada.Items.Add(PanOpcion);
            CbxEntrada.Items.Add(CebicheOpcion);
            CbxEntrada.SelectedItem = OpcionPorDefecto;

            //comboboxPlato fuerte 

            ComboBoxItem ChuletasOpcion = new ComboBoxItem();
            ChuletasOpcion.Text = "Chuletas al albañil";
            ChuletasOpcion.Value = 1;

            ComboBoxItem CostillasOpcion = new ComboBoxItem();
            CostillasOpcion.Text = "Costillas de cerdo";
            CostillasOpcion.Value = 2;

            ComboBoxItem LasanaOpcion = new ComboBoxItem();
            LasanaOpcion.Text = "Lasaña";
            LasanaOpcion.Value = 3;

            ComboBoxItem TacosOpcion = new ComboBoxItem();
            TacosOpcion.Text = "Tacos dorados";
            TacosOpcion.Value = 4;

            ComboBoxItem PambazosOpcion = new ComboBoxItem();
            PambazosOpcion.Text = "Pambazos de papa";
            PambazosOpcion.Value = 5;

            ComboBoxItem CerdoOpcion = new ComboBoxItem();
            CerdoOpcion.Text = "Cerdo agridulce";
            CerdoOpcion.Value = 6;

            ComboBoxItem PechugaOpcion = new ComboBoxItem();
            PechugaOpcion.Text = "Pechugas de Pollo";
            PechugaOpcion.Value = 7;

            ComboBoxItem FajitasOpcion = new ComboBoxItem();
            FajitasOpcion.Text = "Fajitas";
            FajitasOpcion.Value = 8;

            ComboBoxItem BrochetaOpcion = new ComboBoxItem();
            BrochetaOpcion.Text = "Brochetas de pollo";
            BrochetaOpcion.Value = 9;

            ComboBoxItem CamaronesOpcion = new ComboBoxItem();
            CamaronesOpcion.Text = "Camarones zarandeados";
            CamaronesOpcion.Value = 10;

            CbxPlatoFuerte.Items.Add(OpcionPorDefecto);
            CbxPlatoFuerte.Items.Add(ChuletasOpcion);
            CbxPlatoFuerte.Items.Add(CostillasOpcion);
            CbxPlatoFuerte.Items.Add(LasanaOpcion);
            CbxPlatoFuerte.Items.Add(TacosOpcion);
            CbxPlatoFuerte.Items.Add(PambazosOpcion);
            CbxPlatoFuerte.Items.Add(CerdoOpcion);
            CbxPlatoFuerte.Items.Add(PechugaOpcion);
            CbxPlatoFuerte.Items.Add(FajitasOpcion);
            CbxPlatoFuerte.Items.Add(BrochetaOpcion);
            CbxPlatoFuerte.Items.Add(CamaronesOpcion);
            CbxPlatoFuerte.SelectedItem = OpcionPorDefecto;

            //comboboxpostres

            ComboBoxItem GranolaOpcion = new ComboBoxItem();
            GranolaOpcion.Text = "Granola";
            GranolaOpcion.Value = 1;

            ComboBoxItem WafflesOpcion = new ComboBoxItem();
            WafflesOpcion.Text = "Waffles";
            WafflesOpcion.Value = 2;

            ComboBoxItem QuequeManOpcion = new ComboBoxItem();
            QuequeManOpcion.Text = "Queque de Manzana";
            QuequeManOpcion.Value = 3;

            ComboBoxItem QuequeChoOpcion = new ComboBoxItem();
            QuequeChoOpcion.Text = "Queque de Chocolate";
            QuequeChoOpcion.Value = 4;

            ComboBoxItem QuequeZanOpcion = new ComboBoxItem();
            QuequeZanOpcion.Text = "Queque de zanahoria";
            QuequeZanOpcion.Value = 5;

            CbxPostre.Items.Add(OpcionPorDefecto);
            CbxPostre.Items.Add(GranolaOpcion);
            CbxPostre.Items.Add(WafflesOpcion);
            CbxPostre.Items.Add(QuequeManOpcion);
            CbxPostre.Items.Add(QuequeChoOpcion);
            CbxPostre.Items.Add(QuequeZanOpcion);
            CbxPostre.SelectedItem = OpcionPorDefecto;

            //comboboxbebidas

            ComboBoxItem AguaMinOpcion = new ComboBoxItem();
            AguaMinOpcion.Text = "Agua Mineral";
            AguaMinOpcion.Value = 1;

            ComboBoxItem AguacocoOpcion = new ComboBoxItem();
            AguacocoOpcion.Text = "Agua de coco";
            AguacocoOpcion.Value = 2;

            ComboBoxItem SangriaOpcion = new ComboBoxItem();
            SangriaOpcion.Text = "Sangria de fresa";
            SangriaOpcion.Value = 3;

            ComboBoxItem TeOpcion = new ComboBoxItem();
            TeOpcion.Text = "Te de menta";
            TeOpcion.Value = 4;

            ComboBoxItem CervezaOpcion = new ComboBoxItem();
            CervezaOpcion.Text = "Cerveza";
            CervezaOpcion.Value = 5;

            CbxBebida.Items.Add(OpcionPorDefecto);
            CbxBebida.Items.Add(AguaMinOpcion);
            CbxBebida.Items.Add(AguacocoOpcion);
            CbxBebida.Items.Add(SangriaOpcion);
            CbxBebida.Items.Add(TeOpcion);
            CbxBebida.Items.Add(CervezaOpcion);
            CbxBebida.SelectedItem = OpcionPorDefecto;           
        }
        private void selectOpcionCBx()
        {
            bool isvalid = true;
            try
            {
                ComboBoxItem SeleccionarEntrada = CbxEntrada.SelectedItem as ComboBoxItem;
                ComboBoxItem SeleccionarPlatoFuerte = CbxPlatoFuerte.SelectedItem as ComboBoxItem;
                ComboBoxItem SeleccionarBebida = CbxBebida.SelectedItem as ComboBoxItem;
                ComboBoxItem SeleccionarPostre = CbxPostre.SelectedItem as ComboBoxItem;

                if (string.IsNullOrEmpty(TxtNombre.Text) || (TxtNombre.Text == "Ingrese nombre:"))
                {
                    MessageBox.Show("Debe ingresar un Nombre", "Advertencia");
                    isvalid = false;
                }
                else if (SeleccionarEntrada.Value == null)
                {
                    MessageBox.Show("Debe seleccionar una Entrada", "Advertencia");
                    isvalid = false;
                }
                else if (SeleccionarPlatoFuerte.Value == null)
                {
                    MessageBox.Show("Debe seleccionar un Plato Fuerte", "Advertencia");
                    isvalid = false;
                }
                else if (SeleccionarBebida.Value == null)
                {
                    MessageBox.Show("Debe seleccionar una Bebida", "Advertencia");
                    isvalid = false;
                }
                else if (SeleccionarPostre.Value == null)
                {
                    MessageBox.Show("Debe seleccionar un Postre", "Advertencia");
                    isvalid = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Debe colocar un Nombre sin valores numericos", "Advertencia");
            }
            if (isvalid)
            {
                FrmOrdenesRealizadas.Instancia.actualizarLboxOrdenes(TxtNombre.Text, CbxEntrada.Text, CbxPlatoFuerte.Text, CbxBebida.Text, CbxPostre.Text);
                LblInfoCantidad.Text = Convert.ToString(--FrmCantidadPersonas.Cantidad);

                LimpiarCampos();
                if (FrmCantidadPersonas.Cantidad == 0)
                {
                    Instancia.Hide();
                    FrmOrdenesRealizadas.Instancia.Show();
                }
            }
        }
        public void LimpiarCampos()
        {           
            TxtNombre.Text ="Ingrese nombre:";
            CbxEntrada.Items.Clear();
            CbxPlatoFuerte.Items.Clear();
            CbxPostre.Items.Clear();
            CbxBebida.Items.Clear();
            LoadCombobox();           
        }
    }
}
