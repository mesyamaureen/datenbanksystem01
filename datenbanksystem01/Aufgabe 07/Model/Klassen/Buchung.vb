Imports System.Xml.Serialization

<System.Serializable()>
Public Class Buchung

    Private muintBuchungsID As UInteger
    Private mKurs As Kurs
    Private mbenTeilnehmer As Benutzer


    'Konstruktor

    Sub New()
        mKurs = New Kurs
        mbenTeilnehmer = New Benutzer
    End Sub


    Sub New(pKurs As Kurs, pintBuchungsID As UInteger, pbenTeilnehmer As Benutzer) '
        muintBuchungsID = pintBuchungsID
        mKurs = pKurs
        mbenTeilnehmer = pbenTeilnehmer
    End Sub


    'Properties
    Public Property BuchungsID As UInteger
        Get
            Return muintBuchungsID
        End Get
        Set(value As UInteger)
            muintBuchungsID = value
        End Set
    End Property

    Public Property gebuchterKurs As Kurs
        Get
            Return mKurs
        End Get
        Set(value As Kurs)
            mKurs = value
        End Set
    End Property

    Public Property Teilnehmer As Benutzer
        Get
            Return mbenTeilnehmer
        End Get
        Set(value As Benutzer)
            mbenTeilnehmer = value
        End Set
    End Property

    Public Shared Function zeigenAlle() As List(Of Buchung)

        Dim lstBuchung As List(Of Buchung)

        lstBuchung = BuchungsDAO.ladenBuchung

        Return lstBuchung

    End Function

End Class
