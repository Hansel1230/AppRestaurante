﻿namespace AppRestaurante
{
    partial class FrmOrdenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LblPostre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblPlatoFuerte = new System.Windows.Forms.Label();
            this.LblEntrada = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CbxPostre = new System.Windows.Forms.ComboBox();
            this.CbxBebida = new System.Windows.Forms.ComboBox();
            this.CbxPlatoFuerte = new System.Windows.Forms.ComboBox();
            this.CbxEntrada = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblOrden = new System.Windows.Forms.Label();
            this.LblInfoCantPersonas = new System.Windows.Forms.Label();
            this.LblInfoCantidad = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.18382F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.81618F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnGuardar, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnCancelar, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblOrden, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblInfoCantPersonas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblInfoCantidad, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.61628F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.56395F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67442F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 688);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.LblPostre, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.LblPlatoFuerte, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.LblEntrada, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LblNombre, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 222);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(365, 315);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // LblPostre
            // 
            this.LblPostre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPostre.AutoSize = true;
            this.LblPostre.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPostre.Location = new System.Drawing.Point(285, 252);
            this.LblPostre.Name = "LblPostre";
            this.LblPostre.Size = new System.Drawing.Size(77, 28);
            this.LblPostre.TabIndex = 4;
            this.LblPostre.Text = "Postre:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bebida:";
            // 
            // LblPlatoFuerte
            // 
            this.LblPlatoFuerte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPlatoFuerte.AutoSize = true;
            this.LblPlatoFuerte.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlatoFuerte.Location = new System.Drawing.Point(231, 126);
            this.LblPlatoFuerte.Name = "LblPlatoFuerte";
            this.LblPlatoFuerte.Size = new System.Drawing.Size(131, 28);
            this.LblPlatoFuerte.TabIndex = 2;
            this.LblPlatoFuerte.Text = "Plato Fuerte:";
            // 
            // LblEntrada
            // 
            this.LblEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEntrada.AutoSize = true;
            this.LblEntrada.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEntrada.Location = new System.Drawing.Point(268, 63);
            this.LblEntrada.Name = "LblEntrada";
            this.LblEntrada.Size = new System.Drawing.Size(94, 28);
            this.LblEntrada.TabIndex = 1;
            this.LblEntrada.Text = "Entrada:";
            this.LblEntrada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(271, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(91, 28);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.CbxPostre, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.CbxBebida, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.CbxPlatoFuerte, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.CbxEntrada, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.TxtNombre, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(374, 222);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(363, 315);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // CbxPostre
            // 
            this.CbxPostre.Dock = System.Windows.Forms.DockStyle.Top;
            this.CbxPostre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPostre.FormattingEnabled = true;
            this.CbxPostre.Location = new System.Drawing.Point(3, 255);
            this.CbxPostre.Name = "CbxPostre";
            this.CbxPostre.Size = new System.Drawing.Size(357, 21);
            this.CbxPostre.TabIndex = 9;
            // 
            // CbxBebida
            // 
            this.CbxBebida.Dock = System.Windows.Forms.DockStyle.Top;
            this.CbxBebida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxBebida.FormattingEnabled = true;
            this.CbxBebida.Location = new System.Drawing.Point(3, 192);
            this.CbxBebida.Name = "CbxBebida";
            this.CbxBebida.Size = new System.Drawing.Size(357, 21);
            this.CbxBebida.TabIndex = 8;
            // 
            // CbxPlatoFuerte
            // 
            this.CbxPlatoFuerte.Dock = System.Windows.Forms.DockStyle.Top;
            this.CbxPlatoFuerte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxPlatoFuerte.FormattingEnabled = true;
            this.CbxPlatoFuerte.Location = new System.Drawing.Point(3, 129);
            this.CbxPlatoFuerte.Name = "CbxPlatoFuerte";
            this.CbxPlatoFuerte.Size = new System.Drawing.Size(357, 21);
            this.CbxPlatoFuerte.TabIndex = 7;
            // 
            // CbxEntrada
            // 
            this.CbxEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.CbxEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEntrada.FormattingEnabled = true;
            this.CbxEntrada.Location = new System.Drawing.Point(3, 66);
            this.CbxEntrada.Name = "CbxEntrada";
            this.CbxEntrada.Size = new System.Drawing.Size(357, 21);
            this.CbxEntrada.TabIndex = 6;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtNombre.Location = new System.Drawing.Point(3, 3);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(357, 20);
            this.TxtNombre.TabIndex = 10;
            this.TxtNombre.Click += new System.EventHandler(this.TxtNombre_Click);
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged_1);
            this.TxtNombre.Enter += new System.EventHandler(this.TxtNombre_Enter);
            this.TxtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            this.TxtNombre.MouseLeave += new System.EventHandler(this.TxtNombre_MouseLeave);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGuardar.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Red;
            this.BtnGuardar.Location = new System.Drawing.Point(3, 543);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(365, 102);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCancelar.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Red;
            this.BtnCancelar.Location = new System.Drawing.Point(374, 543);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(363, 102);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblOrden
            // 
            this.LblOrden.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblOrden.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LblOrden, 2);
            this.LblOrden.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrden.ForeColor = System.Drawing.Color.Maroon;
            this.LblOrden.Location = new System.Drawing.Point(307, 40);
            this.LblOrden.Name = "LblOrden";
            this.LblOrden.Size = new System.Drawing.Size(125, 49);
            this.LblOrden.TabIndex = 4;
            this.LblOrden.Text = "Orden";
            this.LblOrden.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblInfoCantPersonas
            // 
            this.LblInfoCantPersonas.AutoSize = true;
            this.LblInfoCantPersonas.BackColor = System.Drawing.Color.Red;
            this.LblInfoCantPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoCantPersonas.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LblInfoCantPersonas.Location = new System.Drawing.Point(3, 0);
            this.LblInfoCantPersonas.Name = "LblInfoCantPersonas";
            this.LblInfoCantPersonas.Size = new System.Drawing.Size(234, 16);
            this.LblInfoCantPersonas.TabIndex = 1;
            this.LblInfoCantPersonas.Text = "Cantidad de Personas restantes:";
            // 
            // LblInfoCantidad
            // 
            this.LblInfoCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblInfoCantidad.AutoSize = true;
            this.LblInfoCantidad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoCantidad.Location = new System.Drawing.Point(185, 20);
            this.LblInfoCantidad.Name = "LblInfoCantidad";
            this.LblInfoCantidad.Size = new System.Drawing.Size(0, 19);
            this.LblInfoCantidad.TabIndex = 5;
            // 
            // FrmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(740, 688);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmOrdenes";
            this.Text = "Ordenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOrdenes_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOrdenes_FormClosed);
            this.Load += new System.EventHandler(this.FrmOrdenes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblPostre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblPlatoFuerte;
        private System.Windows.Forms.Label LblEntrada;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.ComboBox CbxPostre;
        private System.Windows.Forms.ComboBox CbxBebida;
        private System.Windows.Forms.ComboBox CbxPlatoFuerte;
        private System.Windows.Forms.ComboBox CbxEntrada;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblOrden;
        private System.Windows.Forms.Label LblInfoCantPersonas;
        private System.Windows.Forms.Label LblInfoCantidad;
    }
}