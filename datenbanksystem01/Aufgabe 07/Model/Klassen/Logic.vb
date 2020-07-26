﻿Module Logic

    'Attribute

    Public mlstAktuellAngemeldeterBenutzer As List(Of Benutzer)
    Public mlstBenutzer As List(Of Benutzer)
    Public mlstKunde As List(Of Kunde)
    Public mlstMitarbeiter As List(Of Mitarbeiter)
    Public mlstBuchung As List(Of Buchung)
    Public mlstKurs As List(Of Kurs)
    Public mlstWeiterbildungen As List(Of Weiterbildung)
    Public userController As UserController
    Public weiterbildungscontroller As WeiterbildungsController
    Public bookingController As BookingController

    'init funktion


    'Properties 
    Public Property AngemeldeteBenutzer As List(Of Benutzer)
        Get
            Return mlstAktuellAngemeldeterBenutzer
        End Get
        Set(value As List(Of Benutzer))
            mlstAktuellAngemeldeterBenutzer = value
        End Set
    End Property

    Public Property ListeKunden As List(Of Kunde)
        Get
            Return mlstKunde
        End Get
        Set(value As List(Of Kunde))
            mlstKunde = value
        End Set
    End Property

    Public Property ListeMitarbeiter As List(Of Mitarbeiter)
        Get
            Return mlstMitarbeiter
        End Get
        Set(value As List(Of Mitarbeiter))
            mlstMitarbeiter = value
        End Set
    End Property

    Public Property ListeBuchung As List(Of Buchung)
        Get
            Return mlstBuchung
        End Get
        Set(value As List(Of Buchung))
            mlstBuchung = value
        End Set
    End Property

    Public Property ListeKurse As List(Of Kurs)
        Get
            Return mlstKurs
        End Get
        Set(value As List(Of Kurs))
            mlstKurs = value
        End Set
    End Property

    Public Property ListeWeiterbildung As List(Of Weiterbildung)
        Get
            Return mlstWeiterbildungen
        End Get
        Set(value As List(Of Weiterbildung))
            mlstWeiterbildungen = value
        End Set
    End Property

    ''' <summary>
    ''' Erzeugt Beispieldaten von Benutzern, Mitarbeiter, Weiterbildung, mit denen beim ersten Programmstart gearbeitet werden kann.
    ''' </summary>
    '''<remarks>funktion initialise
    '''</remarks>
    Public Function initialise()

        'TODO initialise lists from database
        'mlstMitarbeiter = New List(Of Mitarbeiter) From
        '  {New Mitarbeiter("jeynie", "pw", "Jeynie", "Mesya Maureen", #09/24/1997#), New Mitarbeiter("hochtritt", "pw", "Hochtritt", "Nina", #10/21/1999#), New Mitarbeiter("off", "pw", "Off", "Thomas", #10/23/1969#)}
        'mlstKunde = New List(Of Kunde) From
        '  {New Kunde("mueller", "pw", "Mueller", "Micha", #03/22/1966#, "BlalBla AG"), New Kunde("meier", "pw", "Meier", "Jens", #05/15/1978#, "ShareNow")}

        mlstKurs = New List(Of Kurs) 'From
        '{New Kurs(#07/30/2020 01:30:00 PM#, "Raum20", True, 4000, False), New Kurs(#08/21/2020 08:00:00 AM #, "Raum12", True, 1500, False)}
        Dim kurs01, kurs02, kurs03, kurs04, kurs05, kurs06, kurs07, kurs08 As Kurs

        'Kurse initialisieren ohne Parameter
        kurs01 = New Kurs()
        kurs01.Zeitpunkt = #07/30/2020#
        kurs01.Ort = "Berlin"
        kurs01.Verfuegbar = True 'Teilnehmeranzahl benötigt???!!!
        kurs01.Preis = 1500
        kurs01.Abgesagt = False

        'Kurse initialisieren mit Parameter
        kurs02 = New Kurs(#08/21/2020#, "Berlin", True, 1800, False)
        kurs03 = New Kurs(#09/13/2020#, "Stuttgart", True, 800, False)
        kurs04 = New Kurs(#12/12/2020#, "Hamburg", True, 1200, False)
        kurs05 = New Kurs(#11/14/2020#, "Stuttgart", True, 800, False)
        kurs06 = New Kurs(#10/21/2020#, "Berlin", True, 1800, False)
        kurs07 = New Kurs(#10/24/2020#, "Berlin", True, 1200, False)
        kurs08 = New Kurs(#11/05/2020#, "Stuttgart", True, 800, False)

        'KursID
        kurs01.KursID = "1"
        kurs02.KursID = "2"
        kurs03.KursID = "3"
        kurs04.KursID = "4"
        kurs05.KursID = "5"
        kurs06.KursID = "6"
        kurs07.KursID = "7"
        kurs08.KursID = "8"

        'Kurse zur Liste hinzufügen
        mlstKurs.Add(kurs01)
        mlstKurs.Add(kurs02)
        mlstKurs.Add(kurs03)
        mlstKurs.Add(kurs04)
        mlstKurs.Add(kurs05)
        mlstKurs.Add(kurs06)
        mlstKurs.Add(kurs07)
        mlstKurs.Add(kurs08)


        'Deklaration der Liste von Weiterbildung
        mlstWeiterbildungen = New List(Of Weiterbildung)


        'Weiterbildungen deklarieren
        Dim agiles, scrum, controlling, bmc As Weiterbildung

        'Weiterbildungen initialisieren ohne Parameter
        agiles = New Weiterbildung()
        agiles.Bezeichnung = "Agiles Projektmanagement"
        agiles.Curriculum = "1) Grundlagen des agilen Projektmanagement
                             2) Scrum
                             3) Kanban
                             4) Design Thinking
                             5) User Journey Mapping"
        agiles.Thema = "Projekt-, Prozess- und Changemanagement"
        agiles.Teilnehmerkreis = "Projektmanager und Projektleiter sowie Projektcontroller, -assistenten,
                                 -mitarbeiter und jeder, der seine Fähigkeiten während der Projektarbeit effizienter gestalten möchte."
        agiles.lstKurs.Add(kurs01)
        agiles.lstKurs.Add(kurs04)

        ' Weiterbildungen initialisieren mit Parameter
        scrum = New Weiterbildung("SCRUM", "Projekt-, Prozess- und Changemanagement", "1) Scrum - Herkunft und Entwicklung
                                                                                       2) Die Scrum Philosophie
                                                                                       3) Die Agile Phase", "Dieser Workshop richtet sich an alle, die in ihrem Unternehmen
                                  die mögliche Umstellung auf agiles Produkt- und Projektmanagement übernehmen sollen und dafür z.B. die Anforderungen liefern mussen", kurs02)
        controlling = New Weiterbildung("Controlling Kompaktseminar", "Controlling", "1) Grundlagen des Controllings,
                                                                                      2) Controlling - Übersicht,
                                                                                      3) Kosten- und Erfolgsrechnung", "Fach- und Führungskräfte, Mitarbeiter der entsprechnenden
                                    Fachabteilung, Finanz- und Budgetverantwortliche, Mitarbeiter des Rechnungswesens sowie der Buchhaltung", kurs05)
        bmc = New Weiterbildung("Business Model Canvas", "Digital Business", "1) Wer sind meine Kunden und welche Bedürfnisse und Interessen haben Sie?
                                                                              2) Was biete ich an und welchen Mehrwert schaffe ich für meine Kunden?
                                                                              3) Wie sieht meine Einnahme- und Kostenstruktur aus?", "Unternehmer, Projektmanager oder Marketingmitarbeiter,
                                die kreative Methoden ausprobieren wollen, um Ihre Projekte schneller und effizientre zu planen. Start-Ups, die Ihr Geschäftsmodell gestalten
                                möchten. Menschen, die sich strategisch und oranisatorisch mit Produkt- und Serviceinnovationen beschäftigen.", kurs07)
        'WeiterbildungsID
        agiles.WeiterbildungsID = "1"
        scrum.WeiterbildungsID = "2"
        controlling.WeiterbildungsID = "3"
        bmc.WeiterbildungsID = "4"

        'Weitere Kurse zur Weiterbildung hinzufügen
        scrum.LstKurs.Add(kurs03)  'Kurs03 wird zur Witerbildung "Scrum" hinzugefügt
        controlling.LstKurs.Add(kurs06)
        bmc.LstKurs.Add(kurs08)
        'weiterbildungscontroller.addKurs(2, kurs03)
        'weiterbildungscontroller.addKurs(3, kurs06)
        'weiterbildungscontroller.addKurs(4, kurs08)

        'Weiterbildungen zur Liste hinzufügen
        mlstWeiterbildungen.Add(agiles)
        mlstWeiterbildungen.Add(scrum)
        mlstWeiterbildungen.Add(controlling)
        mlstWeiterbildungen.Add(bmc)

        'Buchung Datenbank
        mlstBuchung = New List(Of Buchung) From {
        New Buchung(1200, #07/21/2020#, mlstKurs)}

        mlstAktuellAngemeldeterBenutzer = New List(Of Benutzer)

        'BenutzerDAO.speichernMitarbeiter(mlstMitarbeiter)
        'BenutzerDAO.speichernKunde(mlstKunde)
        'BuchungsDAO.speichernBuchung(mlstBuchung)
        'Kurs__und_WeiterbildungsDAO.speichernKurs(mlstKurs)
        'Kurs__und_WeiterbildungsDAO.speichernWeiterbildung(mlstWeiterbildungen)

        mlstMitarbeiter = BenutzerDAO.ladenMitarbeiter()
        mlstKunde = BenutzerDAO.ladenKunden()
        mlstBuchung = BuchungsDAO.ladenBuchung()
        mlstKurs = Kurs__und_WeiterbildungsDAO.ladenKurse()
        mlstWeiterbildungen = Kurs__und_WeiterbildungsDAO.ladenWeiterbildung()

        userController = New UserController(mlstMitarbeiter, mlstKunde)
        weiterbildungscontroller = New WeiterbildungsController(mlstKurs, mlstWeiterbildungen)
        bookingController = New BookingController(mlstBuchung)
    End Function




    'UserController
    Public Function logIn(strBenutzername As String, strPasswort As String) As Dictionary(Of String, String)

        Return userController.logIn(strBenutzername, strPasswort)

    End Function

    Public Function createKunde(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date, pstrFirma As String) As Integer

        Dim kunde As Kunde = New Kunde(strBenutzername, strPasswort, strName, strVorname, datGebDat, pstrFirma)
        mlstKunde.Add(kunde)
        Dim strKundenID As String = kunde.KundenID
        Return strKundenID

    End Function

    Public Function viewKunde(strKundenID) As Array

        Return userController.viewKunde(strKundenID)

    End Function

    Public Function changeKunde(strKundenId As Integer, strBenutzername As String, strPasswort As String, strVorname As String, strName As String) As Boolean

        Return userController.changeKunde(strKundenId, strBenutzername, strPasswort, strVorname, strName)

    End Function

    Public Function deleteKunde(strKundenID As Integer) As Boolean

        Return userController.deleteKunde(strKundenID)

    End Function


    Public Function createMitarbeiter(strBenutzername As String, strPasswort As String, strName As String, strVorname As String, datGebDat As Date) As Integer

        Dim mitarbeiter As Mitarbeiter = New Mitarbeiter(strBenutzername, strPasswort, strName, strVorname, datGebDat)
        mlstMitarbeiter.Add(mitarbeiter)

        Dim strMitarbeiterID As String = mitarbeiter.MitarbeiterID()
        Return strMitarbeiterID

    End Function

    Public Function viewMitarbeiter(strMitarbeiterID As String) As Array

        Return userController.viewMitarbeiter(strMitarbeiterID)

    End Function

    Public Function changeMitarbeiter(strMitarbeiterID As Integer, strBenutzername As String, strPasswort As String, strVorname As String, strName As String) As Boolean

        Return userController.changeMitarbeiter(strMitarbeiterID, strBenutzername, strPasswort, strVorname, strName)

    End Function

    Public Function deleteMitarbeiter(strMitarbeiterID As Integer) As Boolean

        'remember to also remove the ListItem in fachkonzept
        Return userController.deleteMitarbeiter(strMitarbeiterID)

    End Function

    'TODO Datenbank erstellen (fill with records)


    'WeiterbildungsController
    Public Function createKurs(pstrOrt As String, pdatZeitpunkt As Date, pbolavailable As Boolean, pdecPreis As Decimal) As Kurs

        Return weiterbildungscontroller.createKurs(pstrOrt, pdatZeitpunkt, pbolavailable, pdecPreis)

    End Function

    Public Function viewKurs(pstrKundenID As String) As Array

        Return weiterbildungscontroller.viewKurs(pstrKundenID)

    End Function

    Public Function changeKurs(pstrKundenID As String, pstrOrt As String, pdatZeitpunkt As Date, pdecPreis As Decimal, pbearbKurs As Kurs) As Boolean

        Return weiterbildungscontroller.changeKurs(pstrKundenID, pstrOrt, pdatZeitpunkt, pdecPreis, pbearbKurs)

    End Function

    Public Function deleteKurs(pstrKundenID As String) As Boolean

        Return weiterbildungscontroller.deleteKurs(pstrKundenID)

    End Function

    'BookingController
    Public Function createBooking(pKurs As Kurs, pdatDatum As Date, pdecPreis As Decimal, pweiterbil As Weiterbildung) As Buchung

        Return bookingController.createBooking(pKurs, pdatDatum, pdecPreis, pweiterbil)

    End Function

    Public Function viewBooking(pstrBuchungsID) As Array

        Return bookingController.viewBooking(pstrBuchungsID)

    End Function

    Public Function changeBooking(pstrBuchungsID As String, pdecPreis As Decimal, pdatDatum As Date, pbearbBuchung As Buchung) As Boolean

        Return bookingController.changeBooking(pstrBuchungsID, pdecPreis, pdatDatum, pbearbBuchung)

    End Function

    Public Function deleteBooking(pstrKundenID As String) As Boolean

        Return bookingController.deleteBooking(pstrKundenID)

    End Function






End Module
