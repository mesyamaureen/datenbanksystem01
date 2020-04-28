Public Class fachkonzept

    'Properties

    Private Property lstListeKunde As List(Of Kunde)




    'bekommt übergeben die parameter des Kurses
    'alle Use Case funktionen

    Public Function createKunde(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, strFirma As String, datGebDat As Date) As intKundenID

        Dim customer As Kunde = New Kunde(strBenutzername, strPasswort, strName, strVorname, strFirma, datGebDat)
        lstListeKunde.Add(customer)

        Dim intKundenID As Integer = customer.getIntKundenID()
        Return intKundenID

    End Function




End Class
