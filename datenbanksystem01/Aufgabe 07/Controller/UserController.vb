Public Class UserController

    Private Property lstKunde As List(Of Kunde)
    Private Property lstMitarbeiter As List(Of Mitarbeiter)
    Private Property intMitarbeiterID As Integer
    Private Property intKundenID As Integer


    Sub New(lstMitarbeiter As List(Of Mitarbeiter), lstKunde As List(Of Kunde))

        Me.lstMitarbeiter = lstMitarbeiter
        Me.lstKunde = lstKunde

    End Sub

    Function getLstMitarbeiter() As List(Of Mitarbeiter)
        Return lstMitarbeiter
    End Function

    Function setLstMitarbeiter(lstMitarbeiter As List(Of Mitarbeiter))
        Me.lstMitarbeiter = lstMitarbeiter
    End Function

    Function getLstKunde() As List(Of Kunde)
        Return lstKunde
    End Function

    Function setLstKunde(lstKunde As List(Of Kunde))
        Me.lstKunde = lstKunde
    End Function

    Function getintMitarbeiterID()
        Return intMitarbeiterID
    End Function

    Function setintMitarbeiterID()
        Me.intMitarbeiterID = intMitarbeiterID
    End Function

    Function getintKundenID()
        Return intKundenID
    End Function

    Function setintKundenID()
        Me.intKundenID = intKundenID
    End Function



    Public Function logIn(strBenutzername As String, strPasswort As String) As Dictionary(Of String, String)

        Dim result = New Dictionary(Of String, String) From {{"attempt", "failed"}, {"role", Nothing}}

        For Each mitarbeiter As Mitarbeiter In lstMitarbeiter
            If strBenutzername.Equals(mitarbeiter.getStrBenutzername) And strPasswort.Equals(mitarbeiter.getStrPasswort) Then
                result("attempt") = "successful"
                result("role") = "mitarbeiter"
            End If
        Next

        For Each kunde As Kunde In lstKunde
            If strBenutzername.Equals(kunde.getStrBenutzername) And strPasswort.Equals(kunde.getStrPasswort) Then
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