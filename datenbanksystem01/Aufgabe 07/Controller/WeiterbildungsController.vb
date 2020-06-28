Public Class WeiterbildungsController

    'Properties
    Private mlstKurse As List(Of Kurs)
    Private mlstWeiterbildungen As List(Of Weiterbildung)
    Private mstrKursID As String
    Private mstrWeiterbildungsID As String

    'Konstruktor

    Sub New()
        mlstKurse = New List(Of Kurs)
        mlstWeiterbildungen = New List(Of Weiterbildung)
        mstrKursID = String.Empty
        mstrWeiterbildungsID = String.Empty

    End Sub

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
    Private weiterId As UInteger
    Public Function createWeiterbildung(pstrBezeichnung As String, pstrCurriculum As String, pstrTeilnehmerkreis As String, pstrThema As String) As Weiterbildung
        'Deklaration neue Variabel als Zuweisung von Weiterbildung
        Dim neueWeiterbildung As New Weiterbildung
        'Initialisierung der Parameter
        neueWeiterbildung.Bezeichnung = pstrBezeichnung
        neueWeiterbildung.Curriculum = pstrCurriculum
        neueWeiterbildung.Teilnehmerkreis = pstrTeilnehmerkreis
        neueWeiterbildung.Thema = pstrThema

        'WeiterbildungsID generieren
        weiterId += 1
        'Verzweigung für Ausgabe
        If weiterId < 10 Then
            neueWeiterbildung.WeiterbildungsID = "00" & weiterId
        ElseIf 10 <= weiterId < 100 Then
            neueWeiterbildung.WeiterbildungsID = "0" & weiterId
        Else
            neueWeiterbildung.WeiterbildungsID = weiterId
        End If

        'Return als Weiterbildung
        Return neueWeiterbildung
    End Function

    Public Function viewWeiterbildung(strWeiterbildungsID As String) As Array
        'Deklaration neue Variablen
        Dim aryWeiterbil(4) As String
        For Each weiterbil As Weiterbildung In ListeWeiterbildungen
            If weiterbil.WeiterbildungsID = strWeiterbildungsID Then
                aryWeiterbil(0) = weiterbil.Bezeichnung
                aryWeiterbil(1) = weiterbil.Thema
                aryWeiterbil(2) = weiterbil.Curriculum
                aryWeiterbil(3) = weiterbil.Teilnehmerkreis
            End If
        Next
        Return aryWeiterbil
    End Function

    Public Function changeWeiterbildung(strBezeichnung As String, strThema As String, strCurriculum As String, strTeilnehmerkreis As String,
                                        bearbWeiterbildung As Weiterbildung) As Boolean
        'Initialisierung der Parameter
        bearbWeiterbildung.Bezeichnung = strBezeichnung
        bearbWeiterbildung.Thema = strThema
        bearbWeiterbildung.Curriculum = strCurriculum
        bearbWeiterbildung.Teilnehmerkreis = strTeilnehmerkreis
        'Rückgabewert
        Return True
    End Function

    Public Function deleteWeiterbildung(intWeiterbildungID) As Boolean

    End Function

End Class
