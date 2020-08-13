Public Class BookingController

    'Funktionen
    Public Shared Function createBooking(mKurs As Kurs, pbenTeilnehmer As Benutzer) As Buchung
        'Deklaration neue Buchung
        Dim neueBuchung As New Buchung
        neueBuchung.gebuchterKurs = mKurs
        neueBuchung.Teilnehmer = pbenTeilnehmer

        'BuchungID generieren
        Dim weiterId As UInteger = 0
        For Each buchung In ListeBuchung
            If buchung.BuchungsID > weiterId Then
                weiterId = buchung.BuchungsID
            End If
        Next
        neueBuchung.BuchungsID = weiterId + 1

        'Return als Buchung
        Return neueBuchung
    End Function

    Public Shared Function deleteBooking(intBuchungsID As UInteger) As Boolean
        For i = 0 To ListeBuchung.Count - 1
            If ListeBuchung(i).BuchungsID = intBuchungsID Then
                ListeBuchung.RemoveAt(i)
                BuchungsDAO.speichernBuchung(ListeBuchung)
                Return True
                Exit For
            End If
        Next

        Return False
    End Function

End Class
