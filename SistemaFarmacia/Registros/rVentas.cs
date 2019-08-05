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
using SistemaFarmacia.Reportes;

namespace SistemaFarmacia.Registros
{
    public partial class rVentas : Form
    {   
        public List<ProductoDetalles> Detalle { get; set; }
        public rVentas()
        {
            InitializeComponent();
            this.Detalle = new List<ProductoDetalles>();
            ProductoComboBox.Text = null;

            LLenarClientes();
            LLenarProducto();
        }
        private void CargaGrid()
        {
            ProductoDataGridView.DataSource = null;
            ProductoDataGridView.DataSource = this.Detalle;
        }
        private void LlenarPrecio()
        {
            Repositorio<Productos> repositorio = new Repositorio<Productos>();
            List<Productos> lista = repositorio.GetList(c => c.Descripcion == ProductoComboBox.Text);
            foreach (var item in lista)
            {
                PrecioNumericUpDown.Value = item.Precio;
            }
        }

        private void LLenarClientes()
        {
            Repositorio<Clientes> db = new Repositorio<Clientes>(new DAL.SistemaFarmaciaContexto());
            var lista = new List<Clientes>();
            lista = db.GetList(l => true);
            ClienteComboBox.DataSource = lista;
            ClienteComboBox.DisplayMember = "Nombres";
            ClienteComboBox.ValueMember = "ClientesId";
        }

        private void LLenarProducto()
        {
            Repositorio<Productos> db = new Repositorio<Productos>(new DAL.SistemaFarmaciaContexto());
            var lista = new List<Productos>();
            lista = db.GetList(l => true);
            ProductoComboBox.DataSource = lista;
            ProductoComboBox.DisplayMember = "Descripcion";
            ProductoComboBox.ValueMember = "ProductoId";
        }
        private void Limpiar()
        {
            VentaIdNumericUpDown.Value = 0;
            ClienteComboBox.Text = string.Empty;
            FechaDateTimePicker.Value = DateTime.Now;
            PrecioNumericUpDown.Value = 0;
            SubTotalNumericUpDown.Value = 0;
            ItbisNumericUpDown.Value = 0;
            TotalNumericUpDown.Value = 0;
        

        }
        private Ventas LlenarClase()
        {
            Ventas ventas = new Ventas();
            ventas.ClienteId = (int)VentaIdNumericUpDown.Value;
            ventas.Valor = PrecioNumericUpDown.Value;
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


        private void LlenarCampo(Ventas ventas)
        {
            VentaIdNumericUpDown.Value = ventas.VentaId;
            ClienteComboBox.Text = ventas.ClienteId.ToString();
            PrecioNumericUpDown.Value = ventas.VentaId;
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
        public void CalcularItbis()
        {
            decimal itbis = 0;
            foreach (var item in Detalle)
            {
                itbis += item.Itbis;
            }
            ItbisNumericUpDown.Value = itbis;
         }
        public void CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in Detalle)
            {
                total += (item.Valor) + item.Itbis;
            }
           TotalNumericUpDown.Value = total;
        }

        public void CalcularSubtotal()
        {
            decimal subtotal = 0;
            foreach (var item in Detalle)
            {
                subtotal += item.Valor;
            }
            SubTotalNumericUpDown.Value = subtotal;
        }

        private bool Existe()
        {
            bool estado = false;
            List<ProductoDetalles> detalle = new List<ProductoDetalles>();

            if (ProductoDataGridView.DataSource != null)
            {
                detalle = (List<ProductoDetalles>)ProductoDataGridView.DataSource;
            }

            string descripcion = string.Empty;
            foreach (var item in detalle)
            {
                descripcion = item.Producto;
            }
            if (descripcion == ProductoComboBox.Text)
            {
                MessageBox.Show("Produco ha sido agregado!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                estado = true;
            }
            return estado;
        }
        
        public string id_mat;
        private bool ExisteEnGrid()
        {

            bool paso = true;

            if(ProductoDataGridView.RowCount > 0)
            {
                id_mat = ProductoComboBox.SelectedValue.ToString();
                for (int i = 0; i < ProductoDataGridView.RowCount; i++)
                {
                    if (Convert.ToInt16(ProductoDataGridView.Rows[i].Cells["Id"].Value) == Convert.ToInt16(id_mat))
                    {
                        MessageBox.Show("El Producto ya ha sido ingresado");
                        paso = false;

                    }
                }

            }

            return paso;

        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Ventas> repositorio = new Repositorio<Ventas>();
            Ventas venta;
            bool Paso = false;

            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos!!", "Validación!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //venta = LlenarClase();

           
            else
            {
                venta = LlenarClase();
                Repositorio<Ventas> repositorioD = new Repositorio<Ventas>();
                int id = Convert.ToInt32(VentaIdNumericUpDown.Value);
                Ventas ven = repositorioD.Buscar(id);

                if (ven != null)
                {
                    Paso = repositorioD.Modificar(venta);
                    MessageBox.Show("Modificado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Id no existe", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ReciboVentas ReciboVentas = new ReciboVentas();
            ReciboVentas.Show();

            if (Paso)
            {
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //if (!Validar())
            //    return;

            //bool paso = false;
            //Repositorio<Ventas> dbe = new Repositorio<Ventas>();
            //Ventas ventas = new Ventas();

            //ventas = LlenarClase();

            //if (VentaIdNumericUpDown.Value == 0)
            //{
            //    paso = VentaBLL.Guardar(ventas);
            //}
            //else
            //{
            //    if (!ExisteEnLaBaseDeDatos())
            //    {
            //        MessageBox.Show("No se puede modificar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    paso = VentaBLL.Modificar(ventas);
            //}
            //ReciboVentas ReciboVentas = new ReciboVentas();
            //ReciboVentas.Show();

            //if (paso)
            //    MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Limpiar();
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

        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ProductoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarPrecio();
            if (CantidadNumericUpDown.Text != "0")
            {
                //LlenarImporte();
            }
            LlenarPrecio();
        }  

       
        private void AgregarDetalleButton_Click(object sender, EventArgs e)
        {
            List<ProductoDetalles> detalles = new List<ProductoDetalles>();
            Repositorio<Ventas> db = new Repositorio<Ventas>(new DAL.SistemaFarmaciaContexto());
            if (ProductoDataGridView.DataSource != null)
                this.Detalle = (List<ProductoDetalles>)ProductoDataGridView.DataSource;

            if (Existe())
            {
                ProductoComboBox.Focus();
                return;
            }

            this.Detalle.Add(new ProductoDetalles()
            {
                Id = (int)ProductoComboBox.SelectedValue,
                VentaId = (int)VentaIdNumericUpDown.Value,
                Producto = ProductoComboBox.Text,
                Cantidad = (int)CantidadNumericUpDown.Value,
                Valor = PrecioNumericUpDown.Value * CantidadNumericUpDown.Value,
                Itbis = (PrecioNumericUpDown.Value * CantidadNumericUpDown.Value) * 0.18m,
            });

            CargaGrid();

            CalcularSubtotal();
            CalcularItbis();
            CalcularTotal();
            ProductoComboBox.Text = null;
            PrecioNumericUpDown.Value = 0;
            CantidadNumericUpDown.Value = 0;
        }

        private void NuevoProductoButton_Click(object sender, EventArgs e)
        {
            rProducto productos = new rProducto();
            productos.ShowDialog();
            LLenarProducto();


        }

        
    }
}
