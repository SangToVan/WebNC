using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test_Data
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddlMaLop.DataSource = data.dsLop();
                ddlMaLop.DataTextField = "tenlop";
                ddlMaLop.DataValueField = "malop";
                DataBind();
            }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien s = new SinhVien();
                s.hoten = txtHoTen.Text;
                s.diachi = txtDiaChi.Text;
                s.dienthoai = txtSDT.Text;
                s.malop = int.Parse(ddlMaLop.SelectedValue);
                data.AddSV(s);
                msg.ForeColor = System.Drawing.Color.Green;
                msg.Text = "Thêm sinh viên thành công";

            } catch(Exception e1)
            {
                msg.ForeColor = System.Drawing.Color.Red;
                msg.Text = "Có lỗi khi thêm sinh viên: " + e1.Message;
            }
        }
    }
}