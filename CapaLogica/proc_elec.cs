using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    class proc_elec
    {
        CapaDatos.conexion con = new CapaDatos.conexion();

        public void agregar_proceso(string descripcion)
        {
            con.agregarproceso(descripcion);
        }
        public void eliminar_proceso(int id_eleccion)
        {
            con.eliminarproceso(id_eleccion);
        }
    }
}
