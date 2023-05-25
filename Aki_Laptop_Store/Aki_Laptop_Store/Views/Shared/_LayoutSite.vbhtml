<!DOCTYPE html>
<html>
<head>
    <title>@Page.Title</title>
    <link href="~/Pulic/css/StyleSite.css" rel="stylesheet" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    @*@RenderSection("header", required:     false)*@
</head>
<body>
    <section class="header clearfix">
        <div class="header-info">
            <div class="container">
                <div class="row">
                    <div class="col-md">

                        <a class="" href="#">ORDER ONLINE OR CALL US (+84) 343300521</a>
                    </div>
                    <div class="col-md-4" style="color: white;">
                        @*Sign in or Create Account | Link Follow*@
                        <a class="sign-in" href="#">Sign in</a>
                        or <a class="sign-in" href="#">Create Account</a>
                    </div>
                </div>
            </div>

        </div>

        <div class="container py-2">
            <div class="row">
                <div class="col-md-3 logo">
                    @*Logo_Store*@
                    <img src="~/Pulic/images/Logo.png" alt="Logo" class="img-fluid" />
                </div>

                <div class="col-md-6">
                    @*Contact*@
                </div>
                <div class=" col-md-3">
                    @*Cart/ Bag-Shopping*@
                </div>
            </div>
        </div>
        <div class="container nav-header">
            @*Navheader*@
            <ul class="nav nav-tabs">
                <li class="nav-item">
                    <a class="nav-link active" href="#">Home</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Link</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Link</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link disabled" href="#">Disabled</a>
                </li>
            </ul>
        </div>
    </section>
    <section class="mainmenu clearfix"></section>
    <section class="maincontent clearfix"></section>
    @RenderBody()
    <section class="footer clearfix"></section>
    <section class="copyrigt clearfix"></section>
    <script src="~/Scripts/bootstrap.bundle.min.js"></script>
    <script src="~/Pulic/fontawesome-free-6.4.0-web/js/fontawesome.min.js"></script>
    @*@RenderSection("footer", required:    false)*@
</body>
</html>
