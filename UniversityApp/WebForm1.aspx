<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UniversityApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            text-align: right;
            width: 305px;
        }
        .auto-style3 {
            height: 23px;
            text-align: right;
            width: 305px;
        }
        .auto-style4 {
            width: 184px;
        }
        .auto-style5 {
            height: 23px;
            width: 184px;
        }
        .auto-style6 {
            text-align: right;
            width: 305px;
            height: 30px;
        }
        .auto-style7 {
            width: 184px;
            height: 30px;
        }
        .auto-style8 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">StudentName:</td>
                <td id="nameTextBox" class="auto-style4">
                    <asp:TextBox ID="nameTextBox" runat="server" OnTextChanged="nameTextBox_TextChanged" Width="174px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">RegNo:</td>
                <td class="auto-style5" id="regTextBox">
                    <asp:TextBox ID="regTextBox" runat="server" Width="175px"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style2">Email:</td>
                <td id="emailTextBox" class="auto-style4">
                    <asp:TextBox ID="emailTextBox" runat="server" Width="172px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3" id="addressTextBox">Address:</td>
                <td id="addressTextBox" class="auto-style5">
                    <asp:TextBox ID="addressTextBox" runat="server" Width="176px"></asp:TextBox>
                </td>
                <td id="addressTextBox" class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style2">Department:</td>
                <td id="departmentTextBox" class="auto-style4">
                    <asp:TextBox ID="departmentTextBox" runat="server" Width="178px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style7">
                    <asp:Button ID="saveButton" runat="server" OnClick="Button1_Click" Text="Save" />
                </td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Label ID="messageLabel" runat="server" Text="Message"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
