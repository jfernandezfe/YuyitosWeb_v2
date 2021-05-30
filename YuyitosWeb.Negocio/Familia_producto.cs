using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuyitosWeb.DALC;

namespace YuyitosWeb.Negocio
{
    public class Familia_producto
    {
        public decimal Id_familia { get; set; }
        public string Nombre_familia { get; set; }

        YuyitosWebEntities db = new YuyitosWebEntities();

        public List<Familia_producto> ReadAll()
        {
            return db.FAMILIA_PRODUCTO.Select(f => new Familia_producto()
            {

                Id_familia = f.ID_FAMILIA,
                Nombre_familia = f.NOMBRE_FAMILIA

            }).ToList();
        }

    }
}
