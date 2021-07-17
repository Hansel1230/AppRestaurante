using System;
using System.Windows.Forms;

namespace AppRestaurante
{
    partial class FrmCantidadPersonas
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
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblCantidadPersonas = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LblCantidadPersonas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblCantidad, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtCantidad, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnEnviar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnCancelar, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.37194F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.73942F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(581, 449);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // LblCantidad
            // 
            this.LblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(182, 112);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(105, 28);
            this.LblCantidad.TabIndex = 3;
            this.LblCantidad.Text = "Cantidad:";
            this.LblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCantidadPersonas
            // 
            this.LblCantidadPersonas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblCantidadPersonas.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LblCantidadPersonas, 2);
            this.LblCantidadPersonas.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadPersonas.ForeColor = System.Drawing.Color.Maroon;
            this.LblCantidadPersonas.Location = new System.Drawing.Point(126, 0);
            this.LblCantidadPersonas.Name = "LblCantidadPersonas";
            this.LblCantidadPersonas.Size = new System.Drawing.Size(328, 42);
            this.LblCantidadPersonas.TabIndex = 0;
            this.LblCantidadPersonas.Text = "Cantidad de personas";
            this.LblCantidadPersonas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblCantidadPersonas.Click += new System.EventHandler(this.LblCantidadPersonas_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(293, 115);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(285, 20);
            this.TxtCantidad.TabIndex = 5;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tableLayoutPanel1.SetColumnSpan(this.BtnEnviar, 2);
            this.BtnEnviar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnEnviar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEnviar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.ForeColor = System.Drawing.Color.Red;
            this.BtnEnviar.Location = new System.Drawing.Point(3, 227);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(575, 51);
            this.BtnEnviar.TabIndex = 6;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = false;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tableLayoutPanel1.SetColumnSpan(this.BtnCancelar, 2);
            this.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCancelar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Red;
            this.BtnCancelar.Location = new System.Drawing.Point(3, 304);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(575, 47);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmCantidadPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmCantidadPersonas";
            this.Text = "FrmCantidadPersonas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCantidadPersonas_FormClosed);
            this.Load += new System.EventHandler(this.FrmCantidadPersonas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblCantidadPersonas;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}