Imports System.Xml.Serialization

<System.Serializable()>
Public Class Buchung

    Public mstrBuchungsID As String
    Public mdecPreis As Decimal
    Public mdatDatum As Date
    Public mKurs As Kurs
    Public mstrKundenID As String
    Public mstrKursID As String
    Public mstrWeiterbildungsBezeichnung As String
    Private mstrOrtKurs As String


    'Konstruktor

    Sub New()
        mdecPreis = Nothing
        mdatDatum = Nothing
        mKurs = New Kurs
        mstrWeiterbildungsBezeichnung = Nothing
        mstrOrtKurs = Nothing
    End Sub


    Sub New(pKurs As Kurs, pdatDatum As Date, pWeiterbildungsbezeichnung As String, pdecPreis As Decimal, pstrOrtKurs As String) '

        mdecPreis = pdecPreis
        mdatDatum = pdatDatum
        mKurs = pKurs
        mstrWeiterbildungsBezeichnung = pWeiterbildungsbezeichnung
        mstrOrtKurs = pstrOrtKurs
    End Sub


    'Properties
    Public Property BuchungsID As String
        Get
            Return mstrBuchungsID
        End Get
        Set(value As String)
            mstrBuchungsID = value
        End Set
    End Property

    Public Property Preis As Decimal
        Get
            Return mdecPreis
        End Get
        Set(value As Decimal)
            If mdecPreis > 0 Then
                mdecPreis = value
            End If
        End Set
    End Property

    Public Property BuchungsDatum As Date
        Get
            Return mdatDatum
        End Get
        Set(value As Date)
            mdatDatum = value
        End Set
    End Property

    Public Property Kurse As Kurs
        Get
            Return mKurs
        End Get
        Set(value As Kurs)
            mKurs = value
        End Set
    End Property

    Public ReadOnly Property KundenID As String
        Get
            Return mstrKundenID
        End Get
    End Property

    Public ReadOnly Property KursID As String
        Get
            Return mstrKursID
        End Get
    End Property

    Public Property Weiterbildung As String
        Get
            Return mstrWeiterbildungsBezeichnung
        End Get
        Set(value As String)
            mstrWeiterbildungsBezeichnung = value
        End Set
    End Property

    Public Property OrtKurs As String
        Get
            Return mstrOrtKurs
        End Get
        Set(value As String)
            mstrOrtKurs = value
        End Set
    End Property

    Public Shared Function zeigenAlle() As List(Of Buchung)

        Dim lstBuchung As List(Of Buchung)

        lstBuchung = BuchungsDAO.ladenBuchung

        Return lstBuchung

    End Function

    Public Shared Sub speichernAlle(pstrBuchung As List(Of Buchung))

        BuchungsDAO.speichernBuchung(pstrBuchung)

    End Sub

End Class
