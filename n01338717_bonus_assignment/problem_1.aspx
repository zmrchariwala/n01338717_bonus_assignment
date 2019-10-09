<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="problem_1.aspx.cs" Inherits="n01338717_bonus_assignment.problem_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Problem 1</title>
    
</head>
<body>
    <form id="form1" runat="server">
        <h1>Cartesian Plane</h1>
        <div>
            <asp:Label runat="server">Enter a value for x:</asp:Label>
            <asp:TextBox runat="server" ID="x_axis"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="x_axis" ForeColor="Red" ErrorMessage="Please enter a value"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label runat="server">Enter a value for Y:</asp:Label>
            <asp:TextBox runat="server" ID="y_axis"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="y_axis" ForeColor="Red" ErrorMessage="Please enter a value"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Button runat="server" Text="Submit" />
        </div>
        <div runat="server" id="graph_summary"></div>
    </form>
</body>
</html>
