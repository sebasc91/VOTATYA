using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    class propuesta
    {
        CapaDatos.conexion con = new CapaDatos.conexion();
        public void agregar_propuesta(int id_candidato, string descripcion)
        {
            con.agregar_propuesta(id_candidato,descripcion);
        }
        public void eliminar_propuesta(int id_propuesta)
        {
            con.eliminar_propuesta(id_propuesta);
        }
        public void buscar_propuestas(int id_candidato)
        {
            con.buscar_propuestas(id_candidato);
        }
    }
}
