
Imports System.IO
Imports System.Xml.Serialization
Public Class DAO


    Protected Shared Function ladenXml(pstrDateipfad As String, pType As Type) As Object
        ' Dekalration der notwendigen Objekte Variablen für den Dateizugriff
        Dim obj As Object
        Dim objStreamReader As StreamReader ' Wird zum Lesen aus einer Datei benötigt
        Dim objXmlSerializer As XmlSerializer ' Wird zur Umwandlung von XML-Daten in Objekte benötigt

        ' Lesend auf die Datei zugreifen
        objStreamReader = New StreamReader(pstrDateipfad)

        ' Prüfen, ob \ am Ende des Verzeichnisses vergessen wurde; wenn ja, ergänzen
        If Not pstrDateipfad.EndsWith(Path.DirectorySeparatorChar) Then
            ' Wichtig ist, dass hier nicht das "\"-Zeichen verwendet wird, sondern
            ' auf die Systemeinstellungen zurückgegriffen wird
            pstrDateipfad = pstrDateipfad & Path.DirectorySeparatorChar
        End If

        ' Gelesende XML-Daten in Objekte umwandeln 
        objXmlSerializer = New XmlSerializer(pType)
        obj = objXmlSerializer.Deserialize(objStreamReader)

        ' Dateizugriff beenden
        objStreamReader.Close()

        ' Gelesende Objekte zurückliefern
        Return obj
    End Function

    Protected Shared Function ladenXml(pstrDateipfad As String, pType As Type, pExtraTypes() As Type) As Object
        ' Dekalration der notwendigen Objekte Variablen für den Dateizugriff
        Dim obj As Object
        Dim objStreamReader As StreamReader ' Wird zum Lesen aus einer Datei benötigt
        Dim objXmlSerializer As XmlSerializer ' Wird zur Umwandlung von XML-Daten in Objekte benötigt

        ' Lesend auf die Datei zugreifen
        objStreamReader = New StreamReader(pstrDateipfad)

        ' Gelesende XML-Daten in Objekte umwandeln und zurückgeben
        objXmlSerializer = New XmlSerializer(pType, pExtraTypes)
        obj = objXmlSerializer.Deserialize(objStreamReader)

        ' Dateizugriff beenden
        objStreamReader.Close()

        ' Gelesende Objekte zurückliefern
        Return obj
    End Function

    Protected Shared Sub speichernXml(pstrDateipfad As String, pObject As Object, pType As Type)

        ' Dekalration der notwendigen Objekte Variablen für den Dateizugriff
        Dim objStreamWriter As StreamWriter ' Wird zum Schreiben in eine Datei benötigt
        Dim objXmlSerializer As XmlSerializer ' Wird zur Umwandlung von Objekten in XML-Daten benötigt


        ' Schreibend auf die Datei zugreifen
        objStreamWriter = New StreamWriter(pstrDateipfad)

        ' Objekte der Liste aller Benutzer in XML-Daten umwandeln und in die Datei schreiben
        objXmlSerializer = New XmlSerializer(pType)
        objXmlSerializer.Serialize(objStreamWriter, pObject)

        ' Dateizugriff beenden
        objStreamWriter.Close()

    End Sub

    Protected Shared Sub speichernXml(pstrDateipfad As String, pObject As Object, pType As Type, pExtraTypes() As Type)

        ' Dekalration der notwendigen Objekte Variablen für den Dateizugriff
        Dim objStreamWriter As StreamWriter ' Wird zum Schreiben in eine Datei benötigt
        Dim objXmlSerializer As XmlSerializer ' Wird zur Umwandlung von Objekten in XML-Daten benötigt


        ' Schreibend auf die Datei zugreifen
        objStreamWriter = New StreamWriter(pstrDateipfad)

        ' Objekte der Liste aller Benutzer in XML-Daten umwandeln und in die Datei schreiben
        objXmlSerializer = New XmlSerializer(pType, pExtraTypes)
        objXmlSerializer.Serialize(objStreamWriter, pObject)

        ' Dateizugriff beenden
        objStreamWriter.Close()

    End Sub

    Protected Shared Function existiertXml(pstrDateipfad As String) As Boolean
        ' Prüfen, ob es die Datei mit Beispielbenutzern nicht existiert
        Return My.Computer.FileSystem.FileExists(pstrDateipfad) AndAlso My.Computer.FileSystem.GetFileInfo(pstrDateipfad).Length > 0
    End Function
End Class
