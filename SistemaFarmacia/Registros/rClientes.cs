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

namespace SistemaFarmacia.Registros
{
    public partial class rClientes : Form
    {
        public rClientes()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            ClientesIdNumericUpDown.Value = 0;
            NombresTextBox.Text = string.Empty;
            CedulaTextBox.Text = string.Empty;
            TelefonoTextBox.Text = string.Empty;
            CelularTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            
        }
        
        private Clientes LlenarClase()
        {
            Clientes clientes = new Clientes();
            clientes.ClientesId = (int)ClientesIdNumericUpDown.Value;
            clientes.Nombres = NombresTextBox.Text;
            clientes.Cedula = CedulaTextBox.Text;
            clientes.Telefono = TelefonoTextBox.Text;
            clientes.Celular = CedulaTextBox.Text;
            clientes.Direccion = DireccionTextBox.Text;
           

            return clientes;

        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Repositorio<Clientes> db = new Repositorio<Clientes>();
            Clientes clientes = db.Buscar((int)ClientesIdNumericUpDown.Value);

            return (clientes != null);

        }
        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (NombresTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombresTextBox, "El campo Nombre no puede estar vacio");
                NombresTextBox.Focus();

                paso = false;
            }
            if (CedulaTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(CedulaTextBox, "El campo Cedula no puede estar vacio");
                CedulaTextBox.Focus();

                paso = false;
            }
            if (TelefonoTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(TelefonoTextBox, "El campo Telefono no puede estar vacio");
                TelefonoTextBox.Focus();

                paso = false;
            }
            if (CelularTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(CelularTextBox, "El campo Celular no puede estar vacio");
                CelularTextBox.Focus();

                paso = false;
            }
            if (DireccionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DireccionTextBox, "El campo Direccion no puede estar vacio");
                DireccionTextBox.Focus();

                paso = false;
            }
            

            return paso;
        }
        private void LlenarCampo(Clientes clientes)
        {
            ClientesIdNumericUpDown.Value = clientes.ClientesId;
            NombresTextBox.Text = clientes.Nombres;
            CedulaTextBox.Text = clientes.Cedula;
            TelefonoTextBox.Text = clientes.Telefono;
            CelularTextBox.Text = clientes.Celular;
            DireccionTextBox.Text = clientes.Direccion;      

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if(!Validar())
                return;
            bool paso = false;
            Repositorio<Clientes> dbe = new  Repositorio<Clientes>();
            Clientes clientes = new Clientes ();

            clientes = LlenarClase();


            if (ClientesIdNumericUpDown.Value == 0)
            {
                paso = dbe.Guardar(clientes);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show(" No se puede modificar un cliente que no existe ", " Fallo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = dbe.Modificar(clientes);
            }

            if(paso)
                MessageBox.Show(" Guardado !! ", " Exito ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(" No fue posible guardar !! ", " Fallo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Repositorio < Clientes> db = new Repositorio<Clientes>();
            MyErrorProvider.Clear();
            int id;
            int.TryParse(ClientesIdNumericUpDown.Text, out id);

            Limpiar();

            if (db.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(ClientesIdNumericUpDown, "No se puede eliminar un Cliente que no existe");

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Clientes clientes = new Clientes();
            Repositorio<Clientes> db = new Repositorio<Clientes>();
            int.TryParse(ClientesIdNumericUpDown.Text, out id);
            Limpiar();
            clientes = db.Buscar(id);

            if (clientes != null)
            {
                LlenarCampo(clientes);
            }
            else
                MessageBox.Show("Cliente no encontrado");




        }
    }
}

