using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cesarc
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        src.CifradoCesar cc = new src.CifradoCesar();
        src.TransformarInverso ti = new src.TransformarInverso();
        src.GruposInversos gi = new src.GruposInversos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void textbox1_TextChanged1(object sender, EventArgs e)
        {
            TextBox2.Text = cc.mensajeCifrado(textbox1.Text, Int32.Parse(textbox5.Text), "");
            TextBox3.Text = ti.inverso(textbox1.Text, "");
            TextBox4.Text = gi.invertir_en_grupos(textbox1.Text, Int32.Parse(textbox6.Text), "");
        }
    }
}