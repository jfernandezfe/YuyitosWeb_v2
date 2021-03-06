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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class YuyitosWebEntities : DbContext
    {
        public YuyitosWebEntities()
            : base("name=YuyitosWebEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BOLETA> BOLETA { get; set; }
        public DbSet<CLIENTE> CLIENTE { get; set; }
        public DbSet<CODIGO_PRODUCTO> CODIGO_PRODUCTO { get; set; }
        public DbSet<COMUNA> COMUNA { get; set; }
        public DbSet<FAMILIA_PRODUCTO> FAMILIA_PRODUCTO { get; set; }
        public DbSet<FIADO> FIADO { get; set; }
        public DbSet<MARCA> MARCA { get; set; }
        public DbSet<ORDEN_PEDIDO> ORDEN_PEDIDO { get; set; }
        public DbSet<PRODUCTO> PRODUCTO { get; set; }
        public DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public DbSet<RECEPCION> RECEPCION { get; set; }
        public DbSet<REGION> REGION { get; set; }
        public DbSet<REGISTRO_VENTAS> REGISTRO_VENTAS { get; set; }
        public DbSet<RUBRO> RUBRO { get; set; }
        public DbSet<SUBFAMILIA> SUBFAMILIA { get; set; }
        public DbSet<TIPO_PRODUCTO> TIPO_PRODUCTO { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
    
        public virtual int SP_INGRESAR_ORDEN_PEDIDO(Nullable<System.DateTime> fECHA, Nullable<decimal> cANTIDAD, string eSTADO, Nullable<decimal> iD_PROD, string rUT_PROVEEDOR)
        {
            var fECHAParameter = fECHA.HasValue ?
                new ObjectParameter("FECHA", fECHA) :
                new ObjectParameter("FECHA", typeof(System.DateTime));
    
            var cANTIDADParameter = cANTIDAD.HasValue ?
                new ObjectParameter("CANTIDAD", cANTIDAD) :
                new ObjectParameter("CANTIDAD", typeof(decimal));
    
            var eSTADOParameter = eSTADO != null ?
                new ObjectParameter("ESTADO", eSTADO) :
                new ObjectParameter("ESTADO", typeof(string));
    
            var iD_PRODParameter = iD_PROD.HasValue ?
                new ObjectParameter("ID_PROD", iD_PROD) :
                new ObjectParameter("ID_PROD", typeof(decimal));
    
            var rUT_PROVEEDORParameter = rUT_PROVEEDOR != null ?
                new ObjectParameter("RUT_PROVEEDOR", rUT_PROVEEDOR) :
                new ObjectParameter("RUT_PROVEEDOR", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INGRESAR_ORDEN_PEDIDO", fECHAParameter, cANTIDADParameter, eSTADOParameter, iD_PRODParameter, rUT_PROVEEDORParameter);
        }
    
        public virtual int SP_INGRESAR_PROVEEDOR(string rUT, string nOMBRE, Nullable<decimal> tELEFONO, string eMAIL, string rAZON_SOCIAL, string dIRECCION, Nullable<decimal> rUBRO, Nullable<decimal> cOMUNA, Nullable<decimal> rEGION)
        {
            var rUTParameter = rUT != null ?
                new ObjectParameter("RUT", rUT) :
                new ObjectParameter("RUT", typeof(string));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var tELEFONOParameter = tELEFONO.HasValue ?
                new ObjectParameter("TELEFONO", tELEFONO) :
                new ObjectParameter("TELEFONO", typeof(decimal));
    
            var eMAILParameter = eMAIL != null ?
                new ObjectParameter("EMAIL", eMAIL) :
                new ObjectParameter("EMAIL", typeof(string));
    
            var rAZON_SOCIALParameter = rAZON_SOCIAL != null ?
                new ObjectParameter("RAZON_SOCIAL", rAZON_SOCIAL) :
                new ObjectParameter("RAZON_SOCIAL", typeof(string));
    
            var dIRECCIONParameter = dIRECCION != null ?
                new ObjectParameter("DIRECCION", dIRECCION) :
                new ObjectParameter("DIRECCION", typeof(string));
    
            var rUBROParameter = rUBRO.HasValue ?
                new ObjectParameter("RUBRO", rUBRO) :
                new ObjectParameter("RUBRO", typeof(decimal));
    
            var cOMUNAParameter = cOMUNA.HasValue ?
                new ObjectParameter("COMUNA", cOMUNA) :
                new ObjectParameter("COMUNA", typeof(decimal));
    
            var rEGIONParameter = rEGION.HasValue ?
                new ObjectParameter("REGION", rEGION) :
                new ObjectParameter("REGION", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INGRESAR_PROVEEDOR", rUTParameter, nOMBREParameter, tELEFONOParameter, eMAILParameter, rAZON_SOCIALParameter, dIRECCIONParameter, rUBROParameter, cOMUNAParameter, rEGIONParameter);
        }
    
        public virtual int SP_INGRESAR_REGISTRO_VENTA(Nullable<decimal> cANT, Nullable<System.DateTime> fECHA, string e_FIADO, Nullable<decimal> pROD_FK)
        {
            var cANTParameter = cANT.HasValue ?
                new ObjectParameter("CANT", cANT) :
                new ObjectParameter("CANT", typeof(decimal));
    
            var fECHAParameter = fECHA.HasValue ?
                new ObjectParameter("FECHA", fECHA) :
                new ObjectParameter("FECHA", typeof(System.DateTime));
    
            var e_FIADOParameter = e_FIADO != null ?
                new ObjectParameter("E_FIADO", e_FIADO) :
                new ObjectParameter("E_FIADO", typeof(string));
    
            var pROD_FKParameter = pROD_FK.HasValue ?
                new ObjectParameter("PROD_FK", pROD_FK) :
                new ObjectParameter("PROD_FK", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INGRESAR_REGISTRO_VENTA", cANTParameter, fECHAParameter, e_FIADOParameter, pROD_FKParameter);
        }
    
        public virtual int SP_INGRESAR_PRODUCTO(string nOMBRE, string dESCRIPCION, Nullable<decimal> pRECIO_COMPRA, Nullable<decimal> pRECIO_VENTA, Nullable<System.DateTime> fECHA_ELAB, Nullable<System.DateTime> fECHA_VENC, Nullable<decimal> sTOCK, Nullable<decimal> sTOCK_CRITICO, Nullable<decimal> mARCAID, Nullable<decimal> tIPOID, string pROVEEDORRUT)
        {
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var dESCRIPCIONParameter = dESCRIPCION != null ?
                new ObjectParameter("DESCRIPCION", dESCRIPCION) :
                new ObjectParameter("DESCRIPCION", typeof(string));
    
            var pRECIO_COMPRAParameter = pRECIO_COMPRA.HasValue ?
                new ObjectParameter("PRECIO_COMPRA", pRECIO_COMPRA) :
                new ObjectParameter("PRECIO_COMPRA", typeof(decimal));
    
            var pRECIO_VENTAParameter = pRECIO_VENTA.HasValue ?
                new ObjectParameter("PRECIO_VENTA", pRECIO_VENTA) :
                new ObjectParameter("PRECIO_VENTA", typeof(decimal));
    
            var fECHA_ELABParameter = fECHA_ELAB.HasValue ?
                new ObjectParameter("FECHA_ELAB", fECHA_ELAB) :
                new ObjectParameter("FECHA_ELAB", typeof(System.DateTime));
    
            var fECHA_VENCParameter = fECHA_VENC.HasValue ?
                new ObjectParameter("FECHA_VENC", fECHA_VENC) :
                new ObjectParameter("FECHA_VENC", typeof(System.DateTime));
    
            var sTOCKParameter = sTOCK.HasValue ?
                new ObjectParameter("STOCK", sTOCK) :
                new ObjectParameter("STOCK", typeof(decimal));
    
            var sTOCK_CRITICOParameter = sTOCK_CRITICO.HasValue ?
                new ObjectParameter("STOCK_CRITICO", sTOCK_CRITICO) :
                new ObjectParameter("STOCK_CRITICO", typeof(decimal));
    
            var mARCAIDParameter = mARCAID.HasValue ?
                new ObjectParameter("MARCAID", mARCAID) :
                new ObjectParameter("MARCAID", typeof(decimal));
    
            var tIPOIDParameter = tIPOID.HasValue ?
                new ObjectParameter("TIPOID", tIPOID) :
                new ObjectParameter("TIPOID", typeof(decimal));
    
            var pROVEEDORRUTParameter = pROVEEDORRUT != null ?
                new ObjectParameter("PROVEEDORRUT", pROVEEDORRUT) :
                new ObjectParameter("PROVEEDORRUT", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INGRESAR_PRODUCTO", nOMBREParameter, dESCRIPCIONParameter, pRECIO_COMPRAParameter, pRECIO_VENTAParameter, fECHA_ELABParameter, fECHA_VENCParameter, sTOCKParameter, sTOCK_CRITICOParameter, mARCAIDParameter, tIPOIDParameter, pROVEEDORRUTParameter);
        }
    
        public virtual int SP_INGRESAR_TIPO_PRODUCTO(string nOMBRE_TIPO, Nullable<decimal> sUBFAMILIAID)
        {
            var nOMBRE_TIPOParameter = nOMBRE_TIPO != null ?
                new ObjectParameter("NOMBRE_TIPO", nOMBRE_TIPO) :
                new ObjectParameter("NOMBRE_TIPO", typeof(string));
    
            var sUBFAMILIAIDParameter = sUBFAMILIAID.HasValue ?
                new ObjectParameter("SUBFAMILIAID", sUBFAMILIAID) :
                new ObjectParameter("SUBFAMILIAID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INGRESAR_TIPO_PRODUCTO", nOMBRE_TIPOParameter, sUBFAMILIAIDParameter);
        }
    }
}
