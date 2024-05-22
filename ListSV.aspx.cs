using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test_Data
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                HienThi();
        }

        private void HienThi()
        {
            grdDS.DataSource = data.dsSinhVien();
            DataBind();
        }

        protected void Sua_Click(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "sua")
            {
                int m = Convert.ToInt16(e.CommandArgument);
                SinhVien s = data.showSV(m);
                Session["sv"] = s;
                Response.Redirect("EditSV.aspx");
                HienThi();
            }
        }

        protected void Xoa_Click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "xoa")
            {
                int m = Convert.ToInt16(e.CommandArgument);
                data.DelSV(m);
                HienThi();
            }
        }
    }
}