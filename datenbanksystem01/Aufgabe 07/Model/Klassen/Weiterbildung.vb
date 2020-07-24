Imports System.Xml.Serialization

<System.Serializable()>
Public Class Weiterbildung

    'Attribiute
    Private mstrWeiterbildungsID As UInteger
    Private mstrBezeichnung As String
    Private mstrThema As String
    Private mstrCurriculum As String
    Private mstrTeilnehmerkreis As String
    'Public mlstKurs As List(Of Kurs)

    'Konstruktor
    'Parameterloser Konstruktor
    Sub New()
        mstrBezeichnung = String.Empty
        mstrThema = String.Empty
        mstrCurriculum = String.Empty
        mstrTeilnehmerkreis = String.Empty
        'mlstKurs = New List(Of Kurs)
    End Sub


    'Konstruktor mit Parametern
    Sub New(pstrBezeichnung As String, pstrThema As String, pstrCurriculum As String, pstrTeilnehmerkreis As String) ', plstKurs As List(Of Kurs))

        mstrBezeichnung = pstrBezeichnung
        mstrThema = pstrThema
        mstrCurriculum = pstrCurriculum
        mstrTeilnehmerkreis = pstrTeilnehmerkreis
        ' mlstKurs = plstKurs
    End Sub


    Public Property WeiterbildungsID As UInteger
        Get
            Return mstrWeiterbildungsID
        End Get
        Set(value As UInteger)
            mstrWeiterbildungsID = value
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
