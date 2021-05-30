using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuyitosWeb.DALC;

namespace YuyitosWeb.Negocio
{
    public class Tipo_producto
    {
        public decimal Id_tipo { get; set; }
        public string Nombre_tipo { get; set; }
        public decimal SubfamiliaId { get; set; }

        public Subfamilia Subfamilia { get; set; }

        YuyitosWebEntities db = new YuyitosWebEntities();

        public List<Tipo_producto> ReadAll()
        {
            return db.TIPO_PRODUCTO.Select(t => new Tipo_producto()
            {

                Id_tipo = t.ID_TIPO,
                Nombre_tipo = t.NOMBRE_TIPO,
                SubfamiliaId = t.SUBFAMILIA_FK,
                Subfamilia = new Subfamilia()
                {
                    Id_subfamilia = t.SUBFAMILIA_FK,
                    Nombre_subfamilia = t.SUBFAMILIA.NOMBRE_SUBFAMILIA,
                    FamiliaId = t.SUBFAMILIA.FAMILIA_FK
                }


            }).ToList();
        }

        public bool Save()
        {
            try
            {
                db.SP_INGRESAR_TIPO_PRODUCTO(this.Nombre_tipo, this.SubfamiliaId);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }   

    }
}
