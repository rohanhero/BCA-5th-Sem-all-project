// // Note: This code doesnot run in online Compilers as it is webform code
// <%@ Page Language="C#" Inherits="EmailRegister.Default" %>
// <!DOCTYPE html>
// <html xmlns="http://www.w3.org/1999/xhtml">
// <head>
//     <meta charset="UTF-8" />
//     <title>Simple Registration Form</title>
// </head>
// <body>
//     <center>
//         <h2>Registration Form</h2>
//         <form id="form1" runat="server">
//             <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
//             <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
//             <br /><br />

//             <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
//             <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
//             <br /><br />

//             <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password:"></asp:Label>
//             <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
//             <br /><br />

//             <asp:Label ID="lblAge" runat="server" Text="Age:"></asp:Label>
//             <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
//             <br /><br />

//             <asp:Label ID="lblEmail" runat="server" Text="Email Id:"></asp:Label>
//             <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
//             <br /><br />

//             <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
//         </form>
//     </center>
// </body>
// </html>