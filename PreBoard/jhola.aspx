<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>VALIDATION CONTROL</h2>
    
    <div>
        <label for="txtName">Name:</label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Name is required" ForeColor="Red"/>

    </div>

    <div>
        <label for="txtAge">Age:</label>
        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="rvAge" ControlToValidate="txtAge" MinimumValue="10" MaximumValue="100" Type="Integer" runat="server" ErrorMessage="Age must be between 10 and 100" ForeColor="Red" />

    </div>
    <div>
        <label for="password">Password:</label>
        <asp:TextBox TextMode="password" ID="password" runat="server"></asp:TextBox> 
        <label for="cPassword">Confirm Password:</label>
        <asp:TextBox TextMode="Password" ID="cPassword" runat="server"></asp:TextBox>
        <asp:CompareValidator ControlToValidate="cPassword" ControlToCompare="password" ErrorMessage="Password doesn't match" ForeColor="Red" runat="server" />
    </div>
    <div>
        <label for="email">Email: </label>
        <asp:TextBox ID="email" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="email" ValidationExpression="^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$" ErrorMessage="Enter a valid email" ForeColor="red" />

    </div>
 <asp:Button ID="submit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
</asp:Content>