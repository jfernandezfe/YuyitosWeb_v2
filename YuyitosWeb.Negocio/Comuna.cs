using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuyitosWeb.DALC;

namespace YuyitosWeb.Negocio
{
    public class Comuna
    {
        public decimal Id_comuna { get; set; }
        public string Nombre_comuna { get; set; }

        YuyitosWebEntities db = new YuyitosWebEntities();

        public List<Comuna> ReadAll()
        {
            return db.COMUNA.Select(c => new Comuna()
            {

                Id_comuna = c.ID_COMUNA,
                Nombre_comuna = c.NOMBRE_COMUNA

            }).ToList();
        }

    }
}
