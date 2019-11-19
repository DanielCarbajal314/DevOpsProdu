using System;
using System.Linq;
using DC.Devops.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DC.DevOps.DataAcess.Test
{
    [TestClass]
    public class ProveedorDeDatosTest
    {
        [TestMethod]
        public void Hay5ProductosEnElArchivo()
        {
            var proveedorDeDatos = new ProveedorDeDatos();
            var productos = proveedorDeDatos.ConsultarProductosDesdeExcel();
            Assert.AreEqual(5, productos.Count());
        }

        [TestMethod]
        public void LosIdsSonMayoresACero()
        {
            var proveedorDeDatos = new ProveedorDeDatos();
            proveedorDeDatos.ConsultarProductosDesdeExcel()
                .ToList()
                .ForEach(producto => Assert.IsTrue(producto.Id > 0));
        }
    }
}
