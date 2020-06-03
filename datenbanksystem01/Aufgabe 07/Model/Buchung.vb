Public Class Buchung

    Public Property strBuchungsID As String
    Public Property decPreis As Decimal
    Public Property datDatum As Date


    'Konstruktor
    Sub New(decPreis As Decimal, datDatum As Date)

        Me.decPreis = decPreis
        Me.datDatum = datDatum

    End Sub


End Class
