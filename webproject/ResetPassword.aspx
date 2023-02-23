<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="_web_project.ResetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <a name="top"></a>
            <style>
    ol {
  background: lightgreen;
  list-style-type: upper-roman;
  text-align: left;
  font-size:larger;
}
body {
    background-image:url('x.jpeg');
    background-repeat:no-repeat;
    background-attachment:fixed;
}
 ul{
  font-weight: 700; font-size: ;Width="132px";
  list-style-type: none;
  margin: 0;
  padding: 0;
  overflow: hidden;
}
      a {
          background-color:#33CC33; Height:36px ;font-weight: 700; font-size: large; Width:132px;
      }
      a:hover, a:active {
  background-color: blue;
  text-decoration: underline;
}
a:link, a:visited {
  background-color:lightorange;
  color: black;
  padding: 2px 3px;
  text-align: left; 
  text-decoration: none;
}
.center {
  font-style: italic;
  font-size: 2.5em;
  color: red;
  text-align: center; 
}
        </style>
    <title>Online News and Community Care</title>
</head>
<body>
    <form id="form1" runat="server">
   
        <br />
        <br />
        <br />
<div style="font-family:Arial">
    <table style="border: 1px solid black; width:300px">
        <tr>
            <td colspan="2">
                <b>Reset my password</b>
            </td>
        </tr>
        <tr>
            <td>
                User Name
            </td>    
            <td>
                <asp:TextBox ID="txtUserName" Width="150px" runat="server">
                </asp:TextBox>
            </td>    
        </tr>
        <tr>
            <td>
                    
            </td>    
            <td>
                <asp:Button ID="btnResetPassword" runat="server" 
                Width="150px" Text="Reset Password" onclick="btnResetPassword_Click" BackColor="#FF6666" />
            </td>    
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>    
        </tr>
    </table>
            <br />
        <br />
        <br />
            <br />
        <br />
</div>
    </form>
</body>
</html>