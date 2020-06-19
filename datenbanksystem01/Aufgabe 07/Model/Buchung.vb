Imports System.Xml.Serialization

<System.Serializable()>
Public Class Buchung

    Public mstrBuchungsID As String
    Public mdecPreis As Decimal
    Public mdatDatum As Date
    Public mlstKurse As List(Of Kurs)


    'Konstruktor

    Sub New()
        mdecPreis = Nothing
        mdatDatum = Nothing
        mlstKurse = New List(Of Kurs)

    End Sub


    Sub New(pdecPreis As Decimal, pdatDatum As Date, plstKurse As List(Of Kurs))

        mdecPreis = pdecPreis
        mdatDatum = pdatDatum
        mlstKurse = New List(Of Kurs)

    End Sub


    'Properties
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

    Public Property ListeKurse As List(Of Kurs)
        Get
            Return mlstKurse
        End Get
        Set(value As List(Of Kurs))
            mlstKurse = value
        End Set
    End Property



End Class
