<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="_web_project.ChangePassword" %>

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
    background-image:url('l.jpeg');
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
    <title> Change Password</title>
    <style type="text/css">
        .auto-style1 {
            width: 463px;
        }
        .auto-style2 {
            height: 118px;
        }
        .auto-style3 {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
    <div>
    <div style="font-family: Arial">
<table style="border: 1px solid black; height: 264px; width: 452px;">
    <tr>
        <td colspan="2">
            <b>Change Password</b>
        </td>
    </tr>
    <tr>
        <td>
            New Password
        </td>
        <td class="auto-style1">
            :<asp:TextBox ID="txtNewPassword"  
            runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorNewPassword" 
                runat="server" ErrorMessage="New Password required"

 

                 ControlToValidate="txtNewPassword" ForeColor="Red">
            </asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Confirm New Password
        </td>
        <td class="auto-style1">
            :<asp:TextBox ID="txtConfirmNewPassword"  runat="server">
            </asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmNewPassword" 
                runat="server" ErrorMessage="Confirm New Password required" Text="*" 
                ControlToValidate="txtConfirmNewPassword"
                ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidatorPassword" runat="server" 
                ErrorMessage="New Password and Confirm New Password must match"
                ControlToValidate="txtConfirmNewPassword" ForeColor="Red" 
                ControlToCompare="txtNewPassword"
                Display="Dynamic" Type="String" Operator="Equal" >
            </asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td>
                    
        </td>
        <td class="auto-style1">
            &nbsp;<asp:Button ID="btnSave" runat="server" 
            Text="Save" onclick="btnSave_Click" Width="70px" BackColor="#33CC33" />
        </td>
    </tr>
    <tr>
        <td colspan="2" class="auto-style3">
            <asp:Label ID="lblMessage" runat="server">
            </asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2" class="auto-style2">
            <asp:ValidationSummary ID="ValidationSummary1" 
            ForeColor="Red" runat="server" />
        </td>
    </tr>
</table>
       <asp:Button ID="Button7" runat="server" BackColor="White" OnClick="Button7_Click" Text="Try Now" Height="39px" Width="110px" />
</div>

    </div>
                <br />
        <br />
        </form>
</body>
</html>
