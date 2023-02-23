<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="_web_project.search" %>

<!DOCTYPE html>
    <html xmlns="http://www.w3.org/1999/xhtml" lang ="bn">

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
        
        .auto-style2 {
            font-size: large;
        }

        .auto-style3 {
            font-size: x-large;
            color: #000066;
        }

        </style>
    </head>
<body data-market="bikroy" data-env="production" data-os="" data-os-ver="" class="on-home-landing">
	<form id="form1" runat="server">
        <div class="w3-bar w3-border w3-light-grey w3-center">
  <a href="home.aspx" style="width:25%; color: #660066;" class="w3-bar-item w3-button w3-mobile"><span class="auto-style2"><strong>ই-শপ.কম</strong></span></a>
  <a href="help.aspx" style="width:25%; color: #660066;" class="w3-bar-item w3-button w3-mobile"><strong><span class="auto-style2"><span class="auto-style2">হেল্প ও সাপোর্ট</span></span></strong><span class="auto-style2"><span class="auto-style9"></span></span></span></a>
  <a href="login.aspx" style="width:25%; color: #660066;" class="w3-bar-item w3-button w3-mobile"><strong><span class="auto-style2"><span class="auto-style2">লগ আউট</span></span></strong><span class="auto-style2"><span class="auto-style9"></span></span></span></a>
  <a href="AddToCart.aspx" style="width:25%; color: #660066;" class="w3-bar-item w3-button w3-mobile"><strong><span class="auto-style2">কার্ট
  (<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>)
            </span></strong>
            </a></div>

<div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" ForeColor="#339966" Height="36px" OnClick="Button2_Click" Text="পণ্য সংযুক্তি" Width="106px" Font-Bold="True" Font-Size="Medium" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button5" runat="server" ForeColor="#339966" Height="38px" OnClick="Button5_Click" Text="অনুসন্ধান" Width="123px" Font-Bold="True" Font-Size="Medium" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button6" runat="server" ForeColor="#339966" Height="35px" OnClick="Button6_Click" Text="লগ ইন" Width="160px" Font-Bold="True" Font-Size="Medium" />
    <br />
    </div>
        <br />
        <strong><span class="auto-style3">
        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <br />
        </span></strong>
        <br />
        <strong><span class="auto-style3">প্রোডাক্টের নাম লিখুনঃ<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
        <asp:TextBox ID="TextBox1" runat="server" Height="44px" OnTextChanged="TextBox1_TextChanged" Width="230px"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button7" runat="server" Font-Bold="True" ForeColor="#CC0000" Height="37px" OnClick="Button7_Click" Text="খুঁজুন" Width="118px" />
        </strong>
        <br />
        <br />


        <br />

<hr />
    <div class="footer-final row">
                <div class="col-8 copyright"><p>&copy; কপিরাইট-ই-শপ ডট  কম লিমিটেড ২০২২</P>
						<p>"ই-শপ  এর অফিশিয়াল ফেসবুক পেজ লিঙ্কঃ <a href ="https://www.facebook.com/Eshop">ই-শপ.কম</a> এই 
                            পেজ ছাড়া অন্য কোনো ফেসবুক পেজে অর্ডার করলে কিংবা আর্থিক লেনদেন করলে EShop.com কর্তৃপক্ষ দায়ী থাকবে না।”</P></div>
    </form>
</body>
</html>
