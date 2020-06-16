Public Class WeiterbildungsController

    'Properties
    Private mlstKurse As List(Of Kurs)
    Private mlstWeiterbildungen As List(Of Weiterbildung)
    Private mstrKursID As String
    Private mstrWeiterbildungsID As String

    'Konstruktor
    Sub New(plstKurse As List(Of Kurs), plstWeiterbildungen As List(Of Weiterbildung))

        mlstKurse = plstKurse
        mlstWeiterbildungen = plstWeiterbildungen

    End Sub

    'Getter & Setter

    Public Property ListeKurse As List(Of Kurs)
        Get
            Return mlstKurse
        End Get
        Set(value As List(Of Kurs))
            mlstKurse = value
        End Set
    End Property

    Public Property ListeWeiterbildungen As List(Of Weiterbildung)
        Get
            Return mlstWeiterbildungen
        End Get
        Set(value As List(Of Weiterbildung))
            mlstWeiterbildungen = value
        End Set
    End Property

    Public Property KursID As String
        Get
            Return mstrKursID
        End Get
        Set(value As String)
            mstrKursID = value
        End Set
    End Property

    Public Property WeiterbildungsID As String
        Get
            Return mstrWeiterbildungsID
        End Get
        Set(value As String)
            mstrWeiterbildungsID = value
        End Set
    End Property




    'Funktionen
    'Kurse
    Public Function createKurs(strOrt As String, datZeitpunkt As Date, bolavailable As Boolean, decPreis As Decimal) As String

    End Function

    Public Function viewKurs(intKundenID As Integer) As Array

    End Function

    Public Function changeKurs(intKundenID As Integer, strOrt As String, datZeitpunkt As Date, decPreis As Decimal) As Boolean

    End Function

    Public Function deleteKurs(intKundenID) As Boolean

    End Function

    'Weiterbildung
    Public Function createWeiterbildung(strBezeichnung As String, strThema As String, strCurriculum As String) As String

    End Function

    Public Function viewWeiterbildung(intWeiterbildungsID As Integer) As Array

    End Function

    Public Function changeWeiterbildung(intWeiterbildungsID As Integer, strBezeichnung As String, strThema As String, strCurriculum As String) As Boolean

    End Function

    Public Function deleteWeiterbildung(intWeiterbildungID) As Boolean

    End Function

End Class
