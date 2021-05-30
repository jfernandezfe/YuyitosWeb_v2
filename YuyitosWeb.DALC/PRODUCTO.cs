//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YuyitosWeb.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCTO
    {
        public PRODUCTO()
        {
            this.CODIGO_PRODUCTO = new HashSet<CODIGO_PRODUCTO>();
            this.ORDEN_PEDIDO = new HashSet<ORDEN_PEDIDO>();
            this.RECEPCION = new HashSet<RECEPCION>();
            this.REGISTRO_VENTAS = new HashSet<REGISTRO_VENTAS>();
        }
    
        public decimal ID_PRODUCTO { get; set; }
        public string NOMBRE_PRODUCTO { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal PRECIO_COMPRA { get; set; }
        public decimal PRECIO_VENTA { get; set; }
        public System.DateTime FECHA_ELAB { get; set; }
        public System.DateTime FECHA_VENC { get; set; }
        public decimal STOCK { get; set; }
        public decimal STOCK_CRITICO { get; set; }
        public decimal MARCA_FK { get; set; }
        public decimal TIPO_FK { get; set; }
        public string PROVEEDOR_FK { get; set; }
    
        public virtual ICollection<CODIGO_PRODUCTO> CODIGO_PRODUCTO { get; set; }
        public virtual MARCA MARCA { get; set; }
        public virtual ICollection<ORDEN_PEDIDO> ORDEN_PEDIDO { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual ICollection<RECEPCION> RECEPCION { get; set; }
        public virtual ICollection<REGISTRO_VENTAS> REGISTRO_VENTAS { get; set; }
        public virtual TIPO_PRODUCTO TIPO_PRODUCTO { get; set; }
    }
}
