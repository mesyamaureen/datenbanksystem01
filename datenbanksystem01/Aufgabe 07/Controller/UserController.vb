Public Class UserController

    Private mlstKunde As List(Of Kunde)
    Private mlstMitarbeiter As List(Of Mitarbeiter)
    Private mstrMitarbeiterID As String
    Private mstrKundenID As String


    Sub New()
        mlstKunde = New List(Of Kunde)
        mlstMitarbeiter = New List(Of Mitarbeiter)
        mstrKundenID = String.Empty
        mstrMitarbeiterID = String.Empty
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

    Public Property MitarbeiterID As String
        Get
            Return mstrMitarbeiterID
        End Get
        Set(value As String)
            mstrMitarbeiterID = value
        End Set
    End Property

    Public Property KundenID As String
        Get
            Return mstrKundenID
        End Get
        Set(value As String)
            mstrKundenID = value
        End Set
    End Property



    'Funktionen

    Public Function logIn(strBenutzername As String, strPasswort As String) As Dictionary(Of String, String)

        Dim result = New Dictionary(Of String, String) From {{"attempt", "failed"}, {"role", Nothing}}

        For Each mitarbeiter As Mitarbeiter In mlstMitarbeiter
            If strBenutzername.Equals(mitarbeiter.Benutzername) And strPasswort.Equals(mitarbeiter.Passwort) Then
                result("attempt") = "successful"
                result("role") = "mitarbeiter"
            End If
        Next

        For Each kunde As Kunde In mlstKunde
            If strBenutzername.Equals(kunde.Benutzername) And strPasswort.Equals(kunde.Passwort) Then
                result("attempt") = "successful"
                result("role") = "kunde"
            End If
        Next

        Return result

    End Function


    Public Function createKunde(strBenutzername As String, strPasswort As String, datGebDat As Date, strFirma As String) As intKundenID

    End Function


    Public Function viewKunde(intKundenID As Integer) As Array

    End Function

    Public Function changeKunde(intKundenID As Integer, strBenutzername As String, strPasswort As String, strVorname As String, strName As String) As Boolean

    End Function

    Public Function deleteKunde(intKundenID As Integer) As Boolean

    End Function


    Public Function createMitarbeiter(strBenutzername As String, strPasswort As String) As intMitarbeiterID

    End Function

    Public Function viewMitarbeiter(intMitarbeiterID As Integer) As Array

    End Function

    Public Function changeMitarbeiter(intMitarbeiterID As Integer, strBenutzername As String, strPasswort As String, strVorname As String, strName As String) As Boolean

    End Function

    Public Function deleteMitarbeiter(iintMitarbeiterID As Integer) As Boolean

    End Function

    ' 1. Alle Controller Klassen erstellen mit Properties, Konstruktor, getter, setter 
    ' 2. Im Modul Logic alle Controller in initialise funktion instanzieren 
    ' 3. Alle Use Case Funktionen in die Controller schreiben (deklarieren)
    ' 4. Alle Use case funktionen in die Logic schreiben 
    ' 5. View kann man nach leeren use case funktionen fertig schreiben (nicht testen weil leer)
    ' 5. Füllen der Controller mit "Logik"








End Class