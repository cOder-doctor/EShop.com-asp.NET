<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SaveRating.aspx.cs" Inherits="_web_project.SaveRating" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html><html lang="bn">

<meta http-equiv="content-type" content="text/html;charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<head><meta http-equiv="X-UA-Compatible" content="IE=edge"><title>Eshop.com</title>
<link rel="alternate"><link rel="canonical" href="index.html"><meta name="robots" content="noodp"><meta 
    name="description" content="পুরনো গাড়ি থেকে শুরু করে মোবাইল ফোন, এমনকি নতুন বাড়ি সহ সবকিছু ক্রয়-বিক্রয় করুন। আপনার নিকটবর্তী স্থান থেকে
     একটি চমৎকার ডিল খুঁজে নিন, বা সারা বাংলাদেশে খুঁজুন।"><!-<link rel="canonical" href="index.html"><meta name="theme-color" content="#ffffff">
    <meta name="google-site-verification" content="Fby1wz3clnhb00BBvcVaaqdUDHc-qCbAbTE19zkpyBo"><meta name="viewport" content="width=device-width, 
        user-scalable=yes, maximum-scale=1, initial-scale=1"><link rel="manifest" href="manifest.json"><link data-page-stylesheet rel="stylesheet" 
            href="dist/15701872/css/lg/bikroy/home.css"><link rel="shortcut icon"><link rel="apple-touch-icon-precomposed" 
                href="../w.bikroy-st.com/dist/img/all/icons/apple-touch-icon-precomposed.png"><link rel="msapplication-TileColor" href="#009877">
    <link rel="msapplication-TileImage" href="../w.bikroy-st.com/dist/img/all/icons/metro-tile.png"><script>var googletag = googletag || {};


                                                                                                        googletag.cmd = googletag.cmd || [];
                                                                                                        (function () {
                                                                                                            var gads = document.createElement('script');
                                                                                                            gads.async = true;
                                                                                                            gads.type = 'text/javascript';
                                                                                                            var useSSL = 'https:' == document.location.protocol;
                                                                                                            gads.src = (useSSL ? 'https:' : 'http:') + '//securepubads.g.doubleclick.net/tag/js/gpt.js';
                                                                                                            var node = document.getElementsByTagName('script')[0];
                                                                                                            node.parentNode.insertBefore(gads, node);
                                                                                                        })();
                                                                                                        googletag.cmd.push(function () {
                                                                                                            googletag.defineSlot('/134461134/bikroy_desktop_homepage_leaderboard', [[970, 90]], 'div-gpt-ad-7834428653818-648').setTargeting('page', ['home']).setTargeting('locale', ['bn']).setTargeting('Ad_Format', ['leaderboard']).setTargeting('Platform', ['Desktop']).addService(googletag.pubads());
                                                                                                            googletag.pubads().enableSingleRequest();
                                                                                                            googletag.enableServices();
                                                                                                        });</script><meta property="og:url" content="https://bikroy.com/"><meta property="og:site_name" content="Bikroy.com"><meta property="og:title" content="Bikroy.com - 
     বাংলাদেশে ইলেকট্রনিকস, গাড়ি, প্রপার্টি এবং চাকরি"><meta property="og:description" content="পুরনো গাড়ি থেকে শুরু করে মোবাইল ফোন, এমনকি নতুন বাড়ি সহ সবকিছু ক্রয়-বিক্রয় করুন। 
         আপনার নিকটবর্তী স্থান থেকে একটি চমৎকার ডিল খুঁজে নিন, বা সারা বাংলাদেশে খুঁজুন।"><meta property="og:image" content="https://bikroy.com/facebook-opengraph.png"/>
    <link rel="prefetch" href="bn/ads/dhaka.html"><link rel="prerender" href="bn/ads/dhaka.html"><script> window.APIDATA = {};
                                                                                                     window.CONFIG = {};
                                                                                                     window.gtmData = [];</script>
    <style type="text/css">
                hr { 
  display: block;

  margin-left: auto;
  margin-right: auto;
  border-width: 2px;
  border-color:#069CA4;
} 
        .auto-style1 {
            font-size: large;
        }
        .starempty
        {
            background-image: url(stars/starempty.png);
            width: 50px;
            height: 50px;
        }
        .starfilled
        {
            background-image: url(stars/starfilled.png);
            width: 50px;
            height: 50px;
        }
        .starwaiting
        {
            background-image: url(stars/starwaiting.png);
            width: 50px;
            height: 50px;
        }
        </style>

    </head>

