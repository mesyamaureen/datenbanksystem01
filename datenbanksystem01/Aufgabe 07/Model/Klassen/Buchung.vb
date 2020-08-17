Imports System.Xml.Serialization

<System.Serializable()>
Public Class Buchung

    Private muintBuchungsID As UInteger
    Private mKurs As Kurs
    Private mbenTeilnehmer As Kunde


    'Konstruktor
    'Paremeterloser Konstruktor
    Sub New()
        gebuchterKurs = New Kurs
        Teilnehmer = New Kunde
    End Sub


    'Konstruktor mit Parameter

    Sub New(pKurs As Kurs, pintBuchungsID As UInteger, pbenTeilnehmer As Kunde) '
        BuchungsID = pintBuchungsID
        gebuchterKurs = pKurs
        Teilnehmer = pbenTeilnehmer
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

    Public Property Teilnehmer As Kunde
        Get
            Return mbenTeilnehmer
        End Get
        Set(value As Kunde)
            mbenTeilnehmer = value
        End Set
    End Property

    Public Shared Function zeigenAlle() As List(Of Buchung)

        Dim lstBuchung As List(Of Buchung)

        lstBuchung = BuchungsDAO.ladenBuchung

        Return lstBuchung

    End Function

End Class
