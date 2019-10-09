<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="problem_2.aspx.cs" Inherits="n01338717_bonus_assignment.problem_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Weekly Calendar</h1>
        </div>
        <div>
            <asp:CheckBoxList runat="server" ID="week_days">
                <asp:ListItem Text="Monday" Value="0"></asp:ListItem>
                <asp:ListItem Text="Tuesday" Value="1"></asp:ListItem>
                <asp:ListItem Text="Wednesday" Value="2"></asp:ListItem>
                <asp:ListItem Text="Thursday" Value="3"></asp:ListItem>
                <asp:ListItem Text="Friday" Value="4"></asp:ListItem>
                <asp:ListItem Text="Saturday" Value="5"></asp:ListItem>
                <asp:ListItem Text="Sunday" Value="6"></asp:ListItem>
            </asp:CheckBoxList>
            
        </div>
        <div>
            <asp:Button runat="server" Text="Submit" />
        </div>
        <div runat="server" id="monthly_summary">

        </div>
    </form>
</body>
</html>
