<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchHistory.aspx.cs" Inherits="SearchHistory" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>My Search History</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%; height: 100%">
            <tr>
                <td align="center" valign="middle">
                    <table style="width: 312px; height: 254px">
                        <tr>
                            <td>
                            </td>
                            <td>
                                <asp:Label ID="lblPageTitle" runat="server" Font-Bold="True" Font-Size="XX-Large"
                                    Text="My Search History"></asp:Label></td>
                            <td style="width: 3px">
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td>
                                <asp:GridView ID="gridSearchHistory" runat="server" BackColor="Silver" BorderColor="Red">
                                </asp:GridView>
                            </td>
                            <td style="width: 3px">
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td>
                                <asp:LinkButton ID="lBtnMailPage" runat="server" OnClick="lBtnMailPage_Click">Mail Page</asp:LinkButton></td>
                            <td style="width: 3px">
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
