<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Hospital</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Default.css" rel="stylesheet" />

    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/popper.min.js"></script>
</head>
<body class="text-center">
    <form id="form1" runat="server">
        <div class="d-flex flex-column align-items-center">
            <img class="m-2" src="/Images/login.png" />
            <h3 class="mb-2 font-weight-normal">Podaj login i hasło</h3>
            <asp:TextBox runat="server" id="inputLogin" class="form-control" placeholder="Login" />
            <asp:TextBox runat="server" id="inputPassword" TextMode="Password" class="form-control" placeholder="Hasło" />
            <asp:button runat="server" ID="buttonLogin" class="m-2 btn btn-primary btn-block btn-lg" Text="Zaloguj" OnClick="buttonLogin_Click" />
            <asp:Label ID="LabelLoginFailed" runat="server" class="h5 font-weight-normal" Text="" />
        </div>
    </form>
</body>
</html>
