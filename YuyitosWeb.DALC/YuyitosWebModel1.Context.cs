﻿//------------------------------------------------------------------------------
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
    
        public virtual int SP_INGRESAR_CODIGO_PRODUCTO(Nullable<decimal> iD_PROD)
        {
            var iD_PRODParameter = iD_PROD.HasValue ?
                new ObjectParameter("ID_PROD", iD_PROD) :
                new ObjectParameter("ID_PROD", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INGRESAR_CODIGO_PRODUCTO", iD_PRODParameter);
        }
    
        public virtual int SP_INGRESAR_PROVEEDOR(string rUT, string nOMBRE, Nullable<decimal> tELEFONO, string eMAIL, Nullable<decimal> iD_RUBRO, string rAZON_SOCIAL, string dIRECCION, Nullable<decimal> iD_REGION, Nullable<decimal> iD_COMUNA)
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
    
            var iD_RUBROParameter = iD_RUBRO.HasValue ?
                new ObjectParameter("ID_RUBRO", iD_RUBRO) :
                new ObjectParameter("ID_RUBRO", typeof(decimal));
    
            var rAZON_SOCIALParameter = rAZON_SOCIAL != null ?
                new ObjectParameter("RAZON_SOCIAL", rAZON_SOCIAL) :
                new ObjectParameter("RAZON_SOCIAL", typeof(string));
    
            var dIRECCIONParameter = dIRECCION != null ?
                new ObjectParameter("DIRECCION", dIRECCION) :
                new ObjectParameter("DIRECCION", typeof(string));
    
            var iD_REGIONParameter = iD_REGION.HasValue ?
                new ObjectParameter("ID_REGION", iD_REGION) :
                new ObjectParameter("ID_REGION", typeof(decimal));
    
            var iD_COMUNAParameter = iD_COMUNA.HasValue ?
                new ObjectParameter("ID_COMUNA", iD_COMUNA) :
                new ObjectParameter("ID_COMUNA", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INGRESAR_PROVEEDOR", rUTParameter, nOMBREParameter, tELEFONOParameter, eMAILParameter, iD_RUBROParameter, rAZON_SOCIALParameter, dIRECCIONParameter, iD_REGIONParameter, iD_COMUNAParameter);
        }
    
        public virtual int SP_INGRESAR_RUBRO(Nullable<decimal> iD_RUBRO, string nOMBRE)
        {
            var iD_RUBROParameter = iD_RUBRO.HasValue ?
                new ObjectParameter("ID_RUBRO", iD_RUBRO) :
                new ObjectParameter("ID_RUBRO", typeof(decimal));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INGRESAR_RUBRO", iD_RUBROParameter, nOMBREParameter);
        }
    }
}