<body data-market="bikroy" data-env="production" data-os="" data-os-ver="" class="on-home-landing">
	<form id="form1" runat="server">
        <div class="w3-bar w3-border w3-light-grey w3-center">
  <a href="home.aspx" style="width:25%; color: #660066;" class="w3-bar-item w3-button w3-mobile"><span class="auto-style1"><strong>ই-শপ.কম</strong></span></a>
  <a href="help.aspx" style="width:25%; color: #660066;" class="w3-bar-item w3-button w3-mobile"><strong><span class="auto-style2"><span class="auto-style2">হেল্প ও সাপোর্ট</span></span></strong><span class="auto-style2"><span class="auto-style9"></span></span></span></a>
  <a href="login.aspx" style="width:25%; color: #660066;" class="w3-bar-item w3-button w3-mobile"><strong><span class="auto-style1"><span class="auto-style2">লগ আউট</span></span></strong><span class="auto-style2"><span class="auto-style9"></span></span></span></a>
  <a href="AddToCart.aspx" style="width:25%; color: #660066;" class="w3-bar-item w3-button w3-mobile"><strong><span class="auto-style1">কার্ট
  (<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>)
            </span></strong>
            </a></div>

<div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" ForeColor="#339966" Height="36px" OnClick="Button2_Click" Text="পণ্য সংযুক্তি" Width="106px" Font-Bold="True" Font-Size="Medium" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button5" runat="server" ForeColor="#339966" Height="38px" OnClick="Button5_Click" Text="অনুসন্ধান" Width="123px" Font-Bold="True" Font-Size="Medium" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button6" runat="server" ForeColor="#339966" Height="35px" OnClick="Button6_Click" Text="লগ ইন" Width="116px" Font-Bold="True" Font-Size="Medium" />
    </div>
        <br />
                <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

        <br />
        <asp:DataList ID="DataList1" runat="server" CellPadding="100" CellSpacing="100" DataKeyField="Id" DataSourceID="SqlDataSource1" HorizontalAlign="Justify" OnItemCommand="DataList1_ItemCommand" RepeatColumns="1" style="margin-right: 83px; margin-bottom: 59px; margin-top: 40px;" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" >
            <AlternatingItemStyle BorderColor="#996600" BorderStyle="Solid" BorderWidth="1px" />
            <EditItemStyle BorderColor="Black" BorderStyle="Dashed" BorderWidth="1px"  HorizontalAlign="Center"  />
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#FFF7E7" BorderColor="Gray" BorderStyle="Outset" BorderWidth="2px" HorizontalAlign="Justify" ForeColor="#8C4510"   Width="100%" VerticalAlign="Middle" />
            <ItemTemplate>
                <table "&gt;
                    &lt;tr&gt;
                        &lt;td class=" auto-style10"="" border="1" class="auto-style14">
                    <caption style="background-color: #C1E0FF">
                        <span class="auto-style11"><strong>Product id:</strong></span>
                        <asp:Label ID="Label9" runat="server" style="text-align: center; font-weight: 700; color: #0066FF;" Text='<%# Eval("Id") %>'></asp:Label>
                        </td>
                        </tr>
                        <tr>
                            <td class="auto-style5"><strong>Product name:</strong>&nbsp;
                                <asp:Label ID="Label2" runat="server" style="color: #CC0000; font-size: x-large; font-weight: 700" Text='<%# Eval("pro_name") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2"><span class="auto-style10"><strong>Quantity:</strong></span>&nbsp;
                                <asp:Label ID="Label3" runat="server" style="font-weight: 700; color: #0066FF" Text='<%# Eval("pro_size") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">&nbsp;<asp:ImageButton ID="ImageButton3" runat="server" Height="123px" ImageAlign="Middle" ImageUrl='<%# Eval("pro_image") %>' Width="130px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">Contact no:&nbsp;
                                <asp:Label ID="Label5" runat="server" style="font-size: medium; font-weight: 700; color: #CC0000" Text='<%# Eval("pro_mobile") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">&nbsp;<span class="auto-style9"><strong>Price:</strong></span>&nbsp;
                                <asp:Label ID="Label4" runat="server" style="font-weight: 700; color: #0099FF; font-size: large" Text='<%# Eval("pro_price") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:ImageButton ID="ImageButton4" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="addtocart" Height="80px" ImageAlign="TextTop" ImageUrl="~/Image/add to cart2.jpg" Width="150px" OnClick="ImageButton4_Click1" OnCommand="ImageButton4_Command" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                        </tr>
                         <tr>
                            <td class="auto-style5">
                                <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="buynow" Height="95px" ImageAlign="TextTop" ImageUrl="~/Image/buynow.jpg" Width="180px" OnClick="ImageButton1_Click1" OnCommand="ImageButton1_Command" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">select rating:<br />
                                <ajaxToolkit:Rating ID="Rating1" runat="server" AutoPostBack="true" CurrentRating="1" EmptyStarCssClass="starempty" FilledStarCssClass="starfilled" MaxRating="5" OnChanged="Rating1_Changed" OnClick="Rating1_Changed" StarCssClass="starempty" WaitingStarCssClass="starwaiting">
                                </ajaxToolkit:Rating>
                                <br />
                            </td>
                        </tr>
                    </caption>
                    <tr>
                        <td class="auto-style2"><span class="auto-style9"><strong>Product_Type:</strong></span>&nbsp;
                            <asp:Label ID="Label10" runat="server" style="font-weight: 700; color: #0099FF; font-size: large" Text='<%# Eval("pro_description") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2"><span class="auto-style1"><strong>Address</strong></span><span class="auto-style9"><strong>:</strong></span>&nbsp;
                            <asp:Label ID="Label7" runat="server" style="font-weight: 700; color: #0099FF; font-size: large" Text='<%# Eval("pro_address") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3"><span class="auto-style9"><strong>Average_rating:</strong></span>&nbsp;
                            <asp:Label ID="Label8" runat="server" style="font-weight: 700; color: #0099FF; font-size: large" Text='<%# Eval("pro_rating") %>'></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#738A9C" BorderColor="#FF0066" BorderStyle="Dashed" BorderWidth="3px" Font-Bold="True" ForeColor="White" />
            <SeparatorStyle BorderColor="Black" BorderWidth="1px" />
        </asp:DataList>
        <br />

        <br />
        <br />

        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Table] WHERE ([Id] = @Id)">
            <SelectParameters>
                <asp:QueryStringParameter Name="Id" QueryStringField="one" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
                  <br />
<hr />
   <div class="footer-final row">
                <div class="col-8 copyright"><p>&copy; কপিরাইট-ই-শপ ডট  কম লিমিটেড ২০২২</P>
						<p>"ই-শপ  এর অফিশিয়াল ফেসবুক পেজ লিঙ্কঃ <a href ="https://www.facebook.com/Eshop">ই-শপ.কম</a> এই 
                            পেজ ছাড়া অন্য কোনো ফেসবুক পেজে অর্ডার করলে কিংবা আর্থিক লেনদেন করলে EShop.com কর্তৃপক্ষ দায়ী থাকবে না।”</P></div>
    </form>
</body>
</html>
