<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentSearchUpdateDeleteUI.aspx.cs" Inherits="UniversityApp.UI.StudentSearchUpdateDeleteUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 286px;
            text-align: right;
        }
        .auto-style3 {
            height: 23px;
            width: 286px;
            text-align: right;
        }
        .auto-style4 {
            width: 286px;
            text-align: right;
            height: 24px;
        }
        .auto-style5 {
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">Reg No:</td>
                    <td>
                        <asp:TextBox ID="regTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style1">
                        <asp:Button ID="searchButton" runat="server" OnClick="searchButton_Click" Text="Search" />
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Student Name:</td>
                    <td>
                        <asp:TextBox ID="studentNameTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Email:</td>
                    <td>
                        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Address:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Department:</td>
                    <td>
                        <asp:TextBox ID="departmentTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="updateButton" runat="server" OnClick="updateButton_Click" Text="Update" />
                        <asp:Button ID="deleteButton" runat="server" OnClick="deleteButton_Click" Text="Delete" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Label ID="messageLabel" runat="server" Text="Message"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
