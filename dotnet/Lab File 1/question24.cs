// // Note: This code doesnot run in online Compilers as it is webform code
// <%@ Page Language="C#" Inherits="RegisterApp.Default" %>
// <!DOCTYPE html>
// <html xmlns="http://www.w3.org/1999/xhtml">
// <head>
//     <title>Form Submission</title>
//     <style>
//         .error {
//             color: red;
//         }
//     </style>
// </head>
// <body>
//     <center>
//         <h1>Register Form:</h1>
//         <form id="form1" runat="server">
//             <asp:Label ID="name" runat="server" Text="Name:"></asp:Label>
//             <asp:TextBox ID="tName" runat="server"></asp:TextBox>
//             <br /><br />

//             <asp:Label ID="address" runat="server" Text="Address:"></asp:Label>
//             <asp:TextBox ID="tAddress" runat="server"></asp:TextBox>
//             <br /><br />

//             <asp:Label ID="gender" runat="server" Text="Gender:"></asp:Label>
//             <asp:RadioButton ID="rmale" runat="server" Text="Male" GroupName="gender"></asp:RadioButton>
//             <asp:RadioButton ID="rfemale" runat="server" Text="Female" GroupName="gender"></asp:RadioButton>
//             <br /><br />

//             <asp:Label ID="country" runat="server" Text="Country:"></asp:Label>
//             <asp:DropDownList ID="dropdown" runat="server">
//                 <asp:ListItem>Please Select Country:</asp:ListItem>
//                 <asp:ListItem>Nepal</asp:ListItem>
//                 <asp:ListItem>Bhutan</asp:ListItem>
//                 <asp:ListItem>India</asp:ListItem>
//                 <asp:ListItem>Japan</asp:ListItem>
//                 <asp:ListItem>China</asp:ListItem>
//             </asp:DropDownList>
//             <br /><br />

//             <asp:Button ID="btnSubmit" runat="server" Text="Submit"></asp:Button>
//         </form>
//     </center>
// </body>
// </html>