﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFarmacia.Registros;
using SistemaFarmacia.Consultas;

namespace SistemaFarmacia
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ConsultaDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cUsuarios cusuario = new cUsuarios();
            cusuario.Show();
        }

        private void RegistroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios rusuario = new rUsuarios();
            rusuario.Show();
        }

        private void RegistroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes clientes = new rClientes();
            clientes.Show();
        }

        private void RegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RegistroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductos rProductos = new rProductos();
            rProductos.Show();

        }

        private void RegistroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVentas rVentas = new rVentas();
            rVentas.Show();

        }

        private void ConsultaDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cVentas cVentas = new cVentas();
            cVentas.Show();


        }

        private void ConsultaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cCliente cCliente = new cCliente();
            cCliente.Show();

        }

        private void ConsultaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cProducto cProducto = new cProducto();
            cProducto.Show();

        }
    }
}
