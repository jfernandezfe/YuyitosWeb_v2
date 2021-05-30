using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuyitosWeb.DALC;

namespace YuyitosWeb.Negocio
{
    public class Rubro
    {

        public decimal Id_rubro { get; set; }
        public string Nombre_rubro { get; set; }

        YuyitosWebEntities db = new YuyitosWebEntities();

        public List<Rubro> ReadAll()
        {
            return db.RUBRO.Select(r => new Rubro()
            {
                
                Id_rubro = r.ID_RUBRO,
                Nombre_rubro = r.NOMBRE_RUBRO
            
            }).ToList();
        }

    }
}
