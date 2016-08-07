<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AutoSurvey.ascx.cs" Inherits="DynamicUC.Controls.AutoSurvey" %>

<asp:Panel GroupingText="User Control" style="background:#ffffff;width:440px;float:left;padding:2px;margin-top:-20px;margin-left:10px;" ID="PnlAuto" runat="server">
    <div style="float:left;">
        Make a Selection<br />
        <asp:DropDownList ID="DDLAutos" Width="125" runat="server"></asp:DropDownList>&nbsp;
    </div>

    <div style="float:left;margin-left:10px;">
        Comments<br />
        <asp:TextBox ID="TxtComments"  Width="250px"  runat="server" Height="75px"></asp:TextBox>
    </div>
</asp:Panel>

