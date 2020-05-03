Public Class WeiterbildungsController

    'Properties
    Private Property lstKurse As List(Of Kurs)
    Private Property lstWeiterbildungen As List(Of Weiterbildung)
    Private Property intKursID As Integer
    Private Property intWeiterbildungsID As Integer

    'Konstruktor
    Sub New(lstKurse As List(Of Kurs), lstWeiterbildungen As List(Of Weiterbildung))

        Me.lstKurse = lstKurse
        Me.lstWeiterbildungen = lstWeiterbildungen

    End Sub

    'Getter & Setter
    Public Function getLstKurse()
        Return lstKurse
    End Function

    Public Function setListKurse()
        Me.lstKurse = lstKurse
    End Function

    Public Function getLstWeiterbildungen()
        Return lstWeiterbildungen
    End Function

    Public Function setlstWeiterbildungen()
        Me.lstWeiterbildungen = lstWeiterbildungen
    End Function

    'Funktionen
    'Kurse
    Public Function createKurs(strOrt As String, datZeitpunkt As Date, bolavailable As Boolean, decPreis As Decimal) As intKursID

    End Function

    Public Function viewKurs(intKundenID As Integer) As Array

    End Function

    Public Function changeKurs(intKundenID As Integer, strOrt As String, datZeitpunkt As Date, decPreis As Decimal) As Boolean

    End Function

    Public Function deleteKurs(intKundenID) As Boolean

    End Function

    'Weiterbildung
    Public Function createWeiterbildung(strBezeichnung As String, strThema As String, strCurriculum As String) As intWeiterbildungsID

    End Function

    Public Function viewWeiterbildung(intWeiterbildungsID As Integer) As Array

    End Function

    Public Function changeWeiterbildung(intWeiterbildungsID As Integer, strBezeichnung As String, strThema As String, strCurriculum As String) As Boolean

    End Function

    Public Function deleteWeiterbildung(intWeiterbildungID) As Boolean

    End Function

End Class
