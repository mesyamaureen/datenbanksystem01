Public Class Kurs

    'Properties
    Public Property strKursID As String
    Public Property datZeitpunkt As Date
    Public Property strOrt As String
    Public Property bolavailable As Boolean
    Public Property decPreis As Decimal

    'Konstruktor
    Sub New(datZeitpunkt As Date, strOrt As String, bolAvailable As Boolean, decPreis As Decimal)

        Me.datZeitpunkt = datZeitpunkt
        Me.strOrt = strOrt
        Me.bolavailable = bolAvailable
        Me.decPreis = decPreis

    End Sub








End Class
