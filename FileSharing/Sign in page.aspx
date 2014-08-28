<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sign in page.aspx.cs" Inherits="Sign_in_page" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Sign in Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%; height: 100%">
            <tr>
                <td align="center" valign="middle">
                    <table style="width: 224px; height: 288px">
                        <tr>
                            <td style="height: 143px">
                            </td>
                            <td style="height: 143px">
                                <asp:Label ID="lblSigninPage" runat="server" Font-Bold="True" Font-Size="XX-Large"
                                    Font-Underline="True" Text="Sign in page" Width="172px"></asp:Label></td>
                            <td style="width: 201px; height: 143px;">
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 1px">
                                <asp:Label ID="lblFirstName" runat="server" Text="First name:" Width="133px"></asp:Label></td>
                            <td style="height: 1px">
                                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
                            <td style="width: 201px; height: 1px">
                                <asp:RequiredFieldValidator ID="fNameValidatoer" runat="server" ErrorMessage="Please enter first name."
                                    Width="191px" ControlToValidate="txtFirstName"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td style="height: 1px">
                                <asp:Label ID="lblLastName" runat="server" Text="Last name:"></asp:Label></td>
                            <td style="height: 1px">
                                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
                            <td style="width: 201px; height: 1px;">
                                <asp:RequiredFieldValidator ID="lNameValidator" runat="server" ErrorMessage="Please enter last name." ControlToValidate="txtLastName"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td style="height: 2px">
                                <asp:Label ID="lblUserName" runat="server" Text="User name:"></asp:Label></td>
                            <td style="height: 2px">
                                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
                            <td style="width: 201px; height: 2px;">
                                <asp:RequiredFieldValidator ID="unValidator" runat="server" ErrorMessage="Pleasr enter user name." ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
                                <asp:Label ID="lblChooseDifferentName" runat="server" ForeColor="Red"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="height: 1px">
                                <asp:Label ID="lblUserPassword" runat="server" Text="User password:"></asp:Label></td>
                            <td style="height: 1px">
                                <asp:TextBox ID="txtUserPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                            <td style="width: 201px; height: 1px;">
                                <asp:RequiredFieldValidator ID="upassValidator" runat="server" ErrorMessage="Please enter password." ControlToValidate="txtUserPassword"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="PasswordLengthValid" runat="server" ErrorMessage="Password must be at least 6 characters." ControlToValidate="txtUserPassword" Width="254px" ValidationExpression="^[\w]{6,}"></asp:RegularExpressionValidator></td>
                        </tr>
                        <tr>
                            <td style="height: 2px">
                                <asp:Label ID="lblReenterPass" runat="server" Text="ReEnter password:"></asp:Label></td>
                            <td style="height: 2px">
                                <asp:TextBox ID="txtReenterPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                            <td style="width: 201px; height: 2px;">
                                <asp:RequiredFieldValidator ID="reRequireValidtor" runat="server" ErrorMessage="Please reEnter password"
                                    Width="154px" ControlToValidate="txtReenterPassword"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="reCompareValidator1" runat="server" ErrorMessage="Passwords are not equal" ControlToCompare="txtUserPassword" ControlToValidate="txtReenterPassword"></asp:CompareValidator></td>
                        </tr>
                        <tr>
                            <td style="height: 1px">
                                <asp:Label ID="lblUserEmail" runat="server" Text="Email:"></asp:Label></td>
                            <td style="height: 1px">
                                <asp:TextBox ID="txtUserEmail" runat="server"></asp:TextBox></td>
                            <td style="width: 201px; height: 1px;">
                                <asp:RequiredFieldValidator ID="emRequireValidator" runat="server" ErrorMessage="Please enter email." ControlToValidate="txtUserEmail" Width="118px"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="emRegularExpressionValidator" runat="server"
                                    ErrorMessage="Incorrect email format!" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtUserEmail" Width="158px"></asp:RegularExpressionValidator></td>
                        </tr>
                        <tr>
                            <td style="height: 1px">
                                <asp:Button ID="btnSubmit" runat="server" Text="Submit" BackColor="SkyBlue" BorderStyle="Outset" Font-Bold="True" ForeColor="Black" OnClick="btnSubmit_Click" /></td>
                            <td style="height: 1px">
                            </td>
                            <td style="width: 201px; height: 1px;">
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
