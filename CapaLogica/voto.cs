using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    class voto
    {
        CapaDatos.conexion con = new CapaDatos.conexion();

        public void agregar_voto(int id_candidato, int id_usuario, DateTime hra_ini, DateTime hra_fin)
        {
            con.agregarvoto(id_candidato, id_usuario,hra_ini,hra_fin);
        }

        public void buscar_voto(int num_lista)
        {
            con.buscar_voto(num_lista);
        }

    }
}
