<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Patient.aspx.cs" Inherits="WebApplication1.Pages.Patient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Hospital</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Patient.css" rel="stylesheet" type="text/css" />

    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/popper.min.js"></script>

</head>
<body class="text-center">
    <form id="form1" runat="server">
        <div class="d-flex flex-column align-items-center">
            <asp:Label ID="LabelWelcome" runat="server" class="mb-2 font-weight-normal"></asp:Label>
            <asp:button runat="server" ID="buttonLogout" class="m-2 btn btn-primary btn-block btn-sm" Text="Wyloguj" OnClick="buttonLogout_Click"/>
        </div>
    </form>
</body>
</html>
