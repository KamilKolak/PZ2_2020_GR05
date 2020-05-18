<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Patient.aspx.cs" Inherits="WebApplication1.Pages.Patient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Hospital</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Patient.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Open+Sans:wght@300;400;600;700&display=swap" rel="stylesheet" />

    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/popper.min.js"></script>

</head>
<body class="text-center">
    <form id="form1" runat="server">
        <div class="d-flex flex-column align-items-center  justify-content-center">
                <div class="row">
                    <div class="col-sm-4">
                        <img class="m-2 float-sm-right"  src="/Images/patient.png" />
                    </div>
                    <div class="col-sm-8" id="info">
                        <div class="row  d-flex justify-content-center justify-content-sm-start">
                            <asp:Label ID="LabelWelcome" runat="server" class="mb-2 font-weight-bold" />
                        </div>
                        <div class="row  d-flex justify-content-center justify-content-sm-start">
                            <asp:Label ID="LabelId" runat="server" class="mb-2 font-weight-normal" Text="ID: &nbsp;" />
                            <asp:Label ID="LabelIdValue" runat="server" class="mb-2 font-weight-normal" />
                        </div>
                        <div class="row  d-flex justify-content-center justify-content-sm-start">
                            <asp:Label ID="LabelToPaid" runat="server" class="mb-2 font-weight-normal" Text="Do zapłaty: &nbsp;" />
                            <asp:Label ID="LabelToPaidValue" runat="server" class="mb-2 font-weight-normal" />
                        </div>
                        <div class="row  d-flex justify-content-center justify-content-sm-start">
                            <asp:Label ID="LabelVisit" runat="server" class="mb-2 font-weight-normal" Text="Następna wizyta: &nbsp;" />
                            <asp:Label ID="LabelVisitValue" runat="server" class="mb-2 font-weight-normal" />
                        </div>
                        <div class="row  d-flex justify-content-center justify-content-sm-start">
                            <asp:Button runat="server" ID="buttonLogout" class="m-2 btn btn-primary btn-block btn-sm" Text="Wyloguj" OnClick="buttonLogout_Click" />
                        </div>
                    </div>
                </div>
        </div>
    </form>
</body>
</html>
