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
    public partial class cProducto : Form
    {
        public cProducto()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

                var lista = new List<Productos>();
                Repositorio<Productos> dbe = new Repositorio<Productos>();
                try
                {
                    if (CriterioTextBox.Text.Trim().Length > 0)
                    {
                        switch (FiltroComboBox.Text)
                        {
                            case "Todo":
                                lista = dbe.GetList(p => true);
                                break;

                            case "ProductoId":
                                int id = Convert.ToInt32(CriterioTextBox.Text);
                                lista = dbe.GetList(p => p.ProductoId == id);
                                break;

                            case "Descripcion":
                                lista = dbe.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
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
