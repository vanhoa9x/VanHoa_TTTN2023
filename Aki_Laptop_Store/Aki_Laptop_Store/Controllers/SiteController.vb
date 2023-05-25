Imports System.Web.Mvc

Namespace Controllers
    Public Class SiteController
        Inherits Controller

        ' GET: Site
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace