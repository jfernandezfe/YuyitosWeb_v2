using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuyitosWeb.DALC;

namespace YuyitosWeb.Negocio
{
    public class Cliente
    {

        public string Rut_cliente { get; set; }
        public string Nombre_cliente { get; set; }
        public string Apellido_cliente { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Fiado { get; set; }
        public decimal ComunaId { get; set; }
        public decimal RegionId { get; set; }
        public decimal VentaId { get; set; }

        public Comuna Comuna { get; set; }
        public Region Region { get; set; }
        public Registro_ventas Registro_ventas { get; set; }

        YuyitosWebEntities db = new YuyitosWebEntities();

        public List<Cliente> ReadAll()
        {
            return this.db.CLIENTE.Select(c => new Cliente()
            {
                Rut_cliente = c.RUT_CLIENTE,
                Nombre_cliente = c.NOMBRE,
                Apellido_cliente = c.APELLIDO,
                Telefono = (int)c.TELEFONO,
                Email = c.EMAIL,
                Direccion = c.DIRECCION,
                Fiado = c.FIADO,
                ComunaId = c.COMUNA_FK,
                Comuna = new Comuna()
                {
                    Id_comuna = c.COMUNA_FK,
                    Nombre_comuna = c.COMUNA.NOMBRE_COMUNA
                },
                RegionId = c.REGION_FK,
                Region = new Region()
                {
                   Id_region = c.REGION_FK,
                   Nombre_region = c.REGION.NOMBRE_REGION
                },
                VentaId = c.VENTAS_FK,
                Registro_ventas = new Registro_ventas()
                {
                    Id_venta = c.VENTAS_FK,
                    Cantidad = c.REGISTRO_VENTAS.CANTIDAD,
                    Total = c.REGISTRO_VENTAS.TOTAL,
                    Fecha_venta = c.REGISTRO_VENTAS.FECHA_VENTA,
                    Cliente_fiado = c.REGISTRO_VENTAS.CLIENTE_FIADO,
                    ProductoId = c.REGISTRO_VENTAS.PRODUCTO_FK
                }

            }).ToList();
        }

    }
}
