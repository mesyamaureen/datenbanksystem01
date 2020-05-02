Module Logic

    'Properties

    Public AktuellAngemeldeterBenutzer As Benutzer
    Private Property lstKunde As List(Of Kunde)
    Private Property lstMitarbeiter As List(Of Mitarbeiter)
    Private Property lstBuchung As List(Of Buchung)
    Private Property lstKurs As List(Of Kurs)
    Private Property lstWeiterbildung As List(Of Weiterbildung)
    Private Property userController As UserController

    'init funktion

    'funktion initialise
    Public Function initialise()
        'TODO initialise lists from database
        lstMitarbeiter = New List(Of Mitarbeiter) From
        {New Mitarbeiter("jeynie", "pw", "Jeynie", "Mesya Maureen", #09/24/1997#), New Mitarbeiter("hochtritt", "pw", "Hochtritt", "Nina", #10/21/1999#)}
        lstKunde = New List(Of Kunde) From
        {New Kunde("mueller", "pw", "Mueller", "Micha", #03/22/1966#), New Kunde("meier", "pw", "Meier", "Jens", #05/15/1978#)}

        userController = New UserController(lstMitarbeiter, lstKunde)

    End Function

    Public Function logIn(strBenutzername As String, strPasswort As String) As Dictionary(Of String, String)

        Return userController.logIn(strBenutzername, strPasswort)

    End Function

    Public Function createKunde(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date) As Integer

        Dim kunde As Kunde = New Kunde(strBenutzername, strPasswort, strName, strVorname, datGebDat)
        lstKunde.Add(kunde)
        Dim intKundenID As Integer = kunde.getIntKundenID()
        Return intKundenID

    End Function

    Public Function viewKunde(intKundenID) As Array

        Return userController.viewKunde(intKundenID)

    End Function

    Public Function changeKunde(intKundenID As Integer, strBenutzername As String, strPasswort As String, strVorname As String, strName As String) As Boolean

        Return userController.changeKunde(intKundenID, strBenutzername, strPasswort, strVorname, strName)

    End Function

    Public Function deleteKunde(intKundenID As Integer) As Boolean

        Return userController.deleteKunde(intKundenID)

    End Function


    Public Function createMitarbeiter(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date) As Integer

        Dim mitarbeiter As Mitarbeiter = New Mitarbeiter(strBenutzername, strPasswort, strName, strVorname, datGebDat)
        lstMitarbeiter.Add(mitarbeiter)

        Dim intMitarbeiterID As Integer = mitarbeiter.getIntMitarbeiterID()
        Return intMitarbeiterID

    End Function

    Public Function viewMitarbeiter(intMitarbeiterID As Integer) As Array

        Return userController.viewMitarbeiter(intMitarbeiterID)

    End Function

    Public Function changeMitarbeiter(intMitarbeiterID As Integer, strBenutzername As String, strPasswort As String, strVorname As String, strName As String) As Boolean

        Return userController.changeMitarbeiter(intMitarbeiterID, strBenutzername, strPasswort, strVorname, strName)

    End Function

    Public Function deleteMitarbeiter(intMitarbeiterID As Integer) As Boolean

        'remember to also remove the ListItem in fachkonzept
        Return userController.deleteMitarbeiter(intMitarbeiterID)

    End Function

    'TODO Datenbank erstellen (fill with records)

End Module
