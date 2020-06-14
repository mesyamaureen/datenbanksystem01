Public Class Kurs

    'Properties
    Public mstrKursID As String
    Public mdatZeitpunkt As Date
    Public mstrOrt As String
    Public mbolVerfuegbar As Boolean
    Public mdecPreis As Decimal
    Protected mbolAbgesagt As Boolean

    'Konstruktor
    Sub New(pdatZeitpunkt As Date, pstrOrt As String, pbolVerfuegbar As Boolean, pdecPreis As Decimal, pbolAbgesagt As Boolean)

        mdatZeitpunkt = pdatZeitpunkt
        mstrOrt = pstrOrt
        mbolVerfuegbar = pbolVerfuegbar
        mdecPreis = pdecPreis
        mbolAbgesagt = pbolAbgesagt

    End Sub








End Class
