Imports System.IO
Imports System.Xml.Serialization

Public Class Kurs__und_WeiterbildungsDAO
    Inherits DAO

    Private Const DateinameKurs As String = "Kurs.xml"
    Private Shared strPfadXMLKurs As String = strDBDir & DateinameKurs
    Private Const DateinameWeiterbildung As String = "Weiterbildung.xml"
    Private Shared strPfadXMLWeiterbildung As String = strDBDir & DateinameWeiterbildung

    Public Shared Function ladenKurse() As List(Of Kurs)

        'Liste aller Mitarbeiter
        Dim lstKurs As List(Of Kurs)

        'Prüfen, ob datei mit Beispieldaten NICHT existiert

        If Not existiertXml(strPfadXMLKurs) Then
            lstKurs = Aufgabe_07.Logic.ListeKurse
        Else 'in allen anderen fällen existiert eine Liste - übernehmen
            lstKurs = ladenXml(strPfadXMLKurs, GetType(List(Of Kurs)))

        End If

        Return lstKurs

    End Function


    Public Shared Sub speichernKurs(plstKurs As List(Of Kurs))

        speichernXml(strPfadXMLKurs, plstKurs, GetType(List(Of Kurs)))


    End Sub


    Public Shared Function ladenWeiterbildung() As List(Of Weiterbildung)

        'Liste aller Mitarbeiter
        Dim lstWeiterbildung As List(Of Weiterbildung)

        'Prüfen, ob datei mit Beispieldaten NICHT existiert

        If Not existiertXml(strPfadXMLWeiterbildung) Then
            lstWeiterbildung = Aufgabe_07.Logic.initialise()
        Else 'in allen anderen fällen existiert eine Liste - übernehmen
            lstWeiterbildung = ladenXml(strPfadXMLWeiterbildung, GetType(List(Of Weiterbildung)))

        End If

        Return lstWeiterbildung

    End Function


    Public Shared Sub speichernWeiterbildung(plstWeiterbildung As List(Of Weiterbildung))

        speichernXml(strPfadXMLWeiterbildung, plstWeiterbildung, GetType(List(Of Weiterbildung)))


    End Sub


End Class
