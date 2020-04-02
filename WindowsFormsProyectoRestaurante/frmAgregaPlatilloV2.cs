﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProyectoRestaurante
{
    public partial class frmAgregaPlatilloV2 : Form
    {
        ListPlatillos listPlatillos;
        ListPlatillosPedidos lPLaPedidos;
        DictionaryPedidos dPedidos;
        AdministraMesa admMesa;
        int numPe, numMesa, numPla=0, op=1;
        public frmAgregaPlatilloV2(ListPlatillos lPlatillos, DictionaryPedidos dP, ListPlatillosPedidos lPlaPe, AdministraMesa aM)
        {
            InitializeComponent();
            listPlatillos = lPlatillos;
            lPLaPedidos = lPlaPe;
            dPedidos = dP;
            admMesa = aM;

        }
        public frmAgregaPlatilloV2(ListPlatillos lPlatillos, DictionaryPedidos dP, ListPlatillosPedidos lPlaPe, AdministraMesa aM, int numP, int numM, int op2)
        {
            InitializeComponent();
            listPlatillos = lPlatillos;
            lPLaPedidos = lPlaPe;
            dPedidos = dP;
            admMesa = aM;
            numPe = numP;
            numMesa = numM;
            op = op2;
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {   
            DialogResult result = MessageBox.Show("¿Estas Seguro De Salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            dtgvPlatillo.Rows.Remove(dtgvPlatillo.CurrentRow);
            int clavePla = Convert.ToInt32(dtgvPlatillo.CurrentRow.Cells[0].Value);
            numPla -= 1;
            lPLaPedidos.QuitarPlatillo(numPe, clavePla);
            dPedidos.QuitaPlatillo(numPe);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(numUpCantidad.Value.ToString());
            string desc = cmbDescripcion.SelectedItem.ToString();
            int clavePla = listPlatillos.NombreAClave(desc);

            double importe = listPlatillos.RegresaImporte(clavePla);
            int tiempo = listPlatillos.RegresaTiempo(clavePla);
            dtgvPlatillo.Rows.Add(desc,cant,importe,tiempo);
          
            numPla += cant;
            lPLaPedidos.AgregarPlatillo(numPe, clavePla, cant);
            dPedidos.AgregaPlatillo(numPe, cant);
        }

        private void frmAgregaPlatilloV2_Load(object sender, EventArgs e)
        {
            string[] numPedidos = dPedidos.arregloNumPedidos();
            for (int i = 0; i < numPedidos.Length; i++)
            {
                txtNumPedido.Text = numPedidos[i];
            }
            string[] descripcion = listPlatillos.arregloDescripcion();
            for (int i = 0; i < descripcion.Length; i++)
            {
                cmbDescripcion.Items.Add(descripcion[i]);
            }

            if (op != 1)
            { 
                txtNumPedido.Text= numPe.ToString();
                string nombreC = admMesa.RegresaNombreCliente(numMesa);
                lblNombre.Text = nombreC;
            }
        }
    }
}
