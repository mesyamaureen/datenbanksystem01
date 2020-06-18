Public Class testLogic
    Private Sub testLogic_Click(sender As Object, e As EventArgs) Handles MyBase.Click, btnLogIn.Click
        'Dim strDBenutzername As String = "jeynie"
        'Dim strDPasswort As String = "pw"

        '   initialise()
        'Dim versuch As Dictionary(Of String, String) = logIn(strDBenutzername, strDPasswort)

        '   lblattempt.Text = versuch("attempt")
        '  lblrole.Text = versuch("role")


        Dim appPath As String = Application.StartupPath()
        'TODO: Dim connect As New SQLite.SQLiteConnection
        'TODO: connect.ConnectionString = "Data Source=" + appPath + "\user.s3db;"
        'TODO: connect.Open()
        'Command = connect.CreateCommand
        'Command.commandText
        ' Command = connect.CreateCommand
        ' Command.commandText = "CREATE TABLE  "
        ' Command.executeNonQuery()
        ' Command.dispose()
        ' connect.Close()

        'tblKunde(kundenID INTEGER PRIMARY KEY AUTOINCREMENT, kndBenutzername TEXT, kndPasswort TEXT, kndVorname TEXT, kndName TEXT, kndGebDat **Text?
        'tblMitarbeiter (MitarbeiterID INTEGER PRIMARY KEY AUTOINCREMENT, maBenutzername TEXT, maPasswort TEXT, maVorname TEXT, maName TEXT, maGebDat
        'tblBuchung (BuchungsID INTEGER PRIMARY KEY AUTOINCREMENT, buchPreis REAL, buchDatum 
        'tblKurs ( KursID INTEGER PRIMARY KEY AUTOINCREMENT, kursPreis REAL, kursZeit, kursOrt TEXT, kursAvailable INTEGER)
        'tblWeiterbildung (WeiterbildungsID INTEGER PRIMARY KEY AUTOINCREMENT, wbBezeichnung TEXT, wbThema TEXT, wbCurriculum TEXT)

        Console.WriteLine(appPath)


    End Sub

    Private Sub testLogic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class