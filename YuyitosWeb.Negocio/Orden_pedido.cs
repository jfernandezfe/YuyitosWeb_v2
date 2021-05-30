using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuyitosWeb.DALC;

namespace YuyitosWeb.Negocio
{
    public class Orden_pedido
    {
        public decimal Id_pedido { get; set; }
        public DateTime Fecha_pedido { get; set; }
        public decimal Cantidad { get; set; }
        public string Estado { get; set; }
        public decimal ProductoId { get; set; }
        public string ProveedorId { get; set; }

        public Producto Producto { get; set; }
        public Proveedor Proveedor { get; set; }

        YuyitosWebEntities db = new YuyitosWebEntities();

        public List<Orden_pedido> ReadAll()
        {
            return this.db.ORDEN_PEDIDO.Select(o => new Orden_pedido() 
            {
                Id_pedido = o.ID_PEDIDO,
                Fecha_pedido = o.FECHA_PEDIDO,
                Cantidad = o.CANTIDAD,
                Estado = o.ESTADO,
                ProductoId = o.PRODUCTO_FK,
                Producto = new Producto()
                {
                    Id_producto = o.PRODUCTO_FK,
                    Nombre_producto = o.PRODUCTO.NOMBRE_PRODUCTO,
                    Descripcion = o.PRODUCTO.DESCRIPCION,
                    Precio_compra = o.PRODUCTO.PRECIO_COMPRA,
                    Precio_venta = o.PRODUCTO.PRECIO_VENTA,
                    Fecha_elab = o.PRODUCTO.FECHA_ELAB,
                    Fecha_venc = o.PRODUCTO.FECHA_VENC,
                    Stock = o.PRODUCTO.STOCK,
                    Stock_critico = o.PRODUCTO.STOCK_CRITICO,
                    MarcaId = o.PRODUCTO.MARCA_FK,
                    TipoId = o.PRODUCTO.TIPO_FK,
                    ProveedorId = o.PRODUCTO.PROVEEDOR_FK
                },
                ProveedorId = o.PROVEEDOR_FK,
                Proveedor = new Proveedor()
                {
                    Rut_proveedor = o.PROVEEDOR_FK,
                    Nombre_proveedor = o.PROVEEDOR.NOMBRE_PROVEEDOR,
                    Telefono = (int)o.PROVEEDOR.TELEFONO,
                    Email = o.PROVEEDOR.EMAIL,
                    Razon_social = o.PROVEEDOR.RAZON_SOCIAL,
                    Direccion = o.PROVEEDOR.DIRECCION,
                    RubroId = o.PROVEEDOR.RUBRO_FK,
                    ComunaId = o.PROVEEDOR.COMUNA_FK,
                    RegionId = o.PROVEEDOR.REGION_FK
                }


            }).ToList();
        }

        public bool Save()
        {
            try
            {
                db.SP_INGRESAR_ORDEN_PEDIDO(this.Fecha_pedido, this.Cantidad, this.Estado, this.ProductoId, this.ProveedorId);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }







    }
}
