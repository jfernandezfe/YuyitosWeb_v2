using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuyitosWeb.DALC;

namespace YuyitosWeb.Negocio
{
    public class Marca
    {

        public decimal Id_marca { get; set; }
        public string Nombre_marca { get; set; }

        YuyitosWebEntities db = new YuyitosWebEntities();

        public List<Marca> ReadAll()
        {
            return db.MARCA.Select(m => new Marca()
            {

                Id_marca = m.ID_MARCA,
                Nombre_marca = m.NOMBRE_MARCA

            }).ToList();
        }

    }
}
