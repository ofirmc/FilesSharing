<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Files Search Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%; height: 100%">
            <tr>
                <td align="center" valign="middle">
                    <table style="width: 314px; height: 265px">
                        <tr>
                            <td>
                            </td>
                            <td style="width: 536px">
                                <asp:Label ID="lblSiteTitle" runat="server" Font-Bold="True" Font-Size="XX-Large"
                                    Font-Underline="True" Text="File Search"></asp:Label><br />
                                welcome to file search. you can select a single xml file to download from the search
                                result table or download all the files that appear in it from the provided link
                                below.</td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                            <td style="width: 536px">
                                <asp:HyperLink ID="hlSignin" runat="server" NavigateUrl="~/Sign in page.aspx">Sign in</asp:HyperLink>
                                <asp:HyperLink ID="hlLogin" runat="server" NavigateUrl="~/Login page.aspx">Login</asp:HyperLink>
                                <asp:LinkButton ID="lBtnSignout" runat="server" OnClick="lBtnSignout_Click">Sign out</asp:LinkButton>
                                <asp:LinkButton ID="lBtnSearchHistory" runat="server" OnClick="lBtnSearchHistory_Click">My search history</asp:LinkButton></td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 65px">
                            </td>
                            <td style="width: 536px; height: 65px;">
                                &nbsp;<asp:Label ID="lblSerachFiles" runat="server" Text="Search files:"></asp:Label>
                                <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>&nbsp;
                                <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" BackColor="SkyBlue" BorderStyle="Outset" />
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                            </td>
                            <td style="height: 65px">
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 2px">
                            </td>
                            <td style="width: 536px; height: 2px">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label></td>
                            <td style="height: 2px">
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 3px">
                            </td>
                            <td style="width: 536px; height: 3px">
                                <asp:LinkButton ID="lBtnDownloadXML" runat="server" OnClick="lBtnDownloadXML_Click">Download XML</asp:LinkButton></td>
                            <td style="height: 3px">
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 92px">
                            </td>
                            <td style="width: 536px; height: 92px;">
                                &nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:GridView ID="GridVResults" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan"
                                    BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Width="441px" OnSelectedIndexChanged="GridVResults_SelectedIndexChanged">
                                    <FooterStyle BackColor="Tan" />
                                    <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                                    <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                                    <HeaderStyle BackColor="Tan" Font-Bold="True" />
                                    <AlternatingRowStyle BackColor="PaleGoldenrod" />
                                    <Columns>
                                        <asp:CommandField ShowSelectButton="True" />
                                    </Columns>
                                </asp:GridView>
                            </td>
                            <td style="height: 92px">
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
