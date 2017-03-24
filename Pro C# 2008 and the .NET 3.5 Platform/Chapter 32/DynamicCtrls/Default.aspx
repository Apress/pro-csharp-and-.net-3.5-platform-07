<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <h1>
    Dynamic Controls
        <asp:Button ID="btnAddWidgets" runat="server" onclick="btnAddWidgets_Click" 
          Text="Add To Panel" />
&nbsp;
        <asp:Button ID="btnRemovePanelItems" runat="server" 
          onclick="btnRemovePanelItems_Click" Text="Clear Panel" />
      </h1>
      <p>
        <asp:Button ID="btnGetTextBoxValues" runat="server" 
          onclick="btnGetTextBoxValues_Click" Text="Get Data in TextBoxes" />
      </p>
      <p>
        <asp:Label ID="lblTextBoxText" runat="server"></asp:Label>
      </p>
      <hr />
    </div>
    <asp:Panel ID="myPanel" runat="server" Height="50px" Width="125px" >
      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
      <asp:Button ID="Button1" runat="server" Text="Button"/><br/>
      <asp:HyperLink ID="HyperLink1" runat="server">HyperLink
      </asp:HyperLink>
    </asp:Panel>
    <p>
      &nbsp;</p>
&nbsp;
    <br />
    <br />
          <hr />

    <asp:Label ID="lblControlInfo" runat="server"></asp:Label>
    </form>
</body>
</html>
