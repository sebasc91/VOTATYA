using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class conexion
    {
        #region conexion

        public SqlConnection con;
        public SqlDataReader dr;
        public SqlCommand cmd;
        public DataTable dt;
        public DataSet ds;
        public SqlDataAdapter da;

        
        public void conectar()
        {
            string conection = "Data Source=DESKTOP-7CQHV2P\\SQLEXPRESS;Initial Catalog=SISVOTACION;Integrated Security=True";
            con = new SqlConnection(conection);

            try
            {
                con.Open();
            }
            catch(Exception ex)
            {
                throw(ex);
            }
            finally
            {
                con.Close();
            }
        }

        #endregion
        #region candidato
        public void agregarcandidato(int id_eleccion,int identy, string nombre, string imagen, string genero, DateTime fecha_nac, int num_lista)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                //cmd.Connection = this.con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "agregar_candidato";
                //cmd.CommandText = "INSERT INTO preguntas (id_estudiante,pregunta,estado,fecha)values(@id_estudiante,@pregunta,'',@fecha)";
                cmd.Parameters.AddWithValue("@id_eleccion", SqlDbType.Int).Value = id_eleccion;
                cmd.Parameters.AddWithValue("@identy",    SqlDbType.Int).Value      = identy;
                cmd.Parameters.AddWithValue("@nombre",    SqlDbType.VarChar).Value  = nombre;
                cmd.Parameters.AddWithValue("@imagen",    SqlDbType.VarChar).Value  = imagen;
                cmd.Parameters.AddWithValue("@genero",    SqlDbType.VarChar).Value  = genero;
                cmd.Parameters.AddWithValue("@fecha_nac", SqlDbType.DateTime).Value = nombre;
                cmd.Parameters.AddWithValue("@num_lista", SqlDbType.Int).Value      = num_lista;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void buscar_candidato(string nombre)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "buscar_candidato";
                cmd.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = nombre;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void buscar_todos_candidatos()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "buscar_todos_candidatos";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void buscar_todos_candidatos_ADMIN()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "buscar_todos_candidatos_ADMIN";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void eliminar_candidato(int identy)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "eliminar_candidato";
                cmd.Parameters.AddWithValue("@identy", SqlDbType.Int).Value = identy;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        #endregion
        #region propuesta
        public void agregar_propuesta(int id_candidato, string descripcion)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "agregar_propuesta";
                cmd.Parameters.AddWithValue("@id_candidato", SqlDbType.Int).Value = id_candidato;
                cmd.Parameters.AddWithValue("@descripcion",  SqlDbType.VarChar).Value = descripcion;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void eliminar_propuesta(int id_candidato)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "eliminar_propuesta";
                cmd.Parameters.AddWithValue("@id_candidato", SqlDbType.Int).Value = id_candidato;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void buscar_propuestas(int id_candidato)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "buscar_propuestas";
                cmd.Parameters.AddWithValue("@id_candidato", SqlDbType.Int).Value = id_candidato;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        #endregion
        #region usuario
        public void agregarusuario(string nombre, int identificacion, string genero, string fecha_nac, string contraseña, int tipo)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "agregar_usuario";
                cmd.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = nombre;
                cmd.Parameters.AddWithValue("@identificacion", SqlDbType.Int).Value = identificacion;
                cmd.Parameters.AddWithValue("@genero", SqlDbType.VarChar).Value = genero;
                cmd.Parameters.AddWithValue("@fecha_nac", SqlDbType.DateTime).Value = fecha_nac;
                cmd.Parameters.AddWithValue("@contraseña", SqlDbType.VarChar).Value = contraseña;
                cmd.Parameters.AddWithValue("@tipo", SqlDbType.Int).Value = tipo;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void eliminar_usuario(int identificacion)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "eliminar_usuario";
                cmd.Parameters.AddWithValue("@identificacion", SqlDbType.Int).Value = identificacion;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataSet login(string nombre, string identificacion, string genero, string fecha_nac, string contraseña, string tipos)
        {
            try
            {
                this.con.Open();
                this.cmd = new SqlCommand();
                this.cmd.Connection = this.con;
                da = new SqlDataAdapter();
                this.ds = new DataSet();
                this.cmd.CommandText = "login1";
                this.cmd.CommandType = CommandType.StoredProcedure;
                this.cmd.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = nombre;
                this.cmd.Parameters.AddWithValue("@contraseña", SqlDbType.VarChar).Value = contraseña;
                da.SelectCommand = this.cmd;
                da.Fill(this.ds);
                //cmd.ExecuteNonQuery();
                this.con.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return this.ds;
        }
        #endregion
        #region PROC_ELEC
        public void agregarproceso(string descripcion)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "agregarproceso";
                cmd.Parameters.AddWithValue("@descripcion", SqlDbType.VarChar).Value = descripcion;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void eliminarproceso(int id_eleccion)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "eliminarproceso";
                cmd.Parameters.AddWithValue("@id_eleccion", SqlDbType.Int).Value = id_eleccion;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void BUSCARPROC(int id_eleccion)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BUSCAR_PROC";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        #endregion
        #region VOTO

        public void agregarvoto(int id_candidato, int id_usuario,  DateTime hra_ini, DateTime hra_fin)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "agregarvoto";
                cmd.Parameters.AddWithValue("@id_candidato", SqlDbType.Int).Value = id_candidato;
                cmd.Parameters.AddWithValue("@id_usuario", SqlDbType.Int).Value = id_usuario;
                cmd.Parameters.AddWithValue("@hra_ini", SqlDbType.DateTime).Value = hra_ini;
                cmd.Parameters.AddWithValue("@hra_fin", SqlDbType.DateTime).Value = hra_fin;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void buscar_voto(int num_lista)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "buscar_voto_ESP";
                cmd.Parameters.AddWithValue("@num_lista", SqlDbType.Int).Value = num_lista;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void buscar_TODOS()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "buscar_votos";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        #endregion

    }
}
