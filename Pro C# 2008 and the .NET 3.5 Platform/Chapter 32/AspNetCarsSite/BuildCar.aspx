<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BuildCar.aspx.cs" Inherits="BuildCarPage" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <asp:Label ID="Label1" runat="server" Font-Size="X-Large" 
    Text="Use this Wizard to build your Dream Car" Width="254px"></asp:Label>
  <br />
  <br />
  <asp:Wizard ID="carWizard" runat="server" ActiveStepIndex="1" 
    BackColor="#E6E2D8" BorderColor="#999999" BorderWidth="1px" 
    Font-Names="Verdana" Font-Size="0.8em" 
    OnFinishButtonClick="carWizard_FinishButtonClick" Width="357px">
    <StepStyle BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderStyle="Solid" 
      BorderWidth="2px" />
    <StartNavigationTemplate>
      <asp:Button ID="StartNextButton" runat="server" BackColor="White" 
        BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" 
        CommandName="MoveNext" Font-Names="Verdana" Font-Size="0.8em" 
        ForeColor="#1C5E55" Text="Next" />
    </StartNavigationTemplate>
    <SideBarStyle BackColor="#1C5E55" Font-Size="0.9em" VerticalAlign="Top" />
    <WizardSteps>
      <asp:WizardStep runat="server" Title="Pick Your Model">
        <asp:TextBox ID="txtCarModel" runat="server" Width="185px"></asp:TextBox>
      </asp:WizardStep>
      <asp:WizardStep runat="server" Title="Pick Your Color">
        <asp:ListBox ID="ListBoxColors" runat="server" Width="237px">
          <asp:ListItem>Purple</asp:ListItem>
          <asp:ListItem>Green</asp:ListItem>
          <asp:ListItem>Red</asp:ListItem>
          <asp:ListItem>Yellow</asp:ListItem>
          <asp:ListItem>Pea Soup Green</asp:ListItem>
          <asp:ListItem>Black</asp:ListItem>
          <asp:ListItem>Lime Green</asp:ListItem>
        </asp:ListBox>
      </asp:WizardStep>
      <asp:WizardStep runat="server" Title="Name Your Car">
        <asp:TextBox ID="txtCarPetName" runat="server" Width="185px"></asp:TextBox>
      </asp:WizardStep>
      <asp:WizardStep runat="server" Title="Delivery Date">
        <asp:Calendar ID="carCalendar" runat="server"></asp:Calendar>
      </asp:WizardStep>
    </WizardSteps>
    <SideBarButtonStyle ForeColor="White" />
    <HeaderStyle BackColor="#666666" BorderColor="#E6E2D8" BorderStyle="Solid" 
      BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="White" 
      HorizontalAlign="Center" />
    <NavigationButtonStyle BackColor="White" BorderColor="#C5BBAF" 
      BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
      ForeColor="#1C5E55" />
  </asp:Wizard>
  <br />
  <asp:Label ID="lblOrder" runat="server" Font-Size="X-Large"></asp:Label>
  <br />
</asp:Content>

