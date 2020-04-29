Public Class testLogic
    Private Sub testLogic_Click(sender As Object, e As EventArgs) Handles MyBase.Click, btnLogIn.Click
        'Dim strDBenutzername As String = "jeynie"
        'Dim strDPasswort As String = "pw"

        '   initialise()
        'Dim versuch As Dictionary(Of String, String) = logIn(strDBenutzername, strDPasswort)

        '   lblattempt.Text = versuch("attempt")
        '  lblrole.Text = versuch("role")


        Dim appPath As String = Application.StartupPath()
        Dim connect As New SQLite.SQLiteConnection
        connect.ConnectionString = "Data Source=" + appPath + "\user.s3db;"
        connect.Open()
        'Command = connect.CreateCommand
        'Command.commandText
        connect.Close()


        Console.WriteLine(appPath)


    End Sub




End Class