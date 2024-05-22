<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="AddSV.aspx.cs" Inherits="Test_Data.WebForm3" %>
<asp:Content ID="Content4" ContentPlaceHolderID="addSV" runat="server">
    <div>
        <h2>Thêm sinh viên</h2>
        <asp:Table runat="server" ID="tblDS" Width="450px">
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
        <asp:Button ID="btnAdd" runat="server" Text="Thêm sinh viên" OnClick="btnAdd_Click" />
        <asp:Button ID="caccelAdd" runat="server" Text="Huỷ bỏ" PostBackUrl="~/ListSV.aspx" />
        <p>
            <asp:Label ID="msg" runat="server" Font-Italic="true"></asp:Label>
        </p>
    </div>
    
</asp:Content>
