namespace AppRestaurante
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblOrdenes = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblEntrada = new System.Windows.Forms.Label();
            this.LblPlatoFuerte = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblPostre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtEntrada = new System.Windows.Forms.TextBox();
            this.TxtPlatoFuerte = new System.Windows.Forms.TextBox();
            this.TxtBebida = new System.Windows.Forms.TextBox();
            this.TxtPostre = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnGuardar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnCancelar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblOrdenes, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.56863F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.72675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.76163F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 688);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 151);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(365, 342);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.TxtPostre, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.TxtBebida, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.TxtPlatoFuerte, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.TxtEntrada, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.TxtNombre, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(374, 151);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(363, 342);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGuardar.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Red;
            this.BtnGuardar.Location = new System.Drawing.Point(3, 499);
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
            this.BtnCancelar.Location = new System.Drawing.Point(374, 499);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(363, 102);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // LblOrdenes
            // 
            this.LblOrdenes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblOrdenes.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LblOrdenes, 2);
            this.LblOrdenes.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrdenes.ForeColor = System.Drawing.Color.Maroon;
            this.LblOrdenes.Location = new System.Drawing.Point(307, 0);
            this.LblOrdenes.Name = "LblOrdenes";
            this.LblOrdenes.Size = new System.Drawing.Size(125, 49);
            this.LblOrdenes.TabIndex = 4;
            this.LblOrdenes.Text = "Orden";
            this.LblOrdenes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // LblEntrada
            // 
            this.LblEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEntrada.AutoSize = true;
            this.LblEntrada.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEntrada.Location = new System.Drawing.Point(268, 68);
            this.LblEntrada.Name = "LblEntrada";
            this.LblEntrada.Size = new System.Drawing.Size(94, 28);
            this.LblEntrada.TabIndex = 1;
            this.LblEntrada.Text = "Entrada:";
            this.LblEntrada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblPlatoFuerte
            // 
            this.LblPlatoFuerte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPlatoFuerte.AutoSize = true;
            this.LblPlatoFuerte.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlatoFuerte.Location = new System.Drawing.Point(231, 136);
            this.LblPlatoFuerte.Name = "LblPlatoFuerte";
            this.LblPlatoFuerte.Size = new System.Drawing.Size(131, 28);
            this.LblPlatoFuerte.TabIndex = 2;
            this.LblPlatoFuerte.Text = "Plato Fuerte:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bebida:";
            // 
            // LblPostre
            // 
            this.LblPostre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPostre.AutoSize = true;
            this.LblPostre.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPostre.Location = new System.Drawing.Point(285, 272);
            this.LblPostre.Name = "LblPostre";
            this.LblPostre.Size = new System.Drawing.Size(77, 28);
            this.LblPostre.TabIndex = 4;
            this.LblPostre.Text = "Postre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtNombre.Location = new System.Drawing.Point(3, 3);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(357, 20);
            this.TxtNombre.TabIndex = 0;
            // 
            // TxtEntrada
            // 
            this.TxtEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtEntrada.Location = new System.Drawing.Point(3, 71);
            this.TxtEntrada.Name = "TxtEntrada";
            this.TxtEntrada.Size = new System.Drawing.Size(357, 20);
            this.TxtEntrada.TabIndex = 1;
            // 
            // TxtPlatoFuerte
            // 
            this.TxtPlatoFuerte.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtPlatoFuerte.Location = new System.Drawing.Point(3, 139);
            this.TxtPlatoFuerte.Name = "TxtPlatoFuerte";
            this.TxtPlatoFuerte.Size = new System.Drawing.Size(357, 20);
            this.TxtPlatoFuerte.TabIndex = 2;
            // 
            // TxtBebida
            // 
            this.TxtBebida.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtBebida.Location = new System.Drawing.Point(3, 207);
            this.TxtBebida.Name = "TxtBebida";
            this.TxtBebida.Size = new System.Drawing.Size(357, 20);
            this.TxtBebida.TabIndex = 3;
            // 
            // TxtPostre
            // 
            this.TxtPostre.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtPostre.Location = new System.Drawing.Point(3, 275);
            this.TxtPostre.Name = "TxtPostre";
            this.TxtPostre.Size = new System.Drawing.Size(357, 20);
            this.TxtPostre.TabIndex = 4;
            // 
            // FrmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(740, 688);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmOrdenes";
            this.Text = "Ordenes";
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
        private System.Windows.Forms.Label LblOrdenes;
        private System.Windows.Forms.Label LblPostre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblPlatoFuerte;
        private System.Windows.Forms.Label LblEntrada;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtPostre;
        private System.Windows.Forms.TextBox TxtBebida;
        private System.Windows.Forms.TextBox TxtPlatoFuerte;
        private System.Windows.Forms.TextBox TxtEntrada;
        private System.Windows.Forms.TextBox TxtNombre;
    }
}