using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaLogica
{
    public class candidato
    {
        CapaDatos.conexion con = new CapaDatos.conexion();
        public void agregar_candidato(int id_eleccion,int identy,string nombre,string imagen,string genero,DateTime fecha_nac,int num_lista)
        {
            con.agregarcandidato(id_eleccion,identy,nombre,imagen,genero,fecha_nac,num_lista);
        }
        public void buscar_candidato(string nombre)
        {
            con.buscar_candidato(nombre);
        }
        public void buscar_todos_candidatos()
        {
            con.buscar_todos_candidatos();
        }
        public void eliminar_candidato(int identy)
        {
            con.eliminar_candidato(identy);
        }

    }
}
