using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuyitosWeb.DALC;

namespace YuyitosWeb.Negocio
{
    public class Region
    {
        public decimal Id_region { get; set; }
        public string Nombre_region { get; set; }

        YuyitosWebEntities db = new YuyitosWebEntities();

        public List<Region> ReadAll()
        {
            return db.REGION.Select(re => new Region()
            {

                Id_region = re.ID_REGION,
                Nombre_region = re.NOMBRE_REGION

            }).ToList();
        }

    }
}
