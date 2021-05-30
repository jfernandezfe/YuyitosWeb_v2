using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuyitosWeb.DALC;

namespace YuyitosWeb.Negocio
{
    public class Producto
    {

        public decimal Id_producto { get; set; }
        public string Nombre_producto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio_compra { get; set; }
        public decimal Precio_venta { get; set; }
        public DateTime Fecha_elab { get; set; }
        public DateTime Fecha_venc { get; set; }
        public decimal Stock { get; set; }
        public decimal Stock_critico { get; set; }
        public decimal MarcaId { get; set; }
        public decimal TipoId { get; set; }
        public string ProveedorId { get; set; }

        public Marca Marca { get; set; }
        public Tipo_producto Tipo_producto { get; set; }
        public Proveedor Proveedor { get; set; }

        YuyitosWebEntities db = new YuyitosWebEntities();

        public List<Producto> ReadAll() 
        {
            return this.db.PRODUCTO.Select(p => new Producto() 
            {
                Id_producto = p.ID_PRODUCTO,
                Nombre_producto = p.NOMBRE_PRODUCTO,
                Descripcion = p.DESCRIPCION,
                Precio_compra = p.PRECIO_COMPRA,
                Precio_venta = p.PRECIO_VENTA,
                Fecha_elab = p.FECHA_ELAB,
                Fecha_venc = p.FECHA_VENC,
                Stock = p.STOCK,
                Stock_critico = p.STOCK_CRITICO,
                MarcaId = p.MARCA_FK,
                Marca = new Marca()
                {
                    Id_marca = p.MARCA_FK,
                    Nombre_marca = p.MARCA.NOMBRE_MARCA
                },
                TipoId = p.TIPO_FK,
                Tipo_producto = new Tipo_producto()
                {
                    Id_tipo = p.TIPO_FK,
                    Nombre_tipo = p.TIPO_PRODUCTO.NOMBRE_TIPO
                },
                ProveedorId = p.PROVEEDOR_FK,
                Proveedor = new Proveedor()
                {
                    Rut_proveedor = p.PROVEEDOR_FK,
                    Nombre_proveedor = p.PROVEEDOR.NOMBRE_PROVEEDOR,
                    Telefono = (int)p.PROVEEDOR.TELEFONO,
                    Email = p.PROVEEDOR.EMAIL,
                    Razon_social = p.PROVEEDOR.RAZON_SOCIAL,
                    Direccion = p.PROVEEDOR.DIRECCION,
                    RubroId = p.PROVEEDOR.RUBRO_FK,
                    ComunaId = p.PROVEEDOR.COMUNA_FK,
                    RegionId = p.PROVEEDOR.REGION_FK

                }

            }).ToList();
        
        }

        public bool Save()
        {
            try
            {
                db.SP_INGRESAR_PRODUCTO(this.Nombre_producto, this.Descripcion, this.Precio_compra, 
                                        this.Precio_venta, this.Fecha_elab, this.Fecha_venc, this.Stock, this.Stock_critico,
                                        this.MarcaId, this.TipoId, this.ProveedorId);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }







    }
}
