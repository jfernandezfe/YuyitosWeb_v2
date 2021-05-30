using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuyitosWeb.DALC;

namespace YuyitosWeb.Negocio
{
    public class Proveedor
    {
        public string Rut_proveedor { get; set; }
        public string Nombre_proveedor { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Razon_social { get; set; }
        public string Direccion { get; set; }
        public decimal RubroId { get; set; }
        public decimal ComunaId { get; set; }
        public decimal RegionId { get; set; }

        public Rubro Rubro { get; set; }
        public Comuna Comuna { get; set; }
        public Region Region { get; set; }

        YuyitosWebEntities db = new YuyitosWebEntities();

        public List<Proveedor> ReadAll()
        {
            return this.db.PROVEEDOR.Select(p => new Proveedor() { 
                Rut_proveedor = p.RUT_PROVEEDOR,
                Nombre_proveedor = p.NOMBRE_PROVEEDOR,
                Telefono = (int)p.TELEFONO,
                Email = p.EMAIL,
                Razon_social = p.RAZON_SOCIAL,
                Direccion = p.DIRECCION,
                RubroId = p.RUBRO_FK,
                Rubro = new Rubro()
                {
                    Id_rubro = p.RUBRO_FK,
                    Nombre_rubro = p.RUBRO.NOMBRE_RUBRO
                    
                },
                ComunaId = p.COMUNA_FK,
                Comuna = new Comuna()
                {
                    Id_comuna = p.COMUNA_FK,
                    Nombre_comuna = p.COMUNA.NOMBRE_COMUNA

                },
                RegionId = p.REGION_FK,
                Region = new Region()
                {
                    Id_region = p.REGION_FK,
                    Nombre_region = p.REGION.NOMBRE_REGION
                }
                
            }).ToList();
        }

        public bool Save()
        {
            try
            {
                db.SP_INGRESAR_PROVEEDOR(this.Rut_proveedor, this.Nombre_proveedor, this.Telefono, 
                                            this.Email, this.Razon_social, this.Direccion, this.RubroId, this.ComunaId, this.RegionId);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


    }
}
