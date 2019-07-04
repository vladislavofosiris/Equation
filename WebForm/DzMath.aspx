<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DzMath.aspx.cs" Inherits="DzWebForm.DzMath" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td> a:</td>
                    <td> 
                        <asp:TextBox ID ="tbA" runat="server" /></td>
                </tr>
                 <tr>
                    <td>b:</td>
                    <td>
                        <asp:TextBox ID ="tbB" runat="server" /></td>
                </tr>
                 <tr>
                    <td>c:</td>
                    <td>
                        <asp:TextBox ID ="tbC" runat="server" /></td>
                </tr>                
            </table>
            <asp:Button ID="btnResult" runat="server" Text="Result" />
            <br /><asp:Label ID="LabeltText" runat="server"></asp:Label>
            <br /><asp:Label ID="LabeltD" runat="server"></asp:Label>
            <br /><asp:Label ID="LabeltX1" runat="server"></asp:Label>
            <br /><asp:Label ID="LabeltX2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
