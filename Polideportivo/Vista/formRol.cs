﻿using Polideportivo.AccesoDatos;
using Polideportivo.Controlador;
using Polideportivo.Modelo;
using System;
using System.Windows.Forms;
using static Polideportivo.Vista.utilidadForms;

namespace Polideportivo.Vista
{
    public partial class formRol : Form
    {

       

        public formRol()
        {
            InitializeComponent();
        }

    
        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
          
        }

    

        private void btnModificarRol_Click(object sender, EventArgs e)
        {
            
        }

        private void btnElinimarRol_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarRol_Click(object sender, EventArgs e)
        {
           
        }

        private void tablaRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablaRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablaRol_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void formRol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vwRol.vwrol' Puede moverla o quitarla según sea necesario.
            this.vwrolTableAdapter.Fill(this.vwRol.vwrol);
            // TODO: esta línea de código carga datos en la tabla 'vwRol.vwrol' Puede moverla o quitarla según sea necesario.


        }

        private void txtNombreDeporte_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
