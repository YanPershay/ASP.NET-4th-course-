<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />

        <div>
            <asp:TextBox runat="server" ID="textX" />
            <asp:TextBox runat="server" ID="textY" />
            <asp:Button runat="server" ID="add" OnClick="Add_Click" Text="Add" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="textAddResponse" />
        </div>
   
    <br />

    <div>
            <asp:TextBox runat="server" ID="textD" />
            <asp:TextBox runat="server" ID="textS" />
            <asp:Button runat="server" ID="concat" OnClick="Concat_Click" Text="Concat" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="textConcatResponse" />
        </div>
   
    <br />

    <div>
            <asp:TextBox runat="server" ID="textA1S" />
            <asp:TextBox runat="server" ID="textA2S" />
        <br />
            <asp:TextBox runat="server" ID="textA1K" />
            <asp:TextBox runat="server" ID="textA2K" />
        <br />                              
            <asp:TextBox runat="server" ID="textA1F" />
            <asp:TextBox runat="server" ID="textA2F" />
            <asp:Button runat="server" ID="Button2" OnClick="Sum_Click" Text="Sum" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="textSumResponse" />
        </div>
   
    <br />

</asp:Content>
