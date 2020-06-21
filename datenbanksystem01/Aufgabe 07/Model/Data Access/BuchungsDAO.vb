Imports System.IO
Imports System.Xml.Serialization
Public Class BuchungsDAO
    Inherits DAO

    Private Const DateinameBuchung As String = "Buchungen.xml"

    Public Shared Function ladenBuchung() As List(Of Buchung)

        'Liste aller Mitarbeiter
        Dim lstBuchung As List(Of Buchung)

        'Dateipfad 
        Dim strDateipfad As String = My.Settings.Datenspeicherort

        'Dateipfad um Konstante ergänzen
        strDateipfad = strDateipfad & DateinameBuchung

        'Prüfen, ob datei mit Beispieldaten NICHT existiert

        If Not existiertXml(strDateipfad) Then
            lstBuchung = Aufgabe_07.Logic.mlstBuchung
        Else 'in allen anderen fällen existiert eine Liste - übernehmen
            lstBuchung = ladenXml(strDateipfad, GetType(List(Of Buchung)))

        End If

        Return lstBuchung

    End Function

    Public Shared Sub speichernBuchung(plstBuchung As List(Of Buchung))

        'Dateipfad
        Dim strDateipfad As String = My.Settings.Datenspeicherort
        strDateipfad = strDateipfad & DateinameBuchung

        speichernXml(strDateipfad, plstBuchung, GetType(List(Of Buchung)))


    End Sub

End Class
