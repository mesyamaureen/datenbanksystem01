Imports System.IO
Imports System.Xml.Serialization

Public Class BenutzerDAO
    Inherits DAO

    Private Const DateinameMitarbeiter As String = "Mitarbeiter.xml"
    Private Const DateinameKunde As String = "Kunden.xml"

    Public Shared Function ladenMitarbeiter() As List(Of Mitarbeiter)

        'Liste aller Mitarbeiter
        Dim lstMitarbeiter As List(Of Mitarbeiter)

        'Dateipfad 
        Dim strDateipfad As String = My.Settings.Datenspeicherort

        'Dateipfad um Konstante ergänzen
        strDateipfad = strDateipfad & DateinameMitarbeiter

        'Prüfen, ob datei mit Beispieldaten NICHT existiert

        If Not existiertXml(strDateipfad) Then
            lstMitarbeiter = Aufgabe_07.Logic.ListeMitarbeiter
        Else 'in allen anderen fällen existiert eine Liste - übernehmen
            lstMitarbeiter = ladenXml(strDateipfad, GetType(List(Of Mitarbeiter)))

        End If

        Return lstMitarbeiter

    End Function

    Public Shared Sub speichernMitarbeiter(plstMitarbeiter As List(Of Mitarbeiter))

        'Dateipfad
        Dim strDateipfad As String = My.Settings.Datenspeicherort
        strDateipfad = strDateipfad & DateinameMitarbeiter

        speichernXml(strDateipfad, plstMitarbeiter, GetType(List(Of Mitarbeiter)))


    End Sub



    Public Shared Function ladenKunden() As List(Of Kunde)

        'Liste aller Mitarbeiter
        Dim lstKunde As List(Of Kunde)

        'Dateipfad 
        Dim strDateipfad As String = My.Settings.Datenspeicherort

        'Dateipfad um Konstante ergänzen
        strDateipfad = strDateipfad & DateinameKunde

        'Prüfen, ob datei mit Beispieldaten NICHT existiert

        If Not existiertXml(strDateipfad) Then
            lstKunde = Aufgabe_07.Logic.ListeKunden
        Else 'in allen anderen fällen existiert eine Liste - übernehmen
            lstKunde = ladenXml(strDateipfad, GetType(List(Of Mitarbeiter)))

        End If

        Return lstKunde

    End Function

    Public Shared Sub speichernKunde(plstKunde As List(Of Kunde))

        'Dateipfad
        Dim strDateipfad As String = My.Settings.Datenspeicherort
        strDateipfad = strDateipfad & DateinameKunde

        speichernXml(strDateipfad, plstKunde, GetType(List(Of Kunde)))


    End Sub

End Class
