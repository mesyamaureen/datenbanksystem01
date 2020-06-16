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
    Public Function createBooking(decPreis As Decimal, datDatum As Date) As String

    End Function

    Public Function viewBooking(intBuchungsID) As Array

    End Function

    Public Function changeBooking(intBuchungsID As Integer, decPreis As Decimal, datDatum As Date)

    End Function

    Public Function deleteBooking(intKundenID As Integer) As Boolean

    End Function


End Class
