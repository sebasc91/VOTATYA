using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace CapaLogica
{
    public class usuario
    {
        CapaDatos.conexion con = new CapaDatos.conexion();
        public void agregar_usuario(string nombre, int identificacion, string genero, string fecha_nac, string contraseña, int tipo)
        {
            con.agregarusuario(nombre, identificacion, genero, fecha_nac, contraseña, tipo);
        }
        public void eliminar_usuario(int identificacion)
        {
            con.eliminar_usuario(identificacion);
        }

        #region NOMBRE
        public string RECOGERNOM(string nombre, string identificacion, string genero, String fecha_nac, string contraseña, string tipo)
        {
            CapaDatos.conexion con = new CapaDatos.conexion();
            try
            {
                DataSet dataset = con.login(nombre, identificacion, genero, fecha_nac, contraseña, tipo);
                if (dataset.Tables.Count > 0)
                {
                    if (dataset.Tables[1].Rows[0][0].ToString().Contains("1"))
                    {
                        nombre = dataset.Tables[0].Rows[0][0].ToString();
                    }
                    else
                    {
                        nombre = "";
                    }
                }
                else
                {
                    nombre = "";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nombre;
        }
        #endregion
        #region IDENTIFICACION
        public string RECOGERid(string nombre, string identificacion, string genero, string fecha_nac, string contraseña, string tipo)
        {
            CapaDatos.conexion con = new CapaDatos.conexion();
            try
            {
                DataSet dataset = con.login(nombre, identificacion, genero, fecha_nac, contraseña, tipo);
                if (dataset.Tables.Count > 0)
                {
                    if (dataset.Tables[1].Rows[0][0].ToString().Contains("1"))
                    {
                        identificacion = dataset.Tables[0].Rows[0][1].ToString();
                    }
                    else
                    {
                        identificacion = "";
                    }
                }
                else
                {
                    identificacion = "";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return identificacion;
        }
        #endregion
        #region CONTRASEÑA
        public string PASS(string nombre, string identificacion, string genero, string fecha_nac, string contraseña, string tipo)
        {
            CapaDatos.conexion con = new CapaDatos.conexion();
            try
            {
                DataSet dataset = con.login(nombre, identificacion, genero, fecha_nac, contraseña, tipo);
                if (dataset.Tables.Count > 0)
                {
                    if (dataset.Tables[1].Rows[0][0].ToString().Contains("1"))
                    {
                        contraseña = dataset.Tables[0].Rows[0][5].ToString();
                    }
                    else
                    {
                        contraseña = "";
                    }
                }
                else
                {
                    contraseña = "";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return contraseña;
        }
        #endregion
        #region TIPO
        public string TIPO(string nombre, string identificacion, string genero, string fecha_nac, string contraseña, string tipo)
        {
            CapaDatos.conexion con = new CapaDatos.conexion();
            try
            {
                DataSet dataset = con.login(nombre, identificacion, genero, fecha_nac, contraseña, tipo);
                if (dataset.Tables.Count > 0)
                {
                    if (dataset.Tables[1].Rows[0][0].ToString().Contains("1"))
                    {
                        tipo = dataset.Tables[0].Rows[0][6].ToString();
                    }
                    else
                    {
                        tipo = "";
                    }
                }
                else
                {
                    tipo = "";
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tipo;
        }
        #endregion
    }
}
