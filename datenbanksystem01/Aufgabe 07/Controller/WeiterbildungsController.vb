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

    Public Property WeiterbildungsID As UInteger
        Get
            Return mstrWeiterbildungsID
        End Get
        Set(value As UInteger)
            mstrWeiterbildungsID = value
        End Set
    End Property




    'Funktionen
    'Kurse
    Private kurseId As UInteger
    Public Function createKurs(pstrOrt As String, pdatZeitpunkt As Date, pbolavailable As Boolean, pdecPreis As Decimal) As Kurs
        'Deklaration neue Variabel
        Dim neuerKurs As New Kurs
        'Initialisierung der Parameter
        neuerKurs.Ort = pstrOrt
        neuerKurs.Zeitpunkt = pdatZeitpunkt
        neuerKurs.Verfuegbar = pbolavailable
        neuerKurs.Preis = pdecPreis

        'KursID generieren
        kurseId += 1
        'Verzweigung für Ausgabe
        If kurseId < 10 Then
            neuerKurs.KursID = "K00" & kurseId
        ElseIf 10 <= kurseId < 100 Then
            neuerKurs.KursID = "K0" & kurseId
        Else
            neuerKurs.KursID = kurseId
        End If
        'Return als Neuer Kurs
        Return neuerKurs
    End Function

    Public Function viewKurs(strKundenID As String) As Array
        'Deklaration neue Variablen
        Dim aryKurse(5) As String
        For Each kurs As Kurs In ListeKurse
            If kurs.KursID = strKundenID Then
                aryKurse(0) = kurs.Zeitpunkt
                aryKurse(1) = kurs.Ort
                aryKurse(2) = kurs.Verfuegbar
                aryKurse(3) = kurs.Abgesagt
                aryKurse(4) = kurs.Preis
            End If
        Next
        Return aryKurse
    End Function

    Public Function changeKurs(strKundenID As String, strOrt As String, datZeitpunkt As Date, decPreis As Decimal, bearbKurs As Kurs) As Boolean 'strKundenId ????
        'Initialisierung der Parameter
        bearbKurs.Ort = strOrt
        bearbKurs.Zeitpunkt = datZeitpunkt
        bearbKurs.Preis = decPreis
        'Rückgabewert
        Return True
    End Function

    Public Function deleteKurs(intKundenID) As Boolean

    End Function

    'Weiterbildung
    Public Function createWeiterbildung(pstrBezeichnung As String, pstrCurriculum As String, pstrTeilnehmerkreis As String, pstrThema As String) As Weiterbildung
        'Deklaration neue Variabel als Zuweisung von Weiterbildung
        Dim neueWeiterbildung As New Weiterbildung
        'Initialisierung der Parameter
        neueWeiterbildung.Bezeichnung = pstrBezeichnung
        neueWeiterbildung.Curriculum = pstrCurriculum
        neueWeiterbildung.Teilnehmerkreis = pstrTeilnehmerkreis
        neueWeiterbildung.Thema = pstrThema

        'WeiterbildungsID generieren
        Dim weiterId As UInteger = 0
        For Each weiterbildung In mlstWeiterbildungen
            If weiterbildung.WeiterbildungsID > weiterId Then
                weiterId = weiterbildung.WeiterbildungsID
            End If
        Next
        neueWeiterbildung.WeiterbildungsID = weiterId + 1

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
                                        bearbWeiterbildung As Weiterbildung) As Weiterbildung
        'Initialisierung der Parameter
        bearbWeiterbildung.Bezeichnung = strBezeichnung
        bearbWeiterbildung.Thema = strThema
        bearbWeiterbildung.Curriculum = strCurriculum
        bearbWeiterbildung.Teilnehmerkreis = strTeilnehmerkreis

        'Rückgabewert
        Return bearbWeiterbildung
    End Function

    Public Function deleteWeiterbildung(intWeiterbildungID) As Boolean
        'Logic.mlstWeiterbildungen.RemoveAt(intWeiterbildungID)
        'Return True
    End Function

End Class
