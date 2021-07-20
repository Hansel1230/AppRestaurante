namespace AppRestaurante
{
    partial class FrmOrdenesRealizadas
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
            this.LblOrdenesRealizadas = new System.Windows.Forms.Label();
            this.LboxOrdenes = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LblOrdenesRealizadas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LboxOrdenes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.63636F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.09091F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(741, 550);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LblOrdenesRealizadas
            // 
            this.LblOrdenesRealizadas.AutoSize = true;
            this.LblOrdenesRealizadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblOrdenesRealizadas.Font = new System.Drawing.Font("Palatino Linotype", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrdenesRealizadas.ForeColor = System.Drawing.Color.Maroon;
            this.LblOrdenesRealizadas.Location = new System.Drawing.Point(3, 0);
            this.LblOrdenesRealizadas.Name = "LblOrdenesRealizadas";
            this.LblOrdenesRealizadas.Size = new System.Drawing.Size(735, 85);
            this.LblOrdenesRealizadas.TabIndex = 0;
            this.LblOrdenesRealizadas.Text = "Ordenes Realizadas";
            this.LblOrdenesRealizadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LboxOrdenes
            // 
            this.LboxOrdenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LboxOrdenes.FormattingEnabled = true;
            this.LboxOrdenes.Location = new System.Drawing.Point(3, 186);
            this.LboxOrdenes.Name = "LboxOrdenes";
            this.LboxOrdenes.Size = new System.Drawing.Size(735, 288);
            this.LboxOrdenes.TabIndex = 1;
            this.LboxOrdenes.SelectedIndexChanged += new System.EventHandler(this.LboxOrdenes_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.65986F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.34014F));
            this.tableLayoutPanel2.Controls.Add(this.BtnVolver, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnSalir, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 480);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(735, 67);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BtnVolver.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVolver.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.Color.Maroon;
            this.BtnVolver.Location = new System.Drawing.Point(3, 3);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(358, 41);
            this.BtnVolver.TabIndex = 0;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.Maroon;
            this.BtnSalir.Location = new System.Drawing.Point(367, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(365, 41);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmOrdenesRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmOrdenesRealizadas";
            this.Text = "Ordenes Realizadas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOrdenesRealizadas_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOrdenesRealizadas_FormClosed);
            this.Load += new System.EventHandler(this.FrmOrdenesRealizadas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblOrdenesRealizadas;
        private System.Windows.Forms.ListBox LboxOrdenes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnSalir;
    }
}