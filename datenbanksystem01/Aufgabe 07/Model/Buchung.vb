Public Class Buchung

    Public Property mstrBuchungsID As String
    Public Property mdecPreis As Decimal
    Public Property mdatDatum As Date


    'Konstruktor
    Sub New(pdecPreis As Decimal, pdatDatum As Date)

        mdecPreis = pdecPreis
        mdatDatum = pdatDatum

    End Sub


End Class
