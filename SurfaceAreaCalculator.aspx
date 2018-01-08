<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SurfaceAreaCalculator.aspx.cs" Inherits="Surface_Area_Calculator.SurfaceAreaCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table align="center" class="auto-style1" border="1" style="background-color:beige">
            <tr>
                <td class="auto-style2" colspan="4"><strong>Calculating Surface Area and Volume</strong></td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style4">Cube</td>
                <td class="auto-style4">Sphere</td>
                <td class="auto-style4">Pyramid</td>
            </tr>
            <tr>
                <td class="auto-style6"><b>Enter Radius</b></td>
                <td class="auto-style6"></td>
                <td class="auto-style6">
                    <asp:TextBox ID="radiusSphere" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td><b>Enter Length of Side/Base Length</b></td>
                <td>
                    <asp:TextBox ID="sideCube" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:TextBox ID="sidePyramid" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><b>Enter Height</b></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:TextBox ID="heightPyramid" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Enter Base Width</td>
                <td class="auto-style3"></td>
                <td class="auto-style3"></td>
                <td class="auto-style3">
                    <asp:TextBox ID="widthPyramid" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Enter Slant Height</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">
                    <asp:TextBox ID="slantHeight" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:ListBox ID="resultsCube" runat="server" Width="317px"></asp:ListBox>
                </td>
                <td>
                    <asp:ListBox ID="resultsSphere" runat="server" Width="287px"></asp:ListBox>
                </td>
                <td>
                    <asp:ListBox ID="resultsPyramid" runat="server" Width="244px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="cube" runat="server" Text="Calculate" Height="26px" OnClick="cube_Click"  />
                </td>
                <td>
                    <asp:Button ID="sphere" runat="server" Text="Calculate" OnClick="sphere_Click" />
                </td>
                <td>
                    <asp:Button ID="pyramid" runat="server" Text="Calculate" OnClick="pyramid_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
