using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test_Data
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SinhVien s = (SinhVien)Session["sv"];
                txtMaSV.Text = s.masv.ToString();
                txtHoTen.Text = s.hoten;
                txtDiaChi.Text = s.diachi;
                txtSDT.Text = s.dienthoai;
                ddlMaLop.DataSource = data.dsLop();
                ddlMaLop.DataTextField = "tenlop";
                ddlMaLop.DataValueField = "malop";
                DataBind();
                ddlMaLop.SelectedValue = s.malop.ToString();
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien s = new SinhVien();
                s.masv = int.Parse(txtMaSV.Text);
                s.hoten = txtHoTen.Text;
                s.diachi = txtDiaChi.Text;
                s.dienthoai = txtSDT.Text;
                s.malop = int.Parse(ddlMaLop.SelectedValue);
                data.EditSV(s);
                msg.ForeColor = System.Drawing.Color.Green;
                msg.Text = "Cập nhật sinh viên thành công";
            } catch (Exception ex)
            {
                msg.ForeColor = System.Drawing.Color.Red;
                msg.Text = "Có lỗi: " + ex.Message;
            }
        }
    }
}