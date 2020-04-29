Public Class testLogic
    Private Sub testLogic_Click(sender As Object, e As EventArgs) Handles MyBase.Click, btnLogIn.Click
        Dim strDBenutzername As String = "jeynie"
        Dim strDPasswort As String = "pw"

        initialise()
        Dim versuch As Dictionary(Of String, String) = logIn(strDBenutzername, strDPasswort)

        lblattempt.Text = versuch("attempt")
        lblrole.Text = versuch("role")

        ' Console.WriteLine("blabliblub")

    End Sub
End Class