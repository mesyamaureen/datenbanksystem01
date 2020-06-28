Imports System.IO
Imports System.Xml.Serialization
Public Class Kurs__und_WeiterbildungsDAO
    Inherits DAO

    Private Const DateinameKurs As String = "Kurs.xml"
    Private Const DateinameWeiterbildung As String = "Mitarbeiter.xml"

    Public Shared Function ladenKurse() As List(Of Kurs)

        'Liste aller Mitarbeiter
        Dim lstKurs As List(Of Kurs)

        'Dateipfad 
        Dim strDateipfad As String = My.Settings.Datenspeicherort

        'Dateipfad um Konstante ergänzen
        strDateipfad = strDateipfad & DateinameKurs

        'Prüfen, ob datei mit Beispieldaten NICHT existiert

        If Not existiertXml(strDateipfad) Then
            lstKurs = Aufgabe_07.Logic.ListeKurse
        Else 'in allen anderen fällen existiert eine Liste - übernehmen
            lstKurs = ladenXml(strDateipfad, GetType(List(Of Kurs)))

        End If

        Return lstKurs

    End Function


    Public Shared Sub speichernKurs(plstKurs As List(Of Kurs))

        'Dateipfad
        Dim strDateipfad As String = My.Settings.Datenspeicherort
        strDateipfad = strDateipfad & DateinameKurs

        speichernXml(strDateipfad, plstKurs, GetType(List(Of Kurs)))


    End Sub


    Public Shared Function ladenWeiterbildung() As List(Of Weiterbildung)

        'Liste aller Mitarbeiter
        Dim lstWeiterbildung As List(Of Weiterbildung)

        'Dateipfad 
        Dim strDateipfad As String = My.Settings.Datenspeicherort

        'Dateipfad um Konstante ergänzen
        strDateipfad = strDateipfad & DateinameWeiterbildung

        'Prüfen, ob datei mit Beispieldaten NICHT existiert

        If Not existiertXml(strDateipfad) Then
            lstWeiterbildung = Aufgabe_07.Logic.initialise()
        Else 'in allen anderen fällen existiert eine Liste - übernehmen
            lstWeiterbildung = ladenXml(strDateipfad, GetType(List(Of Weiterbildung)))

        End If

        Return lstWeiterbildung

    End Function


    Public Shared Sub speichernWeiterbildung(plstWeiterbildung As List(Of Weiterbildung))

        'Dateipfad
        Dim strDateipfad As String = My.Settings.Datenspeicherort
        strDateipfad = strDateipfad & DateinameWeiterbildung

        speichernXml(strDateipfad, plstWeiterbildung, GetType(List(Of Weiterbildung)))


    End Sub


End Class
