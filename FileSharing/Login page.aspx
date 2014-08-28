<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login page.aspx.cs" Inherits="Login_page" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%; height: 100%">
            <tr>
                <td align="center" valign="middle">
                    <table style="width: 263px; height: 250px">
                        <tr>
                            <td style="height: 95px">
                            </td>
                            <td style="height: 95px">
                                <asp:Label ID="lblLoginPage" runat="server" Font-Size="XX-Large" Font-Underline="True"
                                    Text="Login Page"></asp:Label></td>
                            <td style="width: 176px; height: 95px">
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 1px">
                                <asp:Label ID="lblUserName" runat="server" Text="User name:" Width="98px"></asp:Label></td>
                            <td style="height: 1px">
                                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
                            <td style="width: 176px; height: 1px">
                                <asp:RequiredFieldValidator ID="unameValidator" runat="server" ControlToValidate="txtUserName"
                                    ErrorMessage="Please enter user name"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td style="height: 1px">
                                <asp:Label ID="lblUserPassword" runat="server" Text="Password:"></asp:Label></td>
                            <td style="height: 1px">
                                <asp:TextBox ID="txtUserPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                            <td style="width: 176px; height: 1px">
                                <asp:RequiredFieldValidator ID="upassValidator" runat="server" ControlToValidate="txtUserPassword"
                                    ErrorMessage="please enter password"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="PassLengthValid" runat="server" ControlToValidate="txtUserPassword"
                                    ErrorMessage="Password must be at least 6 characters" ValidationExpression="^[\w]{6,}"
                                    Width="238px"></asp:RegularExpressionValidator></td>
                        </tr>
                        <tr>
                            <td style="height: 2px">
                            </td>
                            <td style="height: 2px">
                            </td>
                            <td style="width: 176px; height: 2px">
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 2px">
                                <asp:Button ID="btnSubmit" runat="server" BackColor="SkyBlue" BorderStyle="Outset"
                                    Font-Bold="True" ForeColor="Black" OnClick="btnSubmit_Click" Text="Submit" /></td>
                            <td style="height: 2px">
                                <asp:Label ID="lblLoginError" runat="server" ForeColor="Red"></asp:Label></td>
                            <td style="width: 176px; height: 2px">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
