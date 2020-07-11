Imports System.IO
Imports System.Xml.Serialization
Public Class BuchungsDAO
    Inherits DAO

    Private Const DateinameBuchung As String = "Buchungen.xml"
    Private Shared strPfadXMLBuchung As String = strDBDir & DateinameBuchung

    Public Shared Function ladenBuchung() As List(Of Buchung)

        'Liste aller Mitarbeiter
        Dim lstBuchung As List(Of Buchung)

        'Prüfen, ob datei mit Beispieldaten NICHT existiert

        If Not existiertXml(strPfadXMLBuchung) Then
            lstBuchung = Aufgabe_07.Logic.mlstBuchung
        Else 'in allen anderen fällen existiert eine Liste - übernehmen
            lstBuchung = ladenXml(strPfadXMLBuchung, GetType(List(Of Buchung)))

        End If

        Return lstBuchung

    End Function

    Public Shared Sub speichernBuchung(plstBuchung As List(Of Buchung))

        speichernXml(strPfadXMLBuchung, plstBuchung, GetType(List(Of Buchung)))


    End Sub

End Class
