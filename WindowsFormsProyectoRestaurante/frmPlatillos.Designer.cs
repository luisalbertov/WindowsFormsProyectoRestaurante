﻿namespace WindowsFormsProyectoRestaurante
{
    partial class frmPlatillos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClavePlatillo = new System.Windows.Forms.Label();
            this.txtClavePlatillo = new System.Windows.Forms.TextBox();
            this.ErrorPPlatillos = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTPlatillos = new System.Windows.Forms.ToolTip(this.components);
            this.txtImportePlatillo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.numUpTiempo = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.DataGPlatillos = new System.Windows.Forms.DataGridView();
            this.ClvPlatillo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPPlatillos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGPlatillos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta De Platillos";
            // 
            // lblClavePlatillo
            // 
            this.lblClavePlatillo.AutoSize = true;
            this.lblClavePlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClavePlatillo.Location = new System.Drawing.Point(27, 76);
            this.lblClavePlatillo.Name = "lblClavePlatillo";
            this.lblClavePlatillo.Size = new System.Drawing.Size(124, 16);
            this.lblClavePlatillo.TabIndex = 1;
            this.lblClavePlatillo.Text = "Clave De Platillo";
            // 
            // txtClavePlatillo
            // 
            this.txtClavePlatillo.BackColor = System.Drawing.SystemColors.Control;
            this.txtClavePlatillo.Location = new System.Drawing.Point(26, 95);
            this.txtClavePlatillo.Name = "txtClavePlatillo";
            this.txtClavePlatillo.ReadOnly = true;
            this.txtClavePlatillo.Size = new System.Drawing.Size(137, 20);
            this.txtClavePlatillo.TabIndex = 10;
            this.toolTPlatillos.SetToolTip(this.txtClavePlatillo, "Clave Del Platillo");
            this.txtClavePlatillo.TextChanged += new System.EventHandler(this.txtClavePlatillo_TextChanged);
            // 
            // ErrorPPlatillos
            // 
            this.ErrorPPlatillos.ContainerControl = this;
            // 
            // txtImportePlatillo
            // 
            this.txtImportePlatillo.CausesValidation = false;
            this.txtImportePlatillo.Location = new System.Drawing.Point(26, 203);
            this.txtImportePlatillo.Name = "txtImportePlatillo";
            this.txtImportePlatillo.Size = new System.Drawing.Size(140, 20);
            this.txtImportePlatillo.TabIndex = 1;
            this.txtImportePlatillo.Text = "0";
            this.toolTPlatillos.SetToolTip(this.txtImportePlatillo, "Costo Del Platillo");
            this.txtImportePlatillo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImportePlatillo_KeyPress);
            this.txtImportePlatillo.Validating += new System.ComponentModel.CancelEventHandler(this.txtImportePlatillo_Validating);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(12, 293);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 34);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.toolTPlatillos.SetToolTip(this.btnRegistrar, "Click Para Registrar");
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(130, 293);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 34);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.toolTPlatillos.SetToolTip(this.btnSalir, "Click Para Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // numUpTiempo
            // 
            this.numUpTiempo.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpTiempo.Location = new System.Drawing.Point(26, 255);
            this.numUpTiempo.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numUpTiempo.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpTiempo.Name = "numUpTiempo";
            this.numUpTiempo.Size = new System.Drawing.Size(140, 20);
            this.numUpTiempo.TabIndex = 2;
            this.numUpTiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTPlatillos.SetToolTip(this.numUpTiempo, "Tiempo De Preparacion En Minutos");
            this.numUpTiempo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numUpTiempo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CausesValidation = false;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(26, 149);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(137, 20);
            this.txtDescripcion.TabIndex = 0;
            this.toolTPlatillos.SetToolTip(this.txtDescripcion, "Ingrese Descripcion Del Platillo");
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            this.txtDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescripcion_Validating);
            // 
            // DataGPlatillos
            // 
            this.DataGPlatillos.AllowUserToAddRows = false;
            this.DataGPlatillos.AllowUserToDeleteRows = false;
            this.DataGPlatillos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGPlatillos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGPlatillos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClvPlatillo,
            this.DescripcionP,
            this.Importe,
            this.Tiempo});
            this.DataGPlatillos.Location = new System.Drawing.Point(228, 61);
            this.DataGPlatillos.Name = "DataGPlatillos";
            this.DataGPlatillos.ReadOnly = true;
            this.DataGPlatillos.Size = new System.Drawing.Size(467, 275);
            this.DataGPlatillos.TabIndex = 11;
            this.toolTPlatillos.SetToolTip(this.DataGPlatillos, "Menu De Platillos Agregados");
            // 
            // ClvPlatillo
            // 
            this.ClvPlatillo.HeaderText = "Clave De Platillo";
            this.ClvPlatillo.Name = "ClvPlatillo";
            this.ClvPlatillo.ReadOnly = true;
            // 
            // DescripcionP
            // 
            this.DescripcionP.HeaderText = "Descripcion";
            this.DescripcionP.Name = "DescripcionP";
            this.DescripcionP.ReadOnly = true;
            this.DescripcionP.Width = 120;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe Del Platillo";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo De Preperacion";
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.ReadOnly = true;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(27, 185);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(131, 15);
            this.lblImporte.TabIndex = 3;
            this.lblImporte.Text = "Importe Del Platillo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(27, 130);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 16);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tiempo De Preparacion";
            // 
            // frmPlatillos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 336);
            this.ControlBox = false;
            this.Controls.Add(this.DataGPlatillos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numUpTiempo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtImportePlatillo);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.txtClavePlatillo);
            this.Controls.Add(this.lblClavePlatillo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlatillos";
            this.Text = "Alta De Platillos";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPPlatillos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGPlatillos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClavePlatillo;
        private System.Windows.Forms.TextBox txtClavePlatillo;
        private System.Windows.Forms.ErrorProvider ErrorPPlatillos;
        private System.Windows.Forms.TextBox txtImportePlatillo;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.ToolTip toolTPlatillos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpTiempo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView DataGPlatillos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClvPlatillo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
    }
}