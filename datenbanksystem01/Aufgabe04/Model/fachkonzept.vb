Public Class fachkonzept

    'Properties

    Private Property lstListeKunde As List(Of Kunde)
    Private Property lstListeMitarbeiter As List(Of Mitarbeiter)




    'bekommt übergeben die parameter des Kurses
    'alle Use Case funktionen

    Public Function createKunde(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, strFirma As String, datGebDat As Date) As intKundenID

        Dim customer As Kunde = New Kunde(strBenutzername, strPasswort, strName, strVorname, strFirma, datGebDat)
        lstListeKunde.Add(customer)

        Dim intKundenID As Integer = customer.getIntKundenID()
        Return intKundenID

    End Function

    Public Function createMitarbeiter(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date) As intMitarbeiterID

        Dim mitarbeiter As Mitarbeiter = New Mitarbeiter(strBenutzername, strPasswort, strName, strVorname, datGebDat)
        lstListeMitarbeiter.Add(mitarbeiter)

        Dim intMitarbeiterID As Integer = mitarbeiter.getIntMitarbeiterID()
        Return intMitarbeiterID

    End Function


End Class
