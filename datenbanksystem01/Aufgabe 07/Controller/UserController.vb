Public Class UserController

    Private mlstKunde As List(Of Kunde)
    Private mlstMitarbeiter As List(Of Mitarbeiter)
    Private muintBenutzerID As UInteger

    Sub New()
        mlstKunde = New List(Of Kunde)
        mlstMitarbeiter = New List(Of Mitarbeiter)
        muintBenutzerID = String.Empty
    End Sub


    Sub New(plstMitarbeiter As List(Of Mitarbeiter), plstKunde As List(Of Kunde))

        mlstMitarbeiter = plstMitarbeiter
        mlstKunde = plstKunde

    End Sub

    'Properties 
    Public Property ListeKunde As List(Of Kunde)
        Get
            Return mlstKunde
        End Get
        Set(value As List(Of Kunde))
            mlstKunde = value
        End Set
    End Property

    Public Property ListeMitarbeiter As List(Of Mitarbeiter)
        Get
            Return mlstMitarbeiter
        End Get
        Set(value As List(Of Mitarbeiter))
            mlstMitarbeiter = value
        End Set
    End Property

    Public Property ID As String
        Get
            Return muintBenutzerID
        End Get
        Set(value As String)
            muintBenutzerID = value
        End Set
    End Property


    'Funktionen

    Public Function logIn(strBenutzername As String, strPasswort As String) As Dictionary(Of String, String)
        Dim anzumeldenderBenutzer As Benutzer
        Dim result = New Dictionary(Of String, String) From {{"attempt", "failed"}, {"role", Nothing}}

        For Each mitarbeiter As Mitarbeiter In Logic.ListeMitarbeiter
            If strBenutzername.Equals(mitarbeiter.Benutzername) And strPasswort.Equals(mitarbeiter.Passwort) Then
                anzumeldenderBenutzer = mitarbeiter
                Logic.AngemeldeteBenutzer.Add(anzumeldenderBenutzer)
                result("attempt") = "successful"
                result("role") = "mitarbeiter"

            End If
        Next

        For Each kunde As Kunde In Logic.ListeKunden
            If strBenutzername.Equals(kunde.Benutzername) And strPasswort.Equals(kunde.Passwort) Then
                anzumeldenderBenutzer = kunde
                Logic.mlstAktuellAngemeldeterBenutzer.Add(anzumeldenderBenutzer)
                result("attempt") = "successful"
                result("role") = "kunde"
            End If
        Next


        Return result

    End Function


    Public Function createKunde(strBenutzername As String, strPasswort As String, datGebDat As Date, strFirma As String) As Kunde
        ' If Not (mlstKunde.Contains(Me)) Then
        'mlstKunde.Add(Me)

        'End If
        ' Dim neuerKunde As Kunde = New Kunde(frmKundenkontoerstellung.txtBenutzername.Text,
        'frmKundenkontoerstellung.txtPasswort.Text,
        'frmKundenkontoerstellung.txtNachname.Text,
        'frmKundenkontoerstellung.txtVorname.Text,
        'frmKundenkontoerstellung.datboxGebDat.Value,
        'frmKundenkontoerstellung.txtFirma.Text)

        'mlstKunde.Add(neuerKunde)

        'BenutzerDAO.speichernKunde(mlstKunde)

        'frmKundenkontoerstellung.Close()
    End Function


    Public Function viewKunde(uintBenutzerID As UInteger) As Array

    End Function

    Public Function changeKunde(uintBenutzerID As UInteger, strBenutzername As String, strPasswort As String, strVorname As String, strName As String) As Boolean

    End Function

    Public Function deleteKunde(uintBenutzerID As UInteger) As Boolean

    End Function


    Public Function createMitarbeiter(strBenutzername As String, strPasswort As String) As String

    End Function

    Public Function viewMitarbeiter(uintBenutzerID As UInteger) As Array

    End Function

    Public Function changeMitarbeiter(uintBenutzerID As UInteger, strBenutzername As String, strPasswort As String, strVorname As String, strName As String) As Boolean

    End Function

    Public Function deleteMitarbeiter(uintBenutzerID As UInteger) As Boolean

    End Function

    ' 1. Alle Controller Klassen erstellen mit Properties, Konstruktor, getter, setter 
    ' 2. Im Modul Logic alle Controller in initialise funktion instanzieren 
    ' 3. Alle Use Case Funktionen in die Controller schreiben (deklarieren)
    ' 4. Alle Use case funktionen in die Logic schreiben 
    ' 5. View kann man nach leeren use case funktionen fertig schreiben (nicht testen weil leer)
    ' 5. Füllen der Controller mit "Logik"








End Class