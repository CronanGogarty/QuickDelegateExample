<%@ Page MasterPageFile="~/MasterPage.master" Title="Simple Delegate Example" Language="C#" AutoEventWireup="true" CodeFile="1.1-SimpleDelegateExample.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content runat="server" ID="content" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
        <asp:Label runat="server" ID="lblResult" Text="Ask the system a question"></asp:Label>
        <br />
        <asp:TextBox runat="server" ID="txtInput" Text="story bud?"></asp:TextBox>
        <br />
        <asp:Button runat="server" ID="cmdClickMe" Text="Click Me" OnClick="cmdClickMe_Click" />
        <hr />
        <asp:TextBox runat="server" ID="txtAreWeTherYet" Text="Are we there yet?"></asp:TextBox>
        <br />
        <asp:Button runat="server" ID="cmdWhereAreWe" Text="Where are we?" OnClick="cmdWhereAreWe_Click" />
    </div>
</asp:Content>