Public Class BookingController

    'Properties
    Public Property lstBooking As List(Of Buchung)
    Public Property intBuchungsID As Integer

    'Konstruktor
    Sub New(lstBooking As List(Of Buchung))

        Me.lstBooking = lstBooking

    End Sub

    'get&set
    Public Function getLstBooking()
        Return lstBooking
    End Function

    Public Function setLstBooking()
        Me.lstBooking = lstBooking
    End Function

    'Funktionen
    'Public Function createBooking(decPreis As Decimal, datDatum As Date) As intBuchungsID

    'End Function

    Public Function viewBooking(intBuchungsID) As Array

    End Function

    Public Function changeBooking(intBuchungsID As Integer, decPreis As Decimal, datDatum As Date)

    End Function

    Public Function deleteBooking(intKundenID As Integer) As Boolean

    End Function


End Class
