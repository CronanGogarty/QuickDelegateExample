<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DelegateEventHandlerAnonymousDelegate.aspx.cs" Inherits="NewFile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button runat="server" ID="cmdClickDelegate" Text="Click Me"/>
    <br />
    <asp:Button runat="server" ID="cmdClickAnonymousDelegate" Text="Anonymous Delegate" />
    <br />
    <asp:Label runat="server" ID="lblMessage"></asp:Label>
</asp:Content>

