using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;


public partial class _Default : System.Web.UI.Page
{
    /*protected HtmlForm form1;
    /*protected TextBox TextBox1;
    protected TextBox TextBox2;
    protected Button  Button3;*/
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void Mensaje(string Msj)
    {
        Msj = Msj.Replace("'", "");
        ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), Guid.NewGuid().ToString(), "alert('" + Msj + "');", true);
    }
    protected void Button3_Click1(object sender, EventArgs e)
    {
        try
        {
            CapaLogica.usuario usuario = new CapaLogica.usuario();
            string text = usuario.RECOGERNOM(this.TextBox2.Text, this.TextBox1.Text, "", "", "", "");
            string value = usuario.PASS(this.TextBox2.Text, this.TextBox1.Text, "", "", "", "");
            string value2 = usuario.TIPO(this.TextBox2.Text, this.TextBox1.Text, "", "", "", "");
           /* string value3 = usuario.validarpermi(this.txtusu.Text, this.txtcontra.Text, "", "", "", "", "", "");
            string text2 = usuario.validarnomb(this.txtusu.Text, this.txtcontra.Text, "", "", "", "", "", "");
            string value4 = usuario.validarcargo(this.txtusu.Text, this.txtcontra.Text, "", "", "", "", "", "");
            string value5 = usuario.validarcc_usuario(this.txtusu.Text, this.txtcontra.Text, "", "", "", "", "", "");
            string value6 = usuario.validarcorreo(this.txtusu.Text, this.txtcontra.Text, "", "", "", "", "", "");*/
            if (text != "")
            {
                this.Session.Add("nombre", text);
                this.Session.Add("contraseña", value);
                this.Session.Add("estado", value2);
               /* this.Session.Add("permisos", value3);
                this.Session.Add("nombre", text2);
                this.Session.Add("cargo", value4);
                this.Session.Add("cc_usuario", value5);
                this.Session.Add("correo", value6);*/
                if (this.Session["estado"].ToString() == "1" /*&& this.Session["permisos"].ToString() == "0"*/)
                {
                    this.Mensaje("ok");
                    /*base.Response.Redirect("Menuusuario.aspx");
                    this.Mensaje("Bienvenido  " + text2);*/
                }
                /*else if (this.Session["estado"].ToString() == "1" && this.Session["permisos"].ToString() == "1")
                {
                    this.Mensaje("ok");
                    base.Response.Redirect("Menu.aspx");
                    this.Mensaje("Bienvenido  " + text2);
                }*/
            }
            else
            {
                this.Mensaje("Datos Errados");
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }/**/
    }

}