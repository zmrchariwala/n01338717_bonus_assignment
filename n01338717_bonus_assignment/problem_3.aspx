<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="problem_3.aspx.cs" Inherits="n01338717_bonus_assignment.problem_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Problem 3</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>HTTB Booking</h1>
        <div>
            <asp:Label runat="server">How many tickets would you like to buy?</asp:Label>
        </div>
        <div>
            <asp:TextBox runat="server" ID="tickets_quantity"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="tickets_quantity" ForeColor="Red" ErrorMessage="Please enter a number" ></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Button runat="server" Text="Submit" />
        </div>
        <div runat="server" id="summary">
        </div>
    </form>
</body>
</html>
