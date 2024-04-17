using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CVenta
    {
       
        public int id { get; set; }
        public int idcliente{ get; set; }
        public int idruta { get; set; }
        public int cantidadpersonas { get; set; }
        

        public override string ToString()
        {
            return string.Format("Ventas (id={0} idcliente={1}, idruta={2}, cantidadpersonas={3}",
                                  id,idcliente, idruta, cantidadpersonas);
        }
    }
}
