using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuyitosWeb.DALC;

namespace YuyitosWeb.Negocio
{
    public class Subfamilia
    {
        public decimal Id_subfamilia { get; set; }
        public string Nombre_subfamilia { get; set; }
        public decimal FamiliaId { get; set; }

        public Familia_producto familia_Producto { get; set; }

        YuyitosWebEntities db = new YuyitosWebEntities();

        public List<Subfamilia> ReadAll()
        {
            return db.SUBFAMILIA.Select(s => new Subfamilia()
            {

                Id_subfamilia = s.ID_SUBFAMILIA,
                Nombre_subfamilia = s.NOMBRE_SUBFAMILIA,
                FamiliaId = s.FAMILIA_FK,
                familia_Producto = new Familia_producto()
                {
                    Id_familia = s.FAMILIA_FK,
                    Nombre_familia = s.FAMILIA_PRODUCTO.NOMBRE_FAMILIA
                }

            }).ToList();
        }


    }
}
