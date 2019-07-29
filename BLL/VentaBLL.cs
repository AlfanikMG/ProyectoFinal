using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Data.Entity;

namespace BLL
{
    public class VentaBLL
    {
        public static bool Guardar(Ventas ventas)
        {
            bool paso = false;
            SistemaFarmaciaContexto db = new SistemaFarmaciaContexto();
            try
            {
                Repositorio<Productos> prod = new Repositorio<Productos>();
                if (db.Ventas.Add(ventas) != null)
                {

                    foreach (var item in ventas.Productos)
                    {
                        var producto = prod.Buscar(item.Id);
                        producto.Existencia = producto.Existencia - item.Cantidad;
                        prod.Modificar(producto);

                    }

                    paso = db.SaveChanges() > 0;



                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            SistemaFarmaciaContexto db = new SistemaFarmaciaContexto();
            Repositorio<Ventas> vent = new Repositorio<Ventas>();
            Repositorio<Productos> prod = new Repositorio<Productos>();


            try
            {
                var consulta = db.Ventas.Find(id);



                foreach (var item in consulta.Productos)
                {
                    var productos = prod.Buscar(item.Id);
                    productos.Existencia = productos.Existencia + item.Cantidad;
                    prod.Modificar(productos);

                }


                db.Entry(consulta).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }



        public static bool Modificar(Ventas ventas)
        {
            bool paso = false;
            SistemaFarmaciaContexto db = new SistemaFarmaciaContexto();
            Repositorio<Ventas> cons = new Repositorio<Ventas>();
            Repositorio<Productos> prod = new Repositorio<Productos>();
            try
            {
                var ventas1 = cons.Buscar(ventas.VentaId);



                if (ventas != null)
                {
                    foreach (var item in ventas1.Productos)
                    {
                        db.Productos.Find(item.Id).Existencia += item.Cantidad;

                        if (!ventas.Productos.ToList().Exists(v => v.Id == item.Id))
                        {

                            db.Entry(item).State = EntityState.Deleted;
                        }
                    }

                    foreach (var item in ventas.Productos)
                    {
                        db.Productos.Find(item.Id).Existencia -= item.Cantidad;
                        var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                        db.Entry(item).State = estado;
                    }

                    db.Entry(ventas).State = EntityState.Modified;
                }


                if (db.SaveChanges() > 0)
                {
                    paso = true;
                }
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

    }
}
