<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Inventory.aspx.cs" Inherits="Default2" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    DataKeyNames="CarID" DataSourceID="SqlDataSource1" 
    EmptyDataText="There are no data records to display." AllowPaging="True" 
    AllowSorting="True" BackColor="White" BorderColor="#336666" 
    BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
    <footerstyle backcolor="White" forecolor="#333333" />
    <rowstyle backcolor="White" forecolor="#333333" />
    <Columns>
      <asp:commandfield ShowEditButton="True"></asp:commandfield>
      <asp:boundfield DataField="CarID" HeaderText="CarID" ReadOnly="True" 
        SortExpression="CarID"></asp:boundfield>
      <asp:boundfield DataField="Make" HeaderText="Make" SortExpression="Make">
      </asp:boundfield>
      <asp:boundfield DataField="Color" HeaderText="Color" SortExpression="Color">
      </asp:boundfield>
      <asp:boundfield DataField="PetName" HeaderText="PetName" 
        SortExpression="PetName"></asp:boundfield>
    </Columns>
    <pagerstyle backcolor="#336666" forecolor="White" horizontalalign="Center" />
    <selectedrowstyle backcolor="#339966" font-bold="True" forecolor="White" />
    <headerstyle backcolor="#336666" font-bold="True" forecolor="White" />
  </asp:GridView>
  <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:AutoLotConnectionString1 %>" 
    DeleteCommand="DELETE FROM [Inventory] WHERE [CarID] = @CarID" 
    InsertCommand="INSERT INTO [Inventory] ([CarID], [Make], [Color], [PetName]) VALUES (@CarID, @Make, @Color, @PetName)" 
    ProviderName="<%$ ConnectionStrings:AutoLotConnectionString1.ProviderName %>" 
    SelectCommand="SELECT [CarID], [Make], [Color], [PetName] FROM [Inventory]" 
    UpdateCommand="UPDATE [Inventory] SET [Make] = @Make, [Color] = @Color, [PetName] = @PetName WHERE [CarID] = @CarID">
    <DeleteParameters>
      <asp:parameter Name="CarID" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
      <asp:parameter Name="CarID" Type="Int32" />
      <asp:parameter Name="Make" Type="String" />
      <asp:parameter Name="Color" Type="String" />
      <asp:parameter Name="PetName" Type="String" />
    </InsertParameters>
    <UpdateParameters>
      <asp:parameter Name="Make" Type="String" />
      <asp:parameter Name="Color" Type="String" />
      <asp:parameter Name="PetName" Type="String" />
      <asp:parameter Name="CarID" Type="Int32" />
    </UpdateParameters>
  </asp:SqlDataSource>
</asp:Content>

