using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace SistemaFarmacia.Consultas
{
    public partial class cCliente : Form
    {
        public cCliente()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Clientes>();
            Repositorio<Clientes> dbe = new Repositorio<Clientes>();
            try
            {
                if (CriterioTextBox.Text.Trim().Length > 0)
                {
                    switch (FiltroComboBox.Text)
                    {
                        case "Todo":
                            lista = dbe.GetList(p => true);
                            break;

                        case "Id":
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            lista = dbe.GetList(p => p.ClientesId == id);
                            break;

                        case "Nombres":
                            lista = dbe.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                            break;


                        case "Cedula":
                            lista = dbe.GetList(p => p.Cedula.Contains(CriterioTextBox.Text));

                            break;

                        case "Direccion":
                            lista = dbe.GetList(p => p.Direccion.Contains(CriterioTextBox.Text));
                            break;

                        default:
                            break;
                    }

                }
                else
                {
                    lista = dbe.GetList(p => true);
                }
                UsuariosDataGridView.DataSource = null;
                UsuariosDataGridView.DataSource = lista;
            }
            catch (Exception)
            {
                MessageBox.Show("Introdujo un dato incorrecto");
            }
        }
    }
    
}
