<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="_web_project.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
        <a name="top"></a>

<title>Online News and Community Care</title>
    <meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway">
<meta name="viewport" content="width=device-width, initial-scale=1.0" />
<meta name="description" content="" />
<meta name="author" content="" />
<!-- favicons -->
<link rel="shortcut icon" href="images/templatemo_favicon.ico">
<!-- bootstrap core CSS -->
<link href="css/bootstrap.min.css" rel="stylesheet" />
<!-- fancybox CSS -->
<link href="css/jquery.lightbox.css" rel="stylesheet" />
<!-- flex slider CSS -->
<link href="css/flexslider.css" rel="stylesheet" />
<!-- custom styles for this template -->
<link href="css/templatemo_style.css" rel="stylesheet" />
<!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
<!--[if lt IE 9]>
<script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
<script src="https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js"></script>
<![endif]-->
  <meta charset="utf-8" name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.0/css/all.css" integrity="sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ" crossorigin="anonymous">
  <style>
body {
    background-image:url('c.jpg');
    background-repeat:no-repeat;
    background-attachment:fixed;
}
        #Reset1 {
            width: 61px;
            margin-left: 0px;
        }
      .auto-style1 {
          font-size: xx-large;
      }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      <div></div>
        
        <br/>
        <div>
            <h1 style="color: #000080; font-size: large">&nbsp; <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Please Register Here</span></h1>
            <p style="color: #000080; font-size: large">&nbsp;</p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="username" runat="server" Text="Firstname:" Font-Bold="True" Font-Size="Large" ForeColor="#006699"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="username3" runat="server" Text="Surename: " Font-Bold="True" Font-Size="Large" ForeColor="Black"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="username4" runat="server" Text="Email:" Font-Bold="True" Font-Size="Large" ForeColor="#006600"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Email"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="username8" runat="server" Text="Contact no:" Font-Bold="True" Font-Size="Large" ForeColor="#006600" style="color: #000066"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Phone"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="username9" runat="server" Text="Address:" Font-Bold="True" Font-Size="Large" ForeColor="#006600" style="color: #993333"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="TextBox8" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Phone"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="password1" runat="server" Text="Username " Font-Bold="True" Font-Size="Large" ForeColor="Black"></asp:Label>
            :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            &nbsp;<br />
            <br />
            <asp:Label ID="password" runat="server" Text="Password " Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
            :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="password0" runat="server" Text="Confirm Password " Font-Bold="True" Font-Size="Large" ForeColor="#000066" ></asp:Label>
            :&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp; <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input id="reset" type="reset" value="reset" width="100px" name="Reset" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="#0000CC" OnClick="Button1_Click" Text="Sign Up" />
            <br />
            <br />
            </div>

       
    </form>
</body>
</html>
