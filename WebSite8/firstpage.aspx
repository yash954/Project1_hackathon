<%@ Page Language="C#" AutoEventWireup="true" CodeFile="firstpage.aspx.cs" Inherits="firstpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div  style="background-color: red ; align-items:center; ">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:AdRotator  runat="server" AdvertisementFile="XMLFile.xml" Target="_blank" KeywordFilter="Computer"  Width="600px"  height="600px"  />
    <img src="book.jpg"  /><h2>BOOK NOW</h2></div>

        <br/><br/><br/><br/><br/>

       <asp:label Text="Enter city " runat="server" id="lb1"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:dropdownlist id="drp1" runat="server"  OnSelectedIndexChanged="hello"  OnTextChanged="hello" />
        
        <asp:button ID="btn1" runat="server" OnClick="hell" Visible="false" Text="next" Width="45px"/>
    </form>
</body>
</html>
