using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace BLL.Tests
{
    [TestClass()]
    public class RepositorioTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Usuarios> db = new Repositorio<Usuarios>();


            Usuarios us = new Usuarios()
            {
                UsuarioId = 1,
                Nombres = "alfanik",
                Email = "a@gmail.com",
                NivelUsuario = 1,
                Usuario = "Juan123",
                Clave = "12345",
                
                FechaIngreso = DateTime.Now
            };
            Assert.IsTrue(db.Guardar(us));
        }

        [TestMethod()]
        public void ModificarUsuariosTest()
        {
            Repositorio<Usuarios> db = new Repositorio<Usuarios>();


            Usuarios us = new Usuarios()
            {
                UsuarioId = 0,
                Nombres = "alfanik",
                Email = "j@gmail.com",
                NivelUsuario = 1,
                Usuario = "Juan123",
                Clave = "12345",

                FechaIngreso = DateTime.Now
            };
            Assert.IsTrue(db.Guardar(us));
        }

        [TestMethod()]
        public void BuscarUsuariosTest()
        {
            Repositorio<Usuarios> db = new Repositorio<Usuarios>();

            Assert.IsNotNull(db.Buscar(2));
        }

        [TestMethod()]
        public void GetListUsuariosTest()
        {
            Repositorio<Usuarios> db = new Repositorio<Usuarios>();

            Assert.IsNotNull(db.GetList(t => true));
        }


        [TestMethod()]
        public void EliminarUsuarioTest()
        {
            Repositorio<Usuarios> db = new Repositorio<Usuarios>();

            Assert.IsTrue(db.Eliminar(1));
        }

        //clientes
        [TestMethod()]
        public void GuardarClientesTest()
        {
            Repositorio<Clientes> db = new Repositorio<Clientes>();


            Clientes us = new Clientes()
            {
                ClientesId = 0,
                Nombres = "alfanik",
                Cedula = "000000000000",
                Telefono = "0000000000",
                Celular = "Juan123",
                Direccion = "sdfdsf",
            };
            Assert.IsTrue(db.Guardar(us));
        }

        [TestMethod()]
        public void ModificarClientesTest()
        {
            Repositorio<Clientes> db = new Repositorio<Clientes>();


            Clientes us = new Clientes()
            {
                ClientesId = 0,
                Nombres = "alfanik",
                Cedula = "000000000000",
                Telefono = "1110000000",
                Celular = "Juan123",
                Direccion = "sdfdsf",
            };
            Assert.IsTrue(db.Guardar(us));
        }

        [TestMethod()]
        public void BuscarClientesTest()
        {
            Repositorio<Clientes> db = new Repositorio<Clientes>();

            Assert.IsNotNull(db.Buscar(2));
        }

        [TestMethod()]
        public void GetListClientesTest()
        {
            Repositorio<Clientes> db = new Repositorio<Clientes>();

            Assert.IsNotNull(db.GetList(t => true));
        }


        [TestMethod()]
        public void EliminarClientesTest()
        {
            Repositorio<Clientes> db = new Repositorio<Clientes>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}