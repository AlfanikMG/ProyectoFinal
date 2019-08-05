using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidades;



namespace SistemaFarmacia.Registros
{
    public partial class rProducto : Form
    {
        public rProducto()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            ProductoIdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            CostoNumericUpDown.Value = 0;
            PrecioNumericUpDown.Value = 0;
            GananciaNumericUpDown.Value = 0;
            ItbisNumericUpDown.Value = 0;
            DescuentoNumericUpDown.Value = 0;
         
        }
        private Productos LlenarClase()
        {
            Productos p = new Productos();
            p.ProductoId = (int)ProductoIdNumericUpDown.Value;
            p.Descripcion = DescripcionTextBox.Text;
            p.Costo = CostoNumericUpDown.Value;
            p.Precio = PrecioNumericUpDown.Value;
            p.Ganancia = GananciaNumericUpDown.Value;
            p.Itbis = ItbisNumericUpDown.Value;
            p.Descuento = DescuentoNumericUpDown.Value;

            return p;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Repositorio<Productos> db = new Repositorio<Productos>();
            Productos producto = db.Buscar((int)ProductoIdNumericUpDown.Value);
            return (producto != null);

        }
        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider1.Clear();

            if (DescripcionTextBox.Text == string.Empty)
            {
                MyerrorProvider1.SetError(DescuentoNumericUpDown, "El campo Descripcion no puede estar vacio");
                DescripcionTextBox.Focus();

                paso = false;
            }
            if (CostoNumericUpDown.Value == 0)
            {
                MyerrorProvider1.SetError(CostoNumericUpDown, "El campo Costo no puede estar vacio");
                CostoNumericUpDown.Focus();

                paso = false;
            }
            if (GananciaNumericUpDown.Value == 0)
            {
                MyerrorProvider1.SetError(GananciaNumericUpDown, "El campo Ganancia no puede estar vacio");
                GananciaNumericUpDown.Focus();

            }
            if (ExistenciaNumericUpDown.Value == 0)
            {
                MyerrorProvider1.SetError(ExistenciaNumericUpDown, "El campo Existencia no puede estar vacio");
                ExistenciaNumericUpDown.Focus();

            }
            if (ItbisNumericUpDown.Value == 0)
            {
                MyerrorProvider1.SetError(ItbisNumericUpDown, "El campo Itbis no puede estar vacio");
                ItbisNumericUpDown.Focus();

            }
            
            return paso;
        }
        private void LlenarCampo(Productos p)
        {
            ProductoIdNumericUpDown.Value = p.ProductoId;
            
            DescripcionTextBox.Text = p.Descripcion;
            CostoNumericUpDown.Value= p.Costo;
            PrecioNumericUpDown.Value = p.Precio;
            ExistenciaNumericUpDown.Value = p.Existencia;
            ItbisNumericUpDown.Value = p.Itbis;
            DescuentoNumericUpDown.Value = p.Descuento;

        }


        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            bool paso = false;
            Repositorio<Productos> db = new Repositorio<Productos>();
            Productos productos = new Productos();
            if (!Validar())
                return;

            productos = LlenarClase();
            if (ProductoIdNumericUpDown.Value == 0)
            {
                paso = db.Guardar(productos);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Producto que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Producto que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = db.Modificar(productos);
            }
            if (!ExisteEnLaBaseDeDatos())
            {
                if (paso)
                    MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (paso)
                    MessageBox.Show("Modificado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Productos> db = new Repositorio<Productos>();
            MyerrorProvider1.Clear();
            int id;
            int.TryParse(ProductoIdNumericUpDown.Text, out id);

            Limpiar();

            if (db.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyerrorProvider1.SetError(ProductoIdNumericUpDown, "No se puede eliminar un Cliente que no existe");

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Productos producto = new Productos();
            Repositorio<Productos> db = new Repositorio<Productos>();
            int.TryParse(ProductoIdNumericUpDown.Text, out id);
            Limpiar();
            producto = db.Buscar(id);

            if (producto != null)
            {
                LlenarCampo(producto);
            }
            else
                MessageBox.Show("Producto no encontrado");


        }
    }

    
        

       
   
}
