Imports System.Xml.Serialization

<System.Serializable()>
Public Class Weiterbildung

    'Attribute
    Private muintWeiterbildungsID As UInteger
    Private mstrBezeichnung As String
    Private mstrThema As String
    Private mstrCurriculum As String
    Private mstrTeilnehmerkreis As String
    'Konstruktor
    'Parameterloser Konstruktor
    Sub New()
        Bezeichnung = String.Empty
        Thema = String.Empty
        Curriculum = String.Empty
        Teilnehmerkreis = String.Empty
    End Sub


    'Konstruktor mit Parametern
    Sub New(pstrBezeichnung As String, pstrThema As String, pstrCurriculum As String, pstrTeilnehmerkreis As String)

        Bezeichnung = pstrBezeichnung
        Thema = pstrThema
        Curriculum = pstrCurriculum
        Teilnehmerkreis = pstrTeilnehmerkreis
    End Sub

    Public Property WeiterbildungsID As UInteger
        Get
            Return muintWeiterbildungsID
        End Get
        Set(value As UInteger)
            muintWeiterbildungsID = value
        End Set
    End Property


    Public Property Bezeichnung As String
        Get
            Return mstrBezeichnung
        End Get
        Set(value As String)
            mstrBezeichnung = value
        End Set
    End Property

    Public Property Thema As String
        Get
            Return mstrThema
        End Get
        Set(value As String)
            mstrThema = value
        End Set
    End Property

    Public Property Curriculum As String
        Get
            Return mstrCurriculum
        End Get
        Set(value As String)
            mstrCurriculum = value
        End Set
    End Property

    Public Property Teilnehmerkreis As String
        Get
            Return mstrTeilnehmerkreis
        End Get
        Set(value As String)
            mstrTeilnehmerkreis = value
        End Set
    End Property

    Public Shared Function zeigenAlle() As List(Of Weiterbildung)

        Dim lstWeiterbildung As List(Of Weiterbildung)

        lstWeiterbildung = Kurs__und_WeiterbildungsDAO.ladenWeiterbildung()

        Return lstWeiterbildung

    End Function

    Public Shared Sub speichernAlle(pstrWeiterbildung As List(Of Weiterbildung))

        Kurs__und_WeiterbildungsDAO.speichernWeiterbildung(pstrWeiterbildung)

    End Sub

End Class
