using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuyitosWeb.DALC;

namespace YuyitosWeb.Negocio
{
    public class Registro_ventas
    {

        public decimal Id_venta { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha_venta { get; set; }
        public string Cliente_fiado { get; set; }
        public decimal ProductoId { get; set; }

        public Producto Producto { get; set; }

        YuyitosWebEntities db = new YuyitosWebEntities();

        public List<Registro_ventas> ReadAll()
        {
            return this.db.REGISTRO_VENTAS.Select(r => new Registro_ventas()
            {
                
                Id_venta = r.ID_VENTA,
                Cantidad = r.CANTIDAD,
                Total = r.TOTAL,
                Fecha_venta = r.FECHA_VENTA,
                Cliente_fiado = r.CLIENTE_FIADO,
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
                    Stock_critico = r.PRODUCTO.STOCK_CRITICO,
                    MarcaId = r.PRODUCTO.MARCA_FK,
                    TipoId = r.PRODUCTO.TIPO_FK,
                    ProveedorId = r.PRODUCTO.PROVEEDOR_FK
                }

            }).ToList();
        }


        public bool Save()
        {
            try
            {
                db.SP_INGRESAR_REGISTRO_VENTA(this.Cantidad, this.Fecha_venta, this.Cliente_fiado, this.ProductoId);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
