Imports System.IO
Imports System.Xml.Serialization

Public Class BenutzerDAO
    Inherits DAO

    Private Const DateinameMitarbeiter As String = "Mitarbeiter.xml"
    Private Shared strPfadXMLMitarbeiter As String = strDBDir & DateinameMitarbeiter
    Private Const DateinameKunde As String = "Kunden.xml"
    Private Shared strPfadXMLKunde As String = strDBDir & DateinameKunde

    Public Shared Function ladenMitarbeiter() As List(Of Mitarbeiter) 'Benutzer

        'Liste aller Mitarbeiter
        Dim lstMitarbeiter As List(Of Mitarbeiter)

        'Prüfen, ob datei mit Beispieldaten NICHT existiert

        If Not existiertXml(strPfadXMLMitarbeiter) Then
            lstMitarbeiter = Aufgabe_07.Logic.ListeMitarbeiter
        Else 'in allen anderen fällen existiert eine Liste - übernehmen
            lstMitarbeiter = ladenXml(strPfadXMLMitarbeiter, GetType(List(Of Mitarbeiter)))

        End If

        Return lstMitarbeiter

    End Function

    Public Shared Sub speichernMitarbeiter(plstMitarbeiter As List(Of Mitarbeiter))

        speichernXml(strPfadXMLMitarbeiter, plstMitarbeiter, GetType(List(Of Mitarbeiter)))


    End Sub



    Public Shared Function ladenKunden() As List(Of Kunde)

        'Liste aller Mitarbeiter
        Dim lstKunde As List(Of Kunde)

        'Prüfen, ob datei mit Beispieldaten NICHT existiert

        If Not existiertXml(strPfadXMLKunde) Then
            lstKunde = Aufgabe_07.Logic.ListeKunden
        Else 'in allen anderen fällen existiert eine Liste - übernehmen
            lstKunde = ladenXml(strPfadXMLKunde, GetType(List(Of Mitarbeiter)))

        End If

        Return lstKunde

    End Function

    Public Shared Sub speichernKunde(plstKunde As List(Of Kunde))

        speichernXml(strPfadXMLKunde, plstKunde, GetType(List(Of Kunde)))

    End Sub



End Class
