using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuyitosWeb.DALC;

namespace YuyitosWeb.Negocio
{
    public class Boleta
    {

        public decimal N_boleta { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
        public decimal VentasId { get; set; }

        public Registro_ventas Registro_ventas { get; set; }

        YuyitosWebEntities db = new YuyitosWebEntities();

        public List<Boleta> ReadAll()
        {
            return this.db.BOLETA.Select(b => new Boleta()
            {

                N_boleta = b.N_BOLETA,
                Producto = b.PRODUCTO,
                Precio = b.PRECIO,
                Cantidad = b.CANTIDAD,
                Total = b.TOTAL,
                Fecha = b.FECHA,
                VentasId = b.VENTAS_FK,
                Registro_ventas = new Registro_ventas()
                {
                    Id_venta = b.VENTAS_FK, 
                    Cantidad  = b.REGISTRO_VENTAS.CANTIDAD,
                    Total = b.REGISTRO_VENTAS.TOTAL,
                    Fecha_venta = b.REGISTRO_VENTAS.FECHA_VENTA,
                    Cliente_fiado = b.REGISTRO_VENTAS.CLIENTE_FIADO,
                    ProductoId = b.REGISTRO_VENTAS.PRODUCTO_FK
                }
            }).ToList();
        }




    }
}
