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
    
    public partial class REGISTRO_VENTAS
    {
        public REGISTRO_VENTAS()
        {
            this.BOLETA = new HashSet<BOLETA>();
            this.CLIENTE = new HashSet<CLIENTE>();
        }
    
        public decimal ID_VENTA { get; set; }
        public decimal CANTIDAD { get; set; }
        public decimal TOTAL { get; set; }
        public System.DateTime FECHA_VENTA { get; set; }
        public string CLIENTE_FIADO { get; set; }
        public decimal PRODUCTO_FK { get; set; }
    
        public virtual ICollection<BOLETA> BOLETA { get; set; }
        public virtual ICollection<CLIENTE> CLIENTE { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
