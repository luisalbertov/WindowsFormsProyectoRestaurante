﻿namespace WindowsFormsProyectoRestaurante
{
    partial class frmReportePlatilloPedido
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
            this.DataGReportePlaPed = new System.Windows.Forms.DataGridView();
            this.NumPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPlatillo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGReportePlaPed)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGReportePlaPed
            // 
            this.DataGReportePlaPed.AllowUserToAddRows = false;
            this.DataGReportePlaPed.AllowUserToDeleteRows = false;
            this.DataGReportePlaPed.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGReportePlaPed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGReportePlaPed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumPedido,
            this.NumPlatillo,
            this.Cantidad});
            this.DataGReportePlaPed.Location = new System.Drawing.Point(-1, 0);
            this.DataGReportePlaPed.Name = "DataGReportePlaPed";
            this.DataGReportePlaPed.ReadOnly = true;
            this.DataGReportePlaPed.Size = new System.Drawing.Size(343, 263);
            this.DataGReportePlaPed.TabIndex = 0;
            // 
            // NumPedido
            // 
            this.NumPedido.HeaderText = "Numero de Pedido";
            this.NumPedido.Name = "NumPedido";
            this.NumPedido.ReadOnly = true;
            // 
            // NumPlatillo
            // 
            this.NumPlatillo.HeaderText = "Numero de Platillo";
            this.NumPlatillo.Name = "NumPlatillo";
            this.NumPlatillo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // frmReportePlatilloPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 261);
            this.Controls.Add(this.DataGReportePlaPed);
            this.Name = "frmReportePlatilloPedido";
            this.Text = "Reporte Platillo Pedidos";
            this.Load += new System.EventHandler(this.frmReportePlatilloPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGReportePlaPed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGReportePlaPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPlatillo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}