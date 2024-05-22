<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="ListSV.aspx.cs" Inherits="Test_Data.WebForm2" %>

<asp:Content ID="Content3" ContentPlaceHolderID="listSV" runat="server">
    <div>
        <h2>Danh sách sinh viên</h2>
        <asp:GridView ID="grdDS" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="masv" HeaderText="Mã sinh viên" />
                <asp:BoundField DataField="hoten" HeaderText="Họ tên" />
                <asp:BoundField DataField="diachi" HeaderText="Địa chỉ" />
                <asp:BoundField DataField="dienthoai" HeaderText="Số điện thoại" />
                <asp:BoundField DataField="malop" HeaderText="Mã lớp" />
                
                <asp:TemplateField HeaderText="Sửa">
                    <ItemTemplate>
                        <asp:Button ID="sua" CommandName="sua" CommandArgument='<%# Bind("masv") %>'
                            Text="Sửa" OnCommand="Sua_Click" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Xoá">
                    <ItemTemplate>
                        <asp:Button ID="xoa" CommandName="xoa" CommandArgument='<%# Bind("masv") %>'
                            Text="Xoá" OnCommand="Xoa_Click" runat="server" OnClientClick="return confirm('Bạn có chắc chắn muốn xoá không?')"/>
                    </ItemTemplate>
                </asp:TemplateField>
            
            </Columns>
        </asp:GridView>
    </div>


</asp:Content>

