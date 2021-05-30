using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuyitosWeb.DALC;

namespace YuyitosWeb.Negocio
{
    public class Recepcion
    {
        public decimal N_recepcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Total { get; set; }
        public decimal OrdenId { get; set; }
        public decimal ProductoId { get; set; }

        public Orden_pedido Orden_pedido { get; set; }
        public Producto Producto { get; set; }

        YuyitosWebEntities db = new YuyitosWebEntities();

        public List<Recepcion> ReadAll()
        {
            return this.db.RECEPCION.Select(r => new Recepcion()
            {
                N_recepcion = r.N_RECEPCION,
                Cantidad = r.CANTIDAD,
                Total = r.TOTAL,
                OrdenId = r.ORDEN_FK,
                Orden_pedido = new Orden_pedido()
                {
                    Id_pedido = r.ORDEN_FK,
                    Fecha_pedido = r.ORDEN_PEDIDO.FECHA_PEDIDO,
                    Cantidad = r.ORDEN_PEDIDO.CANTIDAD,
                    Estado = r.ORDEN_PEDIDO.ESTADO,
                    ProductoId = r.ORDEN_PEDIDO.PRODUCTO_FK,
                    ProveedorId = r.ORDEN_PEDIDO.PROVEEDOR_FK
                },
                ProductoId = r.PRODUCTO_FK,
                Producto = new Producto()
                {
                    Id_producto = r.PRODUCTO_FK,
                    Nombre_producto = r.PRODUCTO.NOMBRE_PRODUCTO,
                    Descripcion = r.PRODUCTO.DESCRIPCION,
                    Precio_compra = r.PRODUCTO.PRECIO_COMPRA,
                    Precio_venta = r.PRODUCTO.PRECIO_VENTA,
                    Fecha_elab = r.PRODUCTO.FECHA_ELAB,
                    Fecha_venc = r.PRODUCTO.FECHA_VENC,
                    Stock = r.PRODUCTO.STOCK,
                    MarcaId = r.PRODUCTO.MARCA_FK,
                    TipoId = r.PRODUCTO.TIPO_FK,
                    ProveedorId = r.PRODUCTO.PROVEEDOR_FK
                }
            }).ToList();
        }
    }
}
