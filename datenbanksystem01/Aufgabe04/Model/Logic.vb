Module Logic

    'Properties

    Private Property lstListeKunde As List(Of Kunde)
    Private Property lstListeMitarbeiter As List(Of Mitarbeiter)
    Private Property lstListeBuchung As List(Of Buchung)
    Private Property lstListeKurs As List(Of Kurs)
    Private Property lstListeWeiterbildung As List(Of Weiterbildung)

    'init funktion

    'funktion initialise
    Public Function initialise()
        'TODO initialise lists from database
        lstListeMitarbeiter = New List(Of Mitarbeiter) From
        {New Mitarbeiter("jeynie", "pw", "Jeynie", "Mesya Maureen"), New Mitarbeiter("hochtritt", "pw", "Hochtritt", "Nina")}
        lstListeKunde = New List(Of Kunde) From
        {New Kunde("mueller", "pw", "Mueller", "Micha"), New Kunde("meier", "pw", "Meier", "Jens")}


    End Function

    Public Function logIn(strBenutzername As String, strPasswort As String) As Dictionary(Of String, String)
        Console.WriteLine(lstListeMitarbeiter(0).getStrBenutzername)

        Dim result = New Dictionary(Of String, String) From {{"attempt", "failed"}, {"role", Nothing}}

        For Each mitarbeiter As Mitarbeiter In lstListeMitarbeiter
            If strBenutzername.Equals(mitarbeiter.getStrBenutzername) And strPasswort.Equals(mitarbeiter.getStrPasswort) Then
                result("attempt") = "successful"
                result("role") = "mitarbeiter"
            End If
        Next

        For Each kunde As Kunde In lstListeKunde
            If strBenutzername.Equals(kunde.getStrBenutzername) And strPasswort.Equals(kunde.getStrPasswort) Then
                result("attempt") = "successful"
                result("role") = "kunde"
            End If
        Next

        Return result


    End Function

    Sub Main()
        System.Console.WriteLine("Hello World.")
        System.Console.ReadLine()
        End
    End Sub


    Public Function createKunde(strBenutzername As String, strPasswort As String, strName As String, strVorname As String) As Integer

        Dim kunde As Kunde = New Kunde(strBenutzername, strPasswort, strName, strVorname)
        lstListeKunde.Add(kunde)
        Dim intKundenID As Integer = kunde.getIntKundenID()
        Return intKundenID

    End Function

    Public Function createMitarbeiter(strBenutzername As String, strPasswort As String, strName As String, strVorname As String) As Integer

        Dim mitarbeiter As Mitarbeiter = New Mitarbeiter(strBenutzername, strPasswort, strName, strVorname)
        lstListeMitarbeiter.Add(mitarbeiter)

        Dim intMitarbeiterID As Integer = mitarbeiter.getIntMitarbeiterID()
        Return intMitarbeiterID

    End Function


    Public Function deleteMitarbeiter(intMitarbeiterID As Integer) As Boolean

        'remeber to also remove the ListItem in fachkonzept

    End Function

End Module
