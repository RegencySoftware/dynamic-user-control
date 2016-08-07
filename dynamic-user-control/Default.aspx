<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="DynamicUC._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div style="padding-bottom:2px;">
    <h2>Vehicle Comments</h2>

    <!-- Place holder for user controls -->
    <asp:PlaceHolder ID="PHUserControl" runat="server"></asp:PlaceHolder>

    <!-- Save Selections -->
    <asp:Panel style="width:420px;height:150px;float:left;padding:2px;margin-top:-20px;margin-left:10px;" ID="PnlSave" GroupingText="Save Your Selections" runat="server">
      
      <asp:Button ID="BtnSave" runat="server" Text="Save Selections" onclick="BtnSave_Click" />
      <br /><br />
      <asp:Label ID="LblMsg" runat="server" Text="Values loaded from database"  ForeColor="#000000"></asp:Label>

   </asp:Panel>
</div>

</asp:Content>
