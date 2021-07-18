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
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.LblOrdenesRealizadas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LboxOrdenes, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
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
            this.LboxOrdenes.Location = new System.Drawing.Point(3, 223);
            this.LboxOrdenes.Name = "LboxOrdenes";
            this.LboxOrdenes.Size = new System.Drawing.Size(735, 324);
            this.LboxOrdenes.TabIndex = 1;
            // 
            // FrmOrdenesRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmOrdenesRealizadas";
            this.Text = "Ordenes Realizadas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOrdenesRealizadas_FormClosed);
            this.Load += new System.EventHandler(this.FrmOrdenesRealizadas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblOrdenesRealizadas;
        private System.Windows.Forms.ListBox LboxOrdenes;
    }
}