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
    public partial class rVentas : Form
    {   
        public List<ProductoDetalles> Detalle { get; set; }
        public rVentas()
        {
            this.Detalle = new List<ProductoDetalles>();
            InitializeComponent();
        }
        private void CargaGrid()
        {
            ProductoDataGridView.DataSource = null;
            ProductoDataGridView.DataSource = this.Detalle;
        }
        private void Limpiar()
        {
            VentaIdNumericUpDown.Value = 0;
            ClienteComboBox.Text = string.Empty;
            ValorNumericUpDown.Value = 0;
            DevueltaNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            PrecioNumericUpDown.Value = 0;
            ValorNumericUpDown.Value = 0;
            SubTotalNumericUpDown.Value = 0;
            ItbisNumericUpDown.Value = 0;
            TotalNumericUpDown.Value = 0;
        

        }
        private Ventas LlenarClase()
        {
            Ventas ventas = new Ventas();
            ventas.ClienteId = (int)VentaIdNumericUpDown.Value;
            ventas.Valor = ValorNumericUpDown.Value;
            ventas.Devuelta = DevueltaNumericUpDown.Value;
            ventas.Fecha = FechaDateTimePicker.Value;
            ventas.Precio = PrecioNumericUpDown.Value;
            ventas.Devuelta = DevueltaNumericUpDown.Value;
            ventas.SubTotal = SubTotalNumericUpDown.Value;
            ventas.Itbis = ItbisNumericUpDown.Value;
            ventas.Total = TotalNumericUpDown.Value;

            return ventas;
            
            
            
        }
        private bool Validar()
        {
            bool paso = true;
            paso = false;
            MyerrorProvider.Clear();

            if (ClienteComboBox.Text == string.Empty)
            {
                MyerrorProvider.SetError(ClienteComboBox, "Campo Cliente no puede estar vacio");
                paso = false;
            }
            if (ProductoComboBox.Text == string.Empty)
            {
                MyerrorProvider.SetError(ProductoComboBox, "Campo Producto no puede estar vacio");
                paso = false;
            }
            if (CantidadNumericUpDown.Value == 0)
            {
                MyerrorProvider.SetError(CantidadNumericUpDown, "Campo Cantidad no puede estar vacio");
                paso = false;
            }


            return paso;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();

        }
        private void LlenarCampo(Ventas ventas)
        {
            VentaIdNumericUpDown.Value = ventas.VentaId;
            ClienteComboBox.Text = ventas.ClienteId.ToString();
            ValorNumericUpDown.Value = ventas.VentaId;
            DevueltaNumericUpDown.Value = ventas.VentaId;
            FechaDateTimePicker.Value = ventas.Fecha;
            PrecioNumericUpDown.Value = ventas.Precio;
            DevueltaNumericUpDown.Value = ventas.Devuelta;
            SubTotalNumericUpDown.Value = ventas.SubTotal;
            ItbisNumericUpDown.Value = ventas.Itbis;
            TotalNumericUpDown.Value = ventas.Total;
            

      

        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Repositorio<Ventas> dbe = new Repositorio<Ventas>();
            Ventas ventas = dbe.Buscar((int)((int)VentaIdNumericUpDown.Value));
            return (ventas != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            bool paso = false;
            Repositorio<Ventas> dbe = new Repositorio<Ventas>();
            Ventas ventas = new Ventas();

            ventas = LlenarClase();

            if (VentaIdNumericUpDown.Value == 0)
            {
                paso = dbe.Guardar(ventas);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = dbe.Modificar(ventas);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Ventas> db = new Repositorio<Ventas>();
            MyerrorProvider.Clear();
            int id;
            int.TryParse(VentaIdNumericUpDown.Text, out id);

            Limpiar();

            if (db.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyerrorProvider.SetError(VentaIdNumericUpDown, "No se puede eliminar un rVenta que no existe");

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Ventas ventas = new Ventas();
            Repositorio<Ventas> db = new Repositorio<Ventas>();
            int.TryParse(VentaIdNumericUpDown.Text, out id);
            Limpiar();
            ventas = db.Buscar(id);

            if (ventas != null)
            {
                LlenarCampo(ventas);
            }
            else
                MessageBox.Show("Venta no encontrada");


        }

       
    }
}
