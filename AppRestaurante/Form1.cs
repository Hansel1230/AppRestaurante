﻿using System;
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

        private FomMesas()
        {
            InitializeComponent();
        }
        private void FomMesas_Load(object sender, EventArgs e)
        {

        }
        private void BtnMesa1_Click(object sender, EventArgs e)
        {
            Instancia.Hide();
            FrmCantidadPersonas.Instancia.Show();
        }
    }
}
