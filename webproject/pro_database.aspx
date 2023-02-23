<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pro_database.aspx.cs" Inherits="_web_project.pro_database" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="Id" DataSourceID="SqlDataSource1" Width="1029px" Height="272px" style="margin-left: 40px; margin-right: 66px">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Product_Id" ReadOnly="True" SortExpression="Id" >
                <ControlStyle BackColor="#CC0000" ForeColor="Black" />
                <HeaderStyle BackColor="#6699FF" />
                <ItemStyle BackColor="#6699FF" />
                </asp:BoundField>
                <asp:BoundField DataField="pro_name" HeaderText="Product_name" SortExpression="pro_name" >
                <ControlStyle BackColor="#000099" />
                <HeaderStyle BackColor="#00CC66" />
                <ItemStyle BackColor="#6699FF" />
                </asp:BoundField>
                <asp:BoundField DataField="pro_size" HeaderText="Product_size" SortExpression="pro_size" >
                <HeaderStyle BackColor="#669999" />
                <ItemStyle BackColor="#CC99FF" />
                </asp:BoundField>
                <asp:BoundField DataField="pro_price" HeaderText="Product_price" SortExpression="pro_price" >
                <HeaderStyle BackColor="#6699FF" />
                <ItemStyle BackColor="#CC99FF" />
                </asp:BoundField>
                <asp:BoundField DataField="pro_description" HeaderText="Product_description" SortExpression="pro_description" >
                <HeaderStyle BackColor="#339966" />
                <ItemStyle BackColor="#00CC66" />
                </asp:BoundField>
                <asp:BoundField DataField="pro_address" HeaderText="Product_address" SortExpression="pro_address" >
                 <HeaderStyle BackColor="#00CC99" />
                <ItemStyle BackColor="#00CC66" />
                </asp:BoundField>
                 <asp:ImageField DataImageUrlField="pro_image" HeaderText="Product_image">
                     <ControlStyle Height="110px" Width="150px" />
                     <HeaderStyle BackColor="#339966" />
                     <ItemStyle BackColor="White" />
                </asp:ImageField>  
                <asp:BoundField DataField="pro_mobile" HeaderText="Product_mobile" SortExpression="pro_mobile">
                <ControlStyle BackColor="#669999" />
                <ItemStyle BackColor="#00CC66" />
                </asp:BoundField>
            </Columns>
            <EmptyDataTemplate>
                Id
            </EmptyDataTemplate>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" BackColor="#3366CC" Height="42px" style="margin-top: 0px" Text="Insert Again" Width="118px" OnClick="Button1_Click" />
        <br />
    </form>
</body>
</html>
