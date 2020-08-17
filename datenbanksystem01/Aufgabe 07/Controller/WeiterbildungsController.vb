Public Class WeiterbildungsController


    'Kurse
    Public Shared Function createKurs(pstrOrt As String, pdatZeitpunkt As Date, pbolavailable As Boolean, pdecPreis As Decimal, pweiterbildung As Weiterbildung) As Kurs
        'Deklaration neue Variable
        Dim neuerKurs As New Kurs
        'Initialisierung der Parameter
        neuerKurs.Ort = pstrOrt
        neuerKurs.Zeitpunkt = pdatZeitpunkt
        neuerKurs.Verfuegbar = pbolavailable
        neuerKurs.Preis = pdecPreis
        neuerKurs.Weiterbildung = pweiterbildung

        'KursID generieren
        Dim Id As UInteger = 0
        For Each kurs In ListeKurse
            If kurs.KursID > Id Then
                Id = kurs.KursID
            End If
        Next
        neuerKurs.KursID = Id + 1

        'Return als Neuer Kurs
        Return neuerKurs
    End Function

    Public Shared Function viewKurs(uintKundenID As UInteger) As Array
        'Deklaration neue Variablen
        Dim aryKurse(5) As String
        For Each kurs As Kurs In ListeKurse
            If kurs.KursID = uintKundenID Then
                aryKurse(0) = kurs.Zeitpunkt
                aryKurse(1) = kurs.Ort
                aryKurse(2) = kurs.Verfuegbar
                aryKurse(3) = kurs.Abgesagt
                aryKurse(4) = kurs.Preis
            End If
        Next
        Return aryKurse
    End Function

    Public Shared Function changeKurs(uintKursID As UInteger, strOrt As String, datZeitpunkt As Date, decPreis As Decimal, boolAbgesagt As Boolean) As Boolean
        For i = 0 To ListeKurse.Count - 1
            If ListeKurse(i).KursID = uintKursID Then
                Dim kurs As Kurs = ListeKurse(i)
                kurs.Ort = strOrt
                kurs.Zeitpunkt = datZeitpunkt
                kurs.Preis = decPreis
                kurs.Abgesagt = boolAbgesagt
                ListeKurse(i) = kurs

                Kurs__und_WeiterbildungsDAO.speichernKurs(ListeKurse)
                Return True
                Exit For
            End If
        Next

        Return False
    End Function

    Public Shared Function deleteKurs(intKursID As UInteger) As Boolean
        For i = 0 To ListeKurse.Count - 1
            If ListeKurse(i).KursID = intKursID Then
                ListeKurse.RemoveAt(i)
                Kurs__und_WeiterbildungsDAO.speichernKurs(ListeKurse)
                Return True
                Exit For
            End If
        Next

        Return False
    End Function

    'Funktionen für Weiterbildung
    Public Shared Function createWeiterbildung(pstrBezeichnung As String, pstrCurriculum As String, pstrTeilnehmerkreis As String, pstrThema As String) As Weiterbildung
        'Deklaration neue Variabel als Zuweisung von Weiterbildung
        Dim neueWeiterbildung As New Weiterbildung
        'Initialisierung der Parameter
        neueWeiterbildung.Bezeichnung = pstrBezeichnung
        neueWeiterbildung.Curriculum = pstrCurriculum
        neueWeiterbildung.Teilnehmerkreis = pstrTeilnehmerkreis
        neueWeiterbildung.Thema = pstrThema

        'WeiterbildungsID generieren
        Dim weiterId As UInteger = 0
        For Each weiterbildung In ListeWeiterbildung
            If weiterbildung.WeiterbildungsID > weiterId Then
                weiterId = weiterbildung.WeiterbildungsID
            End If
        Next
        neueWeiterbildung.WeiterbildungsID = weiterId + 1

        'Return als Weiterbildung
        Return neueWeiterbildung
    End Function

    Public Function viewWeiterbildung(uintWeiterbildungsID As UInteger) As Array
        'Deklaration neue Variablen
        Dim aryWeiterbil(4) As String
        For Each weiterbil As Weiterbildung In ListeWeiterbildung
            If weiterbil.WeiterbildungsID = uintWeiterbildungsID Then
                aryWeiterbil(0) = weiterbil.Bezeichnung
                aryWeiterbil(1) = weiterbil.Thema
                aryWeiterbil(2) = weiterbil.Curriculum
                aryWeiterbil(3) = weiterbil.Teilnehmerkreis
            End If
        Next
        Return aryWeiterbil
    End Function

    Public Shared Function changeWeiterbildung(strBezeichnung As String, strThema As String, strCurriculum As String, strTeilnehmerkreis As String,
                                        bearbWeiterbildung As Weiterbildung) As Weiterbildung
        'Initialisierung der Parameter
        bearbWeiterbildung.Bezeichnung = strBezeichnung
        bearbWeiterbildung.Thema = strThema
        bearbWeiterbildung.Curriculum = strCurriculum
        bearbWeiterbildung.Teilnehmerkreis = strTeilnehmerkreis

        'Rückgabewert
        Return bearbWeiterbildung
    End Function

    Public Shared Sub deleteWeiterbildung(intWeiterbildungID As UInteger)
        For i = 0 To ListeWeiterbildung.Count
            If ListeWeiterbildung(i).WeiterbildungsID = intWeiterbildungID Then
                ListeWeiterbildung.RemoveAt(i)
                Kurs__und_WeiterbildungsDAO.speichernWeiterbildung(ListeWeiterbildung)
                Exit For
            End If
        Next
    End Sub

End Class
