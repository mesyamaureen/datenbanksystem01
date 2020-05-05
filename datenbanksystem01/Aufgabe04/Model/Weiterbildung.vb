Public Class Weiterbildung

    'Properties
    Public Property intWeiterbildungsID As Integer
    Public Property strBezeichnung As String
    Public Property strThema As String
    Public Property strCurriculum As String

    'Konstruktor
    Sub New(strBezeichnung As String, strThema As String, strCurriculum As String)

        Me.strBezeichnung = strBezeichnung
        Me.strThema = strThema
        Me.strCurriculum = strCurriculum

    End Sub


End Class
