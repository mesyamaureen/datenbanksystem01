Public Class Buchung

    Public mstrBuchungsID As String
    Public mdecPreis As Decimal
    Public mdatDatum As Date
    Public mlstKurse As List(Of Kurs)


    'Konstruktor
    Sub New(pdecPreis As Decimal, pdatDatum As Date)

        mdecPreis = pdecPreis
        mdatDatum = pdatDatum

    End Sub


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

    Public Property ListeKurse As Date
        Get
            Return mlstKurse
        End Get
        Set(value As Date)
            mlstKurse = value
        End Set
    End Property



End Class
