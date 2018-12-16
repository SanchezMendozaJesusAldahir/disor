<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Cesarc.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cesar</title>
    <style type="text/css">
        #TextArea1 {
            height: 21px; 
            width: 94px;
            top: -102px;
            left: 100px;
            margin-left: 13px;
        }
        #Text1 {
            width: 284px;
            margin-left: 8px;
        }
        #Text2 {
            height: 180px;
            width: 246px;
            top: 98px;
            left: -100px;
        }
        #Text3 {
            height: 184px;
            width: 269px;
        }
        #TextArea2 {
            height: 22px;
            width: 131px;
        }
        #Text4 {
            height: 173px;
            width: 297px;
        }
        #Text5 {
            height: 19px;
            width: 80px;
        }
    </style>
</head>
<body style="height: 682px">
    <form id="form1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        Texto Plano<asp:TextBox ID="textbox1" runat="server" Text="" /></p>
    <div style="height: 315px; width: 1052px; margin-bottom: 18px">
        <fieldset>
            <div height: 290px; width: 301px; position: relative;">
                Desplazamiento<asp:TextBox ID="textbox5" runat="server" Text="" /><br />
                <br />
                Cifrado<br />
                <asp:TextBox ID="TextBox2" runat="server" Height="200px" Width="276px"></asp:TextBox>
            </div>
        </fieldset>

        <fieldset>
            <div  position: relative; top: -297px; left: 317px; height: 288px; width: 327px;">
                Transpocision Inversa<br />
                <br />
                <br />
                <asp:TextBox ID="TextBox3" runat="server" Height="189px" Width="298px"></asp:TextBox>
            </div>
        </fieldset>
        <div>
        </div>
        <fieldset>
            <div position: relative; top: -603px; left: 665px; height: 280px; width: 368px;">
                En grupos de<asp:TextBox ID="textbox6" runat="server" Text=""  /><br />
                <br />
                Transposicion Inversa en Grupos<asp:TextBox ID="TextBox4" runat="server" Height="187px" Width="324px"></asp:TextBox>
            </div>
        </fieldset>
    </div>
    </form>
</body>
</html>