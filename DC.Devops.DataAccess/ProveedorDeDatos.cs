using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DC.Devops.DataAccess
{
    public class ProveedorDeDatos
    {
        public IEnumerable<Producto> ConsultarProductosDesdeExcel()
        {
            var memoryStream = new MemoryStream(Recursos.Archivos.DatosDeLosProductos);
            return new ExcelMapper(memoryStream) { HeaderRow = true }.Fetch<Producto>();
        }
    }
}
