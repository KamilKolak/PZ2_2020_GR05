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
        <div class="container card mt-4">

            <div class="row card-header d-flex align-items-center justify-content-center">
                <img class="m-1" src="/Images/patient.png" />
                <asp:Label class="m-1 font-weight-bold" ID="LabelWelcome" runat="server" />
            </div>
           
            <ul class="nav nav-tabs">
                <li class="nav-item mt-2"><a class="nav-link active" data-toggle="tab" href="#profile">Profil</a></li>
                <li class="nav-item mt-2"><a class="nav-link" data-toggle="tab" href="#password">Zmień hasło</a></li>
            </ul>   

            <div class="tab-content">
                <div id="profile" class="tab-pane fade show active">
                    <div class="row">
                        <asp:Label ID="LabelName" runat="server" class="mb-2 ml-4 mt-2 font-weight-bold" Text="Imię: &nbsp;" />
                        <asp:Label ID="LabelNameValue" runat="server" class="mb-2 mt-2 font-weight-normal" />
                    </div>
                    <div class="row">
                         <asp:Label ID="LabelSurname" runat="server" class="mb-2 ml-4 font-weight-bold" Text="Nazwisko: &nbsp;" />
                        <asp:Label ID="LabelSurnameValue" runat="server" class="mb-2 font-weight-normal" />
                    </div>
                    <div class="row">
                        <asp:Label ID="LabelToPaid" runat="server" class="mb-2 ml-4 font-weight-bold" Text="Do zapłaty: &nbsp;" />
                        <asp:Label ID="LabelToPaidValue" runat="server" class="mb-2 font-weight-normal" />
                    </div>
                    <div class="row">
                        <asp:Label ID="LabelVisit" runat="server" class="mb-2 ml-4 font-weight-bold" Text="Następna wizyta: &nbsp;" />
                        <asp:Label ID="LabelVisitValue" runat="server" class="mb-2 font-weight-normal" />
                    </div>
                    <div class="row">
                        <asp:Button runat="server" ID="buttonLogout" class="btn ml-4 mb-4 mt-2 btn-primary btn-block btn-sm" Text="Wyloguj" OnClick="buttonLogout_Click" />
                    </div>
                </div>

                <div id="password" class="tab-pane fade m-3">
                    <asp:TextBox runat="server" id="inputOldPassword" TextMode="Password" class="form-control mt-2" placeholder="Podaj stare hasło" />
                    <asp:TextBox runat="server" id="inputNewPassword" TextMode="Password" class="form-control mt-2" placeholder="Podaj nowe hasło" />
                    <asp:Button runat="server" ID="buttonChangePassword" class="btn mt-3 mb-2 btn-primary btn-block btn-sm" Text="Zmień hasło" OnClick="buttonChangePassword_Click" />
                </div>
            </div>

        </div>

        <asp:Label ID="LabelPasswordChanged" runat="server" Text="Hasło zostało zmienione" />
        <asp:Label ID="LabelIncorrectLoginPassword" runat="server" Text="Zły login lub hasło" />

    </form>
</body>
</html>
