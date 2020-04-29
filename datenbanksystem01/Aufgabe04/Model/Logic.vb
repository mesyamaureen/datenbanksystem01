Module Logic

    'Properties

    Private Property lstListeKunde As List(Of Kunde)
    Private Property lstListeMitarbeiter As List(Of Mitarbeiter)
    Private Property lstListeBuchungen As List(Of Buchung)
    Private Property lstListeKurs As List(Of Kurs)
    Private Property lstListeWeiterbildung As List(Of Weiterbildung)


    Public Function createKunde(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, strFirma As String, datGebDat As Date) As Integer

        Dim kunde As Kunde = New Kunde(strBenutzername, strPasswort, strName, strVorname, strFirma, datGebDat)
        lstListeKunde.Add(kunde)

        Dim intKundenID As Integer = kunde.getIntKundenID()
        Return intKundenID

    End Function

    Public Function createMitarbeiter(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date) As Integer

        Dim mitarbeiter As Mitarbeiter = New Mitarbeiter(strBenutzername, strPasswort, strName, strVorname, datGebDat)
        lstListeMitarbeiter.Add(mitarbeiter)

        Dim intMitarbeiterID As Integer = mitarbeiter.getIntMitarbeiterID()
        Return intMitarbeiterID

    End Function


    Public Function deleteMitarbeiter(intMitarbeiterID As Integer) As Boolean

        'remeber to also remove the ListItem in fachkonzept

    End Function

End Module
