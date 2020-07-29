Public Class BookingController

    'Properties
    Public mlstBooking As List(Of Buchung)
    Public mstrBuchungsID As String
    Dim ListViewAktBuchungen As ListView

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

    Public Property BuchungsID As String
        Get
            Return mstrBuchungsID
        End Get
        Set(value As String)
            mstrBuchungsID = value
        End Set
    End Property



    'Funktionen
    Public Function createBooking(mKurs As Kurs, pbenTeilnehmer As Benutzer) As Buchung
        'Deklaration neue Buchung
        Dim neueBuchung As New Buchung
        neueBuchung.gebuchterKurs = mKurs
        neueBuchung.Teilnehmer = pbenTeilnehmer

        'BuchungID generieren
        Dim weiterId As UInteger = 0
        For Each buchung In Logic.ListeBuchung
            If buchung.BuchungsID > weiterId Then
                weiterId = buchung.BuchungsID
            End If
        Next
        neueBuchung.BuchungsID = weiterId + 1

        'Return als Buchung
        Return neueBuchung
    End Function

    'wegen GUI überflüssig
    'Public Function viewBooking(intBuchungsID) As Array
    '    Dim aryBuchung(2) As String
    '    For Each buchung As Buchung In Logic.ListeBuchung
    '        If buchung.BuchungsID Then
    '            aryBuchung(0) = buchung.Preis
    '            aryBuchung(1) = buchung.BuchungsDatum
    '        End If
    '    Next
    '    Return aryBuchung
    'End Function

    Public Function changeBooking(puintBuchungsID As UInteger, bearbBuchung As Buchung) As Boolean
        'Initialisierung der Parameter

        'Rückgabewert
        Return True
    End Function

    Public Function deleteBooking(intKundenID As Integer) As Boolean

    End Function


End Class
