<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="EditSV.aspx.cs" Inherits="Test_Data.WebForm4" %>
<asp:Content ID="Content5" ContentPlaceHolderID="editSV" runat="server">
    <div>
        <h2>Sửa thông tin sinh viên</h2>
        <asp:Table runat="server" ID="tblDS" Width="450px">
            <asp:TableRow>
                <asp:TableCell>
                    Mã sinh viên
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtMaSV" runat="server" Enabled="false"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Họ tên
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    Địa chỉ
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    Số điện thoại
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtSDT" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    Mã lớp
                </asp:TableCell>
                <asp:TableCell>
                    <asp:DropDownList ID="ddlMaLop" runat="server" size="4" Width="200px"></asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Button ID="btnEdit" runat="server" Text="Cập nhật" OnClick="btnEdit_Click" OnClientClick="return confirm('Bạn có chắc chắn sửa không?')" />
        <asp:Button ID="btnCancel" runat="server" Text="Huỷ bỏ" PostBackUrl="~/ListSV.aspx" />

        <p>
            <asp:Label ID="msg" runat="server" Font-Italic="true"></asp:Label>
        </p>
    </div>

</asp:Content>
