<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RDLC_Report.aspx.cs" Inherits="_web_project.RDLC_Report" %>

<!DOCTYPE html><html lang="bn">
    <meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1">
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
                .auto-style2 {
            font-size: large;
        }
        .auto-style6 {
            width: 302px;
            height: 78px;
        }
        .auto-style7 {
            width: 302px;
            height: 87px;
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
<body>
    <form id="form1" runat="server">
         <div class="w3-bar w3-border w3-light-grey w3-center">
  <a href="home.aspx" style="width:25%; color: #AC5425;" class="w3-bar-item w3-button w3-mobile"><span class="auto-style2"><strong>E-Shop.com</strong></span></a>
  <a href="help.aspx" style="width:25%; color: #AC5425;" class="w3-bar-item w3-button w3-mobile"><strong><span class="auto-style2"><span class="auto-style2">Help and Support</span></span></strong><span class="auto-style2"><span class="auto-style9"></span></span></span></a>
 <asp:Button ID="Button7" runat="server" ForeColor="#AC5425" Height="34px" OnClick="Button7_Click" Text="Log Out" Width="182px" Font-Bold="True" Font-Size="Medium"  />
  <a href="AddToCart.aspx" style="width:25%; color: #AC5425;" class="w3-bar-item w3-button w3-mobile"><strong><span class="auto-style2">Cart
  (<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>)
            </span></strong>
            </a></div>
   
        <br />
        <br />
        <br /> 
        <asp:TextBox ID="TextBox1" runat="server" Width="100%" Font-Size="60px">You will find Your Cash Memo Here</asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
         
    </form>
</body>
</html>