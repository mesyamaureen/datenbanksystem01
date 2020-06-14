Public Class Weiterbildung

    'Properties
    Public Property mstrWeiterbildungsID As String
    Public Property mstrBezeichnung As String
    Public Property mstrThema As String
    Public Property mstrCurriculum As String
    Public mstrTeilnehmerkreis As String

    'Konstruktor
    Sub New(pstrBezeichnung As String, pstrThema As String, pstrCurriculum As String, pstrTeilnehmerkreis As String)

        mstrBezeichnung = pstrBezeichnung
        mstrThema = pstrThema
        mstrCurriculum = pstrCurriculum
        mstrTeilnehmerkreis = pstrTeilnehmerkreis

    End Sub


End Class
