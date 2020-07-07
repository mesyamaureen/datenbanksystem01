Public Class BookingController

    'Properties
    Public mlstBooking As List(Of Buchung)
    Public mstrBuchungsID As String

    'Konstruktor



    Sub New(plstBooking As List(Of Buchung))

        mlstBooking = plstBooking

    End Sub

    'get&set
    Public Property ListeBuchungen As List(Of Buchung)
        Get
            Return mlstBooking
        End Get
        Set(value As List(Of Buchung))
            mlstBooking = value
        End Set
    End Property

    Public ReadOnly Property BuchungsID As String
        Get
            Return mstrBuchungsID
        End Get
    End Property



    'Funktionen
    Private buchungID As UInteger
    Public Function createBooking(Kurs As Kurs, datDatum As Date, decPreis As Decimal) As Buchung
        'Deklaration neue Variabel
        Dim neueBuchung As New Buchung
        'Initialisierung der Parameter
        neueBuchung.Kurse = Kurs
        neueBuchung.Preis = decPreis
        neueBuchung.BuchungsDatum = datDatum
        'BuchungID generieren
        buchungID += 1
        'Verzweigung für Ausgabe
        If buchungID < 10 Then
            neueBuchung.BuchungsID = "B00" & buchungID
        ElseIf 10 <= buchungID < 100 Then
            neueBuchung.BuchungsID = "B0" & buchungID
        Else
            neueBuchung.BuchungsID = buchungID
        End If

        'Return als Buchung
        Return neueBuchung
    End Function

    Public Function viewBooking(intBuchungsID) As Array
        Dim aryBuchung(2) As String
        For Each buchung As Buchung In ListeBuchungen
            If buchung.BuchungsID Then
                aryBuchung(0) = buchung.Preis
                aryBuchung(1) = buchung.BuchungsDatum
            End If
        Next
        Return aryBuchung
    End Function

    Public Function changeBooking(strBuchungsID As String, decPreis As Decimal, datDatum As Date, bearbBuchung As Buchung) As Boolean
        'Initialisierung der Parameter
        bearbBuchung.Preis = decPreis
        bearbBuchung.BuchungsDatum = datDatum
        'Rückgabewert
        Return True
    End Function

    Public Function deleteBooking(intKundenID As Integer) As Boolean

    End Function


End Class